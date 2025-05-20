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
            int idNatureSinistre = int.Parse(cboSinistre.SelectedValue.ToString());

            DataSet dsTemp = new DataSet();
            dsTemp.Tables.Clear();
            dsTemp.Tables.Add("besoinVehicule");
            dsTemp.Tables["besoinVehicule"].Columns.Add("codeTypeEngin");
            dsTemp.Tables["besoinVehicule"].Columns.Add("nombre");

            //string codesTypeEngin = "";

            foreach(DataRow dr in ds.Tables["Necessiter"].Select("idNatureSinistre = " + idNatureSinistre.ToString()))
            {
                DataRow newRow = dsTemp.Tables["besoinVehicule"].NewRow();
                newRow["codeTypeEngin"] = dr["codeTypeEngin"];
                newRow["nombre"] = dr["nombre"];
                dsTemp.Tables["besoinVehicule"].Rows.Add(newRow);
            }

            //if(codesTypeEngin.EndsWith(",")) codesTypeEngin = codesTypeEngin.Substring(0,codesTypeEngin.Length - 1);

            dsTemp.Tables.Add("vehiculePossible");
            dsTemp.Tables["vehiculePossible"].Columns.Add("typeEngin");
            dsTemp.Tables["vehiculePossible"].Columns.Add("numero");

            string codeOccu = "";
            int nbOcc = 0;

            foreach (DataRow dr2 in dsTemp.Tables["besoinVehicule"].Rows)
            {
                string paramEngin = "enMission = 0 AND enPanne = 0 AND idCaserne = " + cboCaserne.SelectedValue.ToString() + " AND codeTypeEngin = '" + dr2[0] + "'";
                DataRow[] engins = ds.Tables["Engin"].Select(paramEngin);

                foreach (DataRow engin in engins)
                {
                    if(codeOccu != engin["codeTypeEngin"].ToString())
                    {
                        codeOccu = engin["codeTypeEngin"].ToString();
                        nbOcc = Convert.ToInt32(dr2["nombre"]) - 1;
                        //Ajout du vehicule
                        DataRow nRow = dsTemp.Tables["vehiculePossible"].NewRow();
                        nRow["typeEngin"] = engin["codeTypeEngin"];
                        nRow["numero"] = engin["numero"];
                        dsTemp.Tables["vehiculePossible"].Rows.Add(nRow);
                    }
                    else if(codeOccu == engin["codeTypeEngin"].ToString() && nbOcc > 0)
                    {
                        DataRow nRow = dsTemp.Tables["vehiculePossible"].NewRow();
                        nRow["typeEngin"] = engin["codeTypeEngin"];
                        nRow["numero"] = engin["numero"];
                        dsTemp.Tables["vehiculePossible"].Rows.Add(nRow);
                        nbOcc -= 1;
                    }

                }
            }



            /*
            //Creation d'une datatable pour les engins
            DataTable dtEnginsDispo = new DataTable();
            dtEnginsDispo.Columns.Add("codeTypeEngin", typeof(string));
            dtEnginsDispo.Columns.Add("numero", typeof(string));
            dsTemp.Tables.Add(dtEnginsDispo);
       
            //Remplissage de la table personnalisée
            foreach (DataRow drE in ds.Tables["Engin"].Select(paramEngin))
            {
                DataRow nR = dtEnginsDispo.NewRow();
                nR["codeTypeEngin"] = drE["codeTypeEngin"];
                nR["numero"] = drE["numero"];
                dtEnginsDispo.Rows.Add(nR);
            }
            */

            //Création du BindingSource
            BindingSource bs = new BindingSource();
            bs.DataSource = dsTemp.Tables["vehiculePossible"];

            //Liaison à la DataGridView
            dgvEnginsMobil.DataSource = bs;

            //Affichage du groupe
            grpMobilisation.Visible = true;

            btnValider.Enabled = true;
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

            //Remplissage de la cbo des sinistre
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

        private void cboSinistre_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnValider.Enabled = false;
        }
    }
}
