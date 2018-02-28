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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_failure_Click(object sender, EventArgs e)
        {
            FailureForm f = new FailureForm();
            f.ShowDialog();
        }
    }
}
