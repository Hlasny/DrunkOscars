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
    public partial class FailureForm : Form
    {
        private int index;
        public List<string> jmena = new List<string>() { "Maxim", "Dominik", "Nekdo" };

        public FailureForm()
        {
            InitializeComponent();
            label2.Text = jmena[index];
        }

        private void names_timer_Tick(object sender, EventArgs e)
        {
            if (index < jmena.Count)
            {
                label2.Text = jmena[index++];
            }
            else
            {
                names_timer.Enabled = false;
                SummaryForm f = new SummaryForm(jmena);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    this.Close();
                }
            }

        }
    }
}
