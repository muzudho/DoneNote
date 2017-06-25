using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Text;

namespace DoneNote
{
    public partial class TopUserControl : UserControl
    {
        public TopUserControl()
        {
            InitializeComponent();
        }

        public void SyncEditing(bool value)
        {
            if (value)
            {
                saveButton.BackColor = Color.LightGreen;
            }
            else
            {
                saveButton.BackColor = Color.LightGray;
            }
        }

        /// <summary>
        /// テキストを既定のファイルに保存します。
        /// </summary>
        public void Save()
        {
            File.WriteAllText(Form1.TEXT_FILE, ((Form1)ParentForm).TextBoxText);
            ((Form1)ParentForm).Editing = false;
        }

        /// <summary>
        /// [保存]ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        static string Insert(string text, int index, string appends)
        {
            string pre = text.Substring(0, index);
            string epi = text.Substring(index);

            StringBuilder sb = new StringBuilder();
            sb.Append(pre);
            sb.Append(appends);
            sb.Append(epi);
            return sb.ToString();
        }

        /// <summary>
        /// [時分]ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timeButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)ParentForm;
            int oldCaret = form1.CaretPosition;

            // 書き足す文字
            DateTime dt = DateTime.Now;
            string appends = string.Format("{0}{1:D2}:{2:D2}{3}", Environment.NewLine, dt.Hour, dt.Minute, Environment.NewLine);
            // 挿入
            form1.TextBoxText = Insert(form1.TextBoxText, oldCaret, appends);

            // 2つずれてたので足した
            form1.CaretPosition = oldCaret + appends.Length + 2;
            form1.FocusTextBox();
        }

        /// <summary>
        /// [年月日]ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)ParentForm;
            int oldCaret = form1.CaretPosition;

            // 書き足す文字
            DateTime dt = DateTime.Now;
            string appends = string.Format("{0}{1:D4}-{2:D2}-{3:D2}{4}", Environment.NewLine, dt.Year, dt.Month, dt.Day, Environment.NewLine);

            // 挿入
            form1.TextBoxText = Insert(form1.TextBoxText, oldCaret, appends);

            // 2つずれてたので足した
            form1.CaretPosition = oldCaret + appends.Length + 2;
            form1.FocusTextBox();
        }
    }
}
