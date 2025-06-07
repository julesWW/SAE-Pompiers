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
            this.lblDureeEngins = new System.Windows.Forms.Label();
            this.dgwDureeEngins = new System.Windows.Forms.DataGridView();
            this.lblEnginPlusUtilise = new System.Windows.Forms.Label();
            this.lblNBCASERNE = new System.Windows.Forms.Label();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.flpCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlInterCaserne = new System.Windows.Forms.Panel();
            this.btnInterCaserne = new System.Windows.Forms.Button();
            this.dgvInterParSinistre = new System.Windows.Forms.DataGridView();
            this.lblInterParSinistre = new System.Windows.Forms.Label();
            this.lblHabiSol = new System.Windows.Forms.Label();
            this.lblHabiSolVal = new System.Windows.Forms.Label();
            this.lblPompierHabilitation = new System.Windows.Forms.Label();
            this.dgvPompierHabilitation = new System.Windows.Forms.DataGridView();
            this.pnlParCaserne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDureeEngins)).BeginInit();
            this.flpCategories.SuspendLayout();
            this.pnlInterCaserne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterParSinistre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPompierHabilitation)).BeginInit();
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
            this.pnlParCaserne.Controls.Add(this.lblDureeEngins);
            this.pnlParCaserne.Controls.Add(this.dgwDureeEngins);
            this.pnlParCaserne.Controls.Add(this.lblEnginPlusUtilise);
            this.pnlParCaserne.Controls.Add(this.lblNBCASERNE);
            this.pnlParCaserne.Controls.Add(this.cboCaserne);
            this.pnlParCaserne.Controls.Add(this.btnParCaserne);
            this.pnlParCaserne.Location = new System.Drawing.Point(3, 3);
            this.pnlParCaserne.Name = "pnlParCaserne";
            this.pnlParCaserne.Size = new System.Drawing.Size(645, 372);
            this.pnlParCaserne.TabIndex = 2;
            // 
            // lblDureeEngins
            // 
            this.lblDureeEngins.AutoSize = true;
            this.lblDureeEngins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDureeEngins.Location = new System.Drawing.Point(22, 166);
            this.lblDureeEngins.Name = "lblDureeEngins";
            this.lblDureeEngins.Size = new System.Drawing.Size(275, 25);
            this.lblDureeEngins.TabIndex = 5;
            this.lblDureeEngins.Text = "Durées d\'utilisation des engins";
            // 
            // dgwDureeEngins
            // 
            this.dgwDureeEngins.AllowUserToAddRows = false;
            this.dgwDureeEngins.AllowUserToDeleteRows = false;
            this.dgwDureeEngins.AllowUserToResizeRows = false;
            this.dgwDureeEngins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDureeEngins.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgwDureeEngins.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwDureeEngins.Location = new System.Drawing.Point(27, 209);
            this.dgwDureeEngins.Name = "dgwDureeEngins";
            this.dgwDureeEngins.RowHeadersWidth = 51;
            this.dgwDureeEngins.RowTemplate.Height = 24;
            this.dgwDureeEngins.Size = new System.Drawing.Size(469, 147);
            this.dgwDureeEngins.TabIndex = 4;
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
            this.pnlInterCaserne.Controls.Add(this.lblPompierHabilitation);
            this.pnlInterCaserne.Controls.Add(this.dgvPompierHabilitation);
            this.pnlInterCaserne.Controls.Add(this.lblHabiSolVal);
            this.pnlInterCaserne.Controls.Add(this.lblHabiSol);
            this.pnlInterCaserne.Controls.Add(this.lblInterParSinistre);
            this.pnlInterCaserne.Controls.Add(this.dgvInterParSinistre);
            this.pnlInterCaserne.Controls.Add(this.btnInterCaserne);
            this.pnlInterCaserne.Location = new System.Drawing.Point(3, 381);
            this.pnlInterCaserne.Name = "pnlInterCaserne";
            this.pnlInterCaserne.Size = new System.Drawing.Size(645, 760);
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
            // dgvInterParSinistre
            // 
            this.dgvInterParSinistre.AllowUserToAddRows = false;
            this.dgvInterParSinistre.AllowUserToDeleteRows = false;
            this.dgvInterParSinistre.AllowUserToResizeRows = false;
            this.dgvInterParSinistre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInterParSinistre.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvInterParSinistre.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInterParSinistre.Location = new System.Drawing.Point(30, 98);
            this.dgvInterParSinistre.Name = "dgvInterParSinistre";
            this.dgvInterParSinistre.RowHeadersWidth = 51;
            this.dgvInterParSinistre.RowTemplate.Height = 24;
            this.dgvInterParSinistre.RowTemplate.ReadOnly = true;
            this.dgvInterParSinistre.Size = new System.Drawing.Size(469, 147);
            this.dgvInterParSinistre.TabIndex = 6;
            // 
            // lblInterParSinistre
            // 
            this.lblInterParSinistre.AutoSize = true;
            this.lblInterParSinistre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterParSinistre.Location = new System.Drawing.Point(22, 53);
            this.lblInterParSinistre.Name = "lblInterParSinistre";
            this.lblInterParSinistre.Size = new System.Drawing.Size(310, 25);
            this.lblInterParSinistre.TabIndex = 6;
            this.lblInterParSinistre.Text = "Nombre d\'interventions par sinistre";
            // 
            // lblHabiSol
            // 
            this.lblHabiSol.AutoSize = true;
            this.lblHabiSol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabiSol.Location = new System.Drawing.Point(22, 267);
            this.lblHabiSol.Name = "lblHabiSol";
            this.lblHabiSol.Size = new System.Drawing.Size(369, 25);
            this.lblHabiSol.TabIndex = 7;
            this.lblHabiSol.Text = "Les habilitations les plus sollicitées sont : ";
            // 
            // lblHabiSolVal
            // 
            this.lblHabiSolVal.AutoSize = true;
            this.lblHabiSolVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabiSolVal.Location = new System.Drawing.Point(45, 306);
            this.lblHabiSolVal.Name = "lblHabiSolVal";
            this.lblHabiSolVal.Size = new System.Drawing.Size(163, 25);
            this.lblHabiSolVal.TabIndex = 8;
            this.lblHabiSolVal.Text = "HABILITATIONS";
            // 
            // lblPompierHabilitation
            // 
            this.lblPompierHabilitation.AutoSize = true;
            this.lblPompierHabilitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPompierHabilitation.Location = new System.Drawing.Point(22, 411);
            this.lblPompierHabilitation.Name = "lblPompierHabilitation";
            this.lblPompierHabilitation.Size = new System.Drawing.Size(305, 25);
            this.lblPompierHabilitation.TabIndex = 9;
            this.lblPompierHabilitation.Text = "Liste des pompiers par habilitation";
            // 
            // dgvPompierHabilitation
            // 
            this.dgvPompierHabilitation.AllowUserToAddRows = false;
            this.dgvPompierHabilitation.AllowUserToDeleteRows = false;
            this.dgvPompierHabilitation.AllowUserToResizeRows = false;
            this.dgvPompierHabilitation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPompierHabilitation.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvPompierHabilitation.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPompierHabilitation.Location = new System.Drawing.Point(30, 456);
            this.dgvPompierHabilitation.Name = "dgvPompierHabilitation";
            this.dgvPompierHabilitation.RowHeadersWidth = 51;
            this.dgvPompierHabilitation.RowTemplate.Height = 24;
            this.dgvPompierHabilitation.RowTemplate.ReadOnly = true;
            this.dgvPompierHabilitation.Size = new System.Drawing.Size(469, 286);
            this.dgvPompierHabilitation.TabIndex = 10;
            // 
            // uscStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.Controls.Add(this.flpCategories);
            this.Name = "uscStats";
            this.Size = new System.Drawing.Size(803, 554);
            this.Load += new System.EventHandler(this.uscStats_Load);
            this.pnlParCaserne.ResumeLayout(false);
            this.pnlParCaserne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDureeEngins)).EndInit();
            this.flpCategories.ResumeLayout(false);
            this.pnlInterCaserne.ResumeLayout(false);
            this.pnlInterCaserne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterParSinistre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPompierHabilitation)).EndInit();
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
        private System.Windows.Forms.Label lblDureeEngins;
        private System.Windows.Forms.DataGridView dgwDureeEngins;
        private System.Windows.Forms.DataGridView dgvInterParSinistre;
        private System.Windows.Forms.Label lblInterParSinistre;
        private System.Windows.Forms.Label lblHabiSolVal;
        private System.Windows.Forms.Label lblHabiSol;
        private System.Windows.Forms.Label lblPompierHabilitation;
        private System.Windows.Forms.DataGridView dgvPompierHabilitation;
    }
}
