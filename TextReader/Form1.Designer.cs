namespace TextReader
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnSpeak = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mestFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mestSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrSaveToTxt = new System.Windows.Forms.ToolStripMenuItem();
            this.mestSaveToPdf = new System.Windows.Forms.ToolStripMenuItem();
            this.mestSaveToMp3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mestSaveToWav = new System.Windows.Forms.ToolStripMenuItem();
            this.mestAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mestLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.mestArabic = new System.Windows.Forms.ToolStripMenuItem();
            this.mestEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSelectVoice = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSpeak
            // 
            this.btnSpeak.Font = new System.Drawing.Font("Tahoma", 17F);
            this.btnSpeak.Location = new System.Drawing.Point(12, 387);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(144, 58);
            this.btnSpeak.TabIndex = 1;
            this.btnSpeak.Text = "&Speak";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Tahoma", 17F);
            this.btnStop.Location = new System.Drawing.Point(725, 387);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(144, 58);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "S&top";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnResume
            // 
            this.btnResume.Font = new System.Drawing.Font("Tahoma", 17F);
            this.btnResume.Location = new System.Drawing.Point(575, 387);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(144, 58);
            this.btnResume.TabIndex = 3;
            this.btnResume.Text = "&Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Tahoma", 17F);
            this.btnPause.Location = new System.Drawing.Point(425, 387);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(144, 58);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "&Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 48);
            // 
            // abutToolStripMenuItem
            // 
            this.abutToolStripMenuItem.Name = "abutToolStripMenuItem";
            this.abutToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.abutToolStripMenuItem.Text = "Abut";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mestFile,
            this.mestAbout,
            this.mestLanguage});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(881, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mestFile
            // 
            this.mestFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mestSave});
            this.mestFile.Name = "mestFile";
            this.mestFile.Size = new System.Drawing.Size(37, 20);
            this.mestFile.Text = "&File";
            this.mestFile.Click += new System.EventHandler(this.mestFile_Click);
            // 
            // mestSave
            // 
            this.mestSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstrSaveToTxt,
            this.mestSaveToPdf,
            this.mestSaveToMp3,
            this.mestSaveToWav});
            this.mestSave.Name = "mestSave";
            this.mestSave.Size = new System.Drawing.Size(152, 22);
            this.mestSave.Text = "&Save";
            // 
            // mstrSaveToTxt
            // 
            this.mstrSaveToTxt.Name = "mstrSaveToTxt";
            this.mstrSaveToTxt.Size = new System.Drawing.Size(152, 22);
            this.mstrSaveToTxt.Text = "Save To &txt";
            this.mstrSaveToTxt.Click += new System.EventHandler(this.mstrSaveToTxt_Click);
            // 
            // mestSaveToPdf
            // 
            this.mestSaveToPdf.Name = "mestSaveToPdf";
            this.mestSaveToPdf.Size = new System.Drawing.Size(152, 22);
            this.mestSaveToPdf.Text = "Save To &pdf";
            this.mestSaveToPdf.Click += new System.EventHandler(this.mestSaveToPdf_Click);
            // 
            // mestSaveToMp3
            // 
            this.mestSaveToMp3.Name = "mestSaveToMp3";
            this.mestSaveToMp3.Size = new System.Drawing.Size(152, 22);
            this.mestSaveToMp3.Text = "Save To &mp3";
            this.mestSaveToMp3.Click += new System.EventHandler(this.mestSaveToMp3_Click);
            // 
            // mestSaveToWav
            // 
            this.mestSaveToWav.Name = "mestSaveToWav";
            this.mestSaveToWav.Size = new System.Drawing.Size(152, 22);
            this.mestSaveToWav.Text = "Save To &wav";
            this.mestSaveToWav.Click += new System.EventHandler(this.mestSaveToWav_Click);
            // 
            // mestAbout
            // 
            this.mestAbout.Name = "mestAbout";
            this.mestAbout.Size = new System.Drawing.Size(52, 20);
            this.mestAbout.Text = "&About";
            this.mestAbout.Click += new System.EventHandler(this.mestAbout_Click);
            // 
            // mestLanguage
            // 
            this.mestLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mestArabic,
            this.mestEnglish});
            this.mestLanguage.Name = "mestLanguage";
            this.mestLanguage.Size = new System.Drawing.Size(71, 20);
            this.mestLanguage.Text = "&Language";
            // 
            // mestArabic
            // 
            this.mestArabic.Name = "mestArabic";
            this.mestArabic.Size = new System.Drawing.Size(152, 22);
            this.mestArabic.Text = "&Arabic";
            this.mestArabic.Click += new System.EventHandler(this.mestArabic_Click);
            // 
            // mestEnglish
            // 
            this.mestEnglish.Name = "mestEnglish";
            this.mestEnglish.Size = new System.Drawing.Size(152, 22);
            this.mestEnglish.Text = "&English";
            this.mestEnglish.Click += new System.EventHandler(this.mestEnglish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(222, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select Voice:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbSelectVoice
            // 
            this.cbSelectVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectVoice.FormattingEnabled = true;
            this.cbSelectVoice.Items.AddRange(new object[] {
            "NotSet",
            "Male",
            "Female",
            "Natural"});
            this.cbSelectVoice.Location = new System.Drawing.Point(372, 63);
            this.cbSelectVoice.Name = "cbSelectVoice";
            this.cbSelectVoice.Size = new System.Drawing.Size(188, 21);
            this.cbSelectVoice.TabIndex = 8;
            this.cbSelectVoice.SelectedIndexChanged += new System.EventHandler(this.cbSelectVoice_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 17F);
            this.btnClear.Location = new System.Drawing.Point(275, 387);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 58);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(15, 102);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(853, 266);
            this.txtInput.TabIndex = 10;
            this.txtInput.Text = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 450);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cbSelectVoice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnSpeak);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mestFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSelectVoice;
        private System.Windows.Forms.ToolStripMenuItem mestSave;
        private System.Windows.Forms.ToolStripMenuItem mstrSaveToTxt;
        private System.Windows.Forms.ToolStripMenuItem mestSaveToMp3;
        private System.Windows.Forms.ToolStripMenuItem mestSaveToWav;
        private System.Windows.Forms.ToolStripMenuItem mestAbout;
        private System.Windows.Forms.ToolStripMenuItem mestLanguage;
        private System.Windows.Forms.ToolStripMenuItem mestArabic;
        private System.Windows.Forms.ToolStripMenuItem mestEnglish;
        private System.Windows.Forms.ToolStripMenuItem mestSaveToPdf;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox txtInput;
    }
}

