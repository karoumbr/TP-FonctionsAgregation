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

       




        private void btnNbreClients_Click(object sender, EventArgs e)
        {
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            Object c = Global.ExecuterOleDBScalaire(@"select count(*) from clients", cn);
            Global.seDeconnecter(cn);
            txtCountClients.Text = c.ToString();
        }

     
    }
}
