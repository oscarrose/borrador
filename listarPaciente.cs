using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeNegocioCita;

namespace ejcita
{
    public partial class listarPaciente : Form
    {
        public listarPaciente()
        {
            InitializeComponent();
        }

     
        private void listarPaciente_Load(object sender, EventArgs e)
        {
            //llamando a los metodos 
            gridpaciente.DataSource = CapaDeNegocioCita.logicaCita.obtenerpaciente();
        }
    }
}
