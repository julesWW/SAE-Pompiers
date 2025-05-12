using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WGM
{
    public partial class frmNouvMission : Form
    {
        public frmNouvMission()
        {
            InitializeComponent();
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            grpMobilisation.Visible = true;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
