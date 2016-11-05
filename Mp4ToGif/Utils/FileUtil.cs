using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mp4ToGif.Utils
{
    class FileUtil
    {

        public static string getPath(string filePath)
        {
            return Path.GetDirectoryName(filePath);
        }

    }
}
