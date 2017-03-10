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
    public partial class Inscription : Form
    {
        SqlDbConnect ocon;
        //int num;
        public Inscription()
        {
            InitializeComponent();
        }

        private void Inscription_Load(object sender, EventArgs e)
        {
            foreach (TextBox t in Controls.OfType<TextBox>())
            {
                t.ReadOnly = true;
            }

            //Tdebut.ReadOnly = true;
            //Tfin.ReadOnly = true;
            //Tstage.ReadOnly = true;
            comboBox2.Items.Add("CIF");
            comboBox2.Items.Add("SIFE");
            comboBox2.Items.Add("Ch.Force");
            comboBox2.Items.Add("Cde Public");
            class_stagiaire cs = new class_stagiaire();
            ocon = new SqlDbConnect();
            Tstage.Text = stage.liststage[0].Nomstage;
            Tdebut.Text = stage.liststage[0].Datedebut.ToShortDateString().ToString();
            Tfin.Text= stage.liststage[0].Datefin.ToShortDateString().ToString();
            int i = 0;
            ocon.SqlQuery($"select noms,prenom,nums from stagiaire ");
            //MessageBox.Show($"{ocon.QueryEx().ToString()}");
            try
            {

                for (i = 0; i < ocon.QueryEx().Rows.Count; i++)
                {
                    comboBox1.Items.Add($" {ocon.QueryEx().Rows[i][0]} {ocon.QueryEx().Rows[i][1]} ");
                    cs.Noms = ocon.QueryEx().Rows[i][0].ToString();
                    cs.Prenom = ocon.QueryEx().Rows[i][1].ToString();
                    cs.Nums = ocon.QueryEx().Rows[i][2].ToString();
                    class_stagiaire.list_stagiaire.Add(cs);
                }
                
            }
            catch(Exception)
            {
                MessageBox.Show($"Aucune personne est inscrit dans ce");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stagiaire sg = new stagiaire();
            sg.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
                ocon.SqlQuery("INSERT INTO [dbo].[inscription]([cds],[num],[statut],[codeposition],[date_inscription]) VALUES(@cds,@num,@statut,@codeposition,@date_inscription);");
                ocon.Cmd.Parameters.Add("nums", SqlDbType.VarChar).Value = class_stagiaire.list_stagiaire[comboBox1.SelectedIndex].Nums;
                ocon.Cmd.Parameters.Add("statut", SqlDbType.VarChar).Value = comboBox2.Text;
                ocon.Cmd.Parameters.Add("cds", SqlDbType.VarChar).Value = stage.liststage[0].Cds;
                ocon.Cmd.Parameters.Add("codeposition", SqlDbType.Int).Value = 2;
                ocon.Cmd.Parameters.Add("date_inscription", SqlDbType.DateTime).Value = DateTime.Now.Date;
                ocon.NonQueryEx();
                MessageBox.Show("Bien Mis a jour !");
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Error",  "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            
        }

        private void selectedindexchanged1(object sender, EventArgs e)
        {
            textBox4.Text= class_stagiaire.list_stagiaire[comboBox1.SelectedIndex].Noms;
            textBox5.Text= class_stagiaire.list_stagiaire[comboBox1.SelectedIndex].Prenom;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gestion_des_stages gs = new gestion_des_stages();
            gs.Show();
            Hide();
        }
    }
}
