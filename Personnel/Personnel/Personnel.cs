using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pinpon;

namespace Personnel
{
    public partial class uscPersonnel: UserControl
    {

        SQLiteConnection connec;
        BindingSource bsCaserne = new BindingSource();
        public uscPersonnel()
        {
            InitializeComponent();
            connec = Connexion.Connec;

            DataTable dt = connec.GetSchema("Tables");
            //  string liste = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string nomTable = dt.Rows[i][2].ToString();
                string req = "select * from " + nomTable;
                SQLiteCommand cmd = new SQLiteCommand(req, connec);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(MesDatas.DsGlobal, nomTable);
                //  liste = liste + nomTable + "\n";
            }
            //  MessageBox.Show(liste);
            Connexion.FermerConnexion();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            frmIdentification ID = new frmIdentification();
            if (ID.ShowDialog() == DialogResult.OK)
            {
                grpPlus.Visible = true;
                btnPlus.Visible = false;
            }
        }

        private void btnMoins_Click(object sender, EventArgs e)
        {
            grpPlus.Visible = false;
            btnPlus.Visible=true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmIdentification ID = new frmIdentification();
            if (ID.ShowDialog() == DialogResult.OK)
            {
                btnEdit.Visible = false;
                btnValide.Visible = true;
                btnAnnule.Visible = true;
                cboGrade.Visible = true;
                txtTelephone.Visible = true;
                txtBip.Visible = true;
            }
        }

        private void btnValide_Click(object sender, EventArgs e)
        {
            txtGrade.Text = cboGrade.SelectedValue.ToString();
            lblTelephone.Text = "Téléphone : " + txtTelephone.Text;
            lblBip.Text = "Bip : " + txtBip.Text;
            //changer dans MesDatas ... maybe ?


            btnEdit.Visible = true;
            btnValide.Visible = false;
            btnAnnule.Visible = false;
            cboGrade.Visible = false;
            txtTelephone.Visible = false;
            txtBip.Visible = false;
        }

        private void btnAnnule_Click(object sender, EventArgs e)
        {
            btnEdit.Visible = true;
            btnValide.Visible = false;
            btnAnnule.Visible = false;
            cboGrade.Visible = false;
            txtTelephone.Visible = false;
            txtBip.Visible = false;
        }

        private void uscPersonnel_Load(object sender, EventArgs e)
        {
            MesDatas.DsGlobal.Relations.Add("relAffectationCaserne", 
                MesDatas.DsGlobal.Tables["Caserne"].Columns["id"], 
                MesDatas.DsGlobal.Tables["Affectation"].Columns["idCaserne"]);
            BindingSource bsCaserne = new BindingSource();

            bsCaserne.DataSource = MesDatas.DsGlobal.Tables["Caserne"];

            cboCaserne.DataSource = bsCaserne;
            cboCaserne.DisplayMember = "nom";
            cboCaserne.ValueMember = "id";

            cboCaserne_SelectedIndexChanged(sender, e);
            cboPompier_SelectedIndexChanged(sender, e);

            BindingSource bsGrade = new BindingSource();
            bsGrade.DataSource = MesDatas.DsGlobal.Tables["Grade"];

            cboGrade.DataSource = bsGrade;
            cboGrade.DisplayMember = "libelle";
            cboGrade.ValueMember = "code";


            BindingSource bsCaserneModif = new BindingSource();
            bsCaserneModif.DataSource = MesDatas.DsGlobal.Tables["Caserne"];
            cboCaserneModif.DataSource = bsCaserneModif;
            cboCaserneModif.DisplayMember = "nom";
            cboCaserneModif.ValueMember = "id";

        }

        private void cboCaserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCaserne.SelectedValue == null) return;

            DataTable tempPompiers = new DataTable();
            tempPompiers.Columns.Add("matricule", typeof(string));
            tempPompiers.Columns.Add("nom", typeof(string));

            foreach (DataRow dr in MesDatas.DsGlobal.Tables["Affectation"].Rows)
            {
                if (dr["dateFin"] == DBNull.Value && dr["idCaserne"].ToString()== cboCaserne.SelectedValue.ToString())
                {
                    string matricule = dr["matriculePompier"].ToString();
                    foreach (DataRow dr2 in MesDatas.DsGlobal.Tables["Pompier"].Rows)

                    if (dr2["matricule"].ToString()==matricule)
                    {
                        tempPompiers.Rows.Add(matricule, dr2["prenom"].ToString()+" "+ dr2["nom"].ToString());
                    }
                }
            }

            cboPompier.DataSource = tempPompiers;
            cboPompier.DisplayMember = "nom";
            cboPompier.ValueMember = "matricule";

        }

        private void cboPompier_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(DataRow dr in MesDatas.DsGlobal.Tables["Pompier"].Rows)
            {
                if (dr["matricule"].ToString() == cboPompier.SelectedValue.ToString())
                {
                    lblMatricule.Text = "Matricule " + dr["matricule"].ToString();
                    lblNom.Text = "Nom : " + dr["nom"].ToString();
                    lblPrenom.Text = "Prenom : " + dr["prenom"].ToString();
                    string sexe = dr["sexe"].ToString();
                    switch (sexe){
                        case "m":
                            sexe = "masculin";
                            break;
                        case "f":
                            sexe = "féminin";
                            break;
                        default:
                            sexe = "autre";
                            break;
                    }
                    lblSexe.Text = "Sexe : " +sexe;
                    var rm = Properties.Resources.ResourceManager;
                    pboGrade.BackgroundImage = rm.GetObject(dr["codeGrade"].ToString()) as Image;
                    txtGrade.Text = dr["codeGrade"].ToString();
                    lblTelephone.Text = "Téléphone : " + dr["portable"].ToString();
                    lblBip.Text = "Bip : " + dr["bip"].ToString();
                    string type = dr["type"].ToString();
                    switch (type)
                    {
                        case "p":
                            rdbProfessionnel.Checked=true;
                            rdbVolontaire.Checked = false;
                            break;
                        case "v":
                            rdbProfessionnel.Checked = false;
                            rdbVolontaire.Checked = true;
                            break;
                        default:
                            rdbProfessionnel.Checked = true;
                            rdbVolontaire.Checked = false;
                            break;
                    }
                    

                    string[] datesN =dr["dateNaissance"].ToString().Split('-');
                    lblNaissance.Text = ("Date de naissance : " + datesN[1] + "/" + datesN[2] + "/" + datesN[0]);
                    string[] datesE = dr["dateEmbauche"].ToString().Split('-');
                    lblEmbauche.Text = ("Date de naissance : " + datesE[1] + "/" + datesE[2] + "/" + datesE[0]);


                    cboGrade.SelectedValue = dr["codeGrade"];
                    txtTelephone.Text = dr["portable"].ToString();
                    txtBip.Text = dr["bip"].ToString();

                    //Plus
                    cboCaserneModif.SelectedValue=cboCaserne.SelectedValue;
                    chkConge.Checked = dr["enConge"].ToString() == "1";
                }
            }
        }

        private void txtGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
