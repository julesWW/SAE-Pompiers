using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pinpon;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mission
{
    public partial class frmCR : Form
    {
        SQLiteConnection connec;
        int id;
        public frmCR()
        {
            InitializeComponent();
        }
        public frmCR(string mission, int idMission)
        {
            InitializeComponent();
            id = idMission;
            this.Text = "Cloture de " + mission;
            lblMission.Text = mission;
            lblMission.Left = (this.Width / 2) - (lblMission.Width / 2);
        }

        private void frmCR_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string[] datesHeures = dtpFin.Text.Split(' ');
            string[] dates = datesHeures[0].Split('/');
            String dateHeureFin = (dates[2] + "-" + dates[0] + "-" + dates[1] + " " + datesHeures[1]);
            foreach (DataRow r in MesDatas.DsGlobal.Tables["Mission"].Rows)
            {
                if (Convert.ToInt16(r[0]) == id)
                {
                    r["compteRendu"] = rtbCR.Text;
                    r["dateHeureRetour"] = dateHeureFin;
                    r["terminee"] = 1;
                }
            }

            foreach (DataRow r in MesDatas.DsGlobal.Tables["PartirAvec"].Rows)
            {
                if (Convert.ToInt16(r["idMission"]) == id)
                {
                    int Caserne = Convert.ToInt16(r["idCaserne"]);
                    String Engin = r["codeTypeEngin"].ToString();
                    int numEngin = Convert.ToInt16(r["numeroEngin"]);

                    foreach (DataRow r1 in MesDatas.DsGlobal.Tables["Engin"].Rows)
                    {
                        if (Convert.ToInt16(r1["idCaserne"]) == Caserne && r1["codeTypeEngin"].ToString() == Engin && Convert.ToInt16(r1["numero"]) == numEngin)
                        {
                            r1["enMission"] = "0";
                        }
                    }
                }
            }

            foreach (DataRow r in MesDatas.DsGlobal.Tables["Mobiliser"].Rows)
            {
                if (Convert.ToInt16(r["idMission"]) == id)
                {
                    string pompier = r["matriculePompier"].ToString();

                    foreach (DataRow r1 in MesDatas.DsGlobal.Tables["Pompier"].Rows)
                    {
                        if ( r1["matricule"].ToString() == pompier)
                        {
                            r1["enMission"] = "0";
                        }
                    }
                }
            }


            string[] TableMaJ = new string[] { "Engin", "Mission", "PartirAvec", "Pompier", "Mobiliser" };
            connec = Connexion.Connec;
            foreach (string t in TableMaJ)
            {
                string req = "select * from "+t;
                SQLiteCommand cmd = new SQLiteCommand(req, connec);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                SQLiteCommandBuilder builder = new SQLiteCommandBuilder(da);
                da.Update(MesDatas.DsGlobal, t);
            }
            Connexion.FermerConnexion();
            DialogResult = DialogResult.OK;
        }
    }
}
