using Mp4ToGif.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Mp4ToGif
{
    public partial class Form1 : Form
    {

        private System.Timers.Timer aTimer;

        private Thread workThread;

        delegate void StringParameterDelegate(string status);

        public Form1()
        {
            InitializeComponent();

            this.Text = "Convert MP4 TO GIF 1.0.0";

            // Center at initilization
            this.StartPosition = FormStartPosition.CenterScreen;

            rdBtnScaleDefault.Text = ConfigUtil.FFMPEG_SCALE + "";
            rdBtnScaleDefault.Checked = true;
            btnConvert.Enabled = tbMp4Path.Enabled = false;

            this.MinimumSize = new Size(this.Width, this.Height);
            this.MaximumSize = new Size(this.Width, this.Height);

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            // Show the dialog and get result.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbMp4Path.Text = openFileDialog1.FileName;
                Regex re = new Regex("\\d*" + ConfigUtil.MP4);
                Match m = re.Match(tbMp4Path.Text);
                if (m.Success)
                {
                    string videoInfo = VideoUtil.getVideoInfo(tbMp4Path.Text);
                    ConfigUtil.FFMPEG_SCALE = VideoUtil.getWidth(videoInfo);
                    rdBtnScaleWidth.Text = ConfigUtil.FFMPEG_SCALE + "";
                    btnConvert.Enabled = true;
                }
                else
                {
                    tbMp4Path.Text = "";
                    btnConvert.Enabled = false;
                    MessageBox.Show("Can't Support File " + openFileDialog1.FileName);
                }
            }

        }

        private void startTimer()
        {
            aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 1000;
            aTimer.Enabled = true;
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            string fileGif = ConfigUtil.INPUT_PATH.Replace(ConfigUtil.MP4, ConfigUtil.GIF);
            if (File.Exists(fileGif))
            {
                if (!SystemUtil.checkProcess(ConfigUtil.FFMPEG))
                {
                    updateStatus(ConfigUtil.COMPLETE);
                    aTimer.Stop();
                    workThread.Abort();
                }
            }
        }

        private void updateStatus(string status)
        {
            if (InvokeRequired)
            {
                // We're not in the UI thread
                BeginInvoke(new StringParameterDelegate(updateStatus), new object[] { status });
                return;
            }
            lbStatus.Text = status;
        }

        private void convertToGif()
        {
            ConfigUtil.INPUT_PATH = tbMp4Path.Text;

            string fileGif = ConfigUtil.INPUT_PATH.Replace(ConfigUtil.MP4, ConfigUtil.GIF);

            ConfigUtil.FFMPEG_PALETTE_PNG = FileUtil.getPath(ConfigUtil.INPUT_PATH) + @"\" + ConfigUtil.FFMPEG_PALETTE_PNG;

            if (!File.Exists(fileGif))
            {

                updateStatus(ConfigUtil.CONVERTING);

                startTimer();

                string generateAPalette = string.Format(
                    ConfigUtil.FFMPEG_GENERATE_PALETTE,
                    ConfigUtil.FFMPEG_START_AT_SECOND,
                    ConfigUtil.FFMPEG_LENGTH_OF_GIF_VIDEO,
                    ConfigUtil.INPUT_PATH,
                    ConfigUtil.FFMPEG_SCALE,
                    ConfigUtil.FFMPEG_PALETTE_PNG
                );

                string outputGifUsingPalette = string.Format(
                    ConfigUtil.FFMPEG_OUTPUT_GIF_USING_PALETTE,
                    ConfigUtil.FFMPEG_START_AT_SECOND,
                    ConfigUtil.FFMPEG_LENGTH_OF_GIF_VIDEO,
                    ConfigUtil.INPUT_PATH,
                    ConfigUtil.FFMPEG_PALETTE_PNG,
                    ConfigUtil.FFMPEG_SCALE,
                    ConfigUtil.INPUT_PATH.Replace(ConfigUtil.MP4, "")
                );

                String genPalette = string.Format("{0} {1}", ConfigUtil.FFMPEG, generateAPalette);

                String convGif = string.Format("{0} {1}", ConfigUtil.FFMPEG, outputGifUsingPalette);

                String delPalett = string.Format(ConfigUtil.DELETE_FILE, ConfigUtil.FFMPEG_PALETTE_PNG);

                String options = string.Format("{0} & {1} & {2} & exit", genPalette, convGif, delPalett);

                String command = string.Format("/c start {0} /k \"{1}\"", ConfigUtil.CMD, options);

                CmdUtil.RunProcess(ConfigUtil.CMD, command);

            }
            else
            {
                MessageBox.Show("File already exists, " + fileGif);
                workThread.Abort();
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

            workThread = new Thread(new ThreadStart(convertToGif));
            workThread.IsBackground = true;
            workThread.Start();

        }

        private void rdBtnScaleDefault_CheckedChanged(object sender, EventArgs e)
        {
            ConfigUtil.FFMPEG_SCALE = ConfigUtil.FFMPEG_SCALE_CONST;
        }

        private void rdBtnScaleWidth_CheckedChanged(object sender, EventArgs e)
        {
            if (tbMp4Path.Text != null && tbMp4Path.Text != "")
            {
                if (rdBtnScaleWidth.Text != null && rdBtnScaleWidth.Text != ConfigUtil.UNDERLINE)
                {
                    ConfigUtil.FFMPEG_SCALE = Int32.Parse(rdBtnScaleWidth.Text);
                }
            }
        }

    }
}
