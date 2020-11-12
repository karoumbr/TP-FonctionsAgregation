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
           
            OleDbConnection cn = new OleDbConnection();
            OleDbDataReader lect;
            cn = Global.seConnecter(Global.cs);
            lect = Global.ExecuterOleDBSelect(@"select * from clients order by id asc", cn);
            while (lect.Read())
            {
                dgvClients.Rows.Add(lect.GetValue(0), lect.GetValue(1).ToString(), lect.GetValue(2).ToString(), lect.GetDecimal(3));
      
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
    }
}
