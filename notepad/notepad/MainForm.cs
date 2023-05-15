using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace notepad
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private bool _isTextChanged;



        private void mi_New_Click(object sender, EventArgs e)
        {
            SaveOrClearOrCancel();

        }

        private void SaveOrClearOrCancel()
        {
            if (_isTextChanged) // 텍스트 박스 내용이 변경되었으면 메세지박스 호출
            {
                DialogResult objDr = MessageBox.Show(
                     "파일내용이 변경되었습니다.\r\n" +
                     "변경된 내용을 저장하시겠습니까 ?", "메모장",
                     MessageBoxButtons.YesNoCancel,  // 버튼 3개 표시
                     MessageBoxIcon.Exclamation);       // 아이콘 표시
                switch (objDr)
                {
                    case DialogResult.Yes:  // Yes클릭하면 - 저장 할 거면
                        SaveText();  // 저장기능 함수 처리 - 호출
                        _isTextChanged = false; // 저장하고 나면 다시 false로 설정
                        break;
                    case DialogResult.No:      // 아니요 버튼 - 저장 안할거면
                        this.txtMemo.ResetText(); // 현재 써진 글 버리고 새글 작성
                        this.Text = "제목없음"; // 제목 다시 설정
                        _isTextChanged = false;  // 다시 설정
                        break;
                    case DialogResult.Cancel:  // 취소버튼이면 그대로 둔다 
                        break;
                }

            }
            else   // 새로만들기 - 텍스트 박스 내용이 변경되지 않았으면
            {
                ClearText();
            }
        }

        private void ClearText()
        {
            this.txtMemo.ResetText(); // 텍스트 박스 리셋 호출
            this.Text = "제목없음"; // 제목 다시 설정 – 아무 입력 없으므로 
            _isTextChanged = false; // 다시 설정
        }

        private void mi_Open_Click(object sender, EventArgs e)
        {
            if (_isTextChanged)
            {
                Save_Clear_Cancel("Open");
            }
            else
            {
                OpenText();
            }
        }

        private void Save_Clear_Cancel(string strFlag) // 매개변수 
        {
            DialogResult objDr = MessageBox.Show(
                "파일의 내용이 변경되었습니다.\r\n" +
                "변경된 내용을 저장하시겠습니까?",
                "메모장",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Exclamation);
            switch (objDr)
            {
                case DialogResult.Yes:    // 저장할거면 – Yes 버튼이면
                    SaveText();   // 텍스트 저장
                    if (strFlag == "New")  // Yes이고 매개변수가 New 일 때 
                        ClearText(); // 텍스트 클리어(리셋)
                    else
                        OpenText(); // 열기
                    break;
                case DialogResult.No:   // 저장 안할거면 - NO 버튼이면
                    if (strFlag == "New") // No이고 매개변수가 New 일  때 
                        ClearText(); // 텍스트 클리어(리셋)
                    else
                        OpenText(); // 열기
                    break;
                case DialogResult.Cancel:   // 취소면 그대로 유지
                    break;
            }
        }

        private void OpenText()
        {
            DialogResult objDr = openFileDialog1.ShowDialog(); //열기 대화상자
            if (objDr != DialogResult.Cancel)  // ShowDialog() 취소버튼이 아니라면
            {
                string strFileName = openFileDialog1.FileName;
                // 열기 대화상자에서 입력한 파일명 으로 객체 생성
                StreamReader objSr = new StreamReader(strFileName);
                // 해당 파일에서 처음부터 끝까지 Read
                this.txtMemo.Text = objSr.ReadToEnd();   // 읽어서 텍스트 박스에 붙임
                objSr.Close();
                _isTextChanged = false;   // 변경여부를 다시 초기화
                this.Text = strFileName;  // 제목에 파일명 출력
            }
        }



        private void mi_Save_Click(object sender, EventArgs e)
        {
            SaveText();
        }

        private void mi_Exit_Click(object sender, EventArgs e)
        {// 종료
            if (_isTextChanged)
            {
                DialogResult objDr = MessageBox.Show(
                    this.Text + " " +
                    "파일의 내용이 변경되었습니다.\r\n" +
                    "변경된 내용을 저장하시겠습니까?", "메모장",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Exclamation);


                switch (objDr)
                {
                    case DialogResult.Yes:
                        SaveText(); // 텍스트 저장
                        this.Close(); // 종료
                        break;
                    case DialogResult.No:
                        this.Close(); // 종료
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
            else
            {
                this.Close(); // Application.Exit();
            }
        }



        private void mi_Cut_Click(object sender, EventArgs e)
        {// 잘라내기
            txtMemo.Cut();
        }

        private void mi_Copy_Click(object sender, EventArgs e)
        {//복사
            txtMemo.Copy();
        }

        private void mi_Paste_Click(object sender, EventArgs e)
        {//붙어 놓기
            txtMemo.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {//뒤로가기(되돌기기)
            txtMemo.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {//앞으로 가기
            txtMemo.Redo();
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {//폰트 설정
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {             // DialogResult가 Cancel  이 아니면
                txtMemo.Font = fontDialog1.Font;  // 글자 크기, 글자 체 
            }

        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {//배경색 설정
            ColorDialog cr = new ColorDialog();
            if (cr.ShowDialog() == DialogResult.OK)
            {
                txtMemo.BackColor = cr.Color;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        { // 도움말 의 정보 메시지 박스 설정
            MessageBox.Show("Made by 인천대학교 컴퓨터공학부 201602391 박현우");
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SaveFile(string strFileName)  // 저장하는 메소드 기능
        {
            StreamWriter objSw = new StreamWriter(strFileName);
            objSw.Write(this.txtMemo.Text);
            objSw.Flush();  // 스트림의 내용 비움
            objSw.Close();

            _isTextChanged = false;  // 저장하고 나서 다시 false로 설정 
            this.Text = strFileName;
        }




        private void SaveText()
        {
            if (this.Text == "제목없음")  // 한번도 저장되지 않은 문서라면
            {
                DialogResult objDr = saveFileDialog1.ShowDialog();
                if (objDr != DialogResult.Cancel)// 예 버튼 클릭하면 -저장할거면
                {
                    string strFileName = saveFileDialog1.FileName;  // 대화상자에서 입력한 파일명
                    SaveFile(strFileName); // 저장기능 메소드호출-매개변수는 파일명
                }
            }
            else  // 한번이라도 저장된 문서라면
            {
                string strFileName = this.Text; // 파일 전체 이름
                SaveFile(strFileName); // 저장기능 메소드호출-매개변수는 파일명
            }
        }


        private void txtMemo_TextChanged(object sender, EventArgs e)
        {
            _isTextChanged = true;

            mi_Undo.Enabled = true;
            mi_Cut.Enabled = true;
            mi_Copy.Enabled = true;
            mi_Delete.Enabled = true;
            mi_Find.Enabled = true;
            
        }

        private void mi_Undo_Click(object sender, EventArgs e)
        {
            if (this.txtMemo.CanUndo)
            {
                this.txtMemo.Undo();
            }
        }

        private void mi_Delete_Click(object sender, EventArgs e)
        {
            this.txtMemo.SelectedText = String.Empty;
        }

        private void mi_Find_Click(object sender, EventArgs e)
        {
            FrmFind f = new FrmFind(this);
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.openFileDialog1.ShowDialog();
        }

        private void mi_SaveAs_Click(object sender, EventArgs e)
        {
            // 텍스트 내용이 변경되든 아니든 무조건 저장하기 창 띄워 줌
            DialogResult objDr = saveFileDialog1.ShowDialog();
            if (objDr != DialogResult.Cancel)  // 취소 버튼이 아니면
            {
                string strFileName = saveFileDialog1.FileName;  // 대화상자에서 입력한  이름
                SaveFile(strFileName); // 파일이름 매개변수로 저장하기 호출
            }

        }

        private void mi_PageSetup_Click(object sender, EventArgs e)
        {
            //[1] PrintDocument.DocumentName = 문서 지정
            printDocument1.DocumentName = txtMemo.Text;
            //[2] PageSetupDialog.Document = PrintDocument
            pageSetupDialog1.Document = this.printDocument1;
            //[3] 페이지 설정 창 띄우기
            pageSetupDialog1.ShowDialog();
        }

        private void mi_Print_Click(object sender, EventArgs e)
        {
            printDocument1.DocumentName = txtMemo.Text;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDocument1.Print();
                }
                catch
                {
                    MessageBox.Show("인쇄하는 도중에 에러가 발생했습니다.",
                        "인쇄 오류", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringReader objSr = new StringReader(this.txtMemo.Text);

            // 현재 문서의 글꼴과 사이즈
            Font printFont = new Font(txtMemo.Font.Name, txtMemo.Font.Size);
            float linesPerPage = 0; // 페이지의 라인 수
            float yPos = 0; // 페이지 상단에서 떨어진 위치(문자열 출력)
            int count = 0; // 페이지 줄 번호

            float leftMargin = e.MarginBounds.Left; // 왼쪽 여백
            float topMargin = e.MarginBounds.Top; // 오른쪽 여백

            string line = null; // 각 행의 데이터 저장
            linesPerPage = // 페이지 당 라인 수 계산
                e.MarginBounds.Height / printFont.GetHeight(e.Graphics);
            while (count < linesPerPage && ((line = objSr.ReadLine()) != null))
            {
                yPos = topMargin + (count * printFont.GetHeight(e.Graphics));
                e.Graphics.DrawString(line, printFont, Brushes.Black,
                    leftMargin, yPos, new StringFormat());
                count++;
            }
            if (line != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            objSr.Close();
        }

        private void mi_FindNext_Click(object sender, EventArgs e)
        {
            mi_Find_Click(null, null);
        }

        private void mi_SelectAll_Click(object sender, EventArgs e)
        {
            this.txtMemo.SelectAll();
        }

        private void mi_WordWrap_Click(object sender, EventArgs e)
        {
            // WordWrap 은  bool 값 
            // 참이면 거짓으로, 거짓이면 참으로 변환
            this.txtMemo.WordWrap = !(this.txtMemo.WordWrap);  //토글 기능
            this.mi_WordWrap.Checked = !(this.mi_WordWrap.Checked);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tssTime.Text = String.Format("{0}시 {1}분 {2}초"
                , DateTime.Now.Hour, DateTime.Now.Minute
                , DateTime.Now.Second);

        }

        private void mi_Status_Click(object sender, EventArgs e)
        {
            if (mi_Status.Checked == false) // 토글 기능
            {
                this.statusStrip1.Visible = false;  // 보여져 있으면 안보이게
                this.mi_Status.Checked = false;
            }
            else   // 안보이면 보이게 해 주고
            {
                
                this.statusStrip1.Visible = true;
                this.mi_Status.Checked = true;
                
                int intLine = DotNetNote.Library.GetLineAndColumn(txtMemo).Line;
                int intColumn = DotNetNote.Library.GetLineAndColumn(txtMemo).Column;

                string strMsg = String.Format(
                      "Line {0}, Col {1}", intLine, intColumn);

                this.toolStripStatusLabel3.Text = strMsg;
                
            }
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txtMemo_KeyUp(object sender, KeyEventArgs e)
        {
            int intLine = DotNetNote.Library.GetLineAndColumn(txtMemo).Line;
            int intColumn = DotNetNote.Library.GetLineAndColumn(txtMemo).Column;
            string strMsg = String.Format(
                        "Line {0}, Col {1}", intLine, intColumn);
            this.toolStripStatusLabel3.Text = strMsg;
        }
    }
    
}
