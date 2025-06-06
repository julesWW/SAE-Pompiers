namespace WGM
{
    partial class frmNouvMission
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNoMission = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtCodePost = new System.Windows.Forms.TextBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.lblAddr = new System.Windows.Forms.Label();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.grpDecision = new System.Windows.Forms.GroupBox();
            this.btnConsult = new System.Windows.Forms.Button();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.cboSinistre = new System.Windows.Forms.ComboBox();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblNature = new System.Windows.Forms.Label();
            this.grpMobilisation = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEnginsMobil = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.lstEngins = new System.Windows.Forms.ListBox();
            this.lstPompier = new System.Windows.Forms.ListBox();
            this.grpInfo.SuspendLayout();
            this.grpDecision.SuspendLayout();
            this.grpMobilisation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNoMission
            // 
            this.lblNoMission.AutoSize = true;
            this.lblNoMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoMission.Location = new System.Drawing.Point(186, 9);
            this.lblNoMission.Name = "lblNoMission";
            this.lblNoMission.Size = new System.Drawing.Size(103, 25);
            this.lblNoMission.TabIndex = 0;
            this.lblNoMission.Text = "Mission n°";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(416, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(141, 25);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Déclenché le : ";
            // 
            // grpInfo
            // 
            this.grpInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(180)))), ((int)(((byte)(149)))));
            this.grpInfo.Controls.Add(this.txtVille);
            this.grpInfo.Controls.Add(this.txtCodePost);
            this.grpInfo.Controls.Add(this.txtRue);
            this.grpInfo.Controls.Add(this.lblVille);
            this.grpInfo.Controls.Add(this.lblCodePostal);
            this.grpInfo.Controls.Add(this.lblRue);
            this.grpInfo.Controls.Add(this.lblAddr);
            this.grpInfo.Controls.Add(this.txtMotif);
            this.grpInfo.Controls.Add(this.lblMotif);
            this.grpInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfo.Location = new System.Drawing.Point(113, 47);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(664, 168);
            this.grpInfo.TabIndex = 2;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Informations usager";
            // 
            // txtVille
            // 
            this.txtVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVille.Location = new System.Drawing.Point(450, 112);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(183, 27);
            this.txtVille.TabIndex = 8;
            // 
            // txtCodePost
            // 
            this.txtCodePost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodePost.Location = new System.Drawing.Point(450, 79);
            this.txtCodePost.Name = "txtCodePost";
            this.txtCodePost.Size = new System.Drawing.Size(100, 27);
            this.txtCodePost.TabIndex = 7;
            // 
            // txtRue
            // 
            this.txtRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRue.Location = new System.Drawing.Point(450, 46);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(183, 27);
            this.txtRue.TabIndex = 6;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.Location = new System.Drawing.Point(393, 115);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(51, 20);
            this.lblVille.TabIndex = 5;
            this.lblVille.Text = "Ville :";
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.AutoSize = true;
            this.lblCodePostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodePostal.Location = new System.Drawing.Point(329, 82);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(117, 20);
            this.lblCodePostal.TabIndex = 4;
            this.lblCodePostal.Text = "Code postale :";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRue.Location = new System.Drawing.Point(395, 49);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(49, 20);
            this.lblRue.TabIndex = 3;
            this.lblRue.Text = "Rue :";
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddr.Location = new System.Drawing.Point(464, 24);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(133, 20);
            this.lblAddr.TabIndex = 2;
            this.lblAddr.Text = "Adresse Sinistre";
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(78, 51);
            this.txtMotif.Multiline = true;
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(232, 94);
            this.txtMotif.TabIndex = 1;
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotif.Location = new System.Drawing.Point(18, 51);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(56, 20);
            this.lblMotif.TabIndex = 0;
            this.lblMotif.Text = "Motif :";
            // 
            // grpDecision
            // 
            this.grpDecision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(180)))), ((int)(((byte)(149)))));
            this.grpDecision.Controls.Add(this.btnConsult);
            this.grpDecision.Controls.Add(this.cboCaserne);
            this.grpDecision.Controls.Add(this.cboSinistre);
            this.grpDecision.Controls.Add(this.lblCaserne);
            this.grpDecision.Controls.Add(this.lblNature);
            this.grpDecision.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDecision.Location = new System.Drawing.Point(113, 221);
            this.grpDecision.Name = "grpDecision";
            this.grpDecision.Size = new System.Drawing.Size(664, 140);
            this.grpDecision.TabIndex = 3;
            this.grpDecision.TabStop = false;
            this.grpDecision.Text = "Décision du régulateur";
            // 
            // btnConsult
            // 
            this.btnConsult.Location = new System.Drawing.Point(541, 43);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(92, 52);
            this.btnConsult.TabIndex = 5;
            this.btnConsult.Text = "Créer équipe";
            this.btnConsult.UseVisualStyleBackColor = true;
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // cboCaserne
            // 
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(179, 72);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(279, 28);
            this.cboCaserne.TabIndex = 3;
            this.cboCaserne.SelectedIndexChanged += new System.EventHandler(this.cboSinistre_SelectedIndexChanged);
            // 
            // cboSinistre
            // 
            this.cboSinistre.FormattingEnabled = true;
            this.cboSinistre.Location = new System.Drawing.Point(173, 26);
            this.cboSinistre.Name = "cboSinistre";
            this.cboSinistre.Size = new System.Drawing.Size(285, 28);
            this.cboSinistre.TabIndex = 2;
            this.cboSinistre.SelectedIndexChanged += new System.EventHandler(this.cboSinistre_SelectedIndexChanged);
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaserne.Location = new System.Drawing.Point(4, 75);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(169, 20);
            this.lblCaserne.TabIndex = 1;
            this.lblCaserne.Text = "Caserne a mobiliser :";
            // 
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNature.Location = new System.Drawing.Point(15, 29);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(152, 20);
            this.lblNature.TabIndex = 0;
            this.lblNature.Text = "Nature du sinistre :";
            // 
            // grpMobilisation
            // 
            this.grpMobilisation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(180)))), ((int)(((byte)(149)))));
            this.grpMobilisation.Controls.Add(this.lstPompier);
            this.grpMobilisation.Controls.Add(this.lstEngins);
            this.grpMobilisation.Controls.Add(this.label1);
            this.grpMobilisation.Controls.Add(this.lblEnginsMobil);
            this.grpMobilisation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMobilisation.Location = new System.Drawing.Point(35, 372);
            this.grpMobilisation.Name = "grpMobilisation";
            this.grpMobilisation.Size = new System.Drawing.Size(819, 257);
            this.grpMobilisation.TabIndex = 4;
            this.grpMobilisation.TabStop = false;
            this.grpMobilisation.Text = "Mobilisation des engins et des pompiers";
            this.grpMobilisation.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pompiers mobilisés";
            // 
            // lblEnginsMobil
            // 
            this.lblEnginsMobil.AutoSize = true;
            this.lblEnginsMobil.Location = new System.Drawing.Point(74, 23);
            this.lblEnginsMobil.Name = "lblEnginsMobil";
            this.lblEnginsMobil.Size = new System.Drawing.Size(136, 20);
            this.lblEnginsMobil.TabIndex = 0;
            this.lblEnginsMobil.Text = "Engins mobilisés";
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFermer.BackColor = System.Drawing.Color.LightCoral;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(17, 635);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(103, 35);
            this.btnFermer.TabIndex = 5;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnValider
            // 
            this.btnValider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValider.BackColor = System.Drawing.Color.GreenYellow;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(739, 635);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(103, 35);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lstEngins
            // 
            this.lstEngins.FormattingEnabled = true;
            this.lstEngins.ItemHeight = 20;
            this.lstEngins.Location = new System.Drawing.Point(54, 57);
            this.lstEngins.Name = "lstEngins";
            this.lstEngins.Size = new System.Drawing.Size(181, 184);
            this.lstEngins.TabIndex = 2;
            // 
            // lstPompier
            // 
            this.lstPompier.FormattingEnabled = true;
            this.lstPompier.HorizontalScrollbar = true;
            this.lstPompier.ItemHeight = 20;
            this.lstPompier.Location = new System.Drawing.Point(310, 57);
            this.lstPompier.Name = "lstPompier";
            this.lstPompier.Size = new System.Drawing.Size(469, 184);
            this.lstPompier.TabIndex = 3;
            // 
            // frmNouvMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(864, 674);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.grpMobilisation);
            this.Controls.Add(this.grpDecision);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNoMission);
            this.Name = "frmNouvMission";
            this.Text = "Créé une nouvelle mission";
            this.Load += new System.EventHandler(this.frmNouvMission_Load);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpDecision.ResumeLayout(false);
            this.grpDecision.PerformLayout();
            this.grpMobilisation.ResumeLayout(false);
            this.grpMobilisation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoMission;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblCodePostal;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtCodePost;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.GroupBox grpDecision;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Label lblNature;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.ComboBox cboSinistre;
        private System.Windows.Forms.Button btnConsult;
        private System.Windows.Forms.GroupBox grpMobilisation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEnginsMobil;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ListBox lstEngins;
        private System.Windows.Forms.ListBox lstPompier;
    }
}