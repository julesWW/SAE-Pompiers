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

namespace Engins
{

    public partial class USC_Engins : UserControl
    {
        DataSet ds = new DataSet();
        DataTable dtCaserne = new DataTable();
        DataTable dtEngin = new DataTable();
        BindingSource bsEngin = new BindingSource();
        public USC_Engins()
        {
            InitializeComponent();
            String connexionString = "Data Source=SDIS67.db";
            String requete = "SELECT * FROM Caserne";
            SQLiteConnection connection = new SQLiteConnection(connexionString);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(requete, connection);
            try
            {
                //Enlever ces lignes pour l'implémentation aua forulaire principal
                connection.Open();
                adapter.Fill(ds, "Caserne");
                requete = "SELECT * FROM Engin";
                adapter = new SQLiteDataAdapter(requete, connection);
                adapter.Fill(ds, "Engin");
                connection.Close();
                //Là

                //DataSet ds = MesDatas.DsGlobal;

                //Contraintes
                ForeignKeyConstraint FK_Caserne = new ForeignKeyConstraint("FK_Caserne", ds.Tables["Caserne"].Columns["id"], ds.Tables["Engin"].Columns["idCaserne"]);
                ds.Tables["Engin"].Constraints.Add(FK_Caserne);

                ds.Relations.Add("relEnginCaserne", ds.Tables["Caserne"].Columns["id"], ds.Tables["Engin"].Columns["idCaserne"]);
                BindingSource bsCaserne = new BindingSource();
                bsCaserne.DataSource = ds.Tables["Caserne"];
                cboChoixCaserne.DataSource = bsCaserne;
                cboChoixCaserne.DisplayMember = "Nom";
                cboChoixCaserne.ValueMember = "id";

                bsEngin = new BindingSource();
                bsEngin.DataSource = bsCaserne;
                bsEngin.DataMember = "relEnginCaserne";

                DataRowView row = bsEngin.Current as DataRowView;
                //MessageBox.Show(row.Row.Table.Columns.Count.ToString());


                //Affichage de la valeur de la colonne 2 ligne 1 de dtEngin dans une messagebox
                MaJ(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public void MaJ(object sender, EventArgs e)
        {
            DataRowView row = bsEngin.Current as DataRowView;
            if (row != null)
            {
                lblNumVal.Text = row["idCaserne"] + "-" + row["codeTypeEngin"] + "-" + row["numero"];
                String[] date = row["dateReception"].ToString().Split('-');
                lblDateReceptVal.Text = date[1] + "/" + date[2] + "/" + date[0];
                cboMission.Checked = Convert.ToBoolean(row["enMission"]);
                cboPanne.Checked = Convert.ToBoolean(row["enPanne"]);
                var rm = Engins.Properties.Resources.ResourceManager;
                pboEngin.BackgroundImage = rm.GetObject(row["codeTypeEngin"].ToString()) as Image;

            }
            else
            {
                lblNumVal.Text = "Aucune ligne sélectionnée";
            }


        }
        private void cboChoixCaserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            bsEngin.Position = 2;
            MaJ(null, null);

        }
        private void btnPreviousPlus_Click(object sender, EventArgs e)
        {
            bsEngin.MoveFirst();
            MaJ(null, null);
        }
        private void btnNextPlus_Click(object sender, EventArgs e)
        {
            bsEngin.MoveLast();
            MaJ(null, null);
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bsEngin.MovePrevious();
            MaJ(null, null);
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            bsEngin.MoveNext();
            MaJ(null, null);
        }




    }
}
