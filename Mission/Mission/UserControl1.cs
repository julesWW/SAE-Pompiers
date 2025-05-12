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

namespace Mission
{
    public partial class uscMissions: UserControl
    {
        int id=1;
        SQLiteConnection connec;
        public uscMissions()
        {
            InitializeComponent();
            connec = Connexion.Connec;

            DataTable dt = connec.GetSchema("Tables");
            string liste = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string nomTable = dt.Rows[i][2].ToString();
                string req = "select * from " + nomTable;
                SQLiteCommand cmd = new SQLiteCommand(req, connec);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(MesDatas.DsGlobal, nomTable);
                liste = liste + nomTable + "\n";
            }
            MessageBox.Show(liste);
            Connexion.FermerConnexion();
        }
        public uscMissions(int idMission)
        {
            InitializeComponent();
            id=idMission;
        }

        private void uscMissions_Load(object sender, EventArgs e)
        {
            lblIdMission.Text = "id mission: "+id;
          
            foreach(DataRow r in MesDatas.DsGlobal.Tables["Mission"].Rows)
            {
                if(Convert.ToInt16(r[0]) == id)
                {
                    lblMotif.Text = "→" + r["motifAppel"].ToString();
                }
            }
        }
    }
}
