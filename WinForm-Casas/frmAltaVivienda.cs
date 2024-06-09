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
using datos;
using negocio;
using System.IO;
using System.Configuration;


namespace WinForm_Casas
{
    public partial class frmAltaVivienda : Form
    {
        private Vivienda vivienda = null;
        private OpenFileDialog archivo = null;
        public frmAltaVivienda()
        {
            InitializeComponent();
        }

        public frmAltaVivienda(Vivienda vivienda)
        {
            InitializeComponent();
            this.vivienda = vivienda;
            Text = "Modificar Vivienda";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Vivienda house = new Vivienda();
            ViviendaDatos datos = new ViviendaDatos();

            try
            {
                if (vivienda == null)
                    vivienda = new Vivienda();

                vivienda.Casa_lote = int.Parse(txtLote.Text);
                vivienda.Ambientes = int.Parse(txtAmbientes.Text);
                vivienda.M2 = int.Parse(txtM2.Text);
                vivienda.Imagen = txtImagenDescriptiva.Text;
                vivienda.Dormitorios = int.Parse(txtDormitorios.Text);
                vivienda.Baños = int.Parse(txtBaños.Text);
                vivienda.Piscina = (string)cboPiscina.SelectedItem;
                vivienda.Tipo_de_Ventana = (Ventana)cboVentana.SelectedItem as Ventana;
                vivienda.Tipo_de_Calefaccion = (Calefaccion)cboCalefaccion.SelectedItem as Calefaccion;
                //vivienda.Tipo_de_Ventana =cboVentana.SelectedItem as Ventana;
                //vivienda.Tipo_de_Calefaccion = cboCalefaccion.SelectedItem as Calefaccion;

                if (vivienda.Id != 0)
                {
                    datos.modificar(vivienda);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    datos.agregar(vivienda);
                    MessageBox.Show("Agregado exitosamente");
                }

                //Guardo la imagen si la levanto localmente
                if (archivo != null && !(txtImagenDescriptiva.Text.ToUpper().Contains("HTTP"))) 
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);


                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaVivienda_Load(object sender, EventArgs e)
        {
            VentanaDatos ventanaDatos = new VentanaDatos();
            CalefaccionDatos calefaccionDatos = new CalefaccionDatos();

            try
            {
                List<Ventana> ventanas = new List<Ventana>
                {
                    new Ventana { Id = 1, TipoVentana = "Vidrio simple" },
                    new Ventana { Id = 2, TipoVentana = "DVH" }
                };

                cboVentana.DataSource = ventanaDatos.listar();
                cboVentana.ValueMember = "Id";
                cboVentana.DisplayMember = "TipoVentana";

                List<Calefaccion> calefacciones = new List<Calefaccion>
                {
                    new Calefaccion { Id = 1, TipoCalefaccion = "Radiadores" },
                    new Calefaccion { Id = 2, TipoCalefaccion = "Losa radiante" }
                };

                cboCalefaccion.DataSource = calefaccionDatos.listar();
                cboCalefaccion.ValueMember = "Id";
                cboCalefaccion.DisplayMember = "TipoCalefaccion";

                if (vivienda != null)
                {
                    txtLote.Text = vivienda.Casa_lote.ToString();
                    txtAmbientes.Text = vivienda.Ambientes.ToString();
                    txtM2.Text = vivienda.M2.ToString();
                    txtImagenDescriptiva.Text = vivienda.Imagen;
                    cargarImagen(vivienda.Imagen);
                    txtDormitorios.Text = vivienda.Dormitorios.ToString();
                    txtBaños.Text = vivienda.Baños.ToString();
                    cboPiscina.Text = vivienda.Piscina;
                    //cboCalefaccion.SelectedValue = vivienda.Tipo_de_Calefaccion.Id;
                    //cboVentana.SelectedValue = vivienda.Tipo_de_Ventana.Id;

                    if (vivienda.Tipo_de_Ventana != null)
                    {
                      cboVentana.SelectedValue = vivienda.Tipo_de_Ventana.Id;
                    }
                    if (vivienda.Tipo_de_Calefaccion != null)
                    {
                      cboCalefaccion.SelectedValue = vivienda.Tipo_de_Calefaccion.Id;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void txtImagenDescriptiva_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagenDescriptiva.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxCasas.Load(imagen);
            }
            catch (Exception)
            {

                pbxCasas.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/681px-Placeholder_view_vector.svg.png");
            }
        }

        private void AgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagenDescriptiva.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

                //guardo la imagen
                //File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);

                //guardar imagen en pc y la ruta en base de datos


            }
        }
    }
}
