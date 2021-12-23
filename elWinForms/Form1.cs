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
    public partial class frmZonas : Form
    {
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=Personajes;User Id=sa;Password=sa;";
        public frmZonas()
        {
            InitializeComponent();
        }

        private void frmZonas_Load(object sender, EventArgs e)
        {
            using (SqlConnection conexionABaseDeDatos = new SqlConnection(connectionString))
            {
                conexionABaseDeDatos.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Zonas", conexionABaseDeDatos);
                dataAdapter.SelectCommand.CommandType = CommandType.Text;
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                DataRow dataRow = dataTable.NewRow();
                dataRow["ZonasID"] = "0";
                dataRow["Nombre"] = "";
                dataTable.Rows.InsertAt(dataRow, 0);

                cmbZonas.DataSource = dataTable;
                cmbZonas.ValueMember = "ZonasID";
                cmbZonas.DisplayMember = "Nombre";
            }
        }

        private void cmbZonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbZonas.SelectedIndex != 0)
                picZonaSeleccionada.Load("../../../imagenes/Zonas/" + cmbZonas.SelectedValue.ToString() + ".png");
            else
                picZonaSeleccionada.Image = null;
        }
    }
}
