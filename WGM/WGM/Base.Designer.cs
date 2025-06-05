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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBase));
            this.btnQuitter = new System.Windows.Forms.Button();
            this.grbMenu = new System.Windows.Forms.GroupBox();
            this.flpOnglets = new System.Windows.Forms.FlowLayoutPanel();
            this.pboIcone = new System.Windows.Forms.PictureBox();
            this.flpDashboard = new System.Windows.Forms.FlowLayoutPanel();
            this.pboDashboard = new System.Windows.Forms.PictureBox();
            this.btnTableauDeBord = new System.Windows.Forms.Button();
            this.flpEngin = new System.Windows.Forms.FlowLayoutPanel();
            this.pboEngin = new System.Windows.Forms.PictureBox();
            this.btnEngins = new System.Windows.Forms.Button();
            this.flpPersonnel = new System.Windows.Forms.FlowLayoutPanel();
            this.pboPersonnel = new System.Windows.Forms.PictureBox();
            this.btnPersonnel = new System.Windows.Forms.Button();
            this.flpStats = new System.Windows.Forms.FlowLayoutPanel();
            this.pboStats = new System.Windows.Forms.PictureBox();
            this.btnStatistiques = new System.Windows.Forms.Button();
            this.pnlPage = new System.Windows.Forms.Panel();
            this.grbMenu.SuspendLayout();
            this.flpOnglets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboIcone)).BeginInit();
            this.flpDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboDashboard)).BeginInit();
            this.flpEngin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboEngin)).BeginInit();
            this.flpPersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboPersonnel)).BeginInit();
            this.flpStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboStats)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQuitter.BackgroundImage = global::WGM.Properties.Resources.fire_exit;
            this.btnQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitter.Location = new System.Drawing.Point(28, 507);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(147, 85);
            this.btnQuitter.TabIndex = 0;
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // grbMenu
            // 
            this.grbMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grbMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.grbMenu.Controls.Add(this.flpOnglets);
            this.grbMenu.Controls.Add(this.btnQuitter);
            this.grbMenu.Location = new System.Drawing.Point(12, 12);
            this.grbMenu.Name = "grbMenu";
            this.grbMenu.Size = new System.Drawing.Size(205, 623);
            this.grbMenu.TabIndex = 1;
            this.grbMenu.TabStop = false;
            // 
            // flpOnglets
            // 
            this.flpOnglets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flpOnglets.Controls.Add(this.pboIcone);
            this.flpOnglets.Controls.Add(this.flpDashboard);
            this.flpOnglets.Controls.Add(this.flpEngin);
            this.flpOnglets.Controls.Add(this.flpPersonnel);
            this.flpOnglets.Controls.Add(this.flpStats);
            this.flpOnglets.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpOnglets.Location = new System.Drawing.Point(6, 14);
            this.flpOnglets.Name = "flpOnglets";
            this.flpOnglets.Size = new System.Drawing.Size(193, 487);
            this.flpOnglets.TabIndex = 17;
            this.flpOnglets.WrapContents = false;
            // 
            // pboIcone
            // 
            this.pboIcone.BackgroundImage = global::WGM.Properties.Resources.appli;
            this.pboIcone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pboIcone.Dock = System.Windows.Forms.DockStyle.Top;
            this.pboIcone.Location = new System.Drawing.Point(3, 3);
            this.pboIcone.Name = "pboIcone";
            this.pboIcone.Size = new System.Drawing.Size(190, 70);
            this.pboIcone.TabIndex = 17;
            this.pboIcone.TabStop = false;
            // 
            // flpDashboard
            // 
            this.flpDashboard.Controls.Add(this.pboDashboard);
            this.flpDashboard.Controls.Add(this.btnTableauDeBord);
            this.flpDashboard.Location = new System.Drawing.Point(3, 79);
            this.flpDashboard.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.flpDashboard.Name = "flpDashboard";
            this.flpDashboard.Size = new System.Drawing.Size(190, 57);
            this.flpDashboard.TabIndex = 13;
            // 
            // pboDashboard
            // 
            this.pboDashboard.BackgroundImage = global::WGM.Properties.Resources.tasks;
            this.pboDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboDashboard.Location = new System.Drawing.Point(3, 3);
            this.pboDashboard.Name = "pboDashboard";
            this.pboDashboard.Size = new System.Drawing.Size(50, 50);
            this.pboDashboard.TabIndex = 5;
            this.pboDashboard.TabStop = false;
            // 
            // btnTableauDeBord
            // 
            this.btnTableauDeBord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTableauDeBord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(213)))), ((int)(((byte)(149)))));
            this.btnTableauDeBord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTableauDeBord.Location = new System.Drawing.Point(59, 3);
            this.btnTableauDeBord.Name = "btnTableauDeBord";
            this.btnTableauDeBord.Size = new System.Drawing.Size(123, 50);
            this.btnTableauDeBord.TabIndex = 1;
            this.btnTableauDeBord.Text = "Tableau de Bord";
            this.btnTableauDeBord.UseVisualStyleBackColor = false;
            this.btnTableauDeBord.Click += new System.EventHandler(this.btnTableauDeBord_Click);
            // 
            // flpEngin
            // 
            this.flpEngin.Controls.Add(this.pboEngin);
            this.flpEngin.Controls.Add(this.btnEngins);
            this.flpEngin.Location = new System.Drawing.Point(3, 159);
            this.flpEngin.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.flpEngin.Name = "flpEngin";
            this.flpEngin.Size = new System.Drawing.Size(190, 57);
            this.flpEngin.TabIndex = 14;
            // 
            // pboEngin
            // 
            this.pboEngin.BackgroundImage = global::WGM.Properties.Resources.firetruck;
            this.pboEngin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboEngin.Location = new System.Drawing.Point(3, 3);
            this.pboEngin.Name = "pboEngin";
            this.pboEngin.Size = new System.Drawing.Size(50, 50);
            this.pboEngin.TabIndex = 6;
            this.pboEngin.TabStop = false;
            // 
            // btnEngins
            // 
            this.btnEngins.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEngins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(213)))), ((int)(((byte)(149)))));
            this.btnEngins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEngins.Location = new System.Drawing.Point(59, 3);
            this.btnEngins.Name = "btnEngins";
            this.btnEngins.Size = new System.Drawing.Size(123, 50);
            this.btnEngins.TabIndex = 2;
            this.btnEngins.Text = "Gestion des engins";
            this.btnEngins.UseVisualStyleBackColor = false;
            this.btnEngins.Click += new System.EventHandler(this.btnEngins_Click);
            // 
            // flpPersonnel
            // 
            this.flpPersonnel.Controls.Add(this.pboPersonnel);
            this.flpPersonnel.Controls.Add(this.btnPersonnel);
            this.flpPersonnel.Location = new System.Drawing.Point(3, 239);
            this.flpPersonnel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.flpPersonnel.Name = "flpPersonnel";
            this.flpPersonnel.Size = new System.Drawing.Size(190, 57);
            this.flpPersonnel.TabIndex = 15;
            // 
            // pboPersonnel
            // 
            this.pboPersonnel.BackgroundImage = global::WGM.Properties.Resources.firefighter2;
            this.pboPersonnel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboPersonnel.Location = new System.Drawing.Point(3, 3);
            this.pboPersonnel.Name = "pboPersonnel";
            this.pboPersonnel.Size = new System.Drawing.Size(50, 50);
            this.pboPersonnel.TabIndex = 7;
            this.pboPersonnel.TabStop = false;
            // 
            // btnPersonnel
            // 
            this.btnPersonnel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPersonnel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(213)))), ((int)(((byte)(149)))));
            this.btnPersonnel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonnel.Location = new System.Drawing.Point(59, 3);
            this.btnPersonnel.Name = "btnPersonnel";
            this.btnPersonnel.Size = new System.Drawing.Size(123, 50);
            this.btnPersonnel.TabIndex = 4;
            this.btnPersonnel.Text = "Gestion du personnel";
            this.btnPersonnel.UseVisualStyleBackColor = false;
            this.btnPersonnel.Click += new System.EventHandler(this.btnPersonnel_Click);
            // 
            // flpStats
            // 
            this.flpStats.Controls.Add(this.pboStats);
            this.flpStats.Controls.Add(this.btnStatistiques);
            this.flpStats.Location = new System.Drawing.Point(3, 319);
            this.flpStats.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.flpStats.Name = "flpStats";
            this.flpStats.Size = new System.Drawing.Size(190, 57);
            this.flpStats.TabIndex = 16;
            // 
            // pboStats
            // 
            this.pboStats.BackgroundImage = global::WGM.Properties.Resources.statistical;
            this.pboStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboStats.Location = new System.Drawing.Point(3, 3);
            this.pboStats.Name = "pboStats";
            this.pboStats.Size = new System.Drawing.Size(50, 50);
            this.pboStats.TabIndex = 8;
            this.pboStats.TabStop = false;
            // 
            // btnStatistiques
            // 
            this.btnStatistiques.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatistiques.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(213)))), ((int)(((byte)(149)))));
            this.btnStatistiques.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStatistiques.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistiques.Location = new System.Drawing.Point(59, 3);
            this.btnStatistiques.Name = "btnStatistiques";
            this.btnStatistiques.Size = new System.Drawing.Size(123, 50);
            this.btnStatistiques.TabIndex = 3;
            this.btnStatistiques.Text = "Statistique";
            this.btnStatistiques.UseVisualStyleBackColor = false;
            // 
            // pnlPage
            // 
            this.pnlPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPage.BackColor = System.Drawing.Color.Transparent;
            this.pnlPage.Location = new System.Drawing.Point(223, 11);
            this.pnlPage.Name = "pnlPage";
            this.pnlPage.Size = new System.Drawing.Size(872, 624);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBase";
            this.Text = "Combattant du feu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbMenu.ResumeLayout(false);
            this.flpOnglets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboIcone)).EndInit();
            this.flpDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboDashboard)).EndInit();
            this.flpEngin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboEngin)).EndInit();
            this.flpPersonnel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboPersonnel)).EndInit();
            this.flpStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboStats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.GroupBox grbMenu;
        private System.Windows.Forms.Button btnPersonnel;
        private System.Windows.Forms.Button btnStatistiques;
        private System.Windows.Forms.Button btnEngins;
        private System.Windows.Forms.Panel pnlPage;
        private System.Windows.Forms.PictureBox pboStats;
        private System.Windows.Forms.PictureBox pboPersonnel;
        private System.Windows.Forms.PictureBox pboEngin;
        private System.Windows.Forms.PictureBox pboDashboard;
        private System.Windows.Forms.Button btnTableauDeBord;
        private System.Windows.Forms.FlowLayoutPanel flpOnglets;
        private System.Windows.Forms.FlowLayoutPanel flpStats;
        private System.Windows.Forms.FlowLayoutPanel flpPersonnel;
        private System.Windows.Forms.FlowLayoutPanel flpEngin;
        private System.Windows.Forms.FlowLayoutPanel flpDashboard;
        private System.Windows.Forms.PictureBox pboIcone;
    }
}

