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
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Statistiques
{
    public partial class uscStats: UserControl
    {
        SQLiteConnection connec;
        Dictionary<String,int> Casernes = new Dictionary<String,int>();
        public uscStats()
        {
            InitializeComponent();
            dgwDureeEngins.Columns.Add("idEngin", "ID Engin");
            dgwDureeEngins.Columns.Add("duree", "Durée d'utilisation");
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

                requete = @"SELECT COUNT(m.id) AS nombre_inter, s.libelle
                    FROM NatureSinistre s 
                    LEFT JOIN Mission m ON m.idNatureSinistre = s.id
                    GROUP BY s.libelle
                    ORDER BY nombre_inter DESC";

                SQLiteCommand cd2 = new SQLiteCommand(requete, connec);
                dgvInterParSinistre.Rows.Clear();
                dgvInterParSinistre.Columns.Clear();
                dgvInterParSinistre.Columns.Add("libelle", "Type de sinistre");
                dgvInterParSinistre.Columns.Add("nombreInter", "Nombre d'interventions");
                SQLiteDataReader dr2 = cd2.ExecuteReader();
                while (dr2.Read())
                {
                    string libelle = dr2["libelle"].ToString();
                    string nombreInter = dr2["nombre_inter"].ToString();
                    dgvInterParSinistre.Rows.Add(libelle, nombreInter);
                }

                requete = @"SELECT COUNT(m.id) AS nombre_mobilisations, h.libelle
                            FROM Habilitation h LEFT JOIN Mission m ON h.id = m.idNatureSinistre
                            GROUP BY h.libelle
                            ORDER BY nombre_mobilisations DESC";

                SQLiteCommand cd3 = new SQLiteCommand(requete, connec);
                lblHabiSolVal.Text = "";
                int i = 1;
                SQLiteDataReader dr3 = cd3.ExecuteReader();
                while (dr3.Read())
                {
                    if (i < 4) {
                        string libelle = "";
                        if (dr3["libelle"].ToString().Contains("-") && !dr3["libelle"].ToString().Contains(" - "))
                        {
                            string[] codeHeure = dr3["libelle"].ToString().Split('-');
                            libelle = codeHeure[1].Trim();
                        }
                        else
                        {
                            libelle = dr3["libelle"].ToString();
                        }
                        lblHabiSolVal.Text += i + " - " + libelle + " : " + dr3["nombre_mobilisations"].ToString() + " fois sollicitée\n";
                        i++;
                    }
                }

                requete = @"SELECT CONCAT(CONCAT(pomp.nom, ' '), pomp.prenom) AS Nom_pompier, h.libelle AS Habilitation
                            FROM Pompier pomp Inner JOIN Passer pas ON pomp.matricule = pas.matriculePompier RIGHT JOIN Habilitation h ON pas.idHabilitation = h.id
                            ORDER BY h.libelle;";
                SQLiteCommand cd4 = new SQLiteCommand(requete, connec);
                dgvPompierHabilitation.Rows.Clear();
                dgvPompierHabilitation.Columns.Clear();
                dgvPompierHabilitation.Columns.Add("pompier", "Nom du Pompier");
                dgvPompierHabilitation.Columns.Add("habilitation", "Habilitation");
                SQLiteDataReader dr4 = cd4.ExecuteReader();
                while (dr4.Read())
                {
                    string pompier = dr4["Nom_pompier"].ToString();
                    string habilitation = dr4["Habilitation"].ToString();
                    dgvPompierHabilitation.Rows.Add(pompier, habilitation);
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
                ((Button)sender).Text = T + "                 ▼";
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

                SQLiteCommand cd2 = new SQLiteCommand();
                /*requete = @"SELECT pa.idCaserne, pa.codeTypeEngin, pa.numeroEngin, SUM((JULIANDAY(m.dateHeureRetour) - JULIANDAY(m.dateHeureDepart)) * 24) AS duree_totale_utilisation
                            FROM PartirAvec pa JOIN Mission m ON pa.idMission = m.id
                            WHERE m.dateHeureDepart IS NOT NULL AND m.dateHeureRetour IS NOT NULL
                            GROUP BY pa.idCaserne, pa.codeTypeEngin, pa.numeroEngin;";*/
                requete = @"SELECT e.idCaserne, e.codeTypeEngin, e.numero, CAST(ROUND(SUM((JULIANDAY(m.dateHeureRetour) - JULIANDAY(m.dateHeureDepart)) * 24), 0) AS INTEGER) AS duree_utilisation
                            FROM Engin e LEFT JOIN PartirAvec pa ON pa.idCaserne = e.idCaserne AND pa.codeTypeEngin = e.codeTypeEngin AND pa.numeroEngin = e.numero
                                         LEFT JOIN Mission m ON pa.idMission = m.id
                            WHERE e.idCaserne = "+idCaserne+@"
                            GROUP BY e.idCaserne, e.codeTypeEngin, e.numero
                            ORDER BY duree_utilisation DESC;;";
                cd2 = new SQLiteCommand();
                cd2.Connection = connec;
                cd2.CommandType = CommandType.Text;
                cd2.CommandText = requete;
                SQLiteDataReader dr2 = cd2.ExecuteReader();
                dgwDureeEngins.Rows.Clear();
                while (dr2.Read())
                {
                    string idCaserneEngin = dr2["idCaserne"].ToString();
                    string typeEngin = dr2["codeTypeEngin"].ToString();
                    string numero = dr2["numero"].ToString();
                    string duree;
                    if (dr2["duree_utilisation"].ToString() == "")
                    {
                        duree = "0";
                    }
                    else
                    { 
                        duree = dr2["duree_utilisation"].ToString();
                    }
                    string idEngin = idCaserneEngin + "-" + typeEngin + "-" + numero;
                    
                    dgwDureeEngins.Rows.Add(idEngin, duree);
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
