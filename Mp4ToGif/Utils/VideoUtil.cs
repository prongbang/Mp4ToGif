using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mp4ToGif.Utils
{
    class VideoUtil
    {

        public static string getVideoInfo(string mp4Path)
        {
            string @params = string.Format(ConfigUtil.FFMPEG_INFO, mp4Path);
            string output = CmdUtil.RunProcess(ConfigUtil.FFMPEG, @params);

            return output;
        }

        public static int getHeight(string output)
        {
            int height = 0;

            Dictionary<string, int> wh = VideoUtil.getWidthAndHight(output);
            
            if (wh.Count > 0)
            {
                height = wh["height"];
            }

            return height;
        }

        public static int getWidth(string output)
        {
            int width = 0;

            Dictionary<string, int> wh = VideoUtil.getWidthAndHight(output);

            if (wh.Count > 0)
            {
                width = wh["width"];
            }

            return width;
        }

        public static Dictionary<string, int> getWidthAndHight(string output)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            //get the video format
            Regex re = new Regex("(\\d{2,4})x(\\d{2,3})");
            Match m = re.Match(output);
            if (m.Success)
            {
                int width = 0; int height = 0;
                int.TryParse(m.Groups[1].Value, out width);
                int.TryParse(m.Groups[2].Value, out height);
                dictionary.Add("width", width);
                dictionary.Add("height", height);
            }
            return dictionary;
        }

    }
}
