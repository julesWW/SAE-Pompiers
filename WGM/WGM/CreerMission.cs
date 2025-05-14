using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pinpon;

namespace WGM
{
    public partial class frmNouvMission : Form
    {
        public frmNouvMission()
        {
            InitializeComponent();
        }
        //--------Variable globale du form---------------------------------
        DataSet ds = MesDatas.DsGlobal;
        string dateSinistre = DateTime.Now.ToString();
        //-----------------------------------------------------------------
        private void btnConsult_Click(object sender, EventArgs e)
        {

            string paramEngin = "enMission = 0 AND enPanne = 0";
            DataTable dtEnginsDispo = ds.Tables["Engin"].Clone();
            foreach (DataRow drE in ds.Tables["Engin"].Select(paramEngin))
            {
                dtEnginsDispo.ImportRow(drE);
            }


            // Création du BindingSource
            BindingSource bs = new BindingSource();
            bs.DataSource = dtEnginsDispo;

            // Liaison à la DataGridView
            dgvEnginsMobil.DataSource = bs;

            // Affichage du groupe
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

        private void frmNouvMission_Load(object sender, EventArgs e)
        {
            lblDate.Text += dateSinistre;

            // Remplissage de la cbo des sinistre
            cboSinistre.Items.Clear();
            foreach (DataRow dr in ds.Tables["NatureSinistre"].Rows)
            {
                cboSinistre.Items.Add(dr[1]);
            }


            // Remplissage de la cbo Caserne
            cboCaserne.Items.Clear();
            foreach (DataRow dr in ds.Tables["Caserne"].Rows)
            {
                cboCaserne.Items.Add(dr[1]);
            }
        }
    }
}
