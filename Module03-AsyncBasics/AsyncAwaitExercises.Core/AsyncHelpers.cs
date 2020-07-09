using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitExercises.Core
{
    public class AsyncHelpers
    {
        public static async Task<string> GetStringWithRetries(HttpClient client, string url, int maxTries = 3, CancellationToken token = default)
        {
            // Create a method that will try to get a response from a given `url`, retrying `maxTries` number of times.
            // It should wait one second before the second try, and double the wait time before every successive retry
            // (so pauses before retries will be 1, 2, 4, 8, ... seconds).
            // * `maxTries` must be at least 2
            // * we retry if:
            //    * we get non-successful status code (outside of 200-299 range), or
            //    * HTTP call thrown an exception (like network connectivity or DNS issue)
            // * token should be able to cancel both HTTP call and the retry delay
            // * if all retries fails, the method should throw the exception of the last try
            // HINTS:
            // * `HttpClient.GetAsync` does not accept cancellation token (use `GetAsync` instead)
            // * you may use `EnsureSuccessStatusCode()` method

            if (maxTries < 2)
            {
                throw new ArgumentException("The value must be greater than 2", nameof(maxTries));
            }

            var isFaulted = true;
            Exception lastException = null;
            var currentTry = 0;

            var waitTime = TimeSpan.FromSeconds(1);
            var responseText = string.Empty;

            while (currentTry < maxTries && isFaulted)
            {
                if (token.IsCancellationRequested)
                {
                    throw new TaskCanceledException();
                }

                try
                {
                    using var request = new HttpRequestMessage(HttpMethod.Get, new Uri(url));
                    using var response = await client.SendAsync(request, token);
                    response.EnsureSuccessStatusCode();
                    isFaulted = false;
                    responseText = await response.Content.ReadAsStringAsync();
                }
                catch (Exception ex)
                {
                    isFaulted = true;
                    lastException = ex;
                    await Task.Delay(waitTime, token);
                    waitTime *= 2;
                    currentTry++;
                }
            }

            if (isFaulted)
            {
                Debug.Assert(lastException != null, nameof(lastException) + " != null");
                throw lastException;
            }

            return responseText;
        }
    }
}
