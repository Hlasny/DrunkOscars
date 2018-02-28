using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrunkOscars
{
    public partial class SummaryForm : Form
    {
        public SummaryForm(List<string> jmena)
        {
            InitializeComponent();
            foreach (var item in jmena)
            {
                richTextBox1.Text += item + "\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
