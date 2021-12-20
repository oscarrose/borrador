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
    public partial class listarDoctor : Form
    {
        public listarDoctor()
        {
            InitializeComponent();
        }

        private void listarDoctor_Load(object sender, EventArgs e)
        {
            griddoctor.DataSource = logicaCita.obtenerdoctor();

        }
    }
}
