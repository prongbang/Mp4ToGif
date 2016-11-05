using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mp4ToGif.Utils
{
    class ConfigUtil
    {

        public static String MP4 = ".mp4";

        public static String GIF = ".gif";

        public static String UNDERLINE = "____";

        public static String COMPLETE = "Convert Complete";

        public static String CONVERTING = "Converting...";

        public static String FFMPEG = "ffmpeg";

        public static String CMD = "cmd";

        public static String FFMPEG_INFO = "-i \"{0}\"";

        public static String INPUT_PATH = "";

        public static String FFMPEG_PALETTE_PNG = "palette.png";

        public static int FFMPEG_START_AT_SECOND = 0;

        public static int FFMPEG_LENGTH_OF_GIF_VIDEO = 9999999;

        public static int FFMPEG_SCALE_CONST = 660;

        public static int FFMPEG_SCALE = FFMPEG_SCALE_CONST;

        /**
         * {0} : FFMPEG_START_AT_SECOND
         * {1} : FFMPEG_LENGTH_OF_GIF_VIDEO
         * {2} : INPUT_PATH
         * {3} : FFMPEG_SCALE
         * {4} : FFMPEG_PALETTE_PNG
         */
        public static String FFMPEG_GENERATE_PALETTE = "-y -ss {0} -t {1} -i \"{2}\" -vf fps=10,scale={3}:-1:flags=lanczos,palettegen \"{4}\"";

        /**
         * {0} : FFMPEG_START_AT_SECOND
         * {1} : FFMPEG_LENGTH_OF_GIF_VIDEO
         * {2} : INPUT_PATH
         * {3} : FFMPEG_PALETTE_PNG
         * {4} : FFMPEG_SCALE
         * {5} : INPUT_PATH
         */
        public static String FFMPEG_OUTPUT_GIF_USING_PALETTE = "-ss {0} -t {1} -i \"{2}\" -i \"{3}\" -filter_complex \"fps=10,scale={4}:-1:flags=lanczos[x];[x][1:v]paletteuse\" \"{5}.gif\"";

        /**
         * {0} : FFMPEG_PALETTE_PNG
         */
        public static String DELETE_FILE = "del \"{0}\"";

    }
}
