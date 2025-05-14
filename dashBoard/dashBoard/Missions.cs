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

namespace Mission
{
    public partial class uscMissions : UserControl
    {
        int id = 7;
      //  SQLiteConnection connec;
        string mission;
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
            id=idMission;
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
                    string[] datesHeures = r["dateHeureDepart"].ToString().Split(' ');
                    string[] dates = datesHeures[0].Split('-');
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
                    lblCompteRendu.Text = r["compteRendu"].ToString();

                    // if pas fini
                    if (Convert.ToInt16(r["terminee"]) == 0)
                    {
                        lblCompteRendu.Visible = false;
                        lblFin.Visible = false;
                        //Image
                        var rm = dashBoard.Properties.Resources.ResourceManager;
                        pboAlert.BackgroundImage = rm.GetObject("Alert") as Image;
                    }
                    else
                    {
                        btnCloture.Enabled = false;
                        lblCompteRendu.Visible = true;
                        lblFin.Visible = true;
                        //Image
                        var rm = dashBoard.Properties.Resources.ResourceManager;
                        pboAlert.BackgroundImage = rm.GetObject("AlertOff") as Image;
                        btnCloture.BackgroundImage = rm.GetObject("FireManThumbsUpOff") as Image;


                        //dateRetour
                        string[] datesHeuresRetour = r["dateHeureRetour"].ToString().Split(' ');
                        string[] datesRetour = datesHeuresRetour[0].Split('-');
                        lblFin.Text = ("Fin le " + datesRetour[1] + "/" + datesRetour[2] + "/" + datesRetour[0] + " à " + datesHeuresRetour[1]);
                    }
                }
            }
        }
        private void btnCloture_Click(object sender, EventArgs e)
        {
            frmCR frmCR = new frmCR(mission, id);
            if (frmCR.ShowDialog() == DialogResult.OK)
            {
                uscMissions_Load(sender, e);
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Création du PDF!!!");
        }
    }
}
