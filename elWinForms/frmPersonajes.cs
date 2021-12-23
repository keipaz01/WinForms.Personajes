using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elWinForms
{
    public partial class frmPersonajes : Form
    {
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=Personajes;User Id=sa;Password=sa;";

        public frmPersonajes()
        {
            InitializeComponent();
        }
        

        private void frmPersonajes_Load(object sender, EventArgs e)
        {
            // Crear conexión a la base de datos
            using (SqlConnection conexionABaseDeDatos = new SqlConnection(connectionString))
            {
                // Abrir la conexion a la base de datos
                conexionABaseDeDatos.Open();
                
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Personajes", conexionABaseDeDatos);
                dataAdapter.SelectCommand.CommandType = CommandType.Text;
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                DataRow dataRow = dataTable.NewRow();
                dataRow["PersonajeID"] = 0;
                dataRow["Nombre"] = "";
                dataTable.Rows.InsertAt(dataRow, 0);

                cmbPersonajes.DataSource = dataTable;
                cmbPersonajes.ValueMember = "PersonajeID";
                cmbPersonajes.DisplayMember = "Nombre";
            }
        }

        private void cmbPersonajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPersonajes.SelectedIndex != 0) // Esto es un if que se fija si el selectedIndex es distinto de cero.
                picPersonajeSeleccionado.Load("../../../imagenes/Personajes/" + cmbPersonajes.SelectedValue.ToString() + ".png"); // Si es distinto de cero, busco una imagen con ese id
            else // Si es cero
                picPersonajeSeleccionado.Image = null; // No muestro ninguna imagen
        }

        private void btnZonas_Click(object sender, EventArgs e)
        {
            frmZonas f2 = new frmZonas();
            f2.Show();
        }
    }
}
