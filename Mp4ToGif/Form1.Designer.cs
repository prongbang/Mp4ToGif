namespace Mp4ToGif
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tbMp4Path = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.rdBtnScaleDefault = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rdBtnScaleWidth = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PATH : ";
            // 
            // tbMp4Path
            // 
            this.tbMp4Path.Location = new System.Drawing.Point(55, 6);
            this.tbMp4Path.Name = "tbMp4Path";
            this.tbMp4Path.Size = new System.Drawing.Size(416, 20);
            this.tbMp4Path.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(477, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(477, 33);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // rdBtnScaleDefault
            // 
            this.rdBtnScaleDefault.AutoSize = true;
            this.rdBtnScaleDefault.Location = new System.Drawing.Point(345, 38);
            this.rdBtnScaleDefault.Name = "rdBtnScaleDefault";
            this.rdBtnScaleDefault.Size = new System.Drawing.Size(49, 17);
            this.rdBtnScaleDefault.TabIndex = 4;
            this.rdBtnScaleDefault.TabStop = true;
            this.rdBtnScaleDefault.Text = "____";
            this.rdBtnScaleDefault.UseVisualStyleBackColor = true;
            this.rdBtnScaleDefault.CheckedChanged += new System.EventHandler(this.rdBtnScaleDefault_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "SCALE";
            // 
            // rdBtnScaleWidth
            // 
            this.rdBtnScaleWidth.AutoSize = true;
            this.rdBtnScaleWidth.Location = new System.Drawing.Point(408, 38);
            this.rdBtnScaleWidth.Name = "rdBtnScaleWidth";
            this.rdBtnScaleWidth.Size = new System.Drawing.Size(49, 17);
            this.rdBtnScaleWidth.TabIndex = 6;
            this.rdBtnScaleWidth.TabStop = true;
            this.rdBtnScaleWidth.Text = "____";
            this.rdBtnScaleWidth.UseVisualStyleBackColor = true;
            this.rdBtnScaleWidth.CheckedChanged += new System.EventHandler(this.rdBtnScaleWidth_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "STATUS : ";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(77, 39);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(121, 13);
            this.lbStatus.TabIndex = 8;
            this.lbStatus.Text = "Please choose file .MP4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 112);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdBtnScaleWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdBtnScaleDefault);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tbMp4Path);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MP4 TO GIF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMp4Path;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.RadioButton rdBtnScaleDefault;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdBtnScaleWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbStatus;
    }
}

