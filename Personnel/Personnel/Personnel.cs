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
        public uscPersonnel(int i)
        {
            InitializeComponent ();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            frmIdentification ID = new frmIdentification();
            ID.StartPosition = FormStartPosition.CenterParent;
            if (ID.ShowDialog() == DialogResult.OK)
            {
                grpPlus.Visible = true;
                btnPlus.Visible = false;
                btnEdit.Visible = true;
                btnAnnule.Visible = true;
            }
        }

        private void btnMoins_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
                cboGrade.Visible = true;
                txtTelephone.Visible = true;
                txtBip.Visible = true;
        }



        private void btnAnnule_Click(object sender, EventArgs e)
        {
            grpPlus.Visible = false;
            btnPlus.Visible = true;
            cboGrade.Visible = false;
            txtTelephone.Visible = false;
            txtBip.Visible = false;
            btnEdit.Visible = false;
            cboPompier_SelectedIndexChanged(sender, e);
        }

        private void uscPersonnel_Load(object sender, EventArgs e)
        {
            uscPersonnel_SizeChanged(sender, e);
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
                    var rm = Personnel.Properties.Resources.ResourceManager;
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
                    lblEmbauche.Text = ("Date d'embauche : " + datesE[1] + "/" + datesE[2] + "/" + datesE[0]);


                    cboGrade.SelectedValue = dr["codeGrade"];
                    txtTelephone.Text = dr["portable"].ToString();
                    txtBip.Text = dr["bip"].ToString();

                    //Plus
                    cboCaserneModif.SelectedValue=cboCaserne.SelectedValue;
                    chkConge.Checked = dr["enConge"].ToString() == "1";
                    lstAffectationPassees.Items.Clear();
                    foreach (DataRow dr2 in MesDatas.DsGlobal.Tables["Affectation"].Rows)
                    {
                        if (dr2["matriculePompier"].ToString() == cboPompier.SelectedValue.ToString())
                        {
                            if (dr2["dateFin"] != DBNull.Value)
                            {
                                string dateA= dr2["dateA"].ToString();
                                string caserne = "";
                                foreach(DataRow dr3 in MesDatas.DsGlobal.Tables["Caserne"].Rows)
                                {
                                    if (dr3["id"].ToString() == dr2["idCaserne"].ToString())
                                    {
                                        caserne = dr3["nom"].ToString();
                                    }
                                }
                                lstAffectationPassees.Items.Add(dateA+" - "+caserne);
                            }
                        }
                    }
                    lstHabilitation.Items.Clear();
                    foreach (DataRow dr2 in MesDatas.DsGlobal.Tables["Passer"].Rows)
                    {
                        if (dr2["matriculePompier"].ToString() == cboPompier.SelectedValue.ToString())
                        {
                            string dateH = dr2["dateObtention"].ToString();
                            string habilitation = "";
                            foreach (DataRow dr3 in MesDatas.DsGlobal.Tables["Habilitation"].Rows)
                            {
                                if (dr3["id"].ToString() == dr2["idHabilitation"].ToString())
                                {
                                    habilitation = dr3["libelle"].ToString();
                                }
                            }
                            lstHabilitation.Items.Add(dateH + " - " + habilitation);
                        }
                    }
                }
            }
        }

        private void txtGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnMaj_Click(object sender, EventArgs e)
        {
            int Conge = 0;
            string[] dateheure = DateTime.Now.ToString().Split(' ');
            string[] datefin = dateheure[0].ToString().Split('/');
            Boolean changeCaserne = false; 
            


            connec = Connexion.Connec;
            SQLiteTransaction transac = connec.BeginTransaction();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = connec;
            cmd.Transaction = transac;
            try
            {
                try
                {
                    if (cboCaserne.SelectedValue.ToString() != cboCaserneModif.SelectedValue.ToString())
                    {
                        cmd.CommandText = @"INSERT INTO Affectation (matriculePompier, dateA, idCaserne)
                                        VALUES ('" + cboPompier.SelectedValue.ToString() + @"','" + datefin[2] + "-" + datefin[1] + "-" + datefin[0] + @"','" + cboCaserneModif.SelectedValue.ToString() + @"')";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = @"update Affectation set dateFin = '" + datefin[2] + "-" + datefin[1] + "-" + datefin[0] + @"'
                                        where matriculePompier = '" + cboPompier.SelectedValue.ToString() + @"'
                                        AND dateFin is null";
                        cmd.ExecuteNonQuery();
                        changeCaserne = true;
                    }
                }
                catch
                {
                    MessageBox.Show("La caserne ne peut pas être changé 2 fois le même jour","Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // annulation de la transaction
                    transac.Rollback();
                    MessageBox.Show("Transaction annulée !\n");
                    cboPompier_SelectedIndexChanged(sender, e);
                    return;
                }


                txtGrade.Text = cboGrade.SelectedValue.ToString();
                lblTelephone.Text = "Téléphone : " + txtTelephone.Text;
                lblBip.Text = "Bip : " + txtBip.Text;
                if (chkConge.Checked)
                {
                    Conge = 1;
                }
                foreach (DataRow dr in MesDatas.DsGlobal.Tables["Pompier"].Rows)
                {
                    if (dr["matricule"].ToString() == cboPompier.SelectedValue.ToString())
                    {
                        dr["codeGrade"] = txtGrade.Text;
                        dr["portable"] = txtTelephone.Text;
                        dr["bip"] = txtBip.Text;
                        dr["enConge"] = Conge;
                    }
                }

                if (cboCaserne.SelectedValue.ToString() != cboCaserneModif.SelectedValue.ToString() && changeCaserne)
                {
                    foreach (DataRow dr in MesDatas.DsGlobal.Tables["Affectation"].Rows)
                    {
                        if (dr["matriculePompier"].ToString() == cboPompier.SelectedValue.ToString())
                        {
                            if (dr["dateFin"] == DBNull.Value)
                            {
                                dr["dateFin"] = datefin[2] + "-" + datefin[1] + "-" + datefin[0];

                            }
                        }
                    }
                    DataRow newRow = MesDatas.DsGlobal.Tables["Affectation"].NewRow();
                    newRow[0] = cboPompier.SelectedValue.ToString();
                    newRow[1] = datefin[2] + "-" + datefin[1] + "-" + datefin[0];
                    newRow[3] = cboCaserneModif.SelectedValue.ToString();

                    MesDatas.DsGlobal.Tables["Affectation"].Rows.Add(newRow);

                }
                var rm = Personnel.Properties.Resources.ResourceManager;
                pboGrade.BackgroundImage = rm.GetObject(cboGrade.SelectedValue.ToString()) as Image;



                cmd.CommandText = @"update Pompier set codeGrade = '"+ txtGrade.Text + @"'
                                    where matricule = '"+ cboPompier.SelectedValue.ToString() + @"'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = @"update Pompier set portable = '" + txtTelephone.Text + @"'
                                    where matricule = '" + cboPompier.SelectedValue.ToString() + @"'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = @"update Pompier set bip = '" + txtBip.Text + @"'
                                    where matricule = '" + cboPompier.SelectedValue.ToString() + @"'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = @"update Pompier set enConge = '" + Conge + @"'
                                    where matricule = '" + cboPompier.SelectedValue.ToString() + @"'";
                cmd.ExecuteNonQuery();
                
                transac.Commit();

                if (changeCaserne)
                {
                    String nom = cboPompier.SelectedValue.ToString();
                    cboCaserne.SelectedValue = cboCaserneModif.SelectedValue;
                    cboPompier.SelectedValue = nom;
                }
            }
            catch
            {
                // annulation de la transaction
                transac.Rollback();
                MessageBox.Show("Transaction annulée !\n");
            }
        }

        private void txtBip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char)e.KeyChar >= '0' && (char)e.KeyChar <= '9'))
            {
                if ( e.KeyChar != (char)Keys.Back)
                {
                e.Handled = true;
                }
            }
        }

        private void txtTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char)e.KeyChar >= '0' && (char)e.KeyChar <= '9'))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void uscPersonnel_SizeChanged(object sender, EventArgs e)
        {
            if (this.Width > grpGeneral.Width)
            {
                grpGeneral.Left = (int)((this.Width - grpGeneral.Width) / 2.0);
                grpPlus.Left = (int)((this.Width - grpPlus.Width) / 2.0);
            }
            if (this.Width > pnlTitre.Width)
            {
                pnlTitre.Left = (int)((this.Width - pnlTitre.Width) / 2.0);
            }
            lblPersonnel.Left = (int)((pnlTitre.Width - lblPersonnel.Width) / 2.0);
            btnPlus.Left = (int)(this.Width - btnPlus.Width - grpPlus.Left);
        }
    }
}
