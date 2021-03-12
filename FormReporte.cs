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
    public partial class FormReporte : Form
    {

        List<Alquiler> alquileres = new List<Alquiler>();
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        List<Cliente> clientes = new List<Cliente>();
        List<Reporte> reportes = new List<Reporte>();


        public FormReporte()
        {
            InitializeComponent();
        }

        private void buttonReporte_Click(object sender, EventArgs e)
        {
            //recorrer cada alquiler en la lista alquileres
            foreach (var alquiler in alquileres)
            {
                //en cada alquiler buscar quien es el cliente que alquilo por medio de su Nit
                Cliente cliente = clientes.Find(c => c.Nit == alquiler.Nit);

                //en cada alquiler buscar que vehiculo se alquilo por medio de su Placa
                Vehiculo vehiculo = vehiculos.Find(v => v.Placa == alquiler.Placa);

                //Ya con los 3 datos, se crea un nuevo reporte
                Reporte reporte = new Reporte();

                //los datos se van a traer del objeto correspondiente donde esta el dato que interesa
                reporte.Nombre = cliente.Nombre;
                reporte.Placa = vehiculo.Placa;
                reporte.Marca = vehiculo.Marca;
                reporte.Modelo = vehiculo.Modelo;
                reporte.Color = vehiculo.Color;
                reporte.FechaDevolucion = alquiler.FechaDevolucion;
                reporte.Total = vehiculo.PrecioKilometro * alquiler.Kilometros;

                //agregar el reporte a la lista de reportes
                reportes.Add(reporte);

            }

            dataGridViewReporte.DataSource = null;
            dataGridViewReporte.DataSource = reportes;
            dataGridViewReporte.Refresh();
        }

        private void FormReporte_Load(object sender, EventArgs e)
        {
            //cargar todos los datos a sus listas

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

            if (File.Exists("clientes.txt"))
            {
                FileStream stream = new FileStream("clientes.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);

                while (reader.Peek() > -1)
                {
                    Cliente cliente = new Cliente();
                    cliente.Nit = reader.ReadLine();
                    cliente.Nombre = reader.ReadLine();
                    cliente.Direccion = reader.ReadLine();

                    clientes.Add(cliente);
                }
                reader.Close();
            }

            if (File.Exists("alquileres.txt"))
            {
                FileStream stream = new FileStream("alquileres.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);

                while (reader.Peek() > -1)
                {
                    Alquiler alquiler = new Alquiler();
                    alquiler.Nit = reader.ReadLine();
                    alquiler.Placa = reader.ReadLine();
                    alquiler.FechaAlquiler = Convert.ToDateTime(reader.ReadLine());
                    alquiler.FechaDevolucion = Convert.ToDateTime(reader.ReadLine());
                    alquiler.Kilometros = Convert.ToInt32(reader.ReadLine());

                    alquileres.Add(alquiler);

                }
                reader.Close();
            }



        }

        private void buttonRecorrido_Click(object sender, EventArgs e)
        {
            int mayor = alquileres.Max(k => k.Kilometros);

            labelRecorrido.Text = "El mayor recorrido fue de " + mayor.ToString();
        }
    }
}
