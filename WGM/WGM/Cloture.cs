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
using WGM;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mission
{
    public partial class frmCR : Form
    {
        Dictionary<string, bool> enginAReparer;
        int nbReparation=0;
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
            enginAReparer = new Dictionary<string, bool>();
            foreach (DataRow r in MesDatas.DsGlobal.Tables["PartirAvec"].Rows) {
                if (Convert.ToInt16(r["idMission"]) == idMission)
                {
                    enginAReparer.Add(r["idCaserne"] + "-" + r["codeTypeEngin"] + "-" + r["numeroEngin"], true);
                }
            }
        }

        private void frmCR_Load(object sender, EventArgs e)
        {
            flpReparations.Height = 0;
            this.Height = 328;
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


            foreach (uscReparation repar in flpReparations.Controls.OfType<uscReparation>())
            {
                int Caserne = 0;
                String Engin = "";
                int numEngin = 0;
                foreach (System.Windows.Forms.ComboBox c in repar.Controls.OfType<System.Windows.Forms.ComboBox>())
                {
                    String[] nomEngin = c.Text.Split('-');
                    Caserne = Convert.ToInt16(nomEngin[0]);
                    Engin = nomEngin[1];
                    numEngin = Convert.ToInt16(nomEngin[2]);
                }

                foreach (DataRow r1 in MesDatas.DsGlobal.Tables["Engin"].Rows)
                {
                    if (Convert.ToInt16(r1["idCaserne"]) == Caserne && r1["codeTypeEngin"].ToString() == Engin && Convert.ToInt16(r1["numero"]) == numEngin)
                    {
                        r1["enPanne"] = "1";
                    }
                }
                foreach (DataRow r in MesDatas.DsGlobal.Tables["PartirAvec"].Rows)
                {
                    if (Convert.ToInt16(r["idMission"]) == id && Convert.ToInt16(r["idCaserne"]) == Caserne && r["codeTypeEngin"].ToString() == Engin && Convert.ToInt16(r["numeroEngin"]) == numEngin)
                    {
                        foreach(RichTextBox rtb in repar.Controls.OfType<RichTextBox>())
                        {
                            r["ReparationsEventuelles"]=rtb.Text;
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

        private void btnReparation_Click(object sender, EventArgs e)
        {
            this.Height += 210;
            flpReparations.Height = 260;
            btnPlus_Click(sender, e);
        }

        private void newReparation()
        {
            nbReparation++;
            uscReparation R= new uscReparation(enginAReparer);
            R.Tag =nbReparation;
            R.Changement += MajEngin;
            R.Fermer+= AnnulerReparation;
            flpReparations.Controls.Add(R);

        }
        private void MajEngin(String s, String preced, String tag)
        {
            if(preced!=null)
            {
                enginAReparer[preced] = true;
            }
            enginAReparer[s]=false;
            foreach (uscReparation r in flpReparations.Controls.OfType<uscReparation>())
            {
                if (r.Tag+"" != tag)
                {
                    r.MajRemCbo(s);
                    if (preced != null)
                    {
                        r.MajAddCbo(preced);
                    }
                }
            }
        }
        private void AnnulerReparation(String s, int tag)
        {
            foreach(uscReparation r in flpReparations.Controls.OfType<uscReparation>())
            {
                if ((int)r.Tag == tag)
                {
                    flpReparations.Controls.Remove(r);
                }
                else
                {
                    r.MajAddCbo(s);
                }
            }
            enginAReparer[s]=true;
            nbReparation--;
            if (nbReparation < enginAReparer.Count())
            {
                flpReparations.Controls.Remove(btnPlus);
                flpReparations.Controls.Add(btnPlus);
            }
            if (nbReparation == 0)
            {
                flpReparations.Height = 0;
                this.Height = 328;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            flpReparations.Controls.Remove(btnPlus);
            newReparation();
            if (nbReparation < enginAReparer.Count())
            {
            flpReparations.Controls.Add(btnPlus);
            }
        }
    }
}
