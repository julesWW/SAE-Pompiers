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

            int idNatureSinistre = int.Parse(cboCaserne.SelectedValue.ToString());

            List<string> codesTypeEngin = new List<string>();

            foreach(DataRow dr in ds.Tables["Necessiter"].Select("idNatureSinistre = " + idNatureSinistre.ToString()))
            {
                codesTypeEngin.Add(dr["codeTypeEngin"].ToString());
            }

            string paramEngin = "enMission = 0 AND enPanne = 0 AND idCaserne = " + cboCaserne.SelectedValue.ToString() + " AND codeTypeEngin IN " + codesTypeEngin;
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

        private void btnFermer_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void frmNouvMission_Load(object sender, EventArgs e)
        {
            lblDate.Text += dateSinistre;

            // Remplissage de la cbo des sinistre
            cboSinistre.Items.Clear();

            //Défini la sources des valeurs a remplir
            cboSinistre.DataSource = ds.Tables["NatureSinistre"]; 
            //Défini le texte
            cboSinistre.DisplayMember = ds.Tables["NatureSinistre"].Columns[1].ColumnName; 
            //Défini la valeurs associer
            cboSinistre.ValueMember = ds.Tables["NatureSinistre"].Columns[0].ColumnName;


            // Remplissage de la cbo Caserne
            cboCaserne.Items.Clear();

            cboCaserne.DataSource = ds.Tables["Caserne"];
            cboCaserne.DisplayMember = ds.Tables["Caserne"].Columns[1].ColumnName;
            cboCaserne.ValueMember = ds.Tables["Caserne"].Columns[0].ColumnName;
            
        }

        
    }
}
