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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncadacliente_Click(object sender, EventArgs e)
        {
            frmCadastroCliente abrir = new frmCadastroCliente();
            abrir.Show();
            this.Hide();
        }

        private void btncadasanimal_Click(object sender, EventArgs e)
        {
            frmCadastroAnimal abrir = new frmCadastroAnimal();
            abrir.Show();
            this.Hide();
        }

        private void btncadasvaterinario_Click(object sender, EventArgs e)
        {
            frmCadastroVeterinario abrir = new frmCadastroVeterinario();
            abrir.Show();
            this.Hide();
        }
    }
}
