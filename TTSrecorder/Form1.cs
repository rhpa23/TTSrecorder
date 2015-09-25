using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.AudioFormat;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTSrecorder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string GetAudioFileName(string text)
        {
            string audioFileName = text + ".wav";

            string[] textParts = text.Split(',');
            if (textParts.Length > 1)
            {
                audioFileName = textParts[1];
            }

            return audioFileName.Replace("\r", "");
        }

        private string GetAudioText(string text)
        {
            string audioText = text;

            string[] textParts = text.Split(',');
            if (textParts.Length > 1)
            {
                audioText = textParts[0];
            }

            return audioText.Replace("\r", "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show(this, "Write some text to start.", "Empty text", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            string[] texts = textBox1.Text.Split('\n');

            progressBar1.Value = 0;
            progressBar1.Maximum = texts.Length;

            for (int i = 0; i < texts.Length; i++)
            {
                var reader = new SpeechSynthesizer();
                //reader.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(synth_SpeakCompleted);
                reader.Rate = trackRate.Value;
                reader.Volume = trackVolume.Value;
                reader.SelectVoice(((VoiceInfo)cmbVoice.SelectedItem).Name);

                var bits = radio8Bits.Checked ? AudioBitsPerSample.Eight : AudioBitsPerSample.Sixteen;
                var channel = radioChannelMono.Checked ? AudioChannel.Mono : AudioChannel.Stereo;

                var format = new SpeechAudioFormatInfo(int.Parse(cmbSamples.Text), bits, channel);
                string filePath = Directory.GetCurrentDirectory() + @"\Output\";
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }
                reader.SetOutputToWaveFile(Directory.GetCurrentDirectory() + @"\Output\" + GetAudioFileName(texts[i]), format);
                reader.Speak(GetAudioText(texts[i]));
                progressBar1.Value++;
                reader.Dispose();
            }
            MessageBox.Show(this, "All done. Check .wav files on 'Output' folder.", "Finish", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Handle the SpeakCompleted event.
        static void synth_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            // Create a SoundPlayer instance to play the output audio file.
            var m_SoundPlayer = new System.Media.SoundPlayer(@"C:\MyWavFile.wav");

            //  Play the output file.
            m_SoundPlayer.Play();
        }

        private void trackRate_Scroll(object sender, EventArgs e)
        {
            labelRate.Text = "Rate (" + trackRate.Value + ")";
        }

        private void trackVolume_Scroll(object sender, EventArgs e)
        {
            labelVolume.Text = "Volume (" + trackVolume.Value + ")";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IList<VoiceInfo> voiceInfos = new List<VoiceInfo>();
            var reader = new SpeechSynthesizer();

            var installedVoices = reader.GetInstalledVoices();
            if (installedVoices.Count == 0)
            {
                MessageBox.Show(this,
                    "Your system don't have a 'Text to Speech' to make this work. Try install one for continue.",
                    "Finish", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                foreach (InstalledVoice voice in installedVoices)
                {
                    voiceInfos.Add(voice.VoiceInfo);
                }
                cmbVoice.DataSource = voiceInfos;
                cmbVoice.DisplayMember = "Name";
                cmbVoice.ValueMember = "Id";
            }
            reader.Dispose();
        }
    }
}
