using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad
{
    public partial class FrmReplace : Form
    {
        private MainForm dnn = null;

        public FrmReplace()
        {
            InitializeComponent();
        }

        public FrmReplace(MainForm objMainForm)
        {
            dnn = objMainForm;
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!FindText())
            {
                MessageBox.Show(
                    this.txtFind.Text + "을(를) 찾을수없습니다.",
                    "메모장",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        // 찾기전용메서드: 찾지못하면false
        private bool FindText()
        {
            int nFind;
            int nLen;
            string strTempText;
            string strTempFind;
            if (chkCase.Checked) // 대/소문자구분
            {
                strTempText = dnn.txtMemo.Text; // 찾을대상
                strTempFind = txtFind.Text; // 찾을단어
            }
            else
            {
                strTempText = dnn.txtMemo.Text.ToLower(); // 소문자
                strTempFind = txtFind.Text.ToLower(); // 소문자
            }
            nLen = txtFind.Text.Length; // 텍스트길이
            // 위로/ 아래로검색
            if (rdoUp.Checked)
            {
                if (dnn.txtMemo.SelectionStart -
                    dnn.txtMemo.SelectionLength < 0)
                {
                    nFind = -1;
                }
                else
                {
                    nFind = strTempText.LastIndexOf(strTempFind,
                        dnn.txtMemo.SelectionStart -
                        dnn.txtMemo.SelectionLength);
                }
            }
            else   // 아래로
            {
                nFind = strTempText.IndexOf(strTempFind,
                    dnn.txtMemo.SelectionStart +
                    dnn.txtMemo.SelectionLength);
            }
            if (nFind == -1)  // 비교
            { return false; }
            else
            {
                dnn.txtMemo.SelectionStart = nFind;
                dnn.txtMemo.SelectionLength = nLen;
                dnn.txtMemo.Focus();
                return true;
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (!FindText())  // 텍스트가 발견되지 않으면 - false 면
            {
                MessageBox.Show(this.txtFind.Text + "을(를) 찾을수없습니다.",
                    "메모장", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                // 텍스트변경
                dnn.txtMemo.SelectedText = this.txtReplace.Text;
                // 효과
                dnn.txtMemo.SelectionStart = dnn.txtMemo.SelectionStart -
                        txtReplace.Text.Length;
                dnn.txtMemo.SelectionLength = txtReplace.Text.Length;
            }

        }

        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            while (FindText()) // while문으로 전부 바꾸기
            {
                dnn.txtMemo.SelectedText = this.txtReplace.Text;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            this.btnFind.Enabled = true;
            this.btnReplace.Enabled = true;
            this.btnReplaceAll.Enabled = true;
        }
    }
}
