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

namespace WGM
{
    public partial class Form1 : Form
    {
        SQLiteConnection connec;
        public Form1()
        {
            InitializeComponent();
            
        }

            private void btnQuitter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C'est ciao");
            Application.Exit();
        }

        private void btnNouvMissionTemp_Click(object sender, EventArgs e)
        {
            frmNouvMission frmNouvMission = new frmNouvMission();
            frmNouvMission.ShowDialog();
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
        }
    }
}
