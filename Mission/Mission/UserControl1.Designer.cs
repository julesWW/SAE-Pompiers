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
            this.pboAlert = new System.Windows.Forms.PictureBox();
            this.lblIdMission = new System.Windows.Forms.Label();
            this.lblDebut = new System.Windows.Forms.Label();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.btnCloture = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboAlert)).BeginInit();
            this.SuspendLayout();
            // 
            // pboAlert
            // 
            this.pboAlert.BackgroundImage = global::Mission.Properties.Resources.Alert;
            this.pboAlert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboAlert.Location = new System.Drawing.Point(3, 19);
            this.pboAlert.Name = "pboAlert";
            this.pboAlert.Size = new System.Drawing.Size(140, 140);
            this.pboAlert.TabIndex = 0;
            this.pboAlert.TabStop = false;
            // 
            // lblIdMission
            // 
            this.lblIdMission.AutoSize = true;
            this.lblIdMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMission.Location = new System.Drawing.Point(164, 31);
            this.lblIdMission.Name = "lblIdMission";
            this.lblIdMission.Size = new System.Drawing.Size(109, 25);
            this.lblIdMission.TabIndex = 1;
            this.lblIdMission.Text = "id mission :";
            // 
            // lblDebut
            // 
            this.lblDebut.AutoSize = true;
            this.lblDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebut.Location = new System.Drawing.Point(412, 31);
            this.lblDebut.Name = "lblDebut";
            this.lblDebut.Size = new System.Drawing.Size(89, 25);
            this.lblDebut.TabIndex = 2;
            this.lblDebut.Text = "Début le ";
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaserne.Location = new System.Drawing.Point(650, 31);
            this.lblCaserne.MaximumSize = new System.Drawing.Size(280, 150);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(103, 25);
            this.lblCaserne.TabIndex = 3;
            this.lblCaserne.Text = "Caserne : ";
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorie.Location = new System.Drawing.Point(180, 108);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(92, 25);
            this.lblCategorie.TabIndex = 4;
            this.lblCategorie.Text = "catégorie";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotif.Location = new System.Drawing.Point(526, 108);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(74, 25);
            this.lblMotif.TabIndex = 5;
            this.lblMotif.Text = "→Motif";
            // 
            // btnCloture
            // 
            this.btnCloture.Location = new System.Drawing.Point(937, 13);
            this.btnCloture.Name = "btnCloture";
            this.btnCloture.Size = new System.Drawing.Size(73, 70);
            this.btnCloture.TabIndex = 6;
            this.btnCloture.Text = "Cloture Mission";
            this.btnCloture.UseVisualStyleBackColor = true;
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(937, 89);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(73, 70);
            this.btnPDF.TabIndex = 7;
            this.btnPDF.Text = "PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            // 
            // uscMissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnCloture);
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.lblCaserne);
            this.Controls.Add(this.lblDebut);
            this.Controls.Add(this.lblIdMission);
            this.Controls.Add(this.pboAlert);
            this.DoubleBuffered = true;
            this.Name = "uscMissions";
            this.Size = new System.Drawing.Size(1022, 178);
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
    }
}
