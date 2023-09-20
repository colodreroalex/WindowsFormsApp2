using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FPrincipal : Form
    {
        public FPrincipal()
        {
            InitializeComponent();
        }

        private void b_copiar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(TB_etrada.Text))
                    throw new Exception("ERROR: La entrada está vacia");

                TB_salida.Text = TB_etrada.Text;

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message,
                    "Error: Transferir texto",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void B_ocultar_Click(object sender, EventArgs e)
        {
            //Si TB_entrada esta visible
            if (TB_etrada.Visible)
            {
                // -> Ocultar etiqueta de entrada
                L_entrada.Visible = false;
                // -> Ocultar cuadro de texto de entrada
                TB_etrada.Visible = false;
                // -> Modificar etiqueta del boton ocultar
                B_ocultar.Text = "Mostrar";
            }
            //Si TB_entrada NO esta visible 
            else
            {
                // -> Ocultar etiqueta de entrada
                L_entrada.Visible = true;
                // -> Ocultar cuadro de texto de entrada
                TB_etrada.Visible = true;
                // -> Modificar etiqueta del boton ocultar
                B_ocultar.Text = "Ocultar";
            }







        }

        private void B_deshabilitar_Click(object sender, EventArgs e)
        {
            if (TB_etrada.Enabled)
            {
                L_entrada.Enabled = false;
                TB_etrada.Enabled = false;
                B_deshabilitar.Text = "Habilitar";
            }
            else
            {
                L_entrada.Enabled = true;
                TB_etrada.Enabled = true;
                B_deshabilitar.Text = "Deshabilitar";
            }
        }

        private void B_readOnly_Click(object sender, EventArgs e)
        {
            if (TB_etrada.ReadOnly)
            {
                TB_etrada.ReadOnly = false;
                B_readOnly.Text = "Solo lectura";
            }
            else
            {
                TB_etrada.ReadOnly = true;
                B_readOnly.Text = "Edicion";
            }
        }
    }
}
