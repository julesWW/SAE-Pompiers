using System;

namespace Engins
{
    partial class USC_Engins
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
            this.components = new System.ComponentModel.Container();
            this.grpChoixCaserne = new System.Windows.Forms.GroupBox();
            this.cboChoixCaserne = new System.Windows.Forms.ComboBox();
            this.lblChoixCaserne = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.cboPanne = new System.Windows.Forms.CheckBox();
            this.cboMission = new System.Windows.Forms.CheckBox();
            this.lblPanne = new System.Windows.Forms.Label();
            this.lblMission = new System.Windows.Forms.Label();
            this.pboEngin = new System.Windows.Forms.PictureBox();
            this.lblDateReceptVal = new System.Windows.Forms.Label();
            this.lblDateRecept = new System.Windows.Forms.Label();
            this.lblNumVal = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.btnPreviousPlus = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnNextPlus = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bsEngin = new System.Windows.Forms.BindingSource(this.components);
            this.lblEngin = new System.Windows.Forms.Label();
            this.pnlBoutons = new System.Windows.Forms.Panel();
            this.grpChoixCaserne.SuspendLayout();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboEngin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEngin)).BeginInit();
            this.pnlBoutons.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpChoixCaserne
            // 
            this.grpChoixCaserne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpChoixCaserne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(180)))), ((int)(((byte)(149)))));
            this.grpChoixCaserne.Controls.Add(this.cboChoixCaserne);
            this.grpChoixCaserne.Controls.Add(this.lblChoixCaserne);
            this.grpChoixCaserne.Location = new System.Drawing.Point(28, 56);
            this.grpChoixCaserne.Name = "grpChoixCaserne";
            this.grpChoixCaserne.Size = new System.Drawing.Size(823, 73);
            this.grpChoixCaserne.TabIndex = 0;
            this.grpChoixCaserne.TabStop = false;
            // 
            // cboChoixCaserne
            // 
            this.cboChoixCaserne.FormattingEnabled = true;
            this.cboChoixCaserne.Location = new System.Drawing.Point(261, 29);
            this.cboChoixCaserne.Name = "cboChoixCaserne";
            this.cboChoixCaserne.Size = new System.Drawing.Size(384, 24);
            this.cboChoixCaserne.TabIndex = 1;
            this.cboChoixCaserne.SelectedIndexChanged += new System.EventHandler(this.cboChoixCaserne_SelectedIndexChanged);
            // 
            // lblChoixCaserne
            // 
            this.lblChoixCaserne.AutoSize = true;
            this.lblChoixCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoixCaserne.Location = new System.Drawing.Point(22, 25);
            this.lblChoixCaserne.Name = "lblChoixCaserne";
            this.lblChoixCaserne.Size = new System.Drawing.Size(185, 25);
            this.lblChoixCaserne.TabIndex = 0;
            this.lblChoixCaserne.Text = "Choix de la caserne";
            // 
            // grpInfo
            // 
            this.grpInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(180)))), ((int)(((byte)(149)))));
            this.grpInfo.Controls.Add(this.cboPanne);
            this.grpInfo.Controls.Add(this.cboMission);
            this.grpInfo.Controls.Add(this.lblPanne);
            this.grpInfo.Controls.Add(this.lblMission);
            this.grpInfo.Controls.Add(this.pboEngin);
            this.grpInfo.Controls.Add(this.lblDateReceptVal);
            this.grpInfo.Controls.Add(this.lblDateRecept);
            this.grpInfo.Controls.Add(this.lblNumVal);
            this.grpInfo.Controls.Add(this.lblNum);
            this.grpInfo.Location = new System.Drawing.Point(31, 157);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(820, 344);
            this.grpInfo.TabIndex = 1;
            this.grpInfo.TabStop = false;
            // 
            // cboPanne
            // 
            this.cboPanne.AutoSize = true;
            this.cboPanne.Enabled = false;
            this.cboPanne.Location = new System.Drawing.Point(235, 251);
            this.cboPanne.Name = "cboPanne";
            this.cboPanne.Size = new System.Drawing.Size(18, 17);
            this.cboPanne.TabIndex = 8;
            this.cboPanne.UseVisualStyleBackColor = true;
            // 
            // cboMission
            // 
            this.cboMission.AutoSize = true;
            this.cboMission.Enabled = false;
            this.cboMission.Location = new System.Drawing.Point(235, 201);
            this.cboMission.Name = "cboMission";
            this.cboMission.Size = new System.Drawing.Size(18, 17);
            this.cboMission.TabIndex = 7;
            this.cboMission.UseVisualStyleBackColor = true;
            // 
            // lblPanne
            // 
            this.lblPanne.AutoSize = true;
            this.lblPanne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanne.Location = new System.Drawing.Point(35, 243);
            this.lblPanne.Name = "lblPanne";
            this.lblPanne.Size = new System.Drawing.Size(96, 25);
            this.lblPanne.TabIndex = 6;
            this.lblPanne.Text = "En panne";
            // 
            // lblMission
            // 
            this.lblMission.AutoSize = true;
            this.lblMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMission.Location = new System.Drawing.Point(35, 193);
            this.lblMission.Name = "lblMission";
            this.lblMission.Size = new System.Drawing.Size(107, 25);
            this.lblMission.TabIndex = 5;
            this.lblMission.Text = "En mission";
            // 
            // pboEngin
            // 
            this.pboEngin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboEngin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboEngin.Location = new System.Drawing.Point(483, 31);
            this.pboEngin.Name = "pboEngin";
            this.pboEngin.Size = new System.Drawing.Size(300, 216);
            this.pboEngin.TabIndex = 4;
            this.pboEngin.TabStop = false;
            // 
            // lblDateReceptVal
            // 
            this.lblDateReceptVal.AutoSize = true;
            this.lblDateReceptVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReceptVal.Location = new System.Drawing.Point(230, 115);
            this.lblDateReceptVal.Name = "lblDateReceptVal";
            this.lblDateReceptVal.Size = new System.Drawing.Size(112, 25);
            this.lblDateReceptVal.TabIndex = 3;
            this.lblDateReceptVal.Text = "00/00/0000";
            // 
            // lblDateRecept
            // 
            this.lblDateRecept.AutoSize = true;
            this.lblDateRecept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRecept.Location = new System.Drawing.Point(35, 115);
            this.lblDateRecept.Name = "lblDateRecept";
            this.lblDateRecept.Size = new System.Drawing.Size(165, 25);
            this.lblDateRecept.TabIndex = 2;
            this.lblDateRecept.Text = "Date de réception";
            // 
            // lblNumVal
            // 
            this.lblNumVal.AutoSize = true;
            this.lblNumVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumVal.Location = new System.Drawing.Point(230, 53);
            this.lblNumVal.Name = "lblNumVal";
            this.lblNumVal.Size = new System.Drawing.Size(45, 25);
            this.lblNumVal.TabIndex = 1;
            this.lblNumVal.Text = "001";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(35, 53);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(81, 25);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Numéro";
            // 
            // btnPreviousPlus
            // 
            this.btnPreviousPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(213)))), ((int)(((byte)(149)))));
            this.btnPreviousPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreviousPlus.Location = new System.Drawing.Point(4, 10);
            this.btnPreviousPlus.Name = "btnPreviousPlus";
            this.btnPreviousPlus.Size = new System.Drawing.Size(85, 85);
            this.btnPreviousPlus.TabIndex = 2;
            this.btnPreviousPlus.Text = "<<";
            this.btnPreviousPlus.UseVisualStyleBackColor = false;
            this.btnPreviousPlus.Click += new System.EventHandler(this.btnPreviousPlus_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(213)))), ((int)(((byte)(149)))));
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.Location = new System.Drawing.Point(93, 10);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(85, 85);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(213)))), ((int)(((byte)(149)))));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Location = new System.Drawing.Point(184, 10);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(85, 85);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnNextPlus
            // 
            this.btnNextPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(213)))), ((int)(((byte)(149)))));
            this.btnNextPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextPlus.Location = new System.Drawing.Point(275, 10);
            this.btnNextPlus.Name = "btnNextPlus";
            this.btnNextPlus.Size = new System.Drawing.Size(85, 85);
            this.btnNextPlus.TabIndex = 5;
            this.btnNextPlus.Text = ">>";
            this.btnNextPlus.UseVisualStyleBackColor = false;
            this.btnNextPlus.Click += new System.EventHandler(this.btnNextPlus_Click);
            // 
            // bsEngin
            // 
            this.bsEngin.PositionChanged += new System.EventHandler(this.MaJ);
            // 
            // lblEngin
            // 
            this.lblEngin.AutoSize = true;
            this.lblEngin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngin.Location = new System.Drawing.Point(261, 13);
            this.lblEngin.Name = "lblEngin";
            this.lblEngin.Size = new System.Drawing.Size(240, 29);
            this.lblEngin.TabIndex = 6;
            this.lblEngin.Text = "Gestion des Engins";
            // 
            // pnlBoutons
            // 
            this.pnlBoutons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBoutons.BackColor = System.Drawing.Color.Transparent;
            this.pnlBoutons.Controls.Add(this.btnNextPlus);
            this.pnlBoutons.Controls.Add(this.btnNext);
            this.pnlBoutons.Controls.Add(this.btnPrevious);
            this.pnlBoutons.Controls.Add(this.btnPreviousPlus);
            this.pnlBoutons.Location = new System.Drawing.Point(255, 507);
            this.pnlBoutons.Name = "pnlBoutons";
            this.pnlBoutons.Size = new System.Drawing.Size(364, 104);
            this.pnlBoutons.TabIndex = 7;
            // 
            // USC_Engins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.Controls.Add(this.pnlBoutons);
            this.Controls.Add(this.lblEngin);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.grpChoixCaserne);
            this.Name = "USC_Engins";
            this.Size = new System.Drawing.Size(872, 624);
            this.Load += new System.EventHandler(this.USC_Engins_Load);
            this.SizeChanged += new System.EventHandler(this.USC_Engins_SizeChanged);
            this.grpChoixCaserne.ResumeLayout(false);
            this.grpChoixCaserne.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboEngin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEngin)).EndInit();
            this.pnlBoutons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpChoixCaserne;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox cboChoixCaserne;
        private System.Windows.Forms.Label lblChoixCaserne;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblNumVal;
        private System.Windows.Forms.Label lblDateReceptVal;
        private System.Windows.Forms.Label lblDateRecept;
        private System.Windows.Forms.PictureBox pboEngin;
        private System.Windows.Forms.Label lblPanne;
        private System.Windows.Forms.Label lblMission;
        private System.Windows.Forms.CheckBox cboMission;
        private System.Windows.Forms.CheckBox cboPanne;
        private System.Windows.Forms.Button btnPreviousPlus;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnNextPlus;
        private System.Windows.Forms.Label lblEngin;
        private System.Windows.Forms.Panel pnlBoutons;
    }
}
