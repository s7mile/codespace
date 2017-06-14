namespace codespace
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveasMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.redoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.allselMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineNumMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fontMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.customTabControl1 = new System.Windows.Forms.CustomTabControl();
            this.button_Upload = new System.Windows.Forms.Button();
            this.button_download = new System.Windows.Forms.Button();
            this.listBox_filelist = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newBtn = new System.Windows.Forms.ToolStripButton();
            this.openBtn = new System.Windows.Forms.ToolStripButton();
            this.saveBtn = new System.Windows.Forms.ToolStripButton();
            this.printBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.undoBtn = new System.Windows.Forms.ToolStripButton();
            this.redoBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.WebBtn = new System.Windows.Forms.ToolStripButton();
            this.refreshBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tbFind = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.settingBtn = new System.Windows.Forms.ToolStripButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.보기ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenu,
            this.openMenu,
            this.saveMenu,
            this.saveasMenu,
            this.toolStripSeparator1,
            this.exitMenu});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // newMenu
            // 
            this.newMenu.Name = "newMenu";
            this.newMenu.Size = new System.Drawing.Size(178, 22);
            this.newMenu.Text = "새로 만들기";
            this.newMenu.Click += new System.EventHandler(this.newMenu_Click);
            // 
            // openMenu
            // 
            this.openMenu.Name = "openMenu";
            this.openMenu.Size = new System.Drawing.Size(178, 22);
            this.openMenu.Text = "열기";
            this.openMenu.Click += new System.EventHandler(this.openMenu_Click);
            // 
            // saveMenu
            // 
            this.saveMenu.Name = "saveMenu";
            this.saveMenu.Size = new System.Drawing.Size(178, 22);
            this.saveMenu.Text = "저장";
            this.saveMenu.Click += new System.EventHandler(this.saveMenu_Click);
            // 
            // saveasMenu
            // 
            this.saveasMenu.Name = "saveasMenu";
            this.saveasMenu.Size = new System.Drawing.Size(178, 22);
            this.saveasMenu.Text = "다른 이름으로 저장";
            this.saveasMenu.Click += new System.EventHandler(this.saveasMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(178, 22);
            this.exitMenu.Text = "끝내기";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoMenu,
            this.redoMenu,
            this.toolStripSeparator4,
            this.cutMenu,
            this.copyMenu,
            this.pasteMenu,
            this.deleteMenu,
            this.toolStripSeparator6,
            this.allselMenu});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.편집ToolStripMenuItem.Text = "편집";
            // 
            // undoMenu
            // 
            this.undoMenu.Name = "undoMenu";
            this.undoMenu.Size = new System.Drawing.Size(126, 22);
            this.undoMenu.Text = "실행취소";
            this.undoMenu.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoMenu
            // 
            this.redoMenu.Name = "redoMenu";
            this.redoMenu.Size = new System.Drawing.Size(126, 22);
            this.redoMenu.Text = "다시실행";
            this.redoMenu.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(123, 6);
            // 
            // cutMenu
            // 
            this.cutMenu.Name = "cutMenu";
            this.cutMenu.Size = new System.Drawing.Size(126, 22);
            this.cutMenu.Text = "잘라내기";
            this.cutMenu.Click += new System.EventHandler(this.cutMenu_Click);
            // 
            // copyMenu
            // 
            this.copyMenu.Name = "copyMenu";
            this.copyMenu.Size = new System.Drawing.Size(126, 22);
            this.copyMenu.Text = "복사";
            this.copyMenu.Click += new System.EventHandler(this.copyMenu_Click);
            // 
            // pasteMenu
            // 
            this.pasteMenu.Name = "pasteMenu";
            this.pasteMenu.Size = new System.Drawing.Size(126, 22);
            this.pasteMenu.Text = "붙여넣기";
            this.pasteMenu.Click += new System.EventHandler(this.pasteMenu_Click);
            // 
            // deleteMenu
            // 
            this.deleteMenu.Name = "deleteMenu";
            this.deleteMenu.Size = new System.Drawing.Size(126, 22);
            this.deleteMenu.Text = "삭제";
            this.deleteMenu.Click += new System.EventHandler(this.deleteMenu_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(123, 6);
            // 
            // allselMenu
            // 
            this.allselMenu.Name = "allselMenu";
            this.allselMenu.Size = new System.Drawing.Size(126, 22);
            this.allselMenu.Text = "모두 선택";
            // 
            // 보기ToolStripMenuItem
            // 
            this.보기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineNumMenu,
            this.fontMenu});
            this.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            this.보기ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.보기ToolStripMenuItem.Text = "보기";
            // 
            // lineNumMenu
            // 
            this.lineNumMenu.Name = "lineNumMenu";
            this.lineNumMenu.Size = new System.Drawing.Size(110, 22);
            this.lineNumMenu.Text = "줄번호";
            this.lineNumMenu.Click += new System.EventHandler(this.lineNumMenu_Click);
            // 
            // fontMenu
            // 
            this.fontMenu.Name = "fontMenu";
            this.fontMenu.Size = new System.Drawing.Size(110, 22);
            this.fontMenu.Text = "글꼴";
            this.fontMenu.Click += new System.EventHandler(this.fontMenu_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Location = new System.Drawing.Point(0, 52);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.customTabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.button_Upload);
            this.splitContainer1.Panel2.Controls.Add(this.button_download);
            this.splitContainer1.Panel2.Controls.Add(this.listBox_filelist);
            this.splitContainer1.Size = new System.Drawing.Size(793, 326);
            this.splitContainer1.SplitterDistance = 604;
            this.splitContainer1.TabIndex = 5;
            // 
            // customTabControl1
            // 
            this.customTabControl1.DisplayStyle = System.Windows.Forms.TabStyle.Chrome;
            // 
            // 
            // 
            this.customTabControl1.DisplayStyleProvider.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.customTabControl1.DisplayStyleProvider.BorderColorHot = System.Drawing.SystemColors.ControlDark;
            this.customTabControl1.DisplayStyleProvider.BorderColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.customTabControl1.DisplayStyleProvider.CloserColor = System.Drawing.Color.DarkGray;
            this.customTabControl1.DisplayStyleProvider.CloserColorActive = System.Drawing.Color.White;
            this.customTabControl1.DisplayStyleProvider.FocusTrack = false;
            this.customTabControl1.DisplayStyleProvider.HotTrack = true;
            this.customTabControl1.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customTabControl1.DisplayStyleProvider.Opacity = 1F;
            this.customTabControl1.DisplayStyleProvider.Overlap = 16;
            this.customTabControl1.DisplayStyleProvider.Padding = new System.Drawing.Point(7, 5);
            this.customTabControl1.DisplayStyleProvider.Radius = 16;
            this.customTabControl1.DisplayStyleProvider.ShowTabCloser = true;
            this.customTabControl1.DisplayStyleProvider.TextColor = System.Drawing.SystemColors.ControlText;
            this.customTabControl1.DisplayStyleProvider.TextColorDisabled = System.Drawing.SystemColors.ControlDark;
            this.customTabControl1.DisplayStyleProvider.TextColorSelected = System.Drawing.SystemColors.ControlText;
            this.customTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customTabControl1.HotTrack = true;
            this.customTabControl1.Location = new System.Drawing.Point(0, 0);
            this.customTabControl1.Name = "customTabControl1";
            this.customTabControl1.SelectedIndex = 0;
            this.customTabControl1.Size = new System.Drawing.Size(604, 326);
            this.customTabControl1.TabIndex = 6;
            // 
            // button_Upload
            // 
            this.button_Upload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Upload.Location = new System.Drawing.Point(110, 297);
            this.button_Upload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Upload.Name = "button_Upload";
            this.button_Upload.Size = new System.Drawing.Size(76, 23);
            this.button_Upload.TabIndex = 14;
            this.button_Upload.Text = "Upload";
            this.button_Upload.UseVisualStyleBackColor = true;
            // 
            // button_download
            // 
            this.button_download.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_download.Location = new System.Drawing.Point(-1, 297);
            this.button_download.Name = "button_download";
            this.button_download.Size = new System.Drawing.Size(76, 23);
            this.button_download.TabIndex = 13;
            this.button_download.Text = "Download";
            this.button_download.UseVisualStyleBackColor = true;
            // 
            // listBox_filelist
            // 
            this.listBox_filelist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_filelist.FormattingEnabled = true;
            this.listBox_filelist.ItemHeight = 12;
            this.listBox_filelist.Location = new System.Drawing.Point(0, 0);
            this.listBox_filelist.Name = "listBox_filelist";
            this.listBox_filelist.ScrollAlwaysVisible = true;
            this.listBox_filelist.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_filelist.Size = new System.Drawing.Size(185, 292);
            this.listBox_filelist.TabIndex = 12;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBtn,
            this.openBtn,
            this.saveBtn,
            this.printBtn,
            this.toolStripSeparator2,
            this.undoBtn,
            this.redoBtn,
            this.toolStripSeparator3,
            this.WebBtn,
            this.refreshBtn,
            this.toolStripSeparator5,
            this.tbFind,
            this.toolStripLabel1,
            this.settingBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(793, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newBtn
            // 
            this.newBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newBtn.Image = ((System.Drawing.Image)(resources.GetObject("newBtn.Image")));
            this.newBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(23, 22);
            this.newBtn.Text = "New";
            this.newBtn.Click += new System.EventHandler(this.newMenu_Click);
            // 
            // openBtn
            // 
            this.openBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openBtn.Image = ((System.Drawing.Image)(resources.GetObject("openBtn.Image")));
            this.openBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(23, 22);
            this.openBtn.Text = "Open";
            this.openBtn.Click += new System.EventHandler(this.openMenu_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(23, 22);
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveMenu_Click);
            // 
            // printBtn
            // 
            this.printBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printBtn.Image = ((System.Drawing.Image)(resources.GetObject("printBtn.Image")));
            this.printBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(23, 22);
            this.printBtn.Text = "Print";
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // undoBtn
            // 
            this.undoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undoBtn.Image = ((System.Drawing.Image)(resources.GetObject("undoBtn.Image")));
            this.undoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(23, 22);
            this.undoBtn.Text = "Undo";
            this.undoBtn.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoBtn
            // 
            this.redoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redoBtn.Image = ((System.Drawing.Image)(resources.GetObject("redoBtn.Image")));
            this.redoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redoBtn.Name = "redoBtn";
            this.redoBtn.Size = new System.Drawing.Size(23, 22);
            this.redoBtn.Text = "Redo";
            this.redoBtn.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // WebBtn
            // 
            this.WebBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.WebBtn.Image = ((System.Drawing.Image)(resources.GetObject("WebBtn.Image")));
            this.WebBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.WebBtn.Name = "WebBtn";
            this.WebBtn.Size = new System.Drawing.Size(23, 22);
            this.WebBtn.Text = "Web";
            this.WebBtn.Click += new System.EventHandler(this.WebBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtn.Image")));
            this.refreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(23, 22);
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tbFind
            // 
            this.tbFind.AcceptsReturn = true;
            this.tbFind.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(116, 25);
            this.tbFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFind_KeyPress);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel1.Text = "Find: ";
            // 
            // settingBtn
            // 
            this.settingBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.settingBtn.Image = global::codespace.Properties.Resources.setting;
            this.settingBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(23, 22);
            this.settingBtn.Text = "FTP설정";
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 378);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMenu;
        private System.Windows.Forms.ToolStripMenuItem openMenu;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenu;
        private System.Windows.Forms.ToolStripMenuItem saveasMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem lineNumMenu;
        private System.Windows.Forms.CustomTabControl customTabControl1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newBtn;
        private System.Windows.Forms.ToolStripButton openBtn;
        private System.Windows.Forms.ToolStripButton saveBtn;
        private System.Windows.Forms.ToolStripButton printBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton undoBtn;
        private System.Windows.Forms.ToolStripButton redoBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton WebBtn;
        private System.Windows.Forms.ToolStripMenuItem undoMenu;
        private System.Windows.Forms.ToolStripMenuItem redoMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem cutMenu;
        private System.Windows.Forms.ToolStripMenuItem copyMenu;
        private System.Windows.Forms.ToolStripMenuItem pasteMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem allselMenu;
        private System.Windows.Forms.ToolStripButton refreshBtn;
        private System.Windows.Forms.ToolStripMenuItem fontMenu;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button button_Upload;
        private System.Windows.Forms.Button button_download;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton settingBtn;
        private System.Windows.Forms.ToolStripTextBox tbFind;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.ListBox listBox_filelist;
    }
}

