using CadastroDePessoas.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDePessoas
{
    public partial class InicioForm : Form
    {
        public InicioForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = !button2.Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cadastroform = new CadastroForm();
            cadastroform.Show();
        }
    }
}
