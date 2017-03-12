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
        SqlDbConnect con2;
        int nombreinscrit;
        int nbplace;
        //int num;
        public Inscription()
        {
            InitializeComponent();
        }

        private void Inscription_Load(object sender, EventArgs e)
        {
            //stage.liststage.Clear();
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
            
            ocon = new SqlDbConnect();
            Tstage.Text = stage.liststage[0].Nomstage;
            Tdebut.Text = stage.liststage[0].Datedebut.ToShortDateString().ToString();
            Tfin.Text= stage.liststage[0].Datefin.ToShortDateString().ToString();
            
            ocon.SqlQuery($"select noms,prenom,nums from stagiaire where stagiaire.nums not in (select num from inscription)");
            //MessageBox.Show($"{ocon.QueryEx().ToString()}");
            combo();
            
        }
        public void combo()
        {
            class_stagiaire cs;
            int i = 0;
            class_stagiaire.list_stagiaire.Clear();
            comboBox1.Items.Clear();
            try
            {

                for (i = 0; i < ocon.QueryEx().Rows.Count; i++)
                {
                    cs = new class_stagiaire();
                    comboBox1.Items.Add($" {ocon.QueryEx().Rows[i][0]} {ocon.QueryEx().Rows[i][1]} ");
                    cs.Noms = ocon.QueryEx().Rows[i][0].ToString();
                    cs.Prenom = ocon.QueryEx().Rows[i][1].ToString();
                    cs.Nums = ocon.QueryEx().Rows[i][2].ToString();
                    class_stagiaire.list_stagiaire.Add(cs);
                }

            }
            catch (Exception)
            {
                MessageBox.Show($"Aucune personne est inscrit dans la base !");
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
            con2 = new SqlDbConnect();
            con2.SqlQuery($"select nbplace,nbinscrit from stage where cds='{stage.liststage[0].Cds}'");
            nbplace= int.Parse(con2.QueryEx().Rows[0][0].ToString());
            nombreinscrit= int.Parse(con2.QueryEx().Rows[0][1].ToString());
            if(nbplace<nombreinscrit)
            {
                ocon.SqlQuery("INSERT INTO [dbo].[inscription]([cds],[num],[statut],[codeposition],[date_inscription]) VALUES(@cds,@num,@statut,@codeposition,@date_inscription);");
                ocon.Cmd.Parameters.Add("num", SqlDbType.VarChar).Value = class_stagiaire.list_stagiaire[comboBox1.SelectedIndex].Nums;
                ocon.Cmd.Parameters.Add("statut", SqlDbType.VarChar).Value = comboBox2.Text;
                ocon.Cmd.Parameters.Add("cds", SqlDbType.VarChar).Value = stage.liststage[0].Cds;
                ocon.Cmd.Parameters.Add("codeposition", SqlDbType.Int).Value = 3;
                ocon.Cmd.Parameters.Add("date_inscription", SqlDbType.DateTime).Value = DateTime.Now.Date;
                ocon.NonQueryEx();
                MessageBox.Show("Bien Mis a jour !");
                con2 = new SqlDbConnect();
                con2.SqlQuery($"update stage set nbinscrit={nombreinscrit + 1} where cds='{stage.liststage[0].Cds}'");
                con2.NonQueryEx();
            }
            else
            {
                ocon.SqlQuery("INSERT INTO [dbo].[inscription]([cds],[num],[statut],[codeposition],[date_inscription]) VALUES(@cds,@num,@statut,@codeposition,@date_inscription);");
                ocon.Cmd.Parameters.Add("num", SqlDbType.VarChar).Value = class_stagiaire.list_stagiaire[comboBox1.SelectedIndex].Nums;
                ocon.Cmd.Parameters.Add("statut", SqlDbType.VarChar).Value = comboBox2.Text;
                ocon.Cmd.Parameters.Add("cds", SqlDbType.VarChar).Value = stage.liststage[0].Cds;
                ocon.Cmd.Parameters.Add("codeposition", SqlDbType.Int).Value = 2;
                ocon.Cmd.Parameters.Add("date_inscription", SqlDbType.DateTime).Value = DateTime.Now.Date;
                ocon.NonQueryEx();
                MessageBox.Show("Bien Mis a jour !");
                con2 = new SqlDbConnect();
                con2.SqlQuery($"update stage set nbinscrit={nombreinscrit + 1} where cds='{stage.liststage[0].Cds}'");
                con2.NonQueryEx();

            }
            combo();
            foreach(TextBox t in Controls.OfType<TextBox>())
            {
                t.Text = "";
            }
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
