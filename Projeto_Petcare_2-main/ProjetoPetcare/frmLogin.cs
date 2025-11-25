using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPetcare
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            string usuario = "gui";
            int senha = 123;

            usuario = txtnome.Text;
            senha = Convert.ToInt32(txtsenha.Text);

            if (usuario == "bizao" && senha == 123)
            {
                frmMenuPrincipal abrir = new frmMenuPrincipal();
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos, tente novamente!");

            }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            txtnome.Clear();    
            txtsenha.Clear();
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
