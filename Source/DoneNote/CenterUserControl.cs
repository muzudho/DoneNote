using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoneNote
{
    public partial class CenterUserControl : UserControl
    {
        public CenterUserControl()
        {
            InitializeComponent();
        }

        #region テキストボックス
        public string TextBoxText
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        /// <summary>
        /// 出典:「TextBox（またはRichTextBox）の現在のカレット位置（行と列）を取得する」http://dobon.net/vb/dotnet/control/tbgetcaretposition.html
        /// </summary>
        public int CaretPosition
        {
            get
            {
                return textBox1.SelectionStart;
            }
            set
            {
                textBox1.SelectionStart = value;
            }
        }

        public void FocusTextBox()
        {
            textBox1.Focus();
        }
        #endregion

        /// <summary>
        /// テキストを編集した場合
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ((Form1)ParentForm).Editing = true;
        }
    }
}
