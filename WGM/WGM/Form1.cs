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
        public Form1()
        {
            InitializeComponent();
            SQLiteConnection connec = Connexion.Connec;
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
    }
}
