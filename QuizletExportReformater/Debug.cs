using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizletExportReformater
{
    public partial class Debug : Form
    {
        public static Debug instance;
        public Debug()
        {
            InitializeComponent();
        }

        private void Debug_ClientSizeChanged(object sender, EventArgs e)
        {
            TextB.Size = this.Size;
        }

        public void log(String text)
        {
            TextB.Text += "\n" + text;
        }

        private void Debug_Load(object sender, EventArgs e)
        {
            instance = this;
        }

        private void Debug_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
