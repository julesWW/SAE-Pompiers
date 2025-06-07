using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pinpon;
using dashBoard;
using Engins;
using Personnel;

namespace WGM
{
    public partial class frmBase : Form
    {
        SQLiteConnection connec;
        int Page = 0;
        public frmBase()
        {
            InitializeComponent();
         
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C'est ciao");
            Application.Exit();
        }

  
        private void Form1_Load(object sender, EventArgs e)
        {
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

            ForeignKeyConstraint FK_Caserne = new ForeignKeyConstraint("FK_Caserne", MesDatas.DsGlobal.Tables["Caserne"].Columns["id"], MesDatas.DsGlobal.Tables["Engin"].Columns["idCaserne"]);
            MesDatas.DsGlobal.Tables["Engin"].Constraints.Add(FK_Caserne);

            MesDatas.DsGlobal.Relations.Add("relEnginCaserne", MesDatas.DsGlobal.Tables["Caserne"].Columns["id"], MesDatas.DsGlobal.Tables["Engin"].Columns["idCaserne"]);
            MesDatas.DsGlobal.Relations.Add("relAffectationCaserne",
                MesDatas.DsGlobal.Tables["Caserne"].Columns["id"],
                MesDatas.DsGlobal.Tables["Affectation"].Columns["idCaserne"]);
            changePage();
        }

        private void changePage()
        {
            pnlPage.Controls.Clear();
            if(Page==0)
            {
                btnTableauDeBord.BackColor = Color.FromArgb(239, 180, 149);
                uscdashBoard db = new uscdashBoard();
                db.Dock=DockStyle.Fill;
                pnlPage.Controls.Add(db);
            }
            else
            {
                btnTableauDeBord.BackColor = Color.FromArgb(239, 213, 149);
            }
            if (Page == 1)
            {
                btnEngins.BackColor = Color.FromArgb(239, 180, 149);
                USC_Engins en = new USC_Engins ();
                en.Dock = DockStyle.Fill;
                pnlPage.Controls.Add(en);
            }
            else
            {
                btnEngins.BackColor = Color.FromArgb(239, 213, 149);
            }
            if (Page == 2)
            {
                btnPersonnel.BackColor = Color.FromArgb(239, 180, 149);
                uscPersonnel pe = new uscPersonnel(1);
                pe.Dock = DockStyle.Fill;
                pnlPage.Controls.Add(pe);
            }
            else
            {
                btnPersonnel.BackColor = Color.FromArgb(239, 213, 149);
            }
        }

        private void btnTableauDeBord_Click(object sender, EventArgs e)
        {
            if (Page != 0)
            {
                Page = 0;
                changePage();
            }
        }

        private void btnEngins_Click(object sender, EventArgs e)
        {
            if (Page != 1)
            {
                Page = 1;
                changePage();
            }
        }

        private void btnPersonnel_Click(object sender, EventArgs e)
        {
            if (Page != 2)
            {
                Page = 2;
                changePage();
            }
        }
    }
}
