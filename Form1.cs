using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlquilerAutomoviles
{
    public partial class Form1 : Form
    {
        List<Alquiler> alquileres = new List<Alquiler>();
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        List<Cliente> clientes = new List<Cliente>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Como hay que validar que no se ingresen datos 
            //repetidos del vehiculo, es necesario cargar 
            //los datos del archivo a las listas al arrancar

            //Verificar si el archivo existe para que no de error en caso de ser la
            //primera vez que corremos el programa
            if (File.Exists("vehiculos.txt"))
            {
                FileStream stream = new FileStream("vehiculos.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);

                while (reader.Peek() > -1)
                {
                    Vehiculo vehiculo = new Vehiculo();
                    vehiculo.Placa = reader.ReadLine();
                    vehiculo.Marca = reader.ReadLine();
                    vehiculo.Modelo = Convert.ToInt32(reader.ReadLine());
                    vehiculo.Color = reader.ReadLine();
                    vehiculo.PrecioKilometro = Convert.ToDouble(reader.ReadLine());

                    vehiculos.Add(vehiculo);
                }
                reader.Close();
            }
        }


        private void GuardarVehiculo()
        {
            FileStream stream = new FileStream("vehiculos.txt", FileMode.OpenOrCreate, FileAccess.Write);            
            StreamWriter writer = new StreamWriter(stream);
            foreach (var vehiculo in vehiculos)
            {
                writer.WriteLine(vehiculo.Placa);
                writer.WriteLine(vehiculo.Marca);
                writer.WriteLine(vehiculo.Modelo);
                writer.WriteLine(vehiculo.Color);
                writer.WriteLine(vehiculo.PrecioKilometro);                
            }
            //Cerrar el archivo
            writer.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            
                     
            bool existe = vehiculos.Exists(v => v.Placa == textBoxPlaca.Text);

            //si existe indicarlo con un Messagebox
            if (existe)
            {
                MessageBox.Show("Esa placa ya existe", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //sino existe el vehiculo
                // se crea un nuevo vehículo con los datos del formulario
                Vehiculo vehiculo = new Vehiculo();

                vehiculo.Placa = textBoxPlaca.Text;
                vehiculo.Marca = comboBoxMarca.SelectedItem.ToString();
                vehiculo.Modelo = Convert.ToInt32(numericUpDownModelo.Value);
                vehiculo.Color = comboBoxColor.SelectedItem.ToString();
                vehiculo.PrecioKilometro = Convert.ToDouble(textBoxPrecio.Text);

                //se agrega el vehiculo a la lista de vehiculos
                vehiculos.Add(vehiculo);

                //se manda a guardar la lista al archivo 
                //para que ambos esten siempre sincronizados
                GuardarVehiculo();

            }

            

        }
    }
}
