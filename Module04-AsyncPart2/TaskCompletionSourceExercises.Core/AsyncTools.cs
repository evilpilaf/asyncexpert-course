using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace TaskCompletionSourceExercises.Core
{
    public class AsyncTools
    {
        public static Task<string> RunProgramAsync(string path, string args = "")
        {
            var tcs = new TaskCompletionSource<string>(TaskCreationOptions.RunContinuationsAsynchronously);

            var process = new Process
            {
                EnableRaisingEvents = true,
                StartInfo = new ProcessStartInfo(path, args)
                {
                    RedirectStandardError = true,
                    RedirectStandardOutput = true
                }
            };

            process.Exited += async (sender, eventArgs) =>
            {
                var senderProcess = sender as Process;
                Debug.Assert(senderProcess != null, nameof(senderProcess) + " != null");
                if (senderProcess.ExitCode != 0)
                {
                    var error = await senderProcess.StandardError.ReadToEndAsync();
                    tcs.SetException(new Exception(error));
                }
                else
                {
                    var result = await senderProcess.StandardOutput.ReadToEndAsync();
                    tcs.SetResult(result);
                }
            };
            process.Start();    

            return tcs.Task;
        }
    }
}
