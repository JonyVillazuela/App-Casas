using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;


namespace WinForm_Casas
{
    public partial class FrmCasas : Form
    {
        private List<Vivienda> listaVivienda;
        public FrmCasas()
        {
            InitializeComponent();
        }

        private void FrmCasas_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void dgvViviendas_SelectionChanged(object sender, EventArgs e)
        {
            Vivienda selecionada = (Vivienda) dgvViviendas.CurrentRow.DataBoundItem;
            cargarImagen(selecionada.Imagen);
        }

        private void cargar()
        {
            ViviendaDatos datos = new ViviendaDatos();
            try
            {
                listaVivienda = datos.listar();
                dgvViviendas.DataSource = listaVivienda;
                dgvViviendas.Columns["Imagen"].Visible = false;
                dgvViviendas.Columns["Id"].Visible = false;
                cargarImagen(listaVivienda[0].Imagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxCasas.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxCasas.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/681px-Placeholder_view_vector.svg.png");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaVivienda alta = new frmAltaVivienda();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Vivienda seleccionada;
            seleccionada = (Vivienda)dgvViviendas.CurrentRow.DataBoundItem;

            frmAltaVivienda modificar = new frmAltaVivienda(seleccionada);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            ViviendaDatos datos = new ViviendaDatos();
            Vivienda seleccionada;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres eliminar esta vivienda?", "Eliminando",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionada = (Vivienda)dgvViviendas.CurrentRow.DataBoundItem;
                    datos.eliminar(seleccionada.Id);
                    cargar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
