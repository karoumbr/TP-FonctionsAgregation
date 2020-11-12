namespace TP_Fonctions_Agregation
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNbreClients = new System.Windows.Forms.Button();
            this.btnMoyenneSolde = new System.Windows.Forms.Button();
            this.btnSoldeMin = new System.Windows.Forms.Button();
            this.btnSoldeMax = new System.Windows.Forms.Button();
            this.btnSommeSoldes = new System.Windows.Forms.Button();
            this.txtCountClients = new System.Windows.Forms.TextBox();
            this.txtMoyenneSoldes = new System.Windows.Forms.TextBox();
            this.txtSoldeMin = new System.Windows.Forms.TextBox();
            this.txtSoldeMax = new System.Windows.Forms.TextBox();
            this.txtSommeSoldes = new System.Windows.Forms.TextBox();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNouveauClient = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSupprimerClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNbreClients
            // 
            this.btnNbreClients.Location = new System.Drawing.Point(10, 36);
            this.btnNbreClients.Name = "btnNbreClients";
            this.btnNbreClients.Size = new System.Drawing.Size(124, 23);
            this.btnNbreClients.TabIndex = 0;
            this.btnNbreClients.Text = "Nombre de clients";
            this.btnNbreClients.UseVisualStyleBackColor = true;
            this.btnNbreClients.Click += new System.EventHandler(this.btnNbreClients_Click);
            // 
            // btnMoyenneSolde
            // 
            this.btnMoyenneSolde.Location = new System.Drawing.Point(10, 79);
            this.btnMoyenneSolde.Name = "btnMoyenneSolde";
            this.btnMoyenneSolde.Size = new System.Drawing.Size(124, 23);
            this.btnMoyenneSolde.TabIndex = 1;
            this.btnMoyenneSolde.Text = "Moyenne des soldes";
            this.btnMoyenneSolde.UseVisualStyleBackColor = true;
            this.btnMoyenneSolde.Click += new System.EventHandler(this.btnMoyenneSolde_Click);
            // 
            // btnSoldeMin
            // 
            this.btnSoldeMin.Location = new System.Drawing.Point(10, 125);
            this.btnSoldeMin.Name = "btnSoldeMin";
            this.btnSoldeMin.Size = new System.Drawing.Size(124, 23);
            this.btnSoldeMin.TabIndex = 2;
            this.btnSoldeMin.Text = "Solde Minimum";
            this.btnSoldeMin.UseVisualStyleBackColor = true;
            this.btnSoldeMin.Click += new System.EventHandler(this.btnSoldeMin_Click);
            // 
            // btnSoldeMax
            // 
            this.btnSoldeMax.Location = new System.Drawing.Point(10, 175);
            this.btnSoldeMax.Name = "btnSoldeMax";
            this.btnSoldeMax.Size = new System.Drawing.Size(124, 23);
            this.btnSoldeMax.TabIndex = 3;
            this.btnSoldeMax.Text = "Solde Maximum";
            this.btnSoldeMax.UseVisualStyleBackColor = true;
            this.btnSoldeMax.Click += new System.EventHandler(this.btnSoldeMax_Click);
            // 
            // btnSommeSoldes
            // 
            this.btnSommeSoldes.Location = new System.Drawing.Point(10, 214);
            this.btnSommeSoldes.Name = "btnSommeSoldes";
            this.btnSommeSoldes.Size = new System.Drawing.Size(124, 23);
            this.btnSommeSoldes.TabIndex = 4;
            this.btnSommeSoldes.Text = "Somme des soldes";
            this.btnSommeSoldes.UseVisualStyleBackColor = true;
            this.btnSommeSoldes.Click += new System.EventHandler(this.btnSommeSoldes_Click);
            // 
            // txtCountClients
            // 
            this.txtCountClients.Location = new System.Drawing.Point(140, 38);
            this.txtCountClients.Name = "txtCountClients";
            this.txtCountClients.Size = new System.Drawing.Size(100, 20);
            this.txtCountClients.TabIndex = 5;
            // 
            // txtMoyenneSoldes
            // 
            this.txtMoyenneSoldes.Location = new System.Drawing.Point(140, 80);
            this.txtMoyenneSoldes.Name = "txtMoyenneSoldes";
            this.txtMoyenneSoldes.Size = new System.Drawing.Size(100, 20);
            this.txtMoyenneSoldes.TabIndex = 6;
            // 
            // txtSoldeMin
            // 
            this.txtSoldeMin.Location = new System.Drawing.Point(140, 128);
            this.txtSoldeMin.Name = "txtSoldeMin";
            this.txtSoldeMin.Size = new System.Drawing.Size(100, 20);
            this.txtSoldeMin.TabIndex = 7;
            // 
            // txtSoldeMax
            // 
            this.txtSoldeMax.Location = new System.Drawing.Point(140, 177);
            this.txtSoldeMax.Name = "txtSoldeMax";
            this.txtSoldeMax.Size = new System.Drawing.Size(100, 20);
            this.txtSoldeMax.TabIndex = 8;
            // 
            // txtSommeSoldes
            // 
            this.txtSommeSoldes.Location = new System.Drawing.Point(140, 218);
            this.txtSommeSoldes.Name = "txtSommeSoldes";
            this.txtSommeSoldes.Size = new System.Drawing.Size(100, 20);
            this.txtSommeSoldes.TabIndex = 9;
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nom,
            this.adresse,
            this.solde});
            this.dgvClients.Location = new System.Drawing.Point(260, 40);
            this.dgvClients.MultiSelect = false;
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowHeadersWidth = 51;
            this.dgvClients.Size = new System.Drawing.Size(508, 199);
            this.dgvClients.TabIndex = 10;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 60;
            // 
            // nom
            // 
            this.nom.HeaderText = "nom";
            this.nom.MinimumWidth = 6;
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            this.nom.Width = 125;
            // 
            // adresse
            // 
            this.adresse.HeaderText = "Adresse";
            this.adresse.MinimumWidth = 6;
            this.adresse.Name = "adresse";
            this.adresse.ReadOnly = true;
            this.adresse.Width = 125;
            // 
            // solde
            // 
            this.solde.HeaderText = "Solde";
            this.solde.MinimumWidth = 6;
            this.solde.Name = "solde";
            this.solde.ReadOnly = true;
            this.solde.Width = 125;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Table \"clients\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNouveauClient
            // 
            this.btnNouveauClient.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNouveauClient.ImageKey = "add.png";
            this.btnNouveauClient.ImageList = this.imageList1;
            this.btnNouveauClient.Location = new System.Drawing.Point(490, 246);
            this.btnNouveauClient.Name = "btnNouveauClient";
            this.btnNouveauClient.Size = new System.Drawing.Size(124, 45);
            this.btnNouveauClient.TabIndex = 12;
            this.btnNouveauClient.Text = "Nouveau Client";
            this.btnNouveauClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNouveauClient.UseVisualStyleBackColor = true;
            this.btnNouveauClient.Click += new System.EventHandler(this.btnNouveauClient_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "delete.png");
            // 
            // btnSupprimerClient
            // 
            this.btnSupprimerClient.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSupprimerClient.ImageKey = "delete.png";
            this.btnSupprimerClient.ImageList = this.imageList1;
            this.btnSupprimerClient.Location = new System.Drawing.Point(634, 246);
            this.btnSupprimerClient.Name = "btnSupprimerClient";
            this.btnSupprimerClient.Size = new System.Drawing.Size(133, 45);
            this.btnSupprimerClient.TabIndex = 13;
            this.btnSupprimerClient.Text = "Supprimer Client";
            this.btnSupprimerClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimerClient.UseVisualStyleBackColor = true;
            this.btnSupprimerClient.Click += new System.EventHandler(this.btnSupprimerClient_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 303);
            this.Controls.Add(this.btnSupprimerClient);
            this.Controls.Add(this.btnNouveauClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.txtSommeSoldes);
            this.Controls.Add(this.txtSoldeMax);
            this.Controls.Add(this.txtSoldeMin);
            this.Controls.Add(this.txtMoyenneSoldes);
            this.Controls.Add(this.txtCountClients);
            this.Controls.Add(this.btnSommeSoldes);
            this.Controls.Add(this.btnSoldeMax);
            this.Controls.Add(this.btnSoldeMin);
            this.Controls.Add(this.btnMoyenneSolde);
            this.Controls.Add(this.btnNbreClients);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Les fonctions d\'agrégation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNbreClients;
        private System.Windows.Forms.Button btnMoyenneSolde;
        private System.Windows.Forms.Button btnSoldeMin;
        private System.Windows.Forms.Button btnSoldeMax;
        private System.Windows.Forms.Button btnSommeSoldes;
        private System.Windows.Forms.TextBox txtCountClients;
        private System.Windows.Forms.TextBox txtMoyenneSoldes;
        private System.Windows.Forms.TextBox txtSoldeMin;
        private System.Windows.Forms.TextBox txtSoldeMax;
        private System.Windows.Forms.TextBox txtSommeSoldes;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNouveauClient;
        private System.Windows.Forms.Button btnSupprimerClient;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn solde;
    }
}

