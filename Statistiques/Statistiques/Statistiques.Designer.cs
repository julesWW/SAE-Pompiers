namespace Statistiques
{
    partial class uscStats
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
            this.btnParCaserne = new System.Windows.Forms.Button();
            this.pnlParCaserne = new System.Windows.Forms.Panel();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.flpCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlInterCaserne = new System.Windows.Forms.Panel();
            this.btnInterCaserne = new System.Windows.Forms.Button();
            this.lblNBCASERNE = new System.Windows.Forms.Label();
            this.lblEnginPlusUtilise = new System.Windows.Forms.Label();
            this.pnlParCaserne.SuspendLayout();
            this.flpCategories.SuspendLayout();
            this.pnlInterCaserne.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnParCaserne
            // 
            this.btnParCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParCaserne.Location = new System.Drawing.Point(0, 0);
            this.btnParCaserne.Name = "btnParCaserne";
            this.btnParCaserne.Size = new System.Drawing.Size(645, 33);
            this.btnParCaserne.TabIndex = 0;
            this.btnParCaserne.Tag = "open";
            this.btnParCaserne.Text = "Statistiques par Caserne                  ▼";
            this.btnParCaserne.UseVisualStyleBackColor = true;
            this.btnParCaserne.Click += new System.EventHandler(this.btnParCaserne_Click);
            // 
            // pnlParCaserne
            // 
            this.pnlParCaserne.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlParCaserne.Controls.Add(this.lblEnginPlusUtilise);
            this.pnlParCaserne.Controls.Add(this.lblNBCASERNE);
            this.pnlParCaserne.Controls.Add(this.cboCaserne);
            this.pnlParCaserne.Controls.Add(this.btnParCaserne);
            this.pnlParCaserne.Location = new System.Drawing.Point(3, 3);
            this.pnlParCaserne.Name = "pnlParCaserne";
            this.pnlParCaserne.Size = new System.Drawing.Size(645, 400);
            this.pnlParCaserne.TabIndex = 2;
            // 
            // cboCaserne
            // 
            this.cboCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(80, 51);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(417, 33);
            this.cboCaserne.TabIndex = 1;
            this.cboCaserne.SelectedIndexChanged += new System.EventHandler(this.cboCaserne_SelectedIndexChanged);
            // 
            // flpCategories
            // 
            this.flpCategories.AutoScroll = true;
            this.flpCategories.Controls.Add(this.pnlParCaserne);
            this.flpCategories.Controls.Add(this.pnlInterCaserne);
            this.flpCategories.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpCategories.Location = new System.Drawing.Point(56, 64);
            this.flpCategories.Name = "flpCategories";
            this.flpCategories.Size = new System.Drawing.Size(672, 470);
            this.flpCategories.TabIndex = 3;
            this.flpCategories.WrapContents = false;
            // 
            // pnlInterCaserne
            // 
            this.pnlInterCaserne.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlInterCaserne.Controls.Add(this.btnInterCaserne);
            this.pnlInterCaserne.Location = new System.Drawing.Point(3, 409);
            this.pnlInterCaserne.Name = "pnlInterCaserne";
            this.pnlInterCaserne.Size = new System.Drawing.Size(645, 367);
            this.pnlInterCaserne.TabIndex = 3;
            // 
            // btnInterCaserne
            // 
            this.btnInterCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterCaserne.Location = new System.Drawing.Point(0, 0);
            this.btnInterCaserne.Name = "btnInterCaserne";
            this.btnInterCaserne.Size = new System.Drawing.Size(645, 33);
            this.btnInterCaserne.TabIndex = 0;
            this.btnInterCaserne.Tag = "open";
            this.btnInterCaserne.Text = "Statistiques inter-Caserne                  ▼";
            this.btnInterCaserne.UseVisualStyleBackColor = true;
            this.btnInterCaserne.Click += new System.EventHandler(this.btnInterCaserne_Click);
            // 
            // lblNBCASERNE
            // 
            this.lblNBCASERNE.AutoSize = true;
            this.lblNBCASERNE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblNBCASERNE.Location = new System.Drawing.Point(373, 112);
            this.lblNBCASERNE.Name = "lblNBCASERNE";
            this.lblNBCASERNE.Size = new System.Drawing.Size(126, 39);
            this.lblNBCASERNE.TabIndex = 2;
            this.lblNBCASERNE.Text = "ENGIN";
            // 
            // lblEnginPlusUtilise
            // 
            this.lblEnginPlusUtilise.AutoSize = true;
            this.lblEnginPlusUtilise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnginPlusUtilise.Location = new System.Drawing.Point(22, 123);
            this.lblEnginPlusUtilise.Name = "lblEnginPlusUtilise";
            this.lblEnginPlusUtilise.Size = new System.Drawing.Size(310, 25);
            this.lblEnginPlusUtilise.TabIndex = 3;
            this.lblEnginPlusUtilise.Text = "Engin le plus utilisé de la caserne :";
            // 
            // uscStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.Controls.Add(this.flpCategories);
            this.Name = "uscStats";
            this.Size = new System.Drawing.Size(803, 546);
            this.Load += new System.EventHandler(this.uscStats_Load);
            this.pnlParCaserne.ResumeLayout(false);
            this.pnlParCaserne.PerformLayout();
            this.flpCategories.ResumeLayout(false);
            this.pnlInterCaserne.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnParCaserne;
        private System.Windows.Forms.Panel pnlParCaserne;
        private System.Windows.Forms.FlowLayoutPanel flpCategories;
        private System.Windows.Forms.Panel pnlInterCaserne;
        private System.Windows.Forms.Button btnInterCaserne;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.Label lblNBCASERNE;
        private System.Windows.Forms.Label lblEnginPlusUtilise;
    }
}
