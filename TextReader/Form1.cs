using System;
using System.IO;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace TextReader
{
    public partial class FormMain : Form
    {
        SpeechSynthesizer voice; 
        public FormMain()
        {
            InitializeComponent();
            txtInput.DragDrop += new DragEventHandler(txtInput_DragDrop);
            txtInput.AllowDrop = true;
        }

        private void txtInput_DragDrop(object sender, DragEventArgs e)
        {
            object fileName = e.Data.GetData("FileDrop");
            if (fileName != null)
            {
                var list = fileName as string[];
                if (list != null && !string.IsNullOrWhiteSpace(list[0]))
                {
                    txtInput.Clear();
                    txtInput.LoadFile(list[0], RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mestFile_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipText = "I am Here";
            voice = new SpeechSynthesizer();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Minimized)
            {
                //MessageBox.Show("I am Here");
                ShowIcon = false;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Are You sure You Want To Exit Text Reader? ", "Exit Text Reader ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (exit == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cbSelectVoice.SelectedIndex)
                {
                    case 0:
                        voice.SelectVoiceByHints(VoiceGender.NotSet);
                        break;
                    case 1:
                        voice.SelectVoiceByHints(VoiceGender.Male);
                        break;
                    case 2:
                        voice.SelectVoiceByHints(VoiceGender.Female);
                        break;
                    case 3:
                        voice.SelectVoiceByHints(VoiceGender.Neutral);
                        break;
                    default:
                        break;  
                }
                voice.SpeakAsync(txtInput.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            try
            {
                this.voice.Pause();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            try
            {
                this.voice.Resume();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                voice.SpeakAsyncCancelAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mstrSaveToTxt_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "txt File|*.txt";
                    sfd.Title = "Save To TXT File";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(fs);
                        sw.WriteLine(txtInput.Text);
                        sw.Close();
                        MessageBox.Show("File Saved Successfully ", "Saved File ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mestSaveToMp3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "mp3 File|*.mp3";
                    sfd.Title = "Save To MP3 File";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(fs);
                        voice.SetOutputToWaveStream(fs);
                        voice.SpeakAsync(txtInput.Text);
                        MessageBox.Show("Audio Saved Successfully ", "Saved Audio ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mestSaveToWav_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "wav File|*.wav";
                    sfd.Title = "Save To WAV File";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(fs);
                        voice.SetOutputToWaveStream(fs);
                        voice.SpeakAsync(txtInput.Text);
                        MessageBox.Show("Audio Saved Successfully ", "Saved Audio ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mestAbout_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mestArabic_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mestEnglish_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInput_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (txtInput.Text == "")
            {
                txtInput.Paste();
            }
        }

        private void cbSelectVoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            voice.SpeakAsyncCancelAll();
        }

        private void mestSaveToPdf_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "pdf File|*.pdf";
                sfd.Title = "Save To PDF File";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(txtInput.Text);
                    sw.Close();
                    MessageBox.Show("Faile Saved Successfully ", "Faile Audio ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult clear;
                clear = MessageBox.Show("Are you suer you want to clear?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (clear == DialogResult.Yes)
                    txtInput.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    btnSpeak.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                    e.Handled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
