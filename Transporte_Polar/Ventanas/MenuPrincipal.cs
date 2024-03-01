using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using System.Windows.Forms;
using Transporte_Polar.Clases;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

// Codigos de viaje desde Linea 45 hasta la 127
// Camion desde Linea 130 Hatsa la 216 

namespace Transporte_Polar.Ventanas
{
    public partial class MenuPrincipal : Form
    {
        

        // Declaración de variables
        public string cedulaChofer, placaCamion, codigoViaje, destinosViaje, numeroGuia;
        public string estado;
        public string PlacaPorViaje;
        public string viajecodigo;
        public int precio;

        public List<Camion> camiones; 
        public List<Viajes> viajes; 

        public string fileName = "Camion";
        public string fileNameCodigos = "Codigos";
        public string fileNameViajes = "Viajes";
        public Camion camion;
        public Codigo codigo;
        public Viajes viaje;

        // Constructor de la clase
        public MenuPrincipal()
        {
            InitializeComponent();
            LoadCamion();
            LoadViajes();
            LoadData();
           
        }

        public void LoadCamion()
        {
            // Obtiene la lista de camiones desde el repositorio
            List<Camion> camion = Repositorio.ListaCamiones();

            // Llena el DataGridView con la lista de camiones
            if (camion != null)
            {
                FillCamiones(camion);
            }
            else
            {
                dataGridViewCamiones.Rows.Clear();
            }
        }
        //metodo para llenar la lista de cammiones
        public void FillCamiones( List<Camion> camiones)
        {
          
            dataGridViewCuentasporPagar.Rows.Clear();
            if (camiones != null)
            {
               
                // Agrega las filas a la tabla en la GUI
                for (int i = 0; i < camiones.Count(); i++)
                {
                    dataGridViewCamiones.Rows.Add(camiones[i].PlacaCamion, camiones[i].Cedulachofer);
                }
            }
            else
            {
                dataGridViewCamiones.Rows.Clear();
            }
        }
        public void LoadViajes()
        {
            // Obtiene la lista de viajes desde el repositorio
            List<Viajes> viaje = RepositorioViajes.ListaViajes();

            // Llena el DataGridView con la lista de viajes
            if (viaje != null)
            {
                FillViajes(viaje);
            }
            else
            {
                dataGridViewViajes.Rows.Clear();
            }
        }
        //metodo para llenar la lista de cammiones
        public void FillViajes(List<Viajes> viajes)
        {

            dataGridViewViajes.Rows.Clear();
            if (viajes != null && viajes.Count !=0)
            {

                // Agrega las filas a la tabla en la GUI
                for (int i = 0; i < viajes.Count(); i++)
                {
                    dataGridViewViajes.Rows.Add(viajes[i].PlacaCamion, viajes[i].NumeroGuia, viajes[i].ViajeCodigo, viajes[i].Estado);
                }
            }
            else
            {
                dataGridViewViajes.Rows.Clear();
            }
        }
        // Método para cargar datos
        public void LoadData()
        {
            List<Camion> camion = Repositorio.ListaCamiones();
            List<Viajes> viajes = RepositorioViajes.ListaViajes();
            // Extrae los ids de camiones y viajes y los muestra en el Data Grid View
            if (viajes != null)
            {
                FillTable(viajes, camion);
            }
            else { }
        }
        // Método para llenar la tabla de la GUI con la información de los viajes
        public void FillTable(List<Viajes> viajes, List<Camion> camiones)
        {
            int contadorR1 = 0, contadorR2 = 0, contadorR3 = 0;
            dataGridViewCuentasporPagar.Rows.Clear();
            if (viajes != null && camiones != null)
            {
                foreach (Viajes v in viajes)
                {
                    if (v.ViajeCodigo == "R1" && v.Estado == "Realizado")
                        contadorR1++;
                    else if (v.ViajeCodigo == "R2" && v.Estado == "Realizado")
                        contadorR2++;
                    else if (v.ViajeCodigo == "R3" && v.Estado == "Realizado")
                        contadorR3++;
                }
                for (int i = 0; i < viajes.Count(); i++)
                {
                    if (viajes[i].Estado == "Realizado" )
                    {
                        if (viajes[i].ViajeCodigo == "R1")
                            dataGridViewCuentasporPagar.Rows.Add(viajes[i].PlacaCamion, viajes[i].NumeroGuia, viajes[i].ViajeCodigo, contadorR1);
                        else if (viajes[i].ViajeCodigo == "R2")
                            dataGridViewCuentasporPagar.Rows.Add(viajes[i].PlacaCamion, viajes[i].NumeroGuia, viajes[i].ViajeCodigo, contadorR2);
                        else if (viajes[i].ViajeCodigo == "R3")
                            dataGridViewCuentasporPagar.Rows.Add(viajes[i].PlacaCamion, viajes[i].NumeroGuia, viajes[i].ViajeCodigo, contadorR3);
                    }
                }
            }
            else
            {
                dataGridViewCuentasporPagar.Rows.Clear();
            }
        }

        // Método para limpiar los campos de la GUI
        private void Clear()
        {
            textBoxCedulaChofer.Clear();
            textBoxPlacaCamion.Clear();
            textBoxDestinos.Clear();
            textBoxPrecio.Clear();
            textBoxCodigoViaje.Clear();
            textBoxNumeroGuia.Clear();
            textBoxPlacaPorViaje.Clear();
            comboBoxCodigoViaje.SelectedIndex = 0;
            radioButtonPagado.Checked = false;
            radioButtonRealizado.Checked = false;
        }

        // Método para cargar los datos del camión
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

        // Método para cargar los datos del viaje
        public void CargarDatosViajes()
        {
            PlacaPorViaje = textBoxPlacaPorViaje.Text;
            numeroGuia = textBoxNumeroGuia.Text;
            viajecodigo = comboBoxCodigoViaje.Text;
            estado = radioButtonPagado.Checked ? "Pagado" : "Realizado";

            viaje = new Viajes()
            {
                PlacaCamion = PlacaPorViaje,
                NumeroGuia = numeroGuia,
                ViajeCodigo = viajecodigo,
                Estado = estado
            };
        }
        private bool CamposEstanLlenos()
        {
            // Verificamos si las cajas de texto están vacías
            if (string.IsNullOrWhiteSpace(textBoxCedulaChofer.Text) ||
                string.IsNullOrWhiteSpace(textBoxPlacaCamion.Text) ||
                string.IsNullOrWhiteSpace(textBoxDestinos.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrecio.Text) ||
                string.IsNullOrWhiteSpace(textBoxCodigoViaje.Text) ||
                string.IsNullOrWhiteSpace(comboBoxCodigoViaje.Text) ||
                string.IsNullOrWhiteSpace(textBoxNumeroGuia.Text) ||
                (!radioButtonPagado.Checked && !radioButtonRealizado.Checked))
            {
                return false; // Si una caja de texto está vacía, retornamos falso
            }

            return true; // Si todas las cajas de texto tienen datos, retornamos verdadero
        }
        // Evento al hacer click en "Incluir Viajes"
        private void buttonIncluirViajes_Click(object sender, EventArgs e)
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
                    MessageBox.Show("No se encuentra el Codigo del viaje");
                    Clear();
                }
            }

        }

        // Evento al hacer click en "Buscar Viajes"
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
                    textBoxPlacaPorViaje.Text = viajeadmin.PlacaCamion;
                    if (viajeadmin.Estado == "Pagado")
                    {
                        radioButtonPagado.Checked = true;
                    }
                    else
                    {
                        radioButtonRealizado.Checked = true;
                    }
                }
                else
                {
                    MessageBox.Show("No se encuentra el Numero de guia");
                    Clear();
                }
            }
        }

        // Evento al hacer click en "Buscar Código"
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
                    MessageBox.Show("No se encuentra el Codigo del viaje");
                    Clear();
                }
            }
        }

        // Evento al hacer click en "Actualizar Código"
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
            else
            {
                MessageBox.Show("No se encuentra el Codigo del viaje");
                Clear();
            }
        }

        // Evento al hacer click en "Incluir Código"
        private void buttonIncluirCodigo_Click(object sender, EventArgs e)
        {
            // Verificar si todos los campos tienen datos
            if (textBoxCodigoViaje.Text == string.Empty || textBoxDestinos.Text == string.Empty || textBoxPrecio.Text == string.Empty)
            {
                MessageBox.Show("Por favor, completa todos los campos antes de guardar.");
                return;
            }
            else
            {
                codigoViaje = textBoxCodigoViaje.Text;
                var lista = RepositorioCodigos.ListaCodigos();
                Codigo codigoadmin = lista.Find(c => c.Codigos.ToLower() == codigoViaje.ToLower());
                if (codigoadmin != null)
                {
                    MessageBox.Show("Codigo Ya existente");
                    Clear();
                    return;

                }
                else
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
                        var list = new List<Codigo>(); // crear nueva lista si no existe
                        list.Add(codigo); // añadir nuevo código
                        RepositorioCodigos.ListSaveCodigos(list);
                        MessageBox.Show("Codigo Incluido existosamente");
                        Clear();
                    }
                }
            }
        }
        // Evento al hacer click en "Buscar Camión"
        private void buttonBuscarCamion_Click(object sender, EventArgs e)
        {
            // Verificar si todos los campos tienen datos
            
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

        // Evento al hacer click en "Actualizar Camión"
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
            else
            {
                MessageBox.Show("Llena todos los Campos");
            }

                    
                  

        }

        // Evento al cargar el formulario principal


        private void buttonIncluirViajes_Click_1(object sender, EventArgs e)
        {
         //Se verifica si los campos necesarios están vacíos
        if ((textBoxNumeroGuia.Text == string.Empty) || (textBoxPlacaPorViaje.Text == string.Empty)|| (comboBoxCodigoViaje.SelectedIndex == -1))
            {
                MessageBox.Show("Completa todos los campos");
            }

            else
            {
                // Se carga la lista de viajes
                CargarDatosViajes();
                if (File.Exists(fileNameViajes))
                {
                    // Se obtiene la lista existente de viajes
                    var list = RepositorioViajes.ListaViajes();
                    // Se agrega el nuevo viaje a la lista
                    list.Add(viaje);
                    // Se guarda la lista actualizada
                    RepositorioViajes.ListSaveViajes(list);
                    MessageBox.Show("Viaje Incluido exitosamente");
                    // Se limpian los campos
                    Clear();
                }
                else
                {
                    // Si no existe el archivo de viajes, se crea una nueva lista
                    var list = new List<Viajes>();
                    // Se agrega el nuevo viaje a la lista
                    list.Add(viaje);
                    // Se guarda la lista
                    RepositorioViajes.ListSaveViajes(list);
                    MessageBox.Show("Viaje Incluido exitosamente");
                    // Se limpian los campos
                    Clear();
                }
            }
        }

        private void MenuPrincipal_Load_1(object sender, EventArgs e)
        {
            
            // Cargar lista de códigos en el ComboBox de la GUI
            var list = RepositorioCodigos.ListaCodigos();
            foreach (var item in list)
            {
                comboBoxCodigoViaje.Items.Add(item.Codigos);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonClearCodigo_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonActualizarViajes_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBoxNumeroGuia.Text))
            {
                CargarDatosViajes();
                List<Viajes> list = RepositorioViajes.ListaViajes();
                int index = list.FindIndex(c => c.NumeroGuia   == numeroGuia);
                list[index] = viaje;

                RepositorioViajes.ListSaveViajes(list);
                MessageBox.Show("Modificado exitosamente");
                Clear();
            }
            else
            {
                MessageBox.Show("llena la guia del viaje");
            }

        }
        //metodos para buscar el camion que tenga pago pendiente
        public List<Viajes> Search( string desc)
        {

            string descripcion = textBoxSearch.Text;
            List<Viajes> list = RepositorioViajes.ListaViajes();

            return list.FindAll(x => x.PlacaCamion.ToLower().Contains((desc.ToLower())));
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
                List<Viajes> list;
            camiones = Repositorio.ListaCamiones();


                list = Search(textBoxSearch.Text);

                FillTable(list, camiones);
            
        }
        //metodo para buscar un viaje por numero de guia o placa del camion
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
            List<Viajes> list;            
            list = SearchViajes(textBox2.Text);
            FillViajes(list);
        }
        public List<Viajes> SearchViajes(string desc)
        {
            string descripcion = textBox2.Text;
            List<Viajes> list = RepositorioViajes.ListaViajes();
            return list.FindAll(x => x.NumeroGuia.ToLower().Contains((desc.ToLower()))||x.PlacaCamion.ToLower().Contains(desc.ToLower()));
        }

       


        // Método para cargar datos de un código de viaje
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

        // Método para limpiar los campos de código de viaje
        private void buttonClearCodigo_Click(object sender, EventArgs e)
        {
            Clear();
        }

        // Método para limpiar los campos de camión
        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        // Evento al hacer click en "Incluir Camión"
        private void buttonIncluirCamion_Click(object sender, EventArgs e)

        {
            if((textBoxCedulaChofer.Text == string.Empty) || (textBoxPlacaCamion.Text == string.Empty))
            {
                MessageBox.Show("Completa todos los campos");
                return;
            }
            placaCamion = textBoxPlacaCamion.Text;
            var lista = Repositorio.ListaCamiones();
            Camion camionadmi = lista.Find(x => x.PlacaCamion == placaCamion);
            if (camionadmi != null)
            {
                MessageBox.Show("la placa ya existe ");
                Clear();
                return;
            }
                else
                {
                CargarDatosCamion();
                if (File.Exists(fileName))
                {
                    var list = Repositorio.ListaCamiones();
                    list.Add(camion);
                    Repositorio.ListSave(list);
                    MessageBox.Show("Camion Incluido existosamente");
                    Clear();

                }
                else
                {
                    var list = new List<Camion>(); //crear nueva lista si no existe
                    list.Add(camion); //anadir nuevo camion
                    Repositorio.ListSave(list);
                    MessageBox.Show("Camion Incluido existosamente");
                    Clear();
                }
                }
            }
        }
 }
            

           
           
            
            
             
            

        
    
