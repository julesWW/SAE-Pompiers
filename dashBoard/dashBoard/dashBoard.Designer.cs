namespace dashBoard
{
    partial class uscdashBoard
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
            this.lblDashBoard = new System.Windows.Forms.Label();
            this.btnNouvelle = new System.Windows.Forms.Button();
            this.chkEnCours = new System.Windows.Forms.CheckBox();
            this.flpMissions = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTitre = new System.Windows.Forms.Panel();
            this.pnlTitre.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDashBoard
            // 
            this.lblDashBoard.AutoSize = true;
            this.lblDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashBoard.ForeColor = System.Drawing.Color.Black;
            this.lblDashBoard.Location = new System.Drawing.Point(234, 25);
            this.lblDashBoard.Name = "lblDashBoard";
            this.lblDashBoard.Size = new System.Drawing.Size(207, 29);
            this.lblDashBoard.TabIndex = 0;
            this.lblDashBoard.Text = "Tableau de bord";
            // 
            // btnNouvelle
            // 
            this.btnNouvelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(213)))), ((int)(((byte)(149)))));
            this.btnNouvelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNouvelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouvelle.Location = new System.Drawing.Point(578, 8);
            this.btnNouvelle.Name = "btnNouvelle";
            this.btnNouvelle.Size = new System.Drawing.Size(137, 64);
            this.btnNouvelle.TabIndex = 1;
            this.btnNouvelle.Text = "Nouvelle mission";
            this.btnNouvelle.UseVisualStyleBackColor = false;
            this.btnNouvelle.Click += new System.EventHandler(this.btnNouvelle_Click);
            // 
            // chkEnCours
            // 
            this.chkEnCours.AutoSize = true;
            this.chkEnCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnCours.ForeColor = System.Drawing.Color.Black;
            this.chkEnCours.Location = new System.Drawing.Point(4, 27);
            this.chkEnCours.Name = "chkEnCours";
            this.chkEnCours.Size = new System.Drawing.Size(111, 29);
            this.chkEnCours.TabIndex = 2;
            this.chkEnCours.Text = "En cours";
            this.chkEnCours.UseVisualStyleBackColor = true;
            this.chkEnCours.CheckedChanged += new System.EventHandler(this.chkEnCours_CheckedChanged);
            // 
            // flpMissions
            // 
            this.flpMissions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpMissions.AutoScroll = true;
            this.flpMissions.Location = new System.Drawing.Point(3, 85);
            this.flpMissions.Name = "flpMissions";
            this.flpMissions.Size = new System.Drawing.Size(862, 537);
            this.flpMissions.TabIndex = 3;
            // 
            // pnlTitre
            // 
            this.pnlTitre.Controls.Add(this.chkEnCours);
            this.pnlTitre.Controls.Add(this.btnNouvelle);
            this.pnlTitre.Controls.Add(this.lblDashBoard);
            this.pnlTitre.Location = new System.Drawing.Point(69, 9);
            this.pnlTitre.Name = "pnlTitre";
            this.pnlTitre.Size = new System.Drawing.Size(720, 76);
            this.pnlTitre.TabIndex = 4;
            // 
            // uscdashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.Controls.Add(this.pnlTitre);
            this.Controls.Add(this.flpMissions);
            this.Name = "uscdashBoard";
            this.Size = new System.Drawing.Size(868, 622);
            this.Load += new System.EventHandler(this.uscdashBoard_Load);
            this.SizeChanged += new System.EventHandler(this.uscdashBoard_SizeChanged);
            this.pnlTitre.ResumeLayout(false);
            this.pnlTitre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDashBoard;
        private System.Windows.Forms.Button btnNouvelle;
        private System.Windows.Forms.CheckBox chkEnCours;
        private System.Windows.Forms.FlowLayoutPanel flpMissions;
        private System.Windows.Forms.Panel pnlTitre;
    }
}
