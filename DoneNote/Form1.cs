using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DoneNote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public const string TEXT_FILE = "DoneNote.txt";

        private void Form1_Load(object sender, EventArgs e)
        {
            // ファイル読み込み
            if (File.Exists(TEXT_FILE))
            {
                CenterUserControl centerUserControl1 = (CenterUserControl)centerPanel.Controls["centerUserControl1"];
                centerUserControl1.TextBoxText = File.ReadAllText(TEXT_FILE);
            }
        }

        public string TextBoxText
        {
            get
            {
                return ((CenterUserControl)centerPanel.Controls["centerUserControl1"]).TextBoxText;
            }
            set
            {
                ((CenterUserControl)centerPanel.Controls["centerUserControl1"]).TextBoxText = value;
            }
        }
    }
}
