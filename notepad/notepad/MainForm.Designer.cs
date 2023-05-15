namespace notepad
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtMemo = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_New = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_PageSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_Find = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_FindNext = new System.Windows.Forms.ToolStripMenuItem();
            this.바꾸기RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_WordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보기VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Status = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMemo
            // 
            this.txtMemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMemo.Location = new System.Drawing.Point(0, 24);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(649, 385);
            this.txtMemo.TabIndex = 0;
            this.txtMemo.Text = "";
            this.txtMemo.TextChanged += new System.EventHandler(this.txtMemo_TextChanged);
            this.txtMemo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMemo_KeyUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.editToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.보기VToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_New,
            this.mi_Open,
            this.mi_Save,
            this.mi_SaveAs,
            this.toolStripMenuItem3,
            this.mi_PageSetup,
            this.mi_Print,
            this.toolStripMenuItem4,
            this.mi_Exit});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.filesToolStripMenuItem.Text = "파일(F)";
            // 
            // mi_New
            // 
            this.mi_New.Name = "mi_New";
            this.mi_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mi_New.Size = new System.Drawing.Size(198, 22);
            this.mi_New.Text = "새로 만들기(&N)";
            this.mi_New.Click += new System.EventHandler(this.mi_New_Click);
            // 
            // mi_Open
            // 
            this.mi_Open.Name = "mi_Open";
            this.mi_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mi_Open.Size = new System.Drawing.Size(198, 22);
            this.mi_Open.Text = "열기(&O)";
            this.mi_Open.Click += new System.EventHandler(this.mi_Open_Click);
            // 
            // mi_Save
            // 
            this.mi_Save.Name = "mi_Save";
            this.mi_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mi_Save.Size = new System.Drawing.Size(198, 22);
            this.mi_Save.Text = "저장(&S)";
            this.mi_Save.Click += new System.EventHandler(this.mi_Save_Click);
            // 
            // mi_SaveAs
            // 
            this.mi_SaveAs.Name = "mi_SaveAs";
            this.mi_SaveAs.Size = new System.Drawing.Size(198, 22);
            this.mi_SaveAs.Text = "다른 이름으로 저장(&A)";
            this.mi_SaveAs.Click += new System.EventHandler(this.mi_SaveAs_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(195, 6);
            // 
            // mi_PageSetup
            // 
            this.mi_PageSetup.Name = "mi_PageSetup";
            this.mi_PageSetup.Size = new System.Drawing.Size(198, 22);
            this.mi_PageSetup.Text = "페이지 설정(&U)";
            this.mi_PageSetup.Click += new System.EventHandler(this.mi_PageSetup_Click);
            // 
            // mi_Print
            // 
            this.mi_Print.Name = "mi_Print";
            this.mi_Print.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mi_Print.Size = new System.Drawing.Size(198, 22);
            this.mi_Print.Text = "인쇄(&P)";
            this.mi_Print.Click += new System.EventHandler(this.mi_Print_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(195, 6);
            // 
            // mi_Exit
            // 
            this.mi_Exit.Name = "mi_Exit";
            this.mi_Exit.Size = new System.Drawing.Size(198, 22);
            this.mi_Exit.Text = "끝내기(&X)";
            this.mi_Exit.Click += new System.EventHandler(this.mi_Exit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_Undo,
            this.toolStripMenuItem1,
            this.mi_Cut,
            this.mi_Copy,
            this.mi_Paste,
            this.mi_Delete,
            this.toolStripMenuItem2,
            this.mi_Find,
            this.mi_FindNext,
            this.바꾸기RToolStripMenuItem,
            this.toolStripMenuItem5,
            this.mi_SelectAll});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.editToolStripMenuItem.Text = "편집(E)";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // mi_Undo
            // 
            this.mi_Undo.Enabled = false;
            this.mi_Undo.Name = "mi_Undo";
            this.mi_Undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mi_Undo.Size = new System.Drawing.Size(184, 22);
            this.mi_Undo.Text = "실행취소(&U)";
            this.mi_Undo.Click += new System.EventHandler(this.mi_Undo_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 6);
            // 
            // mi_Cut
            // 
            this.mi_Cut.Enabled = false;
            this.mi_Cut.Name = "mi_Cut";
            this.mi_Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mi_Cut.Size = new System.Drawing.Size(184, 22);
            this.mi_Cut.Text = "잘라내기(&T)";
            this.mi_Cut.Click += new System.EventHandler(this.mi_Cut_Click);
            // 
            // mi_Copy
            // 
            this.mi_Copy.Name = "mi_Copy";
            this.mi_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mi_Copy.Size = new System.Drawing.Size(184, 22);
            this.mi_Copy.Text = "복사(&C)";
            this.mi_Copy.Visible = false;
            this.mi_Copy.Click += new System.EventHandler(this.mi_Copy_Click);
            // 
            // mi_Paste
            // 
            this.mi_Paste.Name = "mi_Paste";
            this.mi_Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mi_Paste.Size = new System.Drawing.Size(184, 22);
            this.mi_Paste.Text = "붙어넣기(&P)";
            this.mi_Paste.Click += new System.EventHandler(this.mi_Paste_Click);
            // 
            // mi_Delete
            // 
            this.mi_Delete.Enabled = false;
            this.mi_Delete.Name = "mi_Delete";
            this.mi_Delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.mi_Delete.Size = new System.Drawing.Size(184, 22);
            this.mi_Delete.Text = "삭제(&L)";
            this.mi_Delete.Click += new System.EventHandler(this.mi_Delete_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(181, 6);
            // 
            // mi_Find
            // 
            this.mi_Find.Enabled = false;
            this.mi_Find.Name = "mi_Find";
            this.mi_Find.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mi_Find.Size = new System.Drawing.Size(184, 22);
            this.mi_Find.Text = "찾기(&F)";
            this.mi_Find.Click += new System.EventHandler(this.mi_Find_Click);
            // 
            // mi_FindNext
            // 
            this.mi_FindNext.Enabled = false;
            this.mi_FindNext.Name = "mi_FindNext";
            this.mi_FindNext.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mi_FindNext.Size = new System.Drawing.Size(184, 22);
            this.mi_FindNext.Text = "다음찾기(&N)";
            this.mi_FindNext.Click += new System.EventHandler(this.mi_FindNext_Click);
            // 
            // 바꾸기RToolStripMenuItem
            // 
            this.바꾸기RToolStripMenuItem.Name = "바꾸기RToolStripMenuItem";
            this.바꾸기RToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.바꾸기RToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.바꾸기RToolStripMenuItem.Text = "바꾸기(&R)";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(181, 6);
            // 
            // mi_SelectAll
            // 
            this.mi_SelectAll.Name = "mi_SelectAll";
            this.mi_SelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mi_SelectAll.Size = new System.Drawing.Size(184, 22);
            this.mi_SelectAll.Text = "모두 선택(&A)";
            this.mi_SelectAll.Click += new System.EventHandler(this.mi_SelectAll_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_WordWrap,
            this.fontToolStripMenuItem1,
            this.backgroundColorToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.fontToolStripMenuItem.Text = "서식(O)";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // mi_WordWrap
            // 
            this.mi_WordWrap.Checked = true;
            this.mi_WordWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mi_WordWrap.Name = "mi_WordWrap";
            this.mi_WordWrap.Size = new System.Drawing.Size(153, 22);
            this.mi_WordWrap.Text = "자동줄바꿈(&W)";
            this.mi_WordWrap.Click += new System.EventHandler(this.mi_WordWrap_Click);
            // 
            // fontToolStripMenuItem1
            // 
            this.fontToolStripMenuItem1.Name = "fontToolStripMenuItem1";
            this.fontToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.fontToolStripMenuItem1.Text = "글꼴(&F)";
            this.fontToolStripMenuItem1.Click += new System.EventHandler(this.fontToolStripMenuItem1_Click);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.backgroundColorToolStripMenuItem.Text = "배경색 변경";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // 보기VToolStripMenuItem
            // 
            this.보기VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_Status});
            this.보기VToolStripMenuItem.Name = "보기VToolStripMenuItem";
            this.보기VToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.보기VToolStripMenuItem.Text = "보기(&V)";
            // 
            // mi_Status
            // 
            this.mi_Status.Checked = true;
            this.mi_Status.CheckOnClick = true;
            this.mi_Status.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mi_Status.Name = "mi_Status";
            this.mi_Status.Size = new System.Drawing.Size(149, 22);
            this.mi_Status.Text = "상태표시줄(&S)";
            this.mi_Status.Click += new System.EventHandler(this.mi_Status_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.helpToolStripMenuItem.Text = "도움말(H)";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.aboutToolStripMenuItem.Text = "정보";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "*.txt";
            this.openFileDialog1.Filter = "텍스트문서(*.txt)|*.txt|모든파일(*.*)|*.*";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowColor = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.tssTime,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 387);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(649, 22);
            this.statusStrip1.TabIndex = 2;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(134, 17);
            this.toolStripStatusLabel1.Text = "made by:ParkHyunWoo";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(196, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(76, 17);
            this.toolStripStatusLabel3.Text = "Line 1, Col 1";
            this.toolStripStatusLabel3.Click += new System.EventHandler(this.toolStripStatusLabel3_Click);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(196, 17);
            this.toolStripStatusLabel4.Spring = true;
            // 
            // tssTime
            // 
            this.tssTime.Name = "tssTime";
            this.tssTime.Size = new System.Drawing.Size(31, 17);
            this.tssTime.Text = "시계";
            this.tssTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 409);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "제목없음";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_New;
        private System.Windows.Forms.ToolStripMenuItem mi_Open;
        private System.Windows.Forms.ToolStripMenuItem mi_Save;
        private System.Windows.Forms.ToolStripMenuItem mi_Exit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_Cut;
        private System.Windows.Forms.ToolStripMenuItem mi_Copy;
        private System.Windows.Forms.ToolStripMenuItem mi_Paste;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_Undo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mi_Delete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mi_Find;
        private System.Windows.Forms.ToolStripMenuItem mi_SaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mi_PageSetup;
        private System.Windows.Forms.ToolStripMenuItem mi_Print;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem mi_FindNext;
        private System.Windows.Forms.ToolStripMenuItem 바꾸기RToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem mi_SelectAll;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        public System.Windows.Forms.RichTextBox txtMemo;
        private System.Windows.Forms.ToolStripMenuItem mi_WordWrap;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel tssTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 보기VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_Status;
    }
}

