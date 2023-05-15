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
    public partial class FrmFind : Form
    {
        public FrmFind()
        {
            InitializeComponent();
        }

        private void FrmFind_Load(object sender, EventArgs e)
        {

        }

        private MainForm dnn;

        public FrmFind(MainForm objMainForm)
        {
            dnn = objMainForm;
            InitializeComponent();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            this.btnFind.Enabled = true;
        }

        
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!FindText())  // 찾지 못했다면  bool 값 리턴
            {
                MessageBox.Show(
                  this.txtFind.Text + "을(를) 찾을수없습니다.", "메모장",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private bool FindText()  // bool 타입의메소드
        {
            MainForm dnn2 = new MainForm();
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
            if (rdoUp.Checked)
            {
                if (dnn.txtMemo.SelectionStart - dnn.txtMemo.SelectionLength < 0)
                {
                    nFind = -1;
                }
                else
                {
                    nFind = strTempText.LastIndexOf(strTempFind,
                        dnn.txtMemo.SelectionStart - dnn.txtMemo.SelectionLength);
                }
            }
            else // 아래로
            {
                nFind = strTempText.IndexOf(strTempFind,
                    dnn.txtMemo.SelectionStart + dnn.txtMemo.SelectionLength);
            }
            if (nFind == -1)
            {
                return false;
            }
            else
            {
                dnn.txtMemo.SelectionStart = nFind;
                dnn.txtMemo.SelectionLength = nLen;
                dnn.txtMemo.Focus();
                return true;
            }
            
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

