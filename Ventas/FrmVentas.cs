using Microsoft.Data.SqlClient;
using System.Data;

namespace Ventas
{
    public partial class FrmVentas : Form
    {
        private readonly string _connectionString;
        public FrmVentas()
        {
            InitializeComponent();
            //DgvVentas.AutoGenerateColumns = false;

            _connectionString = "Server=localhost;" +
                "Database=VentasDB;" +
                "Trusted_Connection=True;" +
                "TrustServerCertificate=True";

            CargarGridVentas();
        }

        private void CargarGridVentas()
        {
            try
            {
                DgvVentas.DataSource = null;

                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "SELECT  Id,Fecha,Folio,Total,ClienteId FROM Ventas";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        DataTable dtVentas = new DataTable();
                        adapter.Fill(dtVentas);

                        DgvVentas.DataSource = dtVentas;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarVentas_Click(object sender, EventArgs e)
        {
            try
            {
                DgvVentas.DataSource = null;

                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "SELECT  Id,Fecha,Folio,Total,ClienteId" +
                        " FROM Ventas" +
                        " WHERE Fecha LIKE '%" + TxtBusquedaVentas.Text + "%'";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        DataTable dtVentas = new DataTable();
                        adapter.Fill(dtVentas);

                        DgvVentas.DataSource = dtVentas;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int renglonSeleccionado = DgvVentas.CurrentRow.Index;
                string dato = DgvVentas.Rows[renglonSeleccionado].Cells["Id"].Value.ToString();

                int.TryParse(dato, out int ventaId);
                if (ventaId == 0)
                {
                    throw new Exception("No se pudo obtener el Id");
                }

                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "UPDATE Ventas" +
                        " SET Fecha = '" + TxtFechaVentas.Text + "'," +
                        " Folio = '" + TxtFolioVentas.Text + "'," +
                        " Total = '" + TxtTotalVentas.Text + "'" +
                        " ClienteId = '" + TxtClienteVentas.Text + "'" +
                        " WHERE Id = " + ventaId;

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        con.Open();

                        int registrosAfectados = cmd.ExecuteNonQuery();
                        if (registrosAfectados == 0)
                        {
                            throw new Exception("No se actualizo registro");
                        }

                        TxtFechaVentas.Text = string.Empty;
                        TxtFolioVentas.Text = string.Empty;
                        TxtTotalVentas.Text = string.Empty;
                        TxtClienteVentas.Text = string.Empty;

                        MessageBox.Show("Registro actualizado");
                        CargarGridVentas();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnNuevoVentas_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "INSERT INTO Ventas" +
                        " (Fecha,Folio,Total,ClienteId)" +
                        " VALUES" +
                        " ('" + TxtFechaVentas.Text + "', '" + TxtFolioVentas.Text + "', '" + TxtTotalVentas.Text + "', '" + TxtClienteVentas.Text + "')";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        con.Open();

                        int registrosAfectados = cmd.ExecuteNonQuery();
                        if (registrosAfectados == 0)
                        {
                            throw new Exception("No se agrego registro");
                        }

                        TxtFechaVentas.Text = string.Empty;
                        TxtFolioVentas.Text = string.Empty;
                        TxtTotalVentas.Text = string.Empty;
                        TxtClienteVentas.Text = string.Empty;

                        MessageBox.Show("Registro agregado");
                        CargarGridVentas();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void BtnEliminarVentas_Click(object sender, EventArgs e)
        {
            try
            {
                int renglonSeleccionado = DgvVentas.CurrentRow.Index;
                string dato = DgvVentas.Rows[renglonSeleccionado].Cells["Id"].Value.ToString();

                int.TryParse(dato, out int ventaId);
                if (ventaId == 0)
                {
                    throw new Exception("No se pudo obtener el Id");
                }

                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "DELETE FROM Ventas" +
                        " WHERE Id = " + ventaId;

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        con.Open();

                        int registrosAfectados = cmd.ExecuteNonQuery();
                        if (registrosAfectados == 0)
                        {
                            throw new Exception("No se elimino registro");
                        }

                        MessageBox.Show("Registro eliminado");
                        CargarGridVentas();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
