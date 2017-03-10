using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STAGE
{
    public partial class list_des_inscrits : Form
    {
        public list_des_inscrits()
        {
            InitializeComponent();
        }

        SqlDbConnect cnx = new SqlDbConnect();
        
        private void list_des_inscrits_Load(object sender, EventArgs e)
        {
            
            textBox1.Text = stage.liststage[0].Nomstage;
            textBox2.Text = stage.liststage[0].Datedebut.ToShortDateString().ToString();
            textBox3.Text = stage.liststage[0].Datefin.ToShortDateString().ToString();
            cnx.SqlQuery($"select noms,prenom from stagiaire,inscription,stage where stage.cds=inscription.cds and inscription.num=nums and inscription.cds='{stage.liststage[0].Cds}' ");
            foreach (DataRow dr in cnx.QueryEx().Rows)
            {
                listBox1.Items.Add(dr[0].ToString().ToUpper() + " " + dr[1].ToString());
                

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Inscription I = new Inscription();
            I.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gestion_des_stages gds = new gestion_des_stages();
            gds.Show();
            Hide();
        }
    }
}
