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
        string dateSinistre = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
        string dateSinistre2 = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
        DataSet dsTemp = new DataSet();
        int numeroMission = -1;
        //-----------------------------------------------------------------
        private void btnConsult_Click(object sender, EventArgs e)
        {
            int idNatureSinistre = int.Parse(cboSinistre.SelectedValue.ToString());


            //affecter des vehicules
            
            dsTemp.Tables.Clear();
            dsTemp.Tables.Add("besoinVehicule");
            dsTemp.Tables["besoinVehicule"].Columns.Add("codeTypeEngin");
            dsTemp.Tables["besoinVehicule"].Columns.Add("nombre");

            foreach(DataRow dr in ds.Tables["Necessiter"].Select("idNatureSinistre = " + idNatureSinistre.ToString()))
            {
                DataRow newRow = dsTemp.Tables["besoinVehicule"].NewRow();
                newRow["codeTypeEngin"] = dr["codeTypeEngin"];
                newRow["nombre"] = dr["nombre"];
                dsTemp.Tables["besoinVehicule"].Rows.Add(newRow);
            }

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

            //affecter des pompiers
            dsTemp.Tables.Add("pompierDisHab");
            dsTemp.Tables["pompierDisHab"].Columns.Add("Matricule");
            dsTemp.Tables["pompierDisHab"].Columns.Add("Habilitation");
            dsTemp.Tables["pompierDisHab"].Columns.Add("Choisi");


            dsTemp.Tables.Add("pompierEnvoye");
            dsTemp.Tables["pompierEnvoye"].Columns.Add("Matricule");
            dsTemp.Tables["pompierEnvoye"].Columns.Add("Habilitation");

            List<string> pompierChoisi = new List<string>();

            foreach (DataRow vehicule in dsTemp.Tables["vehiculePossible"].Rows)
            {
                string habilitation = "";
                foreach (DataRow habil in ds.Tables["Embarquer"].Select("codeTypeEngin = " + "'" + vehicule["typeEngin"] + "'"))
                {
                    habilitation += habil["idHabilitation"] + " ";
                }
                string parametrePompier = "enMission = 0 AND enConge = 0";
                foreach (DataRow pompierDispo in ds.Tables["Pompier"].Select(parametrePompier))
                {
                    foreach(DataRow pomHab in ds.Tables["Passer"].Select("matriculePompier = '" + pompierDispo["matricule"].ToString() + "'"))
                    if (habilitation.Contains(pomHab["idHabilitation"].ToString()))
                    {
                            foreach (DataRow matriculePomp in ds.Tables["Affectation"].Select("matriculePompier = '" + pompierDispo["matricule"].ToString() + "' AND idCaserne = '" + cboCaserne.SelectedValue.ToString() + "'"))
                            {
                                DataRow nRow = dsTemp.Tables["pompierDisHab"].NewRow();
                                nRow["Matricule"] = pomHab["matriculePompier"];
                                nRow["Habilitation"] = pomHab["idHabilitation"];
                                nRow["Choisi"] = 0;
                                dsTemp.Tables["pompierDisHab"].Rows.Add(nRow);
                            }
                    }
                }


                foreach (DataRow eng in ds.Tables["Embarquer"].Rows)
                {
                    if (eng["codeTypeEngin"].ToString().Trim() == vehicule["typeEngin"].ToString().Trim())
                    {
                        string hab = eng["idHabilitation"].ToString();
                        int besoin = int.Parse(eng["nombre"].ToString());

                        //Pompiers dispo ayant l'habilitation et pas encore choisis
                        DataRow[] pompiersEligibles = dsTemp.Tables["pompierDisHab"].Select("Habilitation = '" + hab + "' AND Choisi = 0");

                        int nbAffectes = 0;

                        foreach (DataRow pompier in pompiersEligibles)
                        {
                            string matricule = pompier["Matricule"].ToString();

                            if (!pompierChoisi.Contains(matricule))
                            {
                                //Ajout dans pompierEnvoye
                                DataRow newPompier = dsTemp.Tables["pompierEnvoye"].NewRow();
                                newPompier["Matricule"] = matricule;
                                newPompier["Habilitation"] = pompier["Habilitation"];
                                dsTemp.Tables["pompierEnvoye"].Rows.Add(newPompier);

                                //Marquer comme choisi dans pompierDisHab
                                foreach (DataRow ligne in dsTemp.Tables["pompierDisHab"].Rows)
                                {
                                    if (ligne["Matricule"].ToString() == matricule && ligne["Habilitation"].ToString() == hab)
                                    {
                                        ligne["Choisi"] = 1;
                                        break;
                                    }
                                }

                                pompierChoisi.Add(matricule);
                                nbAffectes++;

                                if (nbAffectes >= besoin)
                                    break; //On a assez de pompiers pour le vehicule
                            }
                        }
                    }
                }


            }

            bool assezVehicule = true;
            bool assezPompier = true;

            //Verification du vehicule
            foreach(DataRow besoin in dsTemp.Tables["besoinVehicule"].Rows)
            {
                string codeType = besoin["codeTypeEngin"].ToString();
                int nombreRequis = int.Parse(besoin["nombre"].ToString());

                int nbDispo = dsTemp.Tables["vehiculePossible"].Select("typeEngin = '" + codeType + "'").Length;

                if (nbDispo < nombreRequis)
                {
                    assezVehicule = false;
                    break;
                }
            }

            //Verification pompier
            foreach (DataRow besoin in ds.Tables["Embarquer"].Rows)
            {
                string codeType = besoin["codeTypeEngin"].ToString();
                string hab = besoin["idHabilitation"].ToString();
                int nombre = int.Parse(besoin["nombre"].ToString());

                //Compter combien de véhicules de ce type ont été affectés
                int nbVehicules = dsTemp.Tables["vehiculePossible"].Select("typeEngin = '" + codeType + "'").Length;

                int nbRequis = nbVehicules * nombre;

                //Compter combien de pompiers de cette habilitation ont été envoyés
                int nbPresents = dsTemp.Tables["pompierEnvoye"].Select("Habilitation = '" + hab + "'").Length;

                if (nbPresents < nbRequis)
                {
                    assezPompier = false;
                    break;
                }
            }

            if (assezVehicule && assezPompier)
            {
                //Création du BindingSource engins
                BindingSource bs1 = new BindingSource();
                bs1.DataSource = dsTemp.Tables["vehiculePossible"];

                //Liaison à la DataGridView
                dgvEnginsMobil.DataSource = bs1;

                //BindingSource pompier
                BindingSource bs2 = new BindingSource();
                bs2.DataSource = dsTemp.Tables["pompierEnvoye"];

                //Liaison à la DataGridView
                dgvPompierMobil.DataSource = bs2;

                //Affichage du groupe
                grpMobilisation.Visible = true;

                btnValider.Visible = true;
            }
            else
            {
                btnValider.Visible = false;
                string msg = "Impossible de lancer la mission :\n";

                if (!assezVehicule)
                {
                    msg += "- Nombre de véhicules insuffisant\n";
                }

                if (!assezPompier)
                {
                    msg += "- Nombre de pompiers habilités insuffisant\n";
                }

                msg += "Veuillez essayer une autre caserne si possible";

                MessageBox.Show(msg, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {

            //Remplissage de la mission
            DataRow newMission = MesDatas.DsGlobal.Tables["Mission"].NewRow();
            newMission["id"] = numeroMission;
            newMission["dateHeureDepart"] = dateSinistre.ToString();
            newMission["dateHeureRetour"] = "Null";
            newMission["MotifAppel"] = txtMotif.Text;
            newMission["adresse"] = txtRue.Text;
            newMission["cp"] = txtCodePost.Text;
            newMission["ville"] = txtVille.Text;
            newMission["terminee"] = 0;
            newMission["compteRendu"] = "Null";
            newMission["idNatureSinistre"] = cboSinistre.SelectedValue;
            newMission["idCaserne"] = cboCaserne.SelectedValue;
            MesDatas.DsGlobal.Tables["Mission"].Rows.Add(newMission);

            //Remplissage de PartirAvec & Engin
            foreach(DataRow vehicule in dsTemp.Tables["vehiculePossible"].Rows)
            {
                DataRow newPartirAvec = MesDatas.DsGlobal.Tables["PartirAvec"].NewRow();
                newPartirAvec["idCaserne"] = cboCaserne.SelectedValue;
                newPartirAvec["codeTypeEngin"] = vehicule["typeEngin"];
                newPartirAvec["numeroEngin"] = vehicule["numero"];
                newPartirAvec["idMission"] = numeroMission;
                newPartirAvec["reparationsEventuelles"] = "Null";
                MesDatas.DsGlobal.Tables["PartirAvec"].Rows.Add(newPartirAvec);


                //Partie Engin
                string type = vehicule["typeEngin"].ToString();
                string numero = vehicule["numero"].ToString();
                string caserne = cboCaserne.SelectedValue.ToString(); 

                //Trouver le véhicule correspondant dans dsGlobal 
                string filtre = "codeTypeEngin = '" + type + "' AND numero = " + numero + " AND idCaserne = " + caserne;

                DataRow[] ligneVehicule = MesDatas.DsGlobal.Tables["Engin"].Select(filtre);

                if (ligneVehicule.Length > 0)
                {
                    ligneVehicule[0]["enMission"] = 1;
                }
                else
                {
                    MessageBox.Show("Véhicule non trouvé dans dsGlobal : " + filtre);
                }

            }
             //Remplissage de Mobiliser
            foreach(DataRow pompier in dsTemp.Tables["pompierEnvoye"].Rows)
            {
                DataRow newMobiliser = MesDatas.DsGlobal.Tables["Mobiliser"].NewRow();
                newMobiliser["matriculePompier"] = int.Parse(pompier["Matricule"].ToString());
                newMobiliser["idMission"] = numeroMission;
                newMobiliser["idHabilitation"] = int.Parse(pompier["Habilitation"].ToString());
                MesDatas.DsGlobal.Tables["Mobiliser"].Rows.Add(newMobiliser);

                int matricule = int.Parse(pompier["Matricule"].ToString());

                string filtre = "matricule = '" + matricule + "'";
                DataRow[] lignePompier = MesDatas.DsGlobal.Tables["Pompier"].Select(filtre);
                if (lignePompier.Length > 0)
                {
                    lignePompier[0]["enMission"] = 1;
                }
                else
                {
                    MessageBox.Show("Pompier non trouvé dans dsGlobal : " + filtre);
                }
            }

            DialogResult = DialogResult.OK;
        }

        private void frmNouvMission_Load(object sender, EventArgs e)
        {
            lblDate.Text += dateSinistre2;

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
            
            numeroMission = ds.Tables["Mission"].Rows.Count +1;
            lblNoMission.Text += numeroMission.ToString();
            
            
            btnValider.Visible = false;

        }

        private void cboSinistre_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnValider.Visible = false;
        }
        // Si tu vois ça tu as perdu au jeu
    }
}
