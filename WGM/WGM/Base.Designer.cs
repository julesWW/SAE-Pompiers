namespace WGM
{
    partial class frmBase
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnQuitter = new System.Windows.Forms.Button();
            this.grbMenu = new System.Windows.Forms.GroupBox();
            this.pboStats = new System.Windows.Forms.PictureBox();
            this.pboPersonnel = new System.Windows.Forms.PictureBox();
            this.pboEngin = new System.Windows.Forms.PictureBox();
            this.pboDashboard = new System.Windows.Forms.PictureBox();
            this.btnPersonnel = new System.Windows.Forms.Button();
            this.btnStatistiques = new System.Windows.Forms.Button();
            this.btnEngins = new System.Windows.Forms.Button();
            this.btnTableauDeBord = new System.Windows.Forms.Button();
            this.pnlPage = new System.Windows.Forms.Panel();
            this.grbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboPersonnel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboEngin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuitter.BackgroundImage = global::WGM.Properties.Resources.quit;
            this.btnQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuitter.Location = new System.Drawing.Point(57, 486);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(147, 85);
            this.btnQuitter.TabIndex = 0;
            this.btnQuitter.Text = "             Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // grbMenu
            // 
            this.grbMenu.BackColor = System.Drawing.Color.Brown;
            this.grbMenu.Controls.Add(this.pboStats);
            this.grbMenu.Controls.Add(this.pboPersonnel);
            this.grbMenu.Controls.Add(this.pboEngin);
            this.grbMenu.Controls.Add(this.pboDashboard);
            this.grbMenu.Controls.Add(this.btnPersonnel);
            this.grbMenu.Controls.Add(this.btnStatistiques);
            this.grbMenu.Controls.Add(this.btnEngins);
            this.grbMenu.Controls.Add(this.btnTableauDeBord);
            this.grbMenu.Controls.Add(this.btnQuitter);
            this.grbMenu.Location = new System.Drawing.Point(12, 12);
            this.grbMenu.Name = "grbMenu";
            this.grbMenu.Size = new System.Drawing.Size(268, 602);
            this.grbMenu.TabIndex = 1;
            this.grbMenu.TabStop = false;
            // 
            // pboStats
            // 
            this.pboStats.BackgroundImage = global::WGM.Properties.Resources.statistical;
            this.pboStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboStats.Location = new System.Drawing.Point(11, 235);
            this.pboStats.Name = "pboStats";
            this.pboStats.Size = new System.Drawing.Size(50, 50);
            this.pboStats.TabIndex = 8;
            this.pboStats.TabStop = false;
            // 
            // pboPersonnel
            // 
            this.pboPersonnel.BackgroundImage = global::WGM.Properties.Resources.firefighter2;
            this.pboPersonnel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboPersonnel.Location = new System.Drawing.Point(11, 179);
            this.pboPersonnel.Name = "pboPersonnel";
            this.pboPersonnel.Size = new System.Drawing.Size(50, 50);
            this.pboPersonnel.TabIndex = 7;
            this.pboPersonnel.TabStop = false;
            // 
            // pboEngin
            // 
            this.pboEngin.BackgroundImage = global::WGM.Properties.Resources.firetruck;
            this.pboEngin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboEngin.Location = new System.Drawing.Point(11, 123);
            this.pboEngin.Name = "pboEngin";
            this.pboEngin.Size = new System.Drawing.Size(50, 50);
            this.pboEngin.TabIndex = 6;
            this.pboEngin.TabStop = false;
            // 
            // pboDashboard
            // 
            this.pboDashboard.BackgroundImage = global::WGM.Properties.Resources.tasks;
            this.pboDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboDashboard.Location = new System.Drawing.Point(11, 67);
            this.pboDashboard.Name = "pboDashboard";
            this.pboDashboard.Size = new System.Drawing.Size(50, 50);
            this.pboDashboard.TabIndex = 5;
            this.pboDashboard.TabStop = false;
            // 
            // btnPersonnel
            // 
            this.btnPersonnel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPersonnel.Location = new System.Drawing.Point(71, 182);
            this.btnPersonnel.Name = "btnPersonnel";
            this.btnPersonnel.Size = new System.Drawing.Size(148, 42);
            this.btnPersonnel.TabIndex = 4;
            this.btnPersonnel.Text = "Gestion du personnel";
            this.btnPersonnel.UseVisualStyleBackColor = true;
            this.btnPersonnel.Click += new System.EventHandler(this.btnPersonnel_Click);
            // 
            // btnStatistiques
            // 
            this.btnStatistiques.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatistiques.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStatistiques.Location = new System.Drawing.Point(71, 238);
            this.btnStatistiques.Name = "btnStatistiques";
            this.btnStatistiques.Size = new System.Drawing.Size(148, 42);
            this.btnStatistiques.TabIndex = 3;
            this.btnStatistiques.Text = "Statistique";
            this.btnStatistiques.UseVisualStyleBackColor = true;
            // 
            // btnEngins
            // 
            this.btnEngins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEngins.Location = new System.Drawing.Point(71, 126);
            this.btnEngins.Name = "btnEngins";
            this.btnEngins.Size = new System.Drawing.Size(148, 42);
            this.btnEngins.TabIndex = 2;
            this.btnEngins.Text = "Gestion des engins";
            this.btnEngins.UseVisualStyleBackColor = true;
            this.btnEngins.Click += new System.EventHandler(this.btnEngins_Click);
            // 
            // btnTableauDeBord
            // 
            this.btnTableauDeBord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTableauDeBord.BackColor = System.Drawing.Color.White;
            this.btnTableauDeBord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTableauDeBord.Location = new System.Drawing.Point(71, 70);
            this.btnTableauDeBord.Name = "btnTableauDeBord";
            this.btnTableauDeBord.Size = new System.Drawing.Size(148, 42);
            this.btnTableauDeBord.TabIndex = 1;
            this.btnTableauDeBord.Text = "Tableau de Bord";
            this.btnTableauDeBord.UseVisualStyleBackColor = false;
            this.btnTableauDeBord.Click += new System.EventHandler(this.btnTableauDeBord_Click);
            // 
            // pnlPage
            // 
            this.pnlPage.BackColor = System.Drawing.Color.Transparent;
            this.pnlPage.Location = new System.Drawing.Point(259, 11);
            this.pnlPage.Name = "pnlPage";
            this.pnlPage.Size = new System.Drawing.Size(836, 624);
            this.pnlPage.TabIndex = 2;
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::WGM.Properties.Resources.fondAppliPompierV2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1094, 637);
            this.Controls.Add(this.pnlPage);
            this.Controls.Add(this.grbMenu);
            this.Name = "frmBase";
            this.Text = "Combattant du feu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboPersonnel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboEngin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboDashboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.GroupBox grbMenu;
        private System.Windows.Forms.Button btnTableauDeBord;
        private System.Windows.Forms.Button btnPersonnel;
        private System.Windows.Forms.Button btnStatistiques;
        private System.Windows.Forms.Button btnEngins;
        private System.Windows.Forms.Panel pnlPage;
        private System.Windows.Forms.PictureBox pboStats;
        private System.Windows.Forms.PictureBox pboPersonnel;
        private System.Windows.Forms.PictureBox pboEngin;
        private System.Windows.Forms.PictureBox pboDashboard;
    }
}

