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
            this.lstPompier = new System.Windows.Forms.ListBox();
            this.lstEngins = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEnginsMobil = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.grpInfo.SuspendLayout();
            this.grpDecision.SuspendLayout();
            this.grpMobilisation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNoMission
            // 
            this.lblNoMission.AutoSize = true;
            this.lblNoMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoMission.Location = new System.Drawing.Point(140, 7);
            this.lblNoMission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoMission.Name = "lblNoMission";
            this.lblNoMission.Size = new System.Drawing.Size(80, 20);
            this.lblNoMission.TabIndex = 0;
            this.lblNoMission.Text = "Mission n°";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(312, 7);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(113, 20);
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
            this.grpInfo.Location = new System.Drawing.Point(75, 38);
            this.grpInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpInfo.Size = new System.Drawing.Size(498, 136);
            this.grpInfo.TabIndex = 2;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Informations usager";
            // 
            // txtVille
            // 
            this.txtVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVille.Location = new System.Drawing.Point(338, 91);
            this.txtVille.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(138, 23);
            this.txtVille.TabIndex = 8;
            // 
            // txtCodePost
            // 
            this.txtCodePost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodePost.Location = new System.Drawing.Point(338, 64);
            this.txtCodePost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodePost.Name = "txtCodePost";
            this.txtCodePost.Size = new System.Drawing.Size(76, 23);
            this.txtCodePost.TabIndex = 7;
            // 
            // txtRue
            // 
            this.txtRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRue.Location = new System.Drawing.Point(338, 37);
            this.txtRue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(138, 23);
            this.txtRue.TabIndex = 6;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.Location = new System.Drawing.Point(295, 93);
            this.lblVille.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(42, 17);
            this.lblVille.TabIndex = 5;
            this.lblVille.Text = "Ville :";
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.AutoSize = true;
            this.lblCodePostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodePostal.Location = new System.Drawing.Point(238, 67);
            this.lblCodePostal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(99, 17);
            this.lblCodePostal.TabIndex = 4;
            this.lblCodePostal.Text = "Code postale :";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRue.Location = new System.Drawing.Point(296, 40);
            this.lblRue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(42, 17);
            this.lblRue.TabIndex = 3;
            this.lblRue.Text = "Rue :";
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddr.Location = new System.Drawing.Point(348, 20);
            this.lblAddr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(111, 17);
            this.lblAddr.TabIndex = 2;
            this.lblAddr.Text = "Adresse Sinistre";
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(58, 41);
            this.txtMotif.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMotif.Multiline = true;
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(175, 77);
            this.txtMotif.TabIndex = 1;
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotif.Location = new System.Drawing.Point(14, 41);
            this.lblMotif.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(46, 17);
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
            this.grpDecision.Location = new System.Drawing.Point(76, 180);
            this.grpDecision.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDecision.Name = "grpDecision";
            this.grpDecision.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDecision.Size = new System.Drawing.Size(498, 114);
            this.grpDecision.TabIndex = 3;
            this.grpDecision.TabStop = false;
            this.grpDecision.Text = "Décision du régulateur";
            // 
            // btnConsult
            // 
            this.btnConsult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(213)))), ((int)(((byte)(149)))));
            this.btnConsult.Location = new System.Drawing.Point(406, 35);
            this.btnConsult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(69, 42);
            this.btnConsult.TabIndex = 5;
            this.btnConsult.Text = "Créer équipe";
            this.btnConsult.UseVisualStyleBackColor = false;
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // cboCaserne
            // 
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(148, 58);
            this.cboCaserne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(215, 25);
            this.cboCaserne.TabIndex = 3;
            this.cboCaserne.SelectedIndexChanged += new System.EventHandler(this.cboSinistre_SelectedIndexChanged);
            // 
            // cboSinistre
            // 
            this.cboSinistre.FormattingEnabled = true;
            this.cboSinistre.Location = new System.Drawing.Point(148, 25);
            this.cboSinistre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboSinistre.Name = "cboSinistre";
            this.cboSinistre.Size = new System.Drawing.Size(215, 25);
            this.cboSinistre.TabIndex = 2;
            this.cboSinistre.SelectedIndexChanged += new System.EventHandler(this.cboSinistre_SelectedIndexChanged);
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaserne.Location = new System.Drawing.Point(3, 61);
            this.lblCaserne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(141, 17);
            this.lblCaserne.TabIndex = 1;
            this.lblCaserne.Text = "Caserne a mobiliser :";
            // 
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNature.Location = new System.Drawing.Point(16, 28);
            this.lblNature.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(128, 17);
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
            this.grpMobilisation.Location = new System.Drawing.Point(17, 302);
            this.grpMobilisation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpMobilisation.Name = "grpMobilisation";
            this.grpMobilisation.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpMobilisation.Size = new System.Drawing.Size(614, 209);
            this.grpMobilisation.TabIndex = 4;
            this.grpMobilisation.TabStop = false;
            this.grpMobilisation.Text = "Mobilisation des engins et des pompiers";
            this.grpMobilisation.Visible = false;
            // 
            // lstPompier
            // 
            this.lstPompier.FormattingEnabled = true;
            this.lstPompier.HorizontalScrollbar = true;
            this.lstPompier.ItemHeight = 17;
            this.lstPompier.Location = new System.Drawing.Point(232, 46);
            this.lstPompier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstPompier.Name = "lstPompier";
            this.lstPompier.Size = new System.Drawing.Size(353, 140);
            this.lstPompier.TabIndex = 3;
            // 
            // lstEngins
            // 
            this.lstEngins.FormattingEnabled = true;
            this.lstEngins.ItemHeight = 17;
            this.lstEngins.Location = new System.Drawing.Point(40, 46);
            this.lstEngins.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstEngins.Name = "lstEngins";
            this.lstEngins.Size = new System.Drawing.Size(137, 140);
            this.lstEngins.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pompiers mobilisés";
            // 
            // lblEnginsMobil
            // 
            this.lblEnginsMobil.AutoSize = true;
            this.lblEnginsMobil.Location = new System.Drawing.Point(56, 19);
            this.lblEnginsMobil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnginsMobil.Name = "lblEnginsMobil";
            this.lblEnginsMobil.Size = new System.Drawing.Size(113, 17);
            this.lblEnginsMobil.TabIndex = 0;
            this.lblEnginsMobil.Text = "Engins mobilisés";
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFermer.BackColor = System.Drawing.Color.LightCoral;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(13, 516);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(77, 28);
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
            this.btnValider.Location = new System.Drawing.Point(554, 516);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(77, 28);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // frmNouvMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(648, 548);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.grpMobilisation);
            this.Controls.Add(this.grpDecision);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNoMission);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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