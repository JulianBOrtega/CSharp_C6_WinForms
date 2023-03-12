using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_6_Julian_B_Ortega
{
    public partial class mainFrame : Form
    {
        private string[] generos = new string[] { "Accion", "Horror", "Romance", "Programación", "Religión" };
        private List<string> libros = new List<string>();
        private BindingSource bs = new BindingSource();

        public mainFrame()
        {
            InitializeComponent();
            bs.DataSource = libros;
            inputGenero.Items.AddRange(generos);
            inputGenero.SelectedIndex = 0;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Faltan completar datos o los campos contienen datos incorrectos. Verificar que las páginas y precios solo contienen números", "Datos incorrectos");
                return;
            }
            
            Libro nuevoLibro = new Libro(
                inputNombre.Text.Trim(), 
                inputAutor.Text.Trim(), 
                inputGenero.Text.Trim(),
                Convert.ToInt32(inputPaginas.Text.Trim()), 
                chbImportado.Checked, 
                float.Parse(inputPrecio.Text.Trim())
                );

            LimpiarFormulario();
            libros.Add(nuevoLibro.ObtenerComoString());
            lstLibros.DataSource = bs;
            bs.ResetBindings(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult reply = MessageBox.Show("¿Desea salir de la aplicación?", "Cancelar", MessageBoxButtons.YesNo);
            if (reply == DialogResult.Yes) Application.Exit();
        }

        private void lstLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private bool ValidarCampos()
        {
            if (inputNombre.Text.Trim().Length <= 0) return false;
            if (inputAutor.Text.Trim().Length <= 0) return false;
            if (inputGenero.Text.Trim().Length <= 0) return false;
            if (inputPaginas.Text.Trim().Length <= 0 || !int.TryParse(inputPaginas.Text.Trim(), out int pag)) return false;
            if (inputPrecio.Text.Trim().Length <= 0 || !float.TryParse(inputPrecio.Text.Trim(), out float prec)) return false;

            return true;
        }

        private void LimpiarFormulario()
        {
            inputNombre.Clear();
            inputAutor.Clear();
            inputPaginas.Clear();
            inputGenero.SelectedIndex = 0;
            chbImportado.Checked = false;
            inputPrecio.Clear();
        }
    }
}
