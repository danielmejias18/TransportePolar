using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using System.Windows.Forms;
using Transporte_Polar.Clases;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


//Codigos de viaje desde Linea 45 hasta la 127
// Camion desde Linea 130 Hatsa la 216 

namespace Transporte_Polar.Ventanas
{
    public partial class MenuPrincipal : Form
    {
        public string cedulaChofer, placaCamion, codigoViaje, destinosViaje, numeroGuia;
        public string estado;
        public string viajecodigo;
        public int precio;
       
        public string fileName = "Camion";
        public string fileNameCodigos = "Codigos";
        public string fileNameViajes = "Viajes";
        public Camion camion;
        public Codigo codigo;
        public Viajes viaje;
        public MenuPrincipal()
        {
            InitializeComponent();
            LoadData();
        }



        //METODO PARA LLENAR EL DATA GRID VIEW
        public void FillTable(List<Viajes> viajes, List<Camion> camiones)
        {
            dataGridViewCuentasporPagar.Rows.Clear();
            if (viajes != null && camiones != null)
            { 
                for (int i=0; i<= camiones.Count();i++)
                {
                    dataGridViewCuentasporPagar.Rows.Add(camiones[i].PlacaCamion, viajes[i].ViajeCodigo);
                }
                
               
            }

            else 
            { 
                dataGridViewCuentasporPagar.Rows.Clear();
            }
        }
        public void LoadData()
        {
            List<Camion> camion = Repositorio.ListaCamiones();
            List<Viajes> viajes = RepositorioViajes.ListaViajes();
            //extracts the ids
            if (viajes != null)
            {
               
                FillTable(viajes, camion);

            }
            else { }
        }



        public void CargarDatosCamion()
        {
            cedulaChofer = textBoxCedulaChofer.Text;
            placaCamion = textBoxPlacaCamion.Text;

            camion = new Camion()
            {
                Cedulachofer = cedulaChofer,
                PlacaCamion = placaCamion
            };
        }
        //aqui empieza la parte de viajes
        
        public void CargarDatosViajes() 
        {
            numeroGuia = textBoxNumeroGuia.Text;
            viajecodigo= comboBoxCodigoViaje.Text;
            if (radioButtonPagado.Checked)
            {
                estado = "Pagado";
            }
            else
            {
                estado = "Realizado";
            }
            viaje = new Viajes()
            {
                NumeroGuia = numeroGuia,
                ViajeCodigo = viajecodigo,
                Estado = estado

            };
        }

        private void buttonIncluirViajes_Click(object sender, EventArgs e)
        {
            CargarDatosViajes();
            if (File.Exists(fileNameViajes))
            {
                var list = RepositorioViajes.ListaViajes();
                list.Add(viaje);
                RepositorioViajes.ListSaveViajes(list);
                MessageBox.Show("Codigo Incluido existosamente");
                Clear();
            }
            else
            {
                var list = new List<Viajes>();
                list.Add(viaje);
                RepositorioViajes.ListSaveViajes(list);
                MessageBox.Show("Viaje Incluido existosamente");
                Clear();

            }
        }
         private void buttonBuscarViajes_Click(object sender, EventArgs e)
        {   
            if (textBoxNumeroGuia.Text == string.Empty)
            {
                MessageBox.Show("Introduce el numero de guia");
            }
            else
            {
                numeroGuia = textBoxNumeroGuia.Text;
                var list = RepositorioViajes.ListaViajes();
                Viajes viajeadmin = list.Find(x => x.NumeroGuia == numeroGuia);
                if (viajeadmin != null)
                {
                    comboBoxCodigoViaje.Text = viajeadmin.ViajeCodigo;
                    if (viajeadmin.Estado == "Pagado")
                    {
                        radioButtonPagado.Checked = true;

                    }
                    else
                    {
                        radioButtonRealizado.Checked = true;
                    }
                }
            }

        }

        //aqui termina la parte de viajes

        //ESTA ES LA PARTE DEL PROYECTO DONDE SE HACEN LOS METODOS DE CODIGO DE VIAJE
        public void CargarDatosCodigo()
        {
            destinosViaje = textBoxDestinos.Text;
            codigoViaje = textBoxCodigoViaje.Text;
            precio = int.Parse(textBoxPrecio.Text);

            codigo = new Codigo()
            {
                Destinos = destinosViaje,
                Codigos = codigoViaje,
                Precio = precio
            };
        }
        private void buttonBuscarCodigo_Click(object sender, EventArgs e)
                
        {
            if (textBoxCodigoViaje.Text == string.Empty)
            {
                MessageBox.Show("Introduce el codigo del viaje");

            }
            else
            {
                codigoViaje = textBoxCodigoViaje.Text;

                var list = RepositorioCodigos.ListaCodigos();

                Codigo codigoadmin = list.Find(x => x.Codigos.ToLower() == codigoViaje.ToLower());
                if (codigoadmin != null)
                {
                    textBoxDestinos.Text = codigoadmin.Destinos;
                    textBoxPrecio.Text = codigoadmin.Precio.ToString();

                }
                else
                {
                    MessageBox.Show("No se encuentra El Codigo del viaje");
                    Clear() ;
                }
            }
        }
          private void buttonActualizarCodigo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCodigoViaje.Text))
            {
                CargarDatosCodigo();
                List<Codigo> list = RepositorioCodigos.ListaCodigos();
                int index = list.FindIndex(c => c.Codigos.ToLower() == codigoViaje.ToLower());
                list[index] = codigo;

                RepositorioCodigos.ListSaveCodigos(list);
                MessageBox.Show("Modificado exitosamente");
                Clear();
            }
        }
          private void buttonClearCodigo_Click(object sender, EventArgs e)
        {
            Clear();
        }
            private void buttonIncluirCodigo_Click(object sender, EventArgs e)
        {
                CargarDatosCodigo();
                if (File.Exists(fileNameCodigos))
                {
                    var list = RepositorioCodigos.ListaCodigos();
                    list.Add(codigo);
                    RepositorioCodigos.ListSaveCodigos(list);
                    MessageBox.Show("Codigo Incluido existosamente");
                    Clear();
                }
                else
                {
                    var list = new List<Codigo>(); //crear nueva lista si no existe
                    list.Add(codigo); //anadir nuevo codigo
                    RepositorioCodigos.ListSaveCodigos(list);
                    MessageBox.Show("Codigo Incluido existosamente");
                    Clear();
                }
             

         }
        //hatsa aca llega laparte de codigos de viaje


        //aqui empieza la parte de camion

        private void buttonBuscarCamion_Click(object sender, EventArgs e)
        {
            if (textBoxCedulaChofer.Text == string.Empty)
            {
                MessageBox.Show("Introduce la cedula del chofer");

            }
            else
            {
                cedulaChofer = textBoxCedulaChofer.Text;

                var list = Repositorio.ListaCamiones();

                Camion camionadmin = list.Find(x => x.Cedulachofer == cedulaChofer);
                if (camionadmin != null)
                {
                    textBoxPlacaCamion.Text = camionadmin.PlacaCamion;

                }
                else
                {
                    MessageBox.Show("No se encuentra la Cedula del chofer");
                }
            }
        }

        private void buttonActualizarCamion_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCedulaChofer.Text))
            {
                CargarDatosCamion();
                List<Camion> list = Repositorio.ListaCamiones();
                int index = list.FindIndex(c => c.Cedulachofer == cedulaChofer);
                list[index] = camion;

                Repositorio.ListSave(list);
                MessageBox.Show("Modificado exitosamente");
                Clear();
            }
        }

       

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            var list = RepositorioCodigos.ListaCodigos();
            foreach (var item in list)
            {
                comboBoxCodigoViaje.Items.Add(item.Codigos);
            }
        }

     

        private void Clear()
        {
            textBoxCedulaChofer.Clear();
            textBoxPlacaCamion.Clear();
            textBoxDestinos.Clear();
            textBoxPrecio.Clear();
            textBoxCodigoViaje.Clear();
        }

        

      


        private void buttonClear_Click(object sender, EventArgs e)
        {
           Clear();
        }

       

        private void buttonIncluirCamion_Click(object sender, EventArgs e)
        {
            CargarDatosCamion();
            if (File.Exists(fileName))
            {
                var list = Repositorio.ListaCamiones();
                list.Add(camion);
                Repositorio.ListSave(list);
                MessageBox.Show("Camion Incluido existosamente");
                
            }
            else
            {
                var list = new List<Camion>(); //crear nueva lista si no existe
                list.Add(camion); //anadir nuevo camion
                Repositorio.ListSave(list);
                MessageBox.Show("Camion Incluido existosamente");


            }
        }
        //hasta aca llega la parte de camion
    }
}
