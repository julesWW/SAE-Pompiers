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
            connec = Connexion.Connec;
            try
            {
                string requete = "update Mission set dateHeureRetour = \"" + dateHeureFin + "\" , compteRendu = \"" + rtbCR.Text + "\", terminee = 1 where id = " + id;
                SQLiteCommand cd = new SQLiteCommand();
                cd.Connection = connec;
                cd.CommandType = CommandType.Text;
                cd.CommandText = requete;
                cd.ExecuteNonQuery();
                DialogResult = DialogResult.OK;
            }
            catch (SQLiteException)
            {
                MessageBox.Show("erreur de la requête SQL");
                DialogResult = DialogResult.Cancel;
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("erreur de la connection");
                DialogResult = DialogResult.Cancel;
            }
            catch (Exception erreur)
            {
                MessageBox.Show(erreur.GetType().ToString());
                DialogResult = DialogResult.Cancel;
            }
            finally { }
            Connexion.FermerConnexion();
        }
    }
}
