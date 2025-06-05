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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uscMissions));
            this.lblIdMission = new System.Windows.Forms.Label();
            this.lblDebut = new System.Windows.Forms.Label();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnCloture = new System.Windows.Forms.Button();
            this.pboAlert = new System.Windows.Forms.PictureBox();
            this.btnDeroule = new System.Windows.Forms.Button();
            this.rtxtCompteRendu = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboAlert)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdMission
            // 
            this.lblIdMission.AutoSize = true;
            this.lblIdMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblIdMission.Location = new System.Drawing.Point(101, 11);
            this.lblIdMission.MaximumSize = new System.Drawing.Size(400, 50);
            this.lblIdMission.Name = "lblIdMission";
            this.lblIdMission.Size = new System.Drawing.Size(397, 50);
            this.lblIdMission.TabIndex = 1;
            this.lblIdMission.Text = "id mission : 11111111111111111111111111111111111111111111111";
            // 
            // lblDebut
            // 
            this.lblDebut.AutoSize = true;
            this.lblDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDebut.Location = new System.Drawing.Point(495, 11);
            this.lblDebut.Name = "lblDebut";
            this.lblDebut.Size = new System.Drawing.Size(207, 20);
            this.lblDebut.TabIndex = 2;
            this.lblDebut.Text = "Début le 2025-03-02 14:26";
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCaserne.Location = new System.Drawing.Point(10, 154);
            this.lblCaserne.MaximumSize = new System.Drawing.Size(800, 30);
            this.lblCaserne.MinimumSize = new System.Drawing.Size(800, 30);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(800, 30);
            this.lblCaserne.TabIndex = 3;
            this.lblCaserne.Text = "Caserne : aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\r\n\r\n";
            this.lblCaserne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCategorie.Location = new System.Drawing.Point(101, 61);
            this.lblCategorie.MaximumSize = new System.Drawing.Size(650, 50);
            this.lblCategorie.MinimumSize = new System.Drawing.Size(650, 50);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(650, 50);
            this.lblCategorie.TabIndex = 4;
            this.lblCategorie.Text = "catégorie aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
    "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
    "aaaaaaa";
            this.lblCategorie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMotif.Location = new System.Drawing.Point(6, 184);
            this.lblMotif.MaximumSize = new System.Drawing.Size(810, 80);
            this.lblMotif.MinimumSize = new System.Drawing.Size(810, 80);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(810, 80);
            this.lblMotif.TabIndex = 5;
            this.lblMotif.Text = "→ Motif aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
    "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            this.lblMotif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFin.Location = new System.Drawing.Point(495, 36);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(50, 20);
            this.lblFin.TabIndex = 8;
            this.lblFin.Text = "Fin le";
            this.lblFin.Visible = false;
            // 
            // btnPDF
            // 
            this.btnPDF.BackgroundImage = global::WGM.Properties.Resources.downloadPDF;
            this.btnPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPDF.Location = new System.Drawing.Point(760, 61);
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
            this.btnCloture.Location = new System.Drawing.Point(760, 1);
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
            this.pboAlert.Location = new System.Drawing.Point(5, 11);
            this.pboAlert.Name = "pboAlert";
            this.pboAlert.Size = new System.Drawing.Size(90, 90);
            this.pboAlert.TabIndex = 0;
            this.pboAlert.TabStop = false;
            // 
            // btnDeroule
            // 
            this.btnDeroule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(213)))), ((int)(((byte)(149)))));
            this.btnDeroule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeroule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeroule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeroule.Location = new System.Drawing.Point(0, 122);
            this.btnDeroule.Name = "btnDeroule";
            this.btnDeroule.Size = new System.Drawing.Size(823, 30);
            this.btnDeroule.TabIndex = 10;
            this.btnDeroule.Tag = "Close";
            this.btnDeroule.Text = "▼";
            this.btnDeroule.UseVisualStyleBackColor = false;
            this.btnDeroule.Click += new System.EventHandler(this.btnDeroule_Click);
            // 
            // rtxtCompteRendu
            // 
            this.rtxtCompteRendu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rtxtCompteRendu.Location = new System.Drawing.Point(10, 267);
            this.rtxtCompteRendu.MaximumSize = new System.Drawing.Size(800, 150);
            this.rtxtCompteRendu.MinimumSize = new System.Drawing.Size(800, 150);
            this.rtxtCompteRendu.Name = "rtxtCompteRendu";
            this.rtxtCompteRendu.ReadOnly = true;
            this.rtxtCompteRendu.Size = new System.Drawing.Size(800, 150);
            this.rtxtCompteRendu.TabIndex = 12;
            this.rtxtCompteRendu.Text = resources.GetString("rtxtCompteRendu.Text");
            // 
            // uscMissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(180)))), ((int)(((byte)(149)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.rtxtCompteRendu);
            this.Controls.Add(this.lblCaserne);
            this.Controls.Add(this.btnDeroule);
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnCloture);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.lblDebut);
            this.Controls.Add(this.lblIdMission);
            this.Controls.Add(this.pboAlert);
            this.DoubleBuffered = true;
            this.Name = "uscMissions";
            this.Size = new System.Drawing.Size(823, 442);
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
        private System.Windows.Forms.Button btnDeroule;
        private System.Windows.Forms.RichTextBox rtxtCompteRendu;
    }
}
