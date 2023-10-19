using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_num_3
{
    public partial class FormCrearJuego : Form
    {

        public FormCrearJuego()
        {
            InitializeComponent();
        }

        private void FormCrearJuego_Load(object sender, EventArgs e)
        {

        }

        private void buttonComenzar_Click(object sender, EventArgs e)
        {
            AmigoSecreto amigoSecreto = new AmigoSecreto(Convert.ToInt32(numericCantidadDeJugadores.Value), dateFechaDeInicio.Value, dateFechaDeDescubrimiento.Value, Convert.ToInt32(numericNumeroDeEndulzadas), Convert.ToInt32(numericFrecuenciaDeEndulzadas), Convert.ToDouble(textBoxValorDeEndulzadas.Text), Convert.ToDouble(textBoxValorDeRegalo.Text));
        }
    }
}
