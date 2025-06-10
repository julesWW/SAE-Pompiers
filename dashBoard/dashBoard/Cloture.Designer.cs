namespace Mission
{
    partial class frmCR
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
            this.rtbCR = new System.Windows.Forms.RichTextBox();
            this.lblCR = new System.Windows.Forms.Label();
            this.lblMission = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnReparation = new System.Windows.Forms.Button();
            this.flpReparations = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPlus = new System.Windows.Forms.Button();
            this.flpReparations.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbCR
            // 
            this.rtbCR.Location = new System.Drawing.Point(13, 62);
            this.rtbCR.Name = "rtbCR";
            this.rtbCR.Size = new System.Drawing.Size(519, 98);
            this.rtbCR.TabIndex = 1;
            this.rtbCR.Text = "";
            // 
            // lblCR
            // 
            this.lblCR.AutoSize = true;
            this.lblCR.Location = new System.Drawing.Point(12, 34);
            this.lblCR.Name = "lblCR";
            this.lblCR.Size = new System.Drawing.Size(265, 25);
            this.lblCR.TabIndex = 2;
            this.lblCR.Text = "Compte rendu de la mission :";
            // 
            // lblMission
            // 
            this.lblMission.AutoSize = true;
            this.lblMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMission.Location = new System.Drawing.Point(71, 9);
            this.lblMission.Name = "lblMission";
            this.lblMission.Size = new System.Drawing.Size(79, 25);
            this.lblMission.TabIndex = 3;
            this.lblMission.Text = "Mission";
            // 
            // lblFin
            // 
            this.lblFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(12, 210);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(290, 25);
            this.lblFin.TabIndex = 4;
            this.lblFin.Text = "Date et heure de fin de mission :";
            // 
            // dtpFin
            // 
            this.dtpFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpFin.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFin.Location = new System.Drawing.Point(12, 238);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(265, 30);
            this.dtpFin.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.MistyRose;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(319, 225);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 50);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.BackColor = System.Drawing.Color.Honeydew;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Location = new System.Drawing.Point(429, 225);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(103, 50);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnReparation
            // 
            this.btnReparation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(180)))), ((int)(((byte)(149)))));
            this.btnReparation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReparation.Location = new System.Drawing.Point(26, 166);
            this.btnReparation.Name = "btnReparation";
            this.btnReparation.Size = new System.Drawing.Size(486, 36);
            this.btnReparation.TabIndex = 8;
            this.btnReparation.Text = "Réparations nécessaires sur un ou plusieurs Engin(s)";
            this.btnReparation.UseVisualStyleBackColor = false;
            this.btnReparation.Click += new System.EventHandler(this.btnReparation_Click);
            // 
            // flpReparations
            // 
            this.flpReparations.AutoScroll = true;
            this.flpReparations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(180)))), ((int)(((byte)(149)))));
            this.flpReparations.Controls.Add(this.btnPlus);
            this.flpReparations.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpReparations.Location = new System.Drawing.Point(13, 164);
            this.flpReparations.Name = "flpReparations";
            this.flpReparations.Size = new System.Drawing.Size(526, 13);
            this.flpReparations.TabIndex = 9;
            this.flpReparations.WrapContents = false;
            // 
            // btnPlus
            // 
            this.btnPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlus.BackColor = System.Drawing.Color.Honeydew;
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.Location = new System.Drawing.Point(3, 3);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(513, 30);
            this.btnPlus.TabIndex = 9;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // frmCR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(542, 281);
            this.Controls.Add(this.flpReparations);
            this.Controls.Add(this.btnReparation);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.lblMission);
            this.Controls.Add(this.lblCR);
            this.Controls.Add(this.rtbCR);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmCR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cloture de la mission";
            this.Load += new System.EventHandler(this.frmCR_Load);
            this.flpReparations.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbCR;
        private System.Windows.Forms.Label lblCR;
        private System.Windows.Forms.Label lblMission;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnReparation;
        private System.Windows.Forms.FlowLayoutPanel flpReparations;
        private System.Windows.Forms.Button btnPlus;
    }
}