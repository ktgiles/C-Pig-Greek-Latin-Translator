using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giles_Lab6
{
    public partial class FrmTranslator : Form
    {
        PigLatinTranslator plt;
        PigGreekTranslator pgt;
        public FrmTranslator()
        {
            InitializeComponent();
            plt = new PigLatinTranslator();
            pgt = new PigGreekTranslator();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            if (rbLatin.Checked)
            {
                tbOutput.Text = plt.translate(tbInput.Text);
            }
            else if (rbGreek.Checked)
            {
                tbOutput.Text = pgt.translate(tbInput.Text);
            }
            else
            {
                tbOutput.Text = "Please choose either Pig Latin or Pig Greek";
                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbOutput.Text = "";
            tbInput.Text = "";

        }

        private void rbLatin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLatin.Checked)
            {
                tbOutput.Text = "";
                lblTranslation.Text = "Pig Latin Translation:";
            }
        }

        private void rbGreek_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGreek.Checked)
            {
                tbOutput.Text = "";
                lblTranslation.Text = "Pig Greek Translation:";
            }
        }
    }
}
