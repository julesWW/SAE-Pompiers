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
            this.SuspendLayout();
            // 
            // lblDashBoard
            // 
            this.lblDashBoard.AutoSize = true;
            this.lblDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashBoard.ForeColor = System.Drawing.Color.White;
            this.lblDashBoard.Location = new System.Drawing.Point(272, 17);
            this.lblDashBoard.Name = "lblDashBoard";
            this.lblDashBoard.Size = new System.Drawing.Size(207, 29);
            this.lblDashBoard.TabIndex = 0;
            this.lblDashBoard.Text = "Tableau de bord";
            // 
            // btnNouvelle
            // 
            this.btnNouvelle.BackColor = System.Drawing.Color.LightCoral;
            this.btnNouvelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouvelle.Location = new System.Drawing.Point(615, 17);
            this.btnNouvelle.Name = "btnNouvelle";
            this.btnNouvelle.Size = new System.Drawing.Size(137, 64);
            this.btnNouvelle.TabIndex = 1;
            this.btnNouvelle.Text = "Nouvelle mission";
            this.btnNouvelle.UseVisualStyleBackColor = false;
            // 
            // chkEnCours
            // 
            this.chkEnCours.AutoSize = true;
            this.chkEnCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnCours.ForeColor = System.Drawing.Color.White;
            this.chkEnCours.Location = new System.Drawing.Point(41, 36);
            this.chkEnCours.Name = "chkEnCours";
            this.chkEnCours.Size = new System.Drawing.Size(111, 29);
            this.chkEnCours.TabIndex = 2;
            this.chkEnCours.Text = "En cours";
            this.chkEnCours.UseVisualStyleBackColor = true;
            this.chkEnCours.CheckedChanged += new System.EventHandler(this.chkEnCours_CheckedChanged);
            // 
            // flpMissions
            // 
            this.flpMissions.AutoScroll = true;
            this.flpMissions.Location = new System.Drawing.Point(4, 85);
            this.flpMissions.Name = "flpMissions";
            this.flpMissions.Size = new System.Drawing.Size(794, 505);
            this.flpMissions.TabIndex = 3;
            // 
            // uscdashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.Controls.Add(this.flpMissions);
            this.Controls.Add(this.chkEnCours);
            this.Controls.Add(this.btnNouvelle);
            this.Controls.Add(this.lblDashBoard);
            this.Name = "uscdashBoard";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.uscdashBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDashBoard;
        private System.Windows.Forms.Button btnNouvelle;
        private System.Windows.Forms.CheckBox chkEnCours;
        private System.Windows.Forms.FlowLayoutPanel flpMissions;
    }
}
