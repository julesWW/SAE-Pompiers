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
using System.Net;

namespace Statistiques
{
    public partial class uscStats: UserControl
    {
        SQLiteConnection connec;
        Dictionary<String,int> Casernes = new Dictionary<String,int>();
        public uscStats()
        {
            InitializeComponent();
            /*connec = Connexion.Connec;
            Connexion.FermerConnexion();*/
        }

        private void uscStats_Load(object sender, EventArgs e)
        {
            try
            {
                connec = Connexion.Connec;
                SQLiteCommand cd = new SQLiteCommand();

                string requete = @"SELECT nom,id from Caserne";
                cd = new SQLiteCommand();
                cd.Connection = connec;
                cd.CommandType = CommandType.Text;
                cd.CommandText = requete;
                SQLiteDataReader dr = cd.ExecuteReader();
                cboCaserne.Items.Clear();
                while (dr.Read())
                {
                    Casernes.Add(dr.GetString(0),dr.GetInt32(1));
                    cboCaserne.Items.Add(dr.GetString(0));
                }
                Connexion.FermerConnexion();
            }
            catch (SQLiteException)
            {
                MessageBox.Show("erreur de la requête SQL");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("erreur de la connection");
            }
            catch (Exception erreur)
            {
                MessageBox.Show(erreur.GetType().ToString());
            }
            cboCaserne.SelectedIndex = 0;
            
        }

        private void MenuDeroulant(object sender,Panel P,String T)
        {
            if (((Button)sender).Tag.ToString() == "open")
            {
                ((Button)sender).Text = T+"                  ▲";
                ((Button)sender).Tag = "close";
                P.Height = ((Button)sender).Height;
            }
            else
            {
                ((Button)sender).Text = T + "                  ▼";
                ((Button)sender).Tag = "open";
                P.Height = 400;
            }
        }
        private void btnParCaserne_Click(object sender, EventArgs e)
        {
            MenuDeroulant(sender, pnlParCaserne, "Statistiques par Caserne");
        }

        private void btnInterCaserne_Click(object sender, EventArgs e)
        {
            MenuDeroulant(sender, pnlInterCaserne, "Statistiques inter-Caserne");
        }

        private void cboCaserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            String idCaserne = Casernes[cboCaserne.Text.ToString()].ToString();

            try
            {
                connec = Connexion.Connec;
                SQLiteCommand cd = new SQLiteCommand();

                string requete = @"SELECT 
                                    e.idCaserne,
                                    e.codeTypeEngin,
                                    e.numero,
                                    COUNT(p.idCaserne) AS totalUtilisations
                                FROM Engin e
                                LEFT JOIN PartirAvec p
                                    ON e.idCaserne = p.idCaserne
                                    AND e.codeTypeEngin = p.codeTypeEngin
                                    AND e.numero = p.numeroEngin
                                WHERE e.idCaserne = " + idCaserne + @"
                                GROUP BY e.idCaserne, e.codeTypeEngin, e.numero
                                HAVING totalUtilisations = (
                                    SELECT MAX(compte) FROM (
                                        SELECT COUNT(p2.idCaserne) AS compte
                                        FROM Engin e2
                                        LEFT JOIN PartirAvec p2
                                            ON e2.idCaserne = p2.idCaserne
                                            AND e2.codeTypeEngin = p2.codeTypeEngin
                                            AND e2.numero = p2.numeroEngin
                                        WHERE e2.idCaserne = " + idCaserne + @"
                                        GROUP BY e2.codeTypeEngin, e2.numero
                                    )
                                )";
                cd = new SQLiteCommand();
                cd.Connection = connec;
                cd.CommandType = CommandType.Text;
                cd.CommandText = requete;
                SQLiteDataReader dr = cd.ExecuteReader();
                dr.Read();
                if (dr.Equals(null))
                {
                    lblNBCASERNE.Text = "ouais ouais";
                }
                else
                {
                    lblNBCASERNE.Text = dr.GetInt32(0) + "-" + dr.GetString(1) + "-" + dr.GetInt32(2);
                }
                dr.Close();
                Connexion.FermerConnexion();
            }
            catch (SQLiteException)
            {
                MessageBox.Show("erreur de la requête SQL");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("erreur de la connection");
            }
            catch (Exception erreur)
            {
                MessageBox.Show(erreur.GetType().ToString());
            }
            connec = Connexion.Connec;
        }
    }
}
