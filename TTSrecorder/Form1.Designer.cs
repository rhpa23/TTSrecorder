namespace TTSrecorder
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
            this.btnStart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbSamples = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radio8Bits = new System.Windows.Forms.RadioButton();
            this.radio16Bits = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioChannelStereo = new System.Windows.Forms.RadioButton();
            this.radioChannelMono = new System.Windows.Forms.RadioButton();
            this.trackRate = new System.Windows.Forms.TrackBar();
            this.labelVolume = new System.Windows.Forms.Label();
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cmbVoice = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(697, 447);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 32);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(626, 509);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Let\'s work on this";
            // 
            // cmbSamples
            // 
            this.cmbSamples.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSamples.FormattingEnabled = true;
            this.cmbSamples.Items.AddRange(new object[] {
            "8000",
            "11025",
            "16000",
            "22050",
            "32000",
            "44100",
            "48000",
            "88200",
            "96000",
            "176400",
            "192000",
            "352800",
            "384000"});
            this.cmbSamples.Location = new System.Drawing.Point(651, 92);
            this.cmbSamples.Name = "cmbSamples";
            this.cmbSamples.Size = new System.Drawing.Size(156, 24);
            this.cmbSamples.TabIndex = 2;
            this.cmbSamples.Text = "22050";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(648, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Samples (Hz)";
            // 
            // labelRate
            // 
            this.labelRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRate.AutoSize = true;
            this.labelRate.Location = new System.Drawing.Point(650, 281);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(60, 17);
            this.labelRate.TabIndex = 4;
            this.labelRate.Text = "Rate (0)";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(649, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bits per sample";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.radio16Bits);
            this.panel1.Controls.Add(this.radio8Bits);
            this.panel1.Location = new System.Drawing.Point(651, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 38);
            this.panel1.TabIndex = 5;
            // 
            // radio8Bits
            // 
            this.radio8Bits.AutoSize = true;
            this.radio8Bits.Location = new System.Drawing.Point(11, 3);
            this.radio8Bits.Name = "radio8Bits";
            this.radio8Bits.Size = new System.Drawing.Size(37, 21);
            this.radio8Bits.TabIndex = 0;
            this.radio8Bits.Text = "8";
            this.radio8Bits.UseVisualStyleBackColor = true;
            // 
            // radio16Bits
            // 
            this.radio16Bits.AutoSize = true;
            this.radio16Bits.Checked = true;
            this.radio16Bits.Location = new System.Drawing.Point(76, 3);
            this.radio16Bits.Name = "radio16Bits";
            this.radio16Bits.Size = new System.Drawing.Size(45, 21);
            this.radio16Bits.TabIndex = 0;
            this.radio16Bits.TabStop = true;
            this.radio16Bits.Text = "16";
            this.radio16Bits.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(650, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Channel";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.radioChannelStereo);
            this.panel2.Controls.Add(this.radioChannelMono);
            this.panel2.Location = new System.Drawing.Point(652, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 38);
            this.panel2.TabIndex = 5;
            // 
            // radioChannelStereo
            // 
            this.radioChannelStereo.AutoSize = true;
            this.radioChannelStereo.Location = new System.Drawing.Point(84, 3);
            this.radioChannelStereo.Name = "radioChannelStereo";
            this.radioChannelStereo.Size = new System.Drawing.Size(71, 21);
            this.radioChannelStereo.TabIndex = 0;
            this.radioChannelStereo.Text = "Stereo";
            this.radioChannelStereo.UseVisualStyleBackColor = true;
            // 
            // radioChannelMono
            // 
            this.radioChannelMono.AutoSize = true;
            this.radioChannelMono.Checked = true;
            this.radioChannelMono.Location = new System.Drawing.Point(11, 3);
            this.radioChannelMono.Name = "radioChannelMono";
            this.radioChannelMono.Size = new System.Drawing.Size(64, 21);
            this.radioChannelMono.TabIndex = 0;
            this.radioChannelMono.Text = "Mono";
            this.radioChannelMono.UseVisualStyleBackColor = true;
            // 
            // trackRate
            // 
            this.trackRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackRate.LargeChange = 1;
            this.trackRate.Location = new System.Drawing.Point(653, 301);
            this.trackRate.Minimum = -10;
            this.trackRate.Name = "trackRate";
            this.trackRate.Size = new System.Drawing.Size(147, 56);
            this.trackRate.TabIndex = 6;
            this.trackRate.Scroll += new System.EventHandler(this.trackRate_Scroll);
            // 
            // labelVolume
            // 
            this.labelVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(650, 360);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(93, 17);
            this.labelVolume.TabIndex = 4;
            this.labelVolume.Text = "Volume (100)";
            // 
            // trackVolume
            // 
            this.trackVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackVolume.Location = new System.Drawing.Point(653, 388);
            this.trackVolume.Maximum = 100;
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Size = new System.Drawing.Size(147, 56);
            this.trackVolume.TabIndex = 6;
            this.trackVolume.Value = 100;
            this.trackVolume.Scroll += new System.EventHandler(this.trackVolume_Scroll);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(660, 485);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(147, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // cmbVoice
            // 
            this.cmbVoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoice.FormattingEnabled = true;
            this.cmbVoice.Location = new System.Drawing.Point(651, 34);
            this.cmbVoice.Name = "cmbVoice";
            this.cmbVoice.Size = new System.Drawing.Size(156, 24);
            this.cmbVoice.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(650, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Voice";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 533);
            this.Controls.Add(this.cmbVoice);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.trackVolume);
            this.Controls.Add(this.trackRate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSamples);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "TTS Lines Recorder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbSamples;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radio16Bits;
        private System.Windows.Forms.RadioButton radio8Bits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioChannelStereo;
        private System.Windows.Forms.RadioButton radioChannelMono;
        private System.Windows.Forms.TrackBar trackRate;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.TrackBar trackVolume;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox cmbVoice;
        private System.Windows.Forms.Label label2;
    }
}

