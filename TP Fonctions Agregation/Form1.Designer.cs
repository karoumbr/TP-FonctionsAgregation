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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdClient = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtSolde = new System.Windows.Forms.TextBox();
            this.btnRechercherInfosClient = new System.Windows.Forms.Button();
            this.btnUpdatePrimaire = new System.Windows.Forms.Button();
            this.btnUpdateParamsNonNomes = new System.Windows.Forms.Button();
            this.btnUpdateParamsNomes = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdDebiteur = new System.Windows.Forms.TextBox();
            this.txtIdCrediteur = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMontantTransfert = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTransfertSimple = new System.Windows.Forms.Button();
            this.cmbDebiteur = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbCrediteur = new System.Windows.Forms.ComboBox();
            this.txtMontantTransfertCmb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTransfertAvance = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDetailIdClient = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDetailNomClient = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDetailAdresseClient = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDetailSoldeClient = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dgvClients.SelectionChanged += new System.EventHandler(this.dgvClients_SelectionChanged);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateParamsNomes);
            this.groupBox1.Controls.Add(this.btnUpdateParamsNonNomes);
            this.groupBox1.Controls.Add(this.btnUpdatePrimaire);
            this.groupBox1.Controls.Add(this.btnRechercherInfosClient);
            this.groupBox1.Controls.Add(this.txtSolde);
            this.groupBox1.Controls.Add(this.txtAdresse);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.txtIdClient);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(20, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 247);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mise à jour";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTransfertAvance);
            this.groupBox2.Controls.Add(this.txtMontantTransfertCmb);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmbCrediteur);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmbDebiteur);
            this.groupBox2.Controls.Add(this.btnTransfertSimple);
            this.groupBox2.Controls.Add(this.txtMontantTransfert);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtIdCrediteur);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtIdDebiteur);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(372, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 243);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "adresse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "solde";
            // 
            // txtIdClient
            // 
            this.txtIdClient.Location = new System.Drawing.Point(97, 53);
            this.txtIdClient.Name = "txtIdClient";
            this.txtIdClient.Size = new System.Drawing.Size(100, 20);
            this.txtIdClient.TabIndex = 4;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(97, 84);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 5;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(97, 110);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(100, 20);
            this.txtAdresse.TabIndex = 6;
            // 
            // txtSolde
            // 
            this.txtSolde.Location = new System.Drawing.Point(97, 136);
            this.txtSolde.Name = "txtSolde";
            this.txtSolde.Size = new System.Drawing.Size(100, 20);
            this.txtSolde.TabIndex = 7;
            // 
            // btnRechercherInfosClient
            // 
            this.btnRechercherInfosClient.Location = new System.Drawing.Point(203, 52);
            this.btnRechercherInfosClient.Name = "btnRechercherInfosClient";
            this.btnRechercherInfosClient.Size = new System.Drawing.Size(117, 23);
            this.btnRechercherInfosClient.TabIndex = 8;
            this.btnRechercherInfosClient.Text = "Rechercher";
            this.btnRechercherInfosClient.UseVisualStyleBackColor = true;
            this.btnRechercherInfosClient.Click += new System.EventHandler(this.btnRechercherInfosClient_Click);
            // 
            // btnUpdatePrimaire
            // 
            this.btnUpdatePrimaire.Location = new System.Drawing.Point(12, 182);
            this.btnUpdatePrimaire.Name = "btnUpdatePrimaire";
            this.btnUpdatePrimaire.Size = new System.Drawing.Size(97, 52);
            this.btnUpdatePrimaire.TabIndex = 9;
            this.btnUpdatePrimaire.Text = "Enregistrer (méthode simple)";
            this.btnUpdatePrimaire.UseVisualStyleBackColor = true;
            this.btnUpdatePrimaire.Click += new System.EventHandler(this.btnUpdatePrimaire_Click);
            // 
            // btnUpdateParamsNonNomes
            // 
            this.btnUpdateParamsNonNomes.Location = new System.Drawing.Point(120, 182);
            this.btnUpdateParamsNonNomes.Name = "btnUpdateParamsNonNomes";
            this.btnUpdateParamsNonNomes.Size = new System.Drawing.Size(97, 52);
            this.btnUpdateParamsNonNomes.TabIndex = 10;
            this.btnUpdateParamsNonNomes.Text = "Enregistrer (avec paramètres non només)";
            this.btnUpdateParamsNonNomes.UseVisualStyleBackColor = true;
            this.btnUpdateParamsNonNomes.Click += new System.EventHandler(this.btnUpdateParamsNonNomes_Click);
            // 
            // btnUpdateParamsNomes
            // 
            this.btnUpdateParamsNomes.Location = new System.Drawing.Point(223, 182);
            this.btnUpdateParamsNomes.Name = "btnUpdateParamsNomes";
            this.btnUpdateParamsNomes.Size = new System.Drawing.Size(97, 52);
            this.btnUpdateParamsNomes.TabIndex = 11;
            this.btnUpdateParamsNomes.Text = "Enregistrer (avec paramètres només)";
            this.btnUpdateParamsNomes.UseVisualStyleBackColor = true;
            this.btnUpdateParamsNomes.Click += new System.EventHandler(this.btnUpdateParamsNomes_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "id client débiteur";
            // 
            // txtIdDebiteur
            // 
            this.txtIdDebiteur.Location = new System.Drawing.Point(26, 51);
            this.txtIdDebiteur.Name = "txtIdDebiteur";
            this.txtIdDebiteur.Size = new System.Drawing.Size(100, 20);
            this.txtIdDebiteur.TabIndex = 1;
            // 
            // txtIdCrediteur
            // 
            this.txtIdCrediteur.Location = new System.Drawing.Point(135, 51);
            this.txtIdCrediteur.Name = "txtIdCrediteur";
            this.txtIdCrediteur.Size = new System.Drawing.Size(100, 20);
            this.txtIdCrediteur.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "id client créditeur";
            // 
            // txtMontantTransfert
            // 
            this.txtMontantTransfert.Location = new System.Drawing.Point(267, 49);
            this.txtMontantTransfert.Name = "txtMontantTransfert";
            this.txtMontantTransfert.Size = new System.Drawing.Size(100, 20);
            this.txtMontantTransfert.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "montant transfert";
            // 
            // btnTransfertSimple
            // 
            this.btnTransfertSimple.Location = new System.Drawing.Point(267, 75);
            this.btnTransfertSimple.Name = "btnTransfertSimple";
            this.btnTransfertSimple.Size = new System.Drawing.Size(100, 44);
            this.btnTransfertSimple.TabIndex = 6;
            this.btnTransfertSimple.Text = "Transfert simple";
            this.btnTransfertSimple.UseVisualStyleBackColor = true;
            this.btnTransfertSimple.Click += new System.EventHandler(this.btnTransfertSimple_Click);
            // 
            // cmbDebiteur
            // 
            this.cmbDebiteur.FormattingEnabled = true;
            this.cmbDebiteur.Location = new System.Drawing.Point(12, 161);
            this.cmbDebiteur.Name = "cmbDebiteur";
            this.cmbDebiteur.Size = new System.Drawing.Size(121, 21);
            this.cmbDebiteur.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Débiteur";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(179, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Créditeur";
            // 
            // cmbCrediteur
            // 
            this.cmbCrediteur.FormattingEnabled = true;
            this.cmbCrediteur.Location = new System.Drawing.Point(139, 161);
            this.cmbCrediteur.Name = "cmbCrediteur";
            this.cmbCrediteur.Size = new System.Drawing.Size(121, 21);
            this.cmbCrediteur.TabIndex = 9;
            // 
            // txtMontantTransfertCmb
            // 
            this.txtMontantTransfertCmb.Location = new System.Drawing.Point(267, 161);
            this.txtMontantTransfertCmb.Name = "txtMontantTransfertCmb";
            this.txtMontantTransfertCmb.Size = new System.Drawing.Size(100, 20);
            this.txtMontantTransfertCmb.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(273, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "montant transfert";
            // 
            // btnTransfertAvance
            // 
            this.btnTransfertAvance.Location = new System.Drawing.Point(267, 186);
            this.btnTransfertAvance.Name = "btnTransfertAvance";
            this.btnTransfertAvance.Size = new System.Drawing.Size(100, 44);
            this.btnTransfertAvance.TabIndex = 13;
            this.btnTransfertAvance.Text = "Transfert avancé";
            this.btnTransfertAvance.UseVisualStyleBackColor = true;
            this.btnTransfertAvance.Click += new System.EventHandler(this.btnTransfertAvance_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDetailSoldeClient);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtDetailAdresseClient);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtDetailNomClient);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtDetailIdClient);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(20, 594);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(746, 61);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Détails clients";
            // 
            // txtDetailIdClient
            // 
            this.txtDetailIdClient.Location = new System.Drawing.Point(67, 22);
            this.txtDetailIdClient.Name = "txtDetailIdClient";
            this.txtDetailIdClient.Size = new System.Drawing.Size(47, 20);
            this.txtDetailIdClient.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Id Client";
            // 
            // txtDetailNomClient
            // 
            this.txtDetailNomClient.Location = new System.Drawing.Point(153, 22);
            this.txtDetailNomClient.Name = "txtDetailNomClient";
            this.txtDetailNomClient.Size = new System.Drawing.Size(167, 20);
            this.txtDetailNomClient.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(120, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "nom";
            // 
            // txtDetailAdresseClient
            // 
            this.txtDetailAdresseClient.Location = new System.Drawing.Point(378, 22);
            this.txtDetailAdresseClient.Name = "txtDetailAdresseClient";
            this.txtDetailAdresseClient.Size = new System.Drawing.Size(180, 20);
            this.txtDetailAdresseClient.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(326, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "adresse";
            // 
            // txtDetailSoldeClient
            // 
            this.txtDetailSoldeClient.Location = new System.Drawing.Point(604, 22);
            this.txtDetailSoldeClient.Name = "txtDetailSoldeClient";
            this.txtDetailSoldeClient.Size = new System.Drawing.Size(115, 20);
            this.txtDetailSoldeClient.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(564, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Solde";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 665);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdateParamsNomes;
        private System.Windows.Forms.Button btnUpdateParamsNonNomes;
        private System.Windows.Forms.Button btnUpdatePrimaire;
        private System.Windows.Forms.Button btnRechercherInfosClient;
        private System.Windows.Forms.TextBox txtSolde;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtIdClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTransfertAvance;
        private System.Windows.Forms.TextBox txtMontantTransfertCmb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbCrediteur;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbDebiteur;
        private System.Windows.Forms.Button btnTransfertSimple;
        private System.Windows.Forms.TextBox txtMontantTransfert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdCrediteur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdDebiteur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDetailSoldeClient;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDetailAdresseClient;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDetailNomClient;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDetailIdClient;
        private System.Windows.Forms.Label label12;
    }
}

