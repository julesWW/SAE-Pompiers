using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WGM
{
    public partial class uscReparation : UserControl
    {
        public delegate void change(String engin,String preced,String tag);
        public delegate void close(String engin,int tag);
        public event change Changement;
        String EnginPrecedant;

        Dictionary<String, bool> EnginDeMission;
        public uscReparation()
        {
            InitializeComponent();
            EnginDeMission = new Dictionary<String, bool>();
            EnginDeMission.Add("Ceci", true);
            EnginDeMission.Add("n'as", true);
            EnginDeMission.Add("pas", true);
            EnginDeMission.Add("été", true);
            EnginDeMission.Add("bien", true);
            EnginDeMission.Add("appelé", true);

        }
        public uscReparation(Dictionary<String,bool> E)
        {
            InitializeComponent();
            EnginDeMission = E;
        }

        private void uscReparation_Load(object sender, EventArgs e)
        {
            foreach(KeyValuePair<String, bool> E in EnginDeMission)
            {
                if (E.Value)
                {
                    cboEngin.Items.Add(E.Key);
                }
            }
            cboEngin.SelectedIndex = 0;
            if (this.Changement != null)
            {
                this.Changement(cboEngin.SelectedItem.ToString(),null,this.Tag+"");
                EnginPrecedant = cboEngin.SelectedItem.ToString();
            }
        }

        public void MajRemCbo(String s)
        {
            cboEngin.Items.Remove(s);
        }

        public void MajAddCbo(String s)
        {
            cboEngin.Items.Add(s);
        }

        private void cboEngin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Changement != null)
            {
                this.Changement(cboEngin.SelectedItem.ToString(),EnginPrecedant,this.Tag+"");
                EnginPrecedant = cboEngin.SelectedItem.ToString();
            }
        }
        public event close Fermer;

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.Fermer != null)
            {
                this.Fermer(cboEngin.SelectedItem.ToString(),Convert.ToInt16(this.Tag));
            }
        }
    }
}
