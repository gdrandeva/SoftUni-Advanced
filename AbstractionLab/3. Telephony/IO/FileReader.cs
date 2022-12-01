using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Telephony.IO.Interfaces;

namespace Telephony.IO
{
    public class FileReader : IReader
    {
        public string FilePath { get; private set; }

        public FileReader(string filePath)
        {
            this.FilePath = filePath;
        }
        public string ReadLine()
        => File.
    }
}
