using System;
using System.Buffers;
using System.IO.Pipelines;
using System.Net.Http;
using System.Threading.Tasks;

namespace Pipelines
{
    public class PipeLineCounter
    {
        public async Task<int> CountLines(Uri uri)
        {
            using var client = new HttpClient();
            await using var stream = await client.GetStreamAsync(uri);

            // Calculate how many lines (end of line characters `\n`) are in the network stream
            // To practice, use a pattern where you have the Pipe, Writer and Reader tasks
            // Read about SequenceReader<T>, https://docs.microsoft.com/en-us/dotnet/api/system.buffers.sequencereader-1?view=netcore-3.1
            // This struct h has a method that can be very useful for this scenario :)

            // Good luck and have fun with pipelines!
            var reader = PipeReader.Create(stream, new StreamPipeReaderOptions());
            ReadResult result;
            int items = 0;
            do
            {
                result = await reader.ReadAsync();
                if (result.IsCompleted)
                {
                    break;
                }

                var buffer = result.Buffer;
                var (readItems, position) = CountItems(buffer, result.IsCompleted);

                items += readItems;
                reader.AdvanceTo(position, buffer.End);

            } while (!result.IsCompleted);
            await reader.CompleteAsync();

            return items;
        }

        private (int, SequencePosition) CountItems(in ReadOnlySequence<byte> buffer, in bool resultIsCompleted)
        {
            var reader = new SequenceReader<byte>(buffer);

            int count = 0;
            while (!reader.End)
            {
                if (reader.TryReadTo(out ReadOnlySpan<byte> itemBuffer, (byte)'\n', advancePastDelimiter: true))
                {
                    count++;
                }
                else if (resultIsCompleted)
                {
                    reader.Advance(buffer.Length);
                }
                else
                {
                    break;
                }
            }

            return (count, reader.Position);
        }
    }
}
