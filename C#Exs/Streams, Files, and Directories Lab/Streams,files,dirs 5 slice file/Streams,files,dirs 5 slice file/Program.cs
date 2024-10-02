/* slice an input file into 4 parts
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace Streams_files_dirs_5_slice_file
{
    class Program
    {
        static async Task Main(string[] args)
        {
            int parts = 4;
            byte[] buffer = new byte[4096];

            int totalBytes = 0;

            using (FileStream fs = new FileStream("Input.txt", FileMode.Open, FileAccess.Read))
            {
                long partSize = (long)Math.Ceiling((decimal)fs.Length / parts);

                for (int i = 1; i <= parts; i++)
                {
                    using (FileStream outFS = new FileStream($"Parts-{i}.txt", FileMode.Create, FileAccess.Write))
                    {
                        int readBytes = 0;

                        while (readBytes < partSize && totalBytes < fs.Length)
                        {
                            int bytes = await fs.ReadAsync(buffer, 0, buffer.Length);
                            await outFS.WriteAsync(buffer, 0, bytes);

                            readBytes += bytes;
                            totalBytes += bytes;
                        }

                    }
                }
            }
        }
    }
}
