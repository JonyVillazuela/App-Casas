using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
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
            cboCampo.Items.Add("M2");
            cboCampo.Items.Add("Dormitorios");
            cboCampo.Items.Add("Piscina");
        }

        private void dgvViviendas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvViviendas.CurrentRow != null)
            {
                Vivienda seleccionada = (Vivienda) dgvViviendas.CurrentRow.DataBoundItem;
                cargarImagen(seleccionada.Imagen);
            }
        }

        private void cargar()
        {
            ViviendaDatos datos = new ViviendaDatos();
            try
            {
                listaVivienda = datos.listar();
                dgvViviendas.DataSource = listaVivienda;
                ocultarColumnas();
                cargarImagen(listaVivienda[0].Imagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvViviendas.Columns["Imagen"].Visible = false;
            dgvViviendas.Columns["Id"].Visible = false;
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
            eliminar();
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }

        private void eliminar(bool logico= false)
        {
            ViviendaDatos datos = new ViviendaDatos();
            Vivienda seleccionada;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres eliminar esta vivienda?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionada = (Vivienda)dgvViviendas.CurrentRow.DataBoundItem;

                    if (logico)
                        datos.EliminarLogico(seleccionada.Id);
                    else
                        datos.eliminar(seleccionada.Id);


                    cargar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            List<Vivienda> listaFiltrada;
            string filtro =txtFiltro.Text;

            if(filtro != "")
            {
            //listaFiltrada = listaVivienda.FindAll(x => x.Ambientes.Contains( int.Parse(filtro)));
                //listaFiltrada = listaVivienda.FindAll(x => x.Ambientes.Contains(filtro));
            listaFiltrada = listaVivienda.FindAll(x => x.Ambientes.ToString().Contains(txtFiltro.Text));

            }
            else
            {
                listaFiltrada = listaVivienda; 
            }

            dgvViviendas.DataSource = null;
            dgvViviendas.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if(opcion == "M2" || opcion == "Dormitorios")
            {
            cboCriterio.Items.Clear();
            cboCriterio.Items.Add("Mayor a");
            cboCriterio.Items.Add("Menor a");
            cboCriterio.Items.Add("Igual a");
                txtFiltroAvanzado.Enabled = true;
            }
            else if (opcion == "Piscina")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("¿Quieres Piscina?:");
                txtFiltroAvanzado.Enabled = true;
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("N/A");
                txtFiltroAvanzado.Enabled = false;
            }
        }

        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, complete el campo para filtrar.");
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, complete el criterio para filtrar.");
                return true;
            }
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "M2" || opcion == "Dormitorios")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("Debes cargar el filtro para numéricos...");
                    return true;
                }

                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Solo nros para filtrar los campos numéricos...");
                    return true;
                }
            }
            else if (opcion == "Piscina")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text) || !esSiONo(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("El campo 'Piscina' solo puede ser 'Si' o 'No'.");
                    return true;
                }
            }
            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if(!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private bool esSiONo(string cadena)
        {
            cadena = cadena.ToLower();
            return cadena == "si" || cadena == "no";
        }

        private void BtnFiltrarEspecifico_Click(object sender, EventArgs e)
        {
            ViviendaDatos datos = new ViviendaDatos();

            try
            {
                if (validarFiltro())
                {
                    return;
                }

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;

                if (string.IsNullOrWhiteSpace(filtro))
                {
                   
                    cargar();
                }
                else
                {
                    
                    dgvViviendas.DataSource = datos.filtrar(campo, criterio, filtro);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }
    }
}
