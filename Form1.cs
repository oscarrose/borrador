using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejcita
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listarPaciente formp= new listarPaciente();
            formp.Show();
        }

        private void listarDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listarDoctor formDoctor = new listarDoctor();
            formDoctor.Show();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
