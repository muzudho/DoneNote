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

        /// <summary>
        /// [保存]ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Form1.TEXT_FILE, ((Form1)ParentForm).TextBoxText);
        }
    }
}
