//dashBoard.cs
//
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
using Mission;
using WGM;
using Pinpon;

namespace dashBoard
{
    public partial class uscdashBoard : UserControl
    {
        SQLiteConnection connec;
        public uscdashBoard()
        {
            InitializeComponent();
          /*  connec = Connexion.Connec;
            MesDatas.DsGlobal.Clear();
            DataTable dt = connec.GetSchema("Tables");
            //   string liste = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string nomTable = dt.Rows[i][2].ToString();
                string req = "select * from " + nomTable;
                SQLiteCommand cmd = new SQLiteCommand(req, connec);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(MesDatas.DsGlobal, nomTable);
                // liste = liste + nomTable + "\n";
            }
            //    MessageBox.Show(liste);
            Connexion.FermerConnexion();*/
        }

        private void uscdashBoard_Load(object sender, EventArgs e)
        {
            flpMissions.Controls.Clear();
            foreach (DataRow dr in MesDatas.DsGlobal.Tables["Mission"].Rows)
            {
                uscMissions missions = new uscMissions(Convert.ToUInt16(dr[0]));
                flpMissions.Controls.Add(missions);
            }
        }

        private void chkEnCours_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnCours.Checked)
            {
                flpMissions.Controls.Clear();
                foreach (DataRow dr in MesDatas.DsGlobal.Tables["Mission"].Rows)
                {
                    if (Convert.ToUInt16(dr["terminee"]) == 0)
                    {
                        uscMissions missions = new uscMissions(Convert.ToUInt16(dr[0]));
                        flpMissions.Controls.Add(missions);
                    }
                }
            }
            else
            {
                flpMissions.Controls.Clear();
                foreach (DataRow dr in MesDatas.DsGlobal.Tables["Mission"].Rows)
                {
                    uscMissions missions = new uscMissions(Convert.ToUInt16(dr[0]));
                    flpMissions.Controls.Add(missions);
                }
            }
        }

        //public delegate void Nouveau(object sender, EventArgs e);
        //public event Nouveau nouv;
        private void btnNouvelle_Click(object sender, EventArgs e)
        {
            //if (this.nouv != null)
            //{
            //    this.nouv(sender, e);
            //}
            frmNouvMission nouvM = new frmNouvMission();
            nouvM.ShowDialog();
        }
    }
}
