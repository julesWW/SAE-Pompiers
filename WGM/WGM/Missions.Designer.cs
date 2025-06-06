namespace Mission
{
    partial class uscMissions
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIdMission = new System.Windows.Forms.Label();
            this.lblDebut = new System.Windows.Forms.Label();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.lblCompteRendu = new System.Windows.Forms.Label();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnCloture = new System.Windows.Forms.Button();
            this.pboAlert = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboAlert)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdMission
            // 
            this.lblIdMission.AutoSize = true;
            this.lblIdMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMission.Location = new System.Drawing.Point(96, 8);
            this.lblIdMission.Name = "lblIdMission";
            this.lblIdMission.Size = new System.Drawing.Size(95, 20);
            this.lblIdMission.TabIndex = 1;
            this.lblIdMission.Text = "id mission :";
            // 
            // lblDebut
            // 
            this.lblDebut.AutoSize = true;
            this.lblDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebut.Location = new System.Drawing.Point(251, 8);
            this.lblDebut.Name = "lblDebut";
            this.lblDebut.Size = new System.Drawing.Size(207, 20);
            this.lblDebut.TabIndex = 2;
            this.lblDebut.Text = "Début le 2025-03-02 14:26";
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaserne.Location = new System.Drawing.Point(495, 8);
            this.lblCaserne.MaximumSize = new System.Drawing.Size(200, 50);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(198, 50);
            this.lblCaserne.TabIndex = 3;
            this.lblCaserne.Text = "Caserne : aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
    "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorie.Location = new System.Drawing.Point(97, 44);
            this.lblCategorie.MaximumSize = new System.Drawing.Size(360, 50);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(360, 50);
            this.lblCategorie.TabIndex = 4;
            this.lblCategorie.Text = "catégorie aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
    "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotif.Location = new System.Drawing.Point(463, 46);
            this.lblMotif.MaximumSize = new System.Drawing.Size(230, 75);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(225, 75);
            this.lblMotif.TabIndex = 5;
            this.lblMotif.Text = "→ Motif aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
    "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin.Location = new System.Drawing.Point(251, 26);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(50, 20);
            this.lblFin.TabIndex = 8;
            this.lblFin.Text = "Fin le";
            this.lblFin.Visible = false;
            // 
            // lblCompteRendu
            // 
            this.lblCompteRendu.AutoSize = true;
            this.lblCompteRendu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompteRendu.Location = new System.Drawing.Point(97, 101);
            this.lblCompteRendu.MaximumSize = new System.Drawing.Size(600, 50);
            this.lblCompteRendu.Name = "lblCompteRendu";
            this.lblCompteRendu.Size = new System.Drawing.Size(594, 50);
            this.lblCompteRendu.TabIndex = 9;
            this.lblCompteRendu.Text = "Compte Rendu aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
    "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            this.lblCompteRendu.Visible = false;
            // 
            // btnPDF
            // 
            this.btnPDF.BackgroundImage = global::WGM.Properties.Resources.downloadPDF;
            this.btnPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPDF.Location = new System.Drawing.Point(697, 70);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(60, 60);
            this.btnPDF.TabIndex = 7;
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnCloture
            // 
            this.btnCloture.BackgroundImage = global::WGM.Properties.Resources.FireManThumbsUp;
            this.btnCloture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloture.Location = new System.Drawing.Point(697, 3);
            this.btnCloture.Name = "btnCloture";
            this.btnCloture.Size = new System.Drawing.Size(60, 60);
            this.btnCloture.TabIndex = 6;
            this.btnCloture.UseVisualStyleBackColor = false;
            this.btnCloture.Click += new System.EventHandler(this.btnCloture_Click);
            // 
            // pboAlert
            // 
            this.pboAlert.BackgroundImage = global::WGM.Properties.Resources.Alert;
            this.pboAlert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboAlert.Location = new System.Drawing.Point(5, 27);
            this.pboAlert.Name = "pboAlert";
            this.pboAlert.Size = new System.Drawing.Size(90, 90);
            this.pboAlert.TabIndex = 0;
            this.pboAlert.TabStop = false;
            // 
            // uscMissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.lblCompteRendu);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnCloture);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.lblCaserne);
            this.Controls.Add(this.lblDebut);
            this.Controls.Add(this.lblIdMission);
            this.Controls.Add(this.pboAlert);
            this.DoubleBuffered = true;
            this.Name = "uscMissions";
            this.Size = new System.Drawing.Size(760, 143);
            this.Load += new System.EventHandler(this.uscMissions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboAlert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboAlert;
        private System.Windows.Forms.Label lblIdMission;
        private System.Windows.Forms.Label lblDebut;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Button btnCloture;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label lblCompteRendu;
    }
}
