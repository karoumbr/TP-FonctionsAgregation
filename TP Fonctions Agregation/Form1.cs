using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Fonctions_Agregation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void remplirDatagrdview()
        {
            dgvClients.Rows.Clear();
            cmbCrediteur.Items.Clear();
            cmbDebiteur.Items.Clear();
           
            OleDbConnection cn = new OleDbConnection();
            OleDbDataReader lect;
            cn = Global.seConnecter(Global.cs);
            lect = Global.ExecuterOleDBSelect(@"select * from clients order by id asc", cn);
            while (lect.Read())
            {
                dgvClients.Rows.Add(lect.GetValue(0), lect.GetValue(1).ToString(), lect.GetValue(2).ToString(), lect.GetDecimal(3));
                Client cl = new Client(lect.GetInt32(0), lect.GetValue(1).ToString());
                cmbDebiteur.Items.Add(cl);
                cmbCrediteur.Items.Add(cl);
      
            }
            Global.seDeconnecter(cn);
            lect.Close();

        }



        private void btnNbreClients_Click(object sender, EventArgs e)
        {
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            Object c = Global.ExecuterOleDBScalaire(@"select count(*) from clients", cn);
            Global.seDeconnecter(cn);
            txtCountClients.Text = c.ToString();
        }

        private void btnNouveauClient_Click(object sender, EventArgs e)
        {
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            Global.ExecuterOleDBAction(@"insert into clients (nom, adresse, solde) values ('Nouveau client','adresse',50.000)", cn);
            Global.seDeconnecter(cn);
            remplirDatagrdview();
        }

        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sélectionnez la ligne entière." + "\n" + "Cliquez sur le curseur à gauche du datagrid.", "Erreur de sélection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Voulez vous supprimer ce client?", "Confirmation de la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                OleDbConnection cn = new OleDbConnection();
                cn = Global.seConnecter(Global.cs);
                Global.ExecuterOleDBAction(@"delete from clients where id = " + dgvClients.SelectedRows[0].Cells[0].Value.ToString(), cn);
                Global.seDeconnecter(cn);
                remplirDatagrdview();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCrediteur.DisplayMember = "nom";
            cmbDebiteur.DisplayMember = "nom";
            cmbCrediteur.ValueMember = "id";
            cmbDebiteur.ValueMember = "id";
            remplirDatagrdview();
        }

        private void btnMoyenneSolde_Click(object sender, EventArgs e)
        {
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            Object c = Global.ExecuterOleDBScalaire(@"select AVG(solde) from clients", cn);
            Global.seDeconnecter(cn);
            txtMoyenneSoldes.Text = c.ToString();
        }

        private void btnSoldeMin_Click(object sender, EventArgs e)
        {
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            Object c = Global.ExecuterOleDBScalaire(@"select MIN(solde) from clients", cn);
            Global.seDeconnecter(cn);
            txtSoldeMin.Text = c.ToString();
        }

        private void btnSoldeMax_Click(object sender, EventArgs e)
        {
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            Object c = Global.ExecuterOleDBScalaire(@"select MAX(solde) from clients", cn);
            Global.seDeconnecter(cn);
            txtSoldeMax.Text = c.ToString();
        }

        private void btnSommeSoldes_Click(object sender, EventArgs e)
        {
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            Object c = Global.ExecuterOleDBScalaire(@"select SUM(solde) from clients", cn);
            Global.seDeconnecter(cn);
            txtSommeSoldes.Text = c.ToString();
        }

        private void btnRechercherInfosClient_Click(object sender, EventArgs e)
        {
            OleDbConnection cn = new OleDbConnection();
            OleDbDataReader lecteur;
            cn = Global.seConnecter(Global.cs);
            lecteur = Global.ExecuterOleDBSelect(@"select * from clients where id=" + txtIdClient.Text, cn);
            while (lecteur.Read())
            {
                txtNom.Text = lecteur.GetValue(1).ToString();
                txtAdresse.Text = lecteur.GetValue(2).ToString();
                txtSolde.Text = lecteur.GetValue(3).ToString();
            }
            Global.seDeconnecter(cn);
            lecteur.Close();
        }

        private void btnUpdatePrimaire_Click(object sender, EventArgs e)
        {
            int res = -1;
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            res = Global.ExecuterOleDBAction(@"update clients set nom='" + Global.CleanString(txtNom.Text) + 
                                            "', adresse='" + Global.CleanString(txtAdresse.Text) + 
                                            "',solde=" + txtSolde.Text + " where id=" + txtIdClient.Text, cn);
            Global.seDeconnecter(cn);
            remplirDatagrdview();
            MessageBox.Show("Le nombre de lignes affectés = " + res.ToString());

        }

        private void btnUpdateParamsNonNomes_Click(object sender, EventArgs e)
        {
            int res = -1;
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            Object[] tabPM = { txtNom.Text, txtAdresse.Text, txtSolde.Text, txtIdClient.Text };
            res = Global.ExecuterOleDBAction(@"update clients set nom=?,adresse=?,solde=? where id=?", cn, tabPM);
            Global.seDeconnecter(cn);
            remplirDatagrdview();
            MessageBox.Show("Le nombre de lignes affectés = " + res.ToString());
        }

        private void btnUpdateParamsNomes_Click(object sender, EventArgs e)
        {
            int res = -1;
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            Object[,] tabPMNomes = { {  "@nom",txtNom.Text},
                                    {  "@adr",txtAdresse.Text},
                                    {  "@solde",txtSolde.Text},
                                    {  "@id",txtIdClient.Text}};
            res = Global.ExecuterOleDBActionNomsParams(@"update clients set nom=@nom,adresse=@adr,solde=@solde where id=@id", cn, tabPMNomes);
            Global.seDeconnecter(cn);
            remplirDatagrdview();
            MessageBox.Show("Le nombre de lignes affectés = " + res.ToString());
        }

        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0)
            {
                txtDetailIdClient.Text = dgvClients.SelectedRows[0].Cells[0].Value.ToString();
                txtDetailNomClient.Text = dgvClients.SelectedRows[0].Cells[1].Value.ToString();
                txtDetailAdresseClient.Text = dgvClients.SelectedRows[0].Cells[2].Value.ToString();
                txtDetailSoldeClient.Text = dgvClients.SelectedRows[0].Cells[3].Value.ToString();

            }
            else
            {
                try
                {
                    txtDetailIdClient.Text = dgvClients.Rows[0].Cells[0].Value.ToString();
                    txtDetailNomClient.Text = dgvClients.Rows[0].Cells[1].Value.ToString();
                    txtDetailAdresseClient.Text = dgvClients.Rows[0].Cells[2].Value.ToString();
                    txtDetailSoldeClient.Text = dgvClients.Rows[0].Cells[3].Value.ToString();

                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        private void btnTransfertSimple_Click(object sender, EventArgs e)
        {
            Boolean b = false;
            string[] tabSQL = new string[2];
            tabSQL[0] = @"update clients set solde=solde-" + txtMontantTransfert.Text + " where id=" + txtIdDebiteur.Text;
            tabSQL[1] = @"update clients set solde=solde+" + txtMontantTransfert.Text + " where id=" + txtIdCrediteur.Text;
            b = Global.ExecuterTransaction(Global.cs, tabSQL);
            if (b == false)
            {
                MessageBox.Show("Problème de Transfert.");
            } else
            {
                remplirDatagrdview();
            }
        }

        private void btnTransfertAvance_Click(object sender, EventArgs e)
        {
            Boolean b = false;
            string[] tabSQL = new string[2];
            Client cred = (Client)cmbCrediteur.SelectedItem;
            Client deb = (Client)cmbDebiteur.SelectedItem;
            tabSQL[0] = @"update clients set solde=solde-" + txtMontantTransfertCmb.Text + " where id=" + deb.id;
            tabSQL[1] = @"update clients set solde=solde+" + txtMontantTransfertCmb.Text + " where id=" + cred.id;
            b = Global.ExecuterTransaction(Global.cs, tabSQL);
            if (b == false)
            {
                MessageBox.Show("Problème de Transfert.");
            }
            else
            {
                remplirDatagrdview();
            }


        }
    }
}
