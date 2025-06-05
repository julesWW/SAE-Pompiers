using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pinpon;

namespace Personnel
{
    public partial class frmIdentification : Form
    {
        public frmIdentification()
        {
            InitializeComponent();
        }

        private void btnVoir_MouseDown(object sender, MouseEventArgs e)
        {
            btnVoir.Text = "🗨️";
            txtMdp.UseSystemPasswordChar = false;
        }

        private void btnVoir_MouseUp(object sender, MouseEventArgs e)
        {
            btnVoir.Text = "👁️";
            txtMdp.UseSystemPasswordChar = true;
            txtMdp.Focus();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            foreach (DataRow r in MesDatas.DsGlobal.Tables["Admin"].Rows)
            {
                if (r["login"].ToString() == txtIdentifiant.Text)
                {
                    if(r["mdp"].ToString() == txtMdp.Text)
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            SystemSounds.Beep.Play();
            txtMdp.Text = "";
            lblError.Visible = true;
        }

        private void frmIdentification_Load(object sender, EventArgs e)
        {
        }

        private void txtMdp_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtMdp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnConnect_Click (sender, e);
            }
        }

        private void txtIdentifiant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnConnect_Click(sender, e);
            }
        }

        private void txtIdentifiant_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }
    }
}
