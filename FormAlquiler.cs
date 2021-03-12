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
    public partial class FormAlquiler : Form
    {

        List<Alquiler> alquileres = new List<Alquiler>();
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        List<Cliente> clientes = new List<Cliente>();


        public FormAlquiler()
        {
            InitializeComponent();
        }


        private void Guardar()
        {
            FileStream stream = new FileStream("alquileres.txt", FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);

            foreach (var alquiler in alquileres)
            {
                writer.WriteLine(alquiler.Nit);
                writer.WriteLine(alquiler.Placa);
                writer.WriteLine(alquiler.FechaAlquiler);
                writer.WriteLine(alquiler.FechaDevolucion);
                writer.WriteLine(alquiler.Kilometros);

            }
            

            writer.Close();

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            //se crea un nuevo alquiler
            Alquiler alquiler = new Alquiler();
            alquiler.Nit = textBoxNit.Text;
            alquiler.Placa = comboBoxPlaca.SelectedValue.ToString();
            alquiler.FechaAlquiler = dateTimePickerAlquilado.Value;
            alquiler.FechaDevolucion = dateTimePickerDevuelto.Value;
            alquiler.Kilometros = Convert.ToInt32(textBoxKilometros.Text);

            //se guarda en la lista de alquileres
            alquileres.Add(alquiler);

            //se manda a guardar al archivo toda la lista de alquileres
            Guardar();



        }

        private void FormAlquiler_Load(object sender, EventArgs e)
        {
            //cargar los vehículos
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


            //se cargan las placas al combobox
            comboBoxPlaca.ValueMember = "Placa";
            comboBoxPlaca.DataSource = null;
            comboBoxPlaca.DataSource = vehiculos;
        }
    }
}
