namespace WGM
{
    partial class uscReparation
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
            this.cboEngin = new System.Windows.Forms.ComboBox();
            this.lblEngin = new System.Windows.Forms.Label();
            this.rtbDetail = new System.Windows.Forms.RichTextBox();
            this.lblDetail = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboEngin
            // 
            this.cboEngin.FormattingEnabled = true;
            this.cboEngin.Location = new System.Drawing.Point(140, 12);
            this.cboEngin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboEngin.Name = "cboEngin";
            this.cboEngin.Size = new System.Drawing.Size(265, 33);
            this.cboEngin.TabIndex = 0;
            this.cboEngin.SelectedIndexChanged += new System.EventHandler(this.cboEngin_SelectedIndexChanged);
            // 
            // lblEngin
            // 
            this.lblEngin.AutoSize = true;
            this.lblEngin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEngin.Location = new System.Drawing.Point(2, 12);
            this.lblEngin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEngin.Name = "lblEngin";
            this.lblEngin.Size = new System.Drawing.Size(134, 25);
            this.lblEngin.TabIndex = 1;
            this.lblEngin.Text = "Engin Abimé :";
            // 
            // rtbDetail
            // 
            this.rtbDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rtbDetail.Location = new System.Drawing.Point(7, 80);
            this.rtbDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbDetail.Name = "rtbDetail";
            this.rtbDetail.Size = new System.Drawing.Size(475, 92);
            this.rtbDetail.TabIndex = 2;
            this.rtbDetail.Text = "";
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDetail.Location = new System.Drawing.Point(2, 50);
            this.lblDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(173, 25);
            this.lblDetail.TabIndex = 3;
            this.lblDetail.Text = "Détail des dégâts :";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.LightCoral;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRemove.Location = new System.Drawing.Point(409, 13);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(81, 32);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "retirer";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // uscReparation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(213)))), ((int)(((byte)(149)))));
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.rtbDetail);
            this.Controls.Add(this.lblEngin);
            this.Controls.Add(this.cboEngin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "uscReparation";
            this.Size = new System.Drawing.Size(494, 183);
            this.Load += new System.EventHandler(this.uscReparation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEngin;
        private System.Windows.Forms.Label lblEngin;
        private System.Windows.Forms.RichTextBox rtbDetail;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Button btnRemove;
    }
}
