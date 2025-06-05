namespace Personnel
{
    partial class uscPersonnel
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
            this.lblPersonnel = new System.Windows.Forms.Label();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblPompier = new System.Windows.Forms.Label();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.cboPompier = new System.Windows.Forms.ComboBox();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.grpCarriere = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtBip = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.lblBip = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblEmbauche = new System.Windows.Forms.Label();
            this.rdbProfessionnel = new System.Windows.Forms.RadioButton();
            this.rdbVolontaire = new System.Windows.Forms.RadioButton();
            this.lblNaissance = new System.Windows.Forms.Label();
            this.lblSexe = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.btnAnnule = new System.Windows.Forms.Button();
            this.grpPlus = new System.Windows.Forms.GroupBox();
            this.lstAffectationPassees = new System.Windows.Forms.ListBox();
            this.lstHabilitation = new System.Windows.Forms.ListBox();
            this.btnMaj = new System.Windows.Forms.Button();
            this.chkConge = new System.Windows.Forms.CheckBox();
            this.lblAffectation = new System.Windows.Forms.Label();
            this.lblHabilitation = new System.Windows.Forms.Label();
            this.lblCaserneModif = new System.Windows.Forms.Label();
            this.cboCaserneModif = new System.Windows.Forms.ComboBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.pboGrade = new System.Windows.Forms.PictureBox();
            this.pnlTitre = new System.Windows.Forms.Panel();
            this.grpGeneral.SuspendLayout();
            this.grpCarriere.SuspendLayout();
            this.grpPlus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboGrade)).BeginInit();
            this.pnlTitre.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPersonnel
            // 
            this.lblPersonnel.AutoSize = true;
            this.lblPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonnel.Location = new System.Drawing.Point(213, 2);
            this.lblPersonnel.Name = "lblPersonnel";
            this.lblPersonnel.Size = new System.Drawing.Size(263, 29);
            this.lblPersonnel.TabIndex = 0;
            this.lblPersonnel.Text = "Gestion du personnel";
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaserne.Location = new System.Drawing.Point(1, 40);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(240, 24);
            this.lblCaserne.TabIndex = 1;
            this.lblCaserne.Text = "Sélectionnez une caserne :";
            // 
            // lblPompier
            // 
            this.lblPompier.AutoSize = true;
            this.lblPompier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPompier.Location = new System.Drawing.Point(434, 40);
            this.lblPompier.Name = "lblPompier";
            this.lblPompier.Size = new System.Drawing.Size(231, 24);
            this.lblPompier.TabIndex = 2;
            this.lblPompier.Text = "Sélectionnez un pompier :";
            // 
            // cboCaserne
            // 
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(5, 67);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(236, 24);
            this.cboCaserne.TabIndex = 3;
            this.cboCaserne.SelectedIndexChanged += new System.EventHandler(this.cboCaserne_SelectedIndexChanged);
            // 
            // cboPompier
            // 
            this.cboPompier.FormattingEnabled = true;
            this.cboPompier.Location = new System.Drawing.Point(438, 67);
            this.cboPompier.Name = "cboPompier";
            this.cboPompier.Size = new System.Drawing.Size(227, 24);
            this.cboPompier.TabIndex = 4;
            this.cboPompier.SelectedIndexChanged += new System.EventHandler(this.cboPompier_SelectedIndexChanged);
            // 
            // grpGeneral
            // 
            this.grpGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(180)))), ((int)(((byte)(149)))));
            this.grpGeneral.Controls.Add(this.pboGrade);
            this.grpGeneral.Controls.Add(this.grpCarriere);
            this.grpGeneral.Controls.Add(this.lblEmbauche);
            this.grpGeneral.Controls.Add(this.rdbProfessionnel);
            this.grpGeneral.Controls.Add(this.rdbVolontaire);
            this.grpGeneral.Controls.Add(this.lblNaissance);
            this.grpGeneral.Controls.Add(this.lblSexe);
            this.grpGeneral.Controls.Add(this.lblPrenom);
            this.grpGeneral.Controls.Add(this.lblNom);
            this.grpGeneral.Controls.Add(this.lblMatricule);
            this.grpGeneral.Location = new System.Drawing.Point(12, 111);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(775, 248);
            this.grpGeneral.TabIndex = 5;
            this.grpGeneral.TabStop = false;
            // 
            // grpCarriere
            // 
            this.grpCarriere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(213)))), ((int)(((byte)(149)))));
            this.grpCarriere.Controls.Add(this.btnEdit);
            this.grpCarriere.Controls.Add(this.txtBip);
            this.grpCarriere.Controls.Add(this.txtTelephone);
            this.grpCarriere.Controls.Add(this.txtGrade);
            this.grpCarriere.Controls.Add(this.cboGrade);
            this.grpCarriere.Controls.Add(this.lblBip);
            this.grpCarriere.Controls.Add(this.lblTelephone);
            this.grpCarriere.Controls.Add(this.lblGrade);
            this.grpCarriere.Location = new System.Drawing.Point(36, 133);
            this.grpCarriere.Name = "grpCarriere";
            this.grpCarriere.Size = new System.Drawing.Size(703, 108);
            this.grpCarriere.TabIndex = 8;
            this.grpCarriere.TabStop = false;
            this.grpCarriere.Text = "Carrière";
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Maroon;
            this.btnEdit.Location = new System.Drawing.Point(561, 17);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(116, 31);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Changer";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtBip
            // 
            this.txtBip.Location = new System.Drawing.Point(592, 67);
            this.txtBip.Name = "txtBip";
            this.txtBip.ShortcutsEnabled = false;
            this.txtBip.Size = new System.Drawing.Size(85, 22);
            this.txtBip.TabIndex = 14;
            this.txtBip.Text = "AAAAA";
            this.txtBip.Visible = false;
            this.txtBip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBip_KeyPress);
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(240, 67);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.ShortcutsEnabled = false;
            this.txtTelephone.Size = new System.Drawing.Size(127, 22);
            this.txtTelephone.TabIndex = 13;
            this.txtTelephone.Text = "AAAAAAAAAA";
            this.txtTelephone.Visible = false;
            this.txtTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelephone_KeyPress);
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(94, 28);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.ReadOnly = true;
            this.txtGrade.ShortcutsEnabled = false;
            this.txtGrade.Size = new System.Drawing.Size(100, 22);
            this.txtGrade.TabIndex = 12;
            this.txtGrade.Text = "AAAAAA";
            this.txtGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGrade_KeyPress);
            // 
            // cboGrade
            // 
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(207, 28);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(160, 24);
            this.cboGrade.TabIndex = 7;
            this.cboGrade.Visible = false;
            // 
            // lblBip
            // 
            this.lblBip.AutoSize = true;
            this.lblBip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBip.Location = new System.Drawing.Point(476, 67);
            this.lblBip.Name = "lblBip";
            this.lblBip.Size = new System.Drawing.Size(93, 20);
            this.lblBip.TabIndex = 11;
            this.lblBip.Text = "Bip : AAAA";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(23, 67);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(211, 20);
            this.lblTelephone.TabIndex = 10;
            this.lblTelephone.Text = "Téléphone : AAAAAAAAAA";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(23, 28);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(65, 20);
            this.lblGrade.TabIndex = 9;
            this.lblGrade.Text = "Grade :";
            // 
            // lblEmbauche
            // 
            this.lblEmbauche.AutoSize = true;
            this.lblEmbauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmbauche.Location = new System.Drawing.Point(476, 98);
            this.lblEmbauche.Name = "lblEmbauche";
            this.lblEmbauche.Size = new System.Drawing.Size(253, 20);
            this.lblEmbauche.TabIndex = 7;
            this.lblEmbauche.Text = "Date d\'embauche : AA/AA/AAAA";
            // 
            // rdbProfessionnel
            // 
            this.rdbProfessionnel.AutoSize = true;
            this.rdbProfessionnel.Checked = true;
            this.rdbProfessionnel.Enabled = false;
            this.rdbProfessionnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbProfessionnel.Location = new System.Drawing.Point(480, 70);
            this.rdbProfessionnel.Name = "rdbProfessionnel";
            this.rdbProfessionnel.Size = new System.Drawing.Size(132, 24);
            this.rdbProfessionnel.TabIndex = 6;
            this.rdbProfessionnel.TabStop = true;
            this.rdbProfessionnel.Text = "Professionnel";
            this.rdbProfessionnel.UseVisualStyleBackColor = true;
            // 
            // rdbVolontaire
            // 
            this.rdbVolontaire.AutoSize = true;
            this.rdbVolontaire.Enabled = false;
            this.rdbVolontaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbVolontaire.Location = new System.Drawing.Point(620, 70);
            this.rdbVolontaire.Name = "rdbVolontaire";
            this.rdbVolontaire.Size = new System.Drawing.Size(105, 24);
            this.rdbVolontaire.TabIndex = 5;
            this.rdbVolontaire.Text = "Volontaire";
            this.rdbVolontaire.UseVisualStyleBackColor = true;
            // 
            // lblNaissance
            // 
            this.lblNaissance.AutoSize = true;
            this.lblNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaissance.Location = new System.Drawing.Point(476, 47);
            this.lblNaissance.Name = "lblNaissance";
            this.lblNaissance.Size = new System.Drawing.Size(262, 20);
            this.lblNaissance.TabIndex = 4;
            this.lblNaissance.Text = "Date de naissance : AA/AA/AAAA";
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexe.Location = new System.Drawing.Point(26, 98);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(128, 20);
            this.lblSexe.TabIndex = 3;
            this.lblSexe.Text = "Sexe : Masculin";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(26, 72);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(181, 20);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom : AAAAAAAAA";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(26, 47);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(180, 20);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom : AAAAAAAAAAA";
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricule.Location = new System.Drawing.Point(281, 10);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(149, 20);
            this.lblMatricule.TabIndex = 0;
            this.lblMatricule.Text = "Matricule AAAAAA";
            // 
            // btnAnnule
            // 
            this.btnAnnule.BackColor = System.Drawing.Color.MistyRose;
            this.btnAnnule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnule.ForeColor = System.Drawing.Color.Maroon;
            this.btnAnnule.Location = new System.Drawing.Point(445, 172);
            this.btnAnnule.Name = "btnAnnule";
            this.btnAnnule.Size = new System.Drawing.Size(116, 31);
            this.btnAnnule.TabIndex = 16;
            this.btnAnnule.Text = "Annuler";
            this.btnAnnule.UseVisualStyleBackColor = false;
            this.btnAnnule.Visible = false;
            this.btnAnnule.Click += new System.EventHandler(this.btnAnnule_Click);
            // 
            // grpPlus
            // 
            this.grpPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(213)))), ((int)(((byte)(149)))));
            this.grpPlus.Controls.Add(this.lstAffectationPassees);
            this.grpPlus.Controls.Add(this.btnAnnule);
            this.grpPlus.Controls.Add(this.lstHabilitation);
            this.grpPlus.Controls.Add(this.btnMaj);
            this.grpPlus.Controls.Add(this.chkConge);
            this.grpPlus.Controls.Add(this.lblAffectation);
            this.grpPlus.Controls.Add(this.lblHabilitation);
            this.grpPlus.Controls.Add(this.lblCaserneModif);
            this.grpPlus.Controls.Add(this.cboCaserneModif);
            this.grpPlus.Location = new System.Drawing.Point(12, 365);
            this.grpPlus.Name = "grpPlus";
            this.grpPlus.Size = new System.Drawing.Size(775, 221);
            this.grpPlus.TabIndex = 6;
            this.grpPlus.TabStop = false;
            this.grpPlus.Text = "Information carrière";
            this.grpPlus.Visible = false;
            // 
            // lstAffectationPassees
            // 
            this.lstAffectationPassees.FormattingEnabled = true;
            this.lstAffectationPassees.ItemHeight = 16;
            this.lstAffectationPassees.Location = new System.Drawing.Point(393, 82);
            this.lstAffectationPassees.Name = "lstAffectationPassees";
            this.lstAffectationPassees.ScrollAlwaysVisible = true;
            this.lstAffectationPassees.Size = new System.Drawing.Size(365, 84);
            this.lstAffectationPassees.TabIndex = 23;
            // 
            // lstHabilitation
            // 
            this.lstHabilitation.FormattingEnabled = true;
            this.lstHabilitation.ItemHeight = 16;
            this.lstHabilitation.Location = new System.Drawing.Point(18, 82);
            this.lstHabilitation.Name = "lstHabilitation";
            this.lstHabilitation.ScrollAlwaysVisible = true;
            this.lstHabilitation.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstHabilitation.Size = new System.Drawing.Size(365, 84);
            this.lstHabilitation.TabIndex = 17;
            // 
            // btnMaj
            // 
            this.btnMaj.BackColor = System.Drawing.Color.Honeydew;
            this.btnMaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaj.ForeColor = System.Drawing.Color.Green;
            this.btnMaj.Location = new System.Drawing.Point(578, 172);
            this.btnMaj.Name = "btnMaj";
            this.btnMaj.Size = new System.Drawing.Size(179, 31);
            this.btnMaj.TabIndex = 22;
            this.btnMaj.Text = "Mettre à jour";
            this.btnMaj.UseVisualStyleBackColor = false;
            this.btnMaj.Click += new System.EventHandler(this.btnMaj_Click);
            // 
            // chkConge
            // 
            this.chkConge.AutoSize = true;
            this.chkConge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConge.Location = new System.Drawing.Point(30, 172);
            this.chkConge.Name = "chkConge";
            this.chkConge.Size = new System.Drawing.Size(117, 29);
            this.chkConge.TabIndex = 21;
            this.chkConge.Text = "En congé";
            this.chkConge.UseVisualStyleBackColor = true;
            // 
            // lblAffectation
            // 
            this.lblAffectation.AutoSize = true;
            this.lblAffectation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAffectation.Location = new System.Drawing.Point(491, 58);
            this.lblAffectation.Name = "lblAffectation";
            this.lblAffectation.Size = new System.Drawing.Size(171, 20);
            this.lblAffectation.TabIndex = 19;
            this.lblAffectation.Text = "Affectations passées:";
            // 
            // lblHabilitation
            // 
            this.lblHabilitation.AutoSize = true;
            this.lblHabilitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabilitation.Location = new System.Drawing.Point(126, 58);
            this.lblHabilitation.Name = "lblHabilitation";
            this.lblHabilitation.Size = new System.Drawing.Size(112, 20);
            this.lblHabilitation.TabIndex = 17;
            this.lblHabilitation.Text = "Habilitations :";
            // 
            // lblCaserneModif
            // 
            this.lblCaserneModif.AutoSize = true;
            this.lblCaserneModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaserneModif.Location = new System.Drawing.Point(14, 23);
            this.lblCaserneModif.Name = "lblCaserneModif";
            this.lblCaserneModif.Size = new System.Drawing.Size(82, 20);
            this.lblCaserneModif.TabIndex = 9;
            this.lblCaserneModif.Text = "Caserne :";
            // 
            // cboCaserneModif
            // 
            this.cboCaserneModif.FormattingEnabled = true;
            this.cboCaserneModif.Location = new System.Drawing.Point(102, 23);
            this.cboCaserneModif.Name = "cboCaserneModif";
            this.cboCaserneModif.Size = new System.Drawing.Size(245, 24);
            this.cboCaserneModif.TabIndex = 16;
            // 
            // btnPlus
            // 
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(590, 361);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(180, 31);
            this.btnPlus.TabIndex = 16;
            this.btnPlus.Text = "Plus d\'informations";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // pboGrade
            // 
            this.pboGrade.BackgroundImage = global::WGM.Properties.Resources.SGT;
            this.pboGrade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboGrade.Location = new System.Drawing.Point(303, 32);
            this.pboGrade.Name = "pboGrade";
            this.pboGrade.Size = new System.Drawing.Size(100, 100);
            this.pboGrade.TabIndex = 9;
            this.pboGrade.TabStop = false;
            // 
            // pnlTitre
            // 
            this.pnlTitre.Controls.Add(this.cboPompier);
            this.pnlTitre.Controls.Add(this.cboCaserne);
            this.pnlTitre.Controls.Add(this.lblPersonnel);
            this.pnlTitre.Controls.Add(this.lblPompier);
            this.pnlTitre.Controls.Add(this.lblCaserne);
            this.pnlTitre.Location = new System.Drawing.Point(70, 8);
            this.pnlTitre.Name = "pnlTitre";
            this.pnlTitre.Size = new System.Drawing.Size(667, 97);
            this.pnlTitre.TabIndex = 18;
            // 
            // uscPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.Controls.Add(this.pnlTitre);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.grpPlus);
            this.Controls.Add(this.grpGeneral);
            this.Name = "uscPersonnel";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.uscPersonnel_Load);
            this.SizeChanged += new System.EventHandler(this.uscPersonnel_SizeChanged);
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.grpCarriere.ResumeLayout(false);
            this.grpCarriere.PerformLayout();
            this.grpPlus.ResumeLayout(false);
            this.grpPlus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboGrade)).EndInit();
            this.pnlTitre.ResumeLayout(false);
            this.pnlTitre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPersonnel;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Label lblPompier;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.ComboBox cboPompier;
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.GroupBox grpPlus;
        private System.Windows.Forms.RadioButton rdbVolontaire;
        private System.Windows.Forms.Label lblNaissance;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.GroupBox grpCarriere;
        private System.Windows.Forms.Label lblEmbauche;
        private System.Windows.Forms.RadioButton rdbProfessionnel;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.Label lblBip;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtBip;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblCaserneModif;
        private System.Windows.Forms.ComboBox cboCaserneModif;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label lblAffectation;
        private System.Windows.Forms.Label lblHabilitation;
        private System.Windows.Forms.Button btnMaj;
        private System.Windows.Forms.CheckBox chkConge;
        private System.Windows.Forms.Button btnAnnule;
        private System.Windows.Forms.PictureBox pboGrade;
        private System.Windows.Forms.ListBox lstAffectationPassees;
        private System.Windows.Forms.ListBox lstHabilitation;
        private System.Windows.Forms.Panel pnlTitre;
    }
}
