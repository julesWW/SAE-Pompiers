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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using System.Xml.Linq;

namespace Mission
{
    public partial class uscMissions : UserControl
    {
        int id;
        bool enCours;
        //  SQLiteConnection connec;
        string mission;
        string[] datesHeures;
        string[] dates;
        public uscMissions()
        {
            /*InitializeComponent();
            connec = Connexion.Connec;

            DataTable dt = connec.GetSchema("Tables");
           // string liste = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string nomTable = dt.Rows[i][2].ToString();
                string req = "select * from " + nomTable;
                SQLiteCommand cmd = new SQLiteCommand(req, connec);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(MesDatas.DsGlobal, nomTable);
                 // liste = liste + nomTable + "\n";
            }
            //  MessageBox.Show(liste);
            Connexion.FermerConnexion();*/

        }
        public uscMissions(int idMission)
        {
            id = idMission;
            InitializeComponent();
        }

        private void uscMissions_Load(object sender, EventArgs e)
        {
            lblIdMission.Text = "id mission: " + id;

            foreach (DataRow r in MesDatas.DsGlobal.Tables["Mission"].Rows)
            {
                if (Convert.ToInt16(r[0]) == id)
                {
                    //Motif
                    lblMotif.Text = "→ " + r["motifAppel"].ToString();
                    mission = r["motifAppel"].ToString();
                    //dateDepart
                    datesHeures = r["dateHeureDepart"].ToString().Split(' ');
                    dates = datesHeures[0].Split('-');
                    lblDebut.Text = ("Début le " + dates[1] + "/" + dates[2] + "/" + dates[0] + " à " + datesHeures[1]);
                    //caserne
                    foreach (DataRow r2 in MesDatas.DsGlobal.Tables["Caserne"].Rows)
                    {
                        if (Convert.ToInt16(r2[0]) == Convert.ToInt16(r["idCaserne"]))
                        {
                            lblCaserne.Text = r2["nom"].ToString();
                        }
                    }
                    //Nature Sinistre (catégorie)
                    foreach (DataRow r2 in MesDatas.DsGlobal.Tables["NatureSinistre"].Rows)
                    {
                        if (Convert.ToInt16(r2[0]) == Convert.ToInt16(r["idNatureSinistre"]))
                        {
                            lblCategorie.Text = r2["libelle"].ToString();
                        }
                    }
                    //Compte Rendu
                    rtxtCompteRendu.Text = r["compteRendu"].ToString();

                    // if pas fini
                    if (Convert.ToInt16(r["terminee"]) == 0)
                    {
                        enCours = true;
                        rtxtCompteRendu.Visible = false;
                        lblFin.Visible = false;
                        //Image
                        var rm = WGM.Properties.Resources.ResourceManager;
                        pboAlert.BackgroundImage = rm.GetObject("Alert") as System.Drawing.Image;
                    }
                    else
                    {
                        enCours=false;
                        btnCloture.Enabled = false;
                        rtxtCompteRendu.Visible = true;
                        lblFin.Visible = true;
                        //Image
                        var rm = WGM.Properties.Resources.ResourceManager;
                        pboAlert.BackgroundImage = rm.GetObject("AlertOff") as System.Drawing.Image;
                        btnCloture.BackgroundImage = rm.GetObject("FireManThumbsUpOff") as System.Drawing.Image;


                        //dateRetours
                        string[] datesHeuresRetour = r["dateHeureRetour"].ToString().Split(' ');
                        string[] datesRetour = datesHeuresRetour[0].Split('-');
                        lblFin.Text = ("Fin le " + datesRetour[1] + "/" + datesRetour[2] + "/" + datesRetour[0] + " à " + datesHeuresRetour[1]);
                    }
                }
            }
            BonneTaille();
        }
        private void btnCloture_Click(object sender, EventArgs e)
        {
            frmCR frmCR = new frmCR(mission, id);
            if (frmCR.ShowDialog() == DialogResult.OK)
            {
                uscMissions_Load(sender, e);
                btnPDF_Click(sender, e);
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            DataTable dtMission = MesDatas.DsGlobal.Tables["Mission"];
            DataTable dtCaserne = MesDatas.DsGlobal.Tables["Caserne"];
            DataTable dtAffect = MesDatas.DsGlobal.Tables["Affectation"];
            DataTable dtPompier = MesDatas.DsGlobal.Tables["Pompier"];
            DataTable dtGrade = MesDatas.DsGlobal.Tables["Grade"];
            DataTable dtPasserHabilitation = MesDatas.DsGlobal.Tables["Passer"];
            DataTable dtHabilitation = MesDatas.DsGlobal.Tables["Habilitation"];
            DataTable dtNecessiteEngin = MesDatas.DsGlobal.Tables["Necessiter"];
            DataTable dtEngin = MesDatas.DsGlobal.Tables["Engin"];
            DataTable dtTypeEngin = MesDatas.DsGlobal.Tables["TypeEngin"];
            DataTable dtMobiliser = MesDatas.DsGlobal.Tables["Mobiliser"];
            DataTable dtPartirAvec = MesDatas.DsGlobal.Tables["PartirAvec"];
            int idCaserne = 0;

            foreach (DataRow r in dtCaserne.Rows)
            {
                if (Convert.ToString(r[1]) == lblCaserne.Text)
                {
                    idCaserne = Convert.ToInt16(r[0]);
                }
            }

            QuestPDF.Settings.License = LicenseType.Community;
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(3, Unit.Centimetre);

                    page.Header()
                        .Text("Rapport de mission")
                        .Bold()
                        .FontSize(24);

                    page.Content().Column(col =>
                    {
                        col.Spacing(10);


                        col.Item().Text("Déclenchée le " + dates[1] + "-" + dates[2] + "-" + dates[0] + " à " + datesHeures[1]);
                        if (enCours)
                        {
                            col.Item().Text("Mission toujours en cours");
                        }
                        else
                        {
                            col.Item().Text("Retour le " + lblFin.Text.Replace("Fin le ", ""));
                        }

                        col.Item().Text("--------------------------------------------------------------------------------");

                        col.Item().Text("Type de sinistre : " + lblCategorie.Text).Bold();

                        col.Item().Text("Motif : " + mission);
                        
                        foreach(DataRow r in dtMission.Rows)
                        {
                            if (Convert.ToInt16(r["id"]) == id)
                            {
                                col.Item().Text("Adresse : " + r["adresse"].ToString()+" "+ r["cp"].ToString()+" "+ r["ville"].ToString());
                            }
                        }

                        if (enCours)
                        {
                            col.Item().Text("Le compte rendu n'a pas encore été saisi car la mission est toujours en cours.");
                        }
                        else
                        {
                            col.Item().Text("Compte-rendu : " + rtxtCompteRendu.Text);
                        }

                        col.Item().Text("--------------------------------------------------------------------------------");

                        col.Item().Text("Caserne : " + lblCaserne.Text)
                        .Bold();

                        List<int> pompiersAffectes = new List<int>();
                        foreach (DataRow r in dtMobiliser.Rows)
                        {
                            if (Convert.ToInt16(r["idMission"]) == id)
                            {
                                pompiersAffectes.Add(Convert.ToInt16(r["matriculePompier"]));
                            }
                        }

                        foreach (int matriculePompier in pompiersAffectes)
                        {
                            foreach (DataRow r in dtPompier.Rows)
                            {
                                if (Convert.ToInt16(r["matricule"]) == matriculePompier)
                                {
                                    string codeGrade = "";
                                    foreach (DataRow r2 in dtGrade.Rows)
                                    {
                                        if (Convert.ToString(r2["code"]) == Convert.ToString(r["codeGrade"]))
                                        {
                                            codeGrade = Convert.ToString(r2["libelle"]);
                                        }
                                    }
                                    string habilitation = "";
                                    foreach (DataRow r2 in dtMobiliser.Rows)
                                    {
                                        if (Convert.ToInt16(r2["matriculePompier"]) == Convert.ToInt16(r["matricule"]) && Convert.ToInt16(r2["idMission"]) == id)
                                        {
                                            foreach (DataRow r3 in dtHabilitation.Rows)
                                            {
                                                if (Convert.ToInt16(r2["idHabilitation"]) == Convert.ToInt16(r3["id"]))
                                                {
                                                    habilitation = r3["libelle"].ToString();
                                                }
                                            }
                                        }
                                    }
                                    col.Item().Text(codeGrade + " : " + r["nom"].ToString() + " " + r["prenom"].ToString() + " (" + habilitation + ")");
                                }
                            }
                        }

                        col.Item().Text("--------------------------------------------------------------------------------");
                        col.Item().Text("Engins mobilisés :")
                        .Bold();

                        foreach (DataRow r2 in dtPartirAvec.Rows)
                        {
                            if (Convert.ToInt16(r2["idMission"]) == id)
                            {
                                string nomTypeEngin = "";
                                foreach (DataRow r3 in dtTypeEngin.Rows)
                                {
                                    if (Convert.ToString(r3["code"]) == Convert.ToString(r2["codeTypeEngin"]))
                                    {
                                        nomTypeEngin = r3["nom"].ToString();
                                    }
                                }
                                String Engin = ("→ " + nomTypeEngin + " " + r2["idCaserne"].ToString() + "-" + r2["codeTypeEngin"] + "-" + r2["numeroEngin"]);
                                if (r2["reparationsEventuelles"] != DBNull.Value)
                                {
                                    Engin += " (" + r2["reparationsEventuelles"].ToString() + ")";
                                }
                                col.Item().Text(Engin);
                            }
                        }
                    });
                });
            }).GeneratePdf(@".\..\..\..\..\RapportsDeMissions\Rapport_Mission_"+ id+@".pdf");

        }

        private void BonneTaille()
        {
            if (btnDeroule.Tag.ToString() == "Close")
            {
                this.Height = 123;
            }
            else
            {
                if (enCours)
                {
                    this.Height = 240;
                }
                else
                {
                    this.Height = 350;
                }
            }
        }
        private void btnDeroule_Click(object sender, EventArgs e)
        {
            if (btnDeroule.Tag.ToString() == "Open")
            {
                btnDeroule.Tag = "Close";
                btnDeroule.Text = "▼";
                BonneTaille();
            }
            else
            {
                btnDeroule.Tag = "Open";
                btnDeroule.Text = "▲";
                BonneTaille();
            }
        }
    }
}

