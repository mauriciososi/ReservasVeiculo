using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ERP
{
    
    public partial class frmAdicionar : Form
    {
        
        //string connectionString = @"Data Source=N20393\SQLEXPRESS;Initial Catalog=db_locadora;
        //                             Trusted_Connection=True;Integrated Security=True";
       
        // optionsBuilder.UseSqlServer(@"Server=DESKTOP-9GPMUV2;Database=Cliente;Trusted_Connection=True;");
        bool novo;   // inserir novo registro
        public frmAdicionar()
        {
            //txtCodCli.Text = "teste";
            InitializeComponent();
        }

        private void lblSobreNome_Click(object sender, EventArgs e)
        {

        }

        //private void foxrmPrincipal_Load(object sender, EventArgs e)
        //{

        //}

        private void btnCreate_Click(object sender, EventArgs e)
        {
            novo = true;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {

        }

        //private void formPrincipal_Load(object sender, EventArgs e)
        private void frmAdicionar_Load(object sender, EventArgs e)
        {
            //Código cliente deverá aparecer protegido /será gerado automaticamente
            txtCodCli.Enabled= false;
             
            //int @id = 0;
            //int wrk_id = 1;
        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            
            string strcon = @"Data Source=N20393\SQLEXPRESS; Initial Catalog=db_locadora;Integrated security=True";
                             

            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            string sql = "INSERT INTO TBL_CLIENTE (Nome_cliente,Sobrenome_cliente,CPF_cliente)" +
                         "VALUES (@nome,@sobre, @cpf)";
                                   
            SqlCommand cmd = new SqlCommand(sql, con);
            
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
            cmd.Parameters.AddWithValue("@sobre",  txtSobreNome.Text);
            
            cmd.CommandType = CommandType.Text;
           
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                txtNome.Text = " ";
                txtCPF.Text = " ";
                txtSobreNome.Text = " ";
                con.Close();
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAdicionar_Load_1(object sender, EventArgs e)
        {

        }
    }
}
