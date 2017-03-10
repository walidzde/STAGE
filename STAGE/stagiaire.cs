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
    public partial class stagiaire : Form
    {
        SqlDbConnect con=new SqlDbConnect();
        int numerostage;
        public stagiaire()
        {
            InitializeComponent();
        }
        private void stagiaire_Load(object sender, EventArgs e)
        {
            
            //count number of stagiaire
            con.SqlQuery("select count(*) from stagiaire");
            numerostage = (int)con.QueryEx().Rows[0][0]+1;
            tnum.Text = $"s{numerostage}/{DateTime.Now.Year}";
            tnum.ReadOnly = true;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bretourins_Click(object sender, EventArgs e)
        {
            Inscription ins = new Inscription();
            ins.Show();
            Hide();
        }

        private void Bcreation_Click(object sender, EventArgs e)
        {
            char X=' ';
            if (rbf.Checked == true) X = 'F';
            if (rbm.Checked == true) X = 'M';
           if( check()==false)
            {
                con.SqlQuery(" INSERT INTO [dbo].[stagiaire]([nums] ,[noms],[prenom],[sexe],[dns] ,[dips]) VALUES(@nums,@noms,@prenom,@sexe,@dns,@dips)");
                
                con.Cmd.Parameters.Add("nums", SqlDbType.VarChar).Value = tnum.Text;
                con.Cmd.Parameters.Add("noms", SqlDbType.VarChar).Value = tnom.Text;
                con.Cmd.Parameters.Add("prenom", SqlDbType.VarChar).Value = tprenom.Text;
                con.Cmd.Parameters.Add("sexe", SqlDbType.Char).Value = X;
                con.Cmd.Parameters.Add("dns", SqlDbType.DateTime).Value = dateTimePicker1.Value.Date;
                con.Cmd.Parameters.Add("dips", SqlDbType.VarChar).Value = tdiplome.Text;
                con.NonQueryEx();
                try
                {
                    
                    MessageBox.Show("Bien ajouté");
                }
                catch (Exception)
                {
                    MessageBox.Show("error en cours d'ajout veuillez ressayer");
                }
            }
        }
        bool check()
        {
            bool x = false;
            errorProvider1.Clear();
            foreach (TextBox t in Controls.OfType<TextBox>())
            {
                
                if(t.Text==string.Empty)
                {
                    errorProvider1.SetError(t, "faut remplir cette zone");
                    x = true;
                }
            }
            if(dateTimePicker1.Value>=DateTime.Now.Date)
            {
                errorProvider1.SetError(dateTimePicker1, "La date est fausse");
                x = true;
            }
            return x; 
        }

        private void bstart_Click(object sender, EventArgs e)
        {
            gestion_des_stages gds = new gestion_des_stages();
            gds.Show();
            Hide();
        }
    }
}
