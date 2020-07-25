using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace TaskCombinatorsExercises.Core
{
    public static class HttpClientExtensions
    {
        /*
         Write cancellable async method with timeout handling, that concurrently tries to get data from
         provided urls (first wins and its response is returned, rest is __cancelled__).
         
         Tips:
         * consider using HttpClient.GetAsync (as it is cancellable)
         * consider using Task.WhenAny
         * you may use urls like for testing https://postman-echo.com/delay/3
         * you should have problem with tasks cancellation -
            - how to merge tokens of operations (timeouts) with the provided token? 
            - Tip: you can link tokens with the help of CancellationTokenSource.CreateLinkedTokenSource(token)
         */
        public static async Task<string> ConcurrentDownloadAsync(this HttpClient httpClient, string[] urls, int millisecondsTimeout, CancellationToken token)
        {
            var tasks = new List<Task<HttpResponseMessage>>(urls.Length);
            tasks.AddRange(urls.Select(url => httpClient.GetAsync(url, token)));

            var result = await Task.WhenAny(tasks).TimeoutAfter(TimeSpan.FromMilliseconds(millisecondsTimeout));
            var response = await result;
            return await response.Content.ReadAsStringAsync();
        }
    }
    public static class TaskHelpers
    {
        public static async Task<T> TimeoutAfter<T>(this Task<T> task, TimeSpan timeout)
        {
            using var cts = new CancellationTokenSource(timeout);
            var delayTask = Task.Delay(timeout, cts.Token);
            var resultTask = await Task.WhenAny(task, delayTask);
            
            if (resultTask == delayTask)
            {
                throw new TaskCanceledException();
            }

            cts.Cancel();
            return await task;
        }
    }
}
