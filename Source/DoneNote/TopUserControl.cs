using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        /// <summary>
        /// [時分]ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timeButton_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            ((Form1)ParentForm).TextBoxText += string.Format("{0}{1:D2}:{2:D2}{3}",Environment.NewLine, dt.Hour, dt.Minute, Environment.NewLine);
        }

        /// <summary>
        /// [年月日]ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateButton_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            ((Form1)ParentForm).TextBoxText += string.Format("{0}{1:D4}-{2:D2}-{3:D2}{4}", Environment.NewLine, dt.Year, dt.Month, dt.Day, Environment.NewLine);
        }
    }
}
