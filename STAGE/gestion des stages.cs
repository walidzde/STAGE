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
    public partial class gestion_des_stages : Form
    {
        SqlDbConnect ocon;
        static int a=0;
        stage s;
        public gestion_des_stages()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            stage.liststage.Clear();
            s = new stage();
            s.Nomstage=dgvliststage.CurrentRow.Cells[0].Value.ToString();
            s.Datedebut=Convert.ToDateTime( dgvliststage.CurrentRow.Cells[1].Value);
            s.Datefin=Convert.ToDateTime( dgvliststage.CurrentRow.Cells[2].Value);
            s.Cds = dgvliststage.CurrentRow.Cells[5].Value.ToString();
            stage.liststage.Add(s);
            list_des_inscrits ldi = new list_des_inscrits();
            ldi.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); 
        }

        private void gestion_des_stages_Load(object sender, EventArgs e)
        {
            
            ocon = new SqlDbConnect();
            ocon.SqlQuery("select ts as 'Type Stage',debuts as 'Date Debut',fins as 'Date Fin',nbplace as 'Nombre du place',nbinscrit as 'nombre inscrit',cds  from stage where debuts>getdate()");
            dgvliststage.DataSource = ocon.QueryEx();
            //MessageBox.Show("test");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = a+1;
            if (a % 2 != 0)
            {
                dgvliststage.Sort(dgvliststage.Columns[1], ListSortDirection.Ascending);

            }
            else
            {
                dgvliststage.Sort(dgvliststage.Columns[1], ListSortDirection.Descending);
            }
        }

        private void listepartype_Click(object sender, EventArgs e)
        {
            a = a + 1;
            if (a % 2 != 0)
            {
                dgvliststage.Sort(dgvliststage.Columns[0], ListSortDirection.Ascending);

            }
            else
            {
                dgvliststage.Sort(dgvliststage.Columns[0], ListSortDirection.Descending);
            }
            
        }
    }
}
