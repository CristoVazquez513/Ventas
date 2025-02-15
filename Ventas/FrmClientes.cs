using Microsoft.Data.SqlClient;
using System.Data;

namespace Ventas
{
    public partial class FrmClientes : Form
    {
        private readonly string _connectionString;
        public FrmClientes()
        {
            InitializeComponent();
            DgvClientes.AutoGenerateColumns = false;

            _connectionString = "Server=localhost;" +
                "Database=VentasDB;" +
                "Trusted_Connection=True;" +
                "TrustServerCertificate=True";

            CargarGridClientes();
        }

        private void CargarGridClientes()
        {
            try
            {
                DgvClientes.DataSource = null;

                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "SELECT  Id,Nombre,Telefono,Domicilio FROM Clientes";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        DataTable dtClientes = new DataTable();
                        adapter.Fill(dtClientes);

                        DgvClientes.DataSource = dtClientes;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnBusquedaClientes_Click(object sender, EventArgs e)
        {
            try
            {
                DgvClientes.DataSource = null;

                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "SELECT  Id,Nombre,Telefono,Domicilio" +
                        " FROM Clientes" +
                        " WHERE Nombre LIKE '%" + TxtBusquedaClientes.Text + "%'";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        DataTable dtClientes = new DataTable();
                        adapter.Fill(dtClientes);

                        DgvClientes.DataSource = dtClientes;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnNuevoClientes_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "INSERT INTO Clientes" +
                        " (Nombre,Telefono,Domicilio)" +
                        " VALUES" +
                        " ('" + TxtNombreClientes.Text + "', '" + TxtTelefonoClientes.Text + "', '" + TxtDomicilioClientes.Text + "')";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        con.Open();

                        int registrosAfectados = cmd.ExecuteNonQuery();
                        if (registrosAfectados == 0)
                        {
                            throw new Exception("No se agrego registro");
                        }

                        TxtNombreClientes.Text = string.Empty;
                        TxtTelefonoClientes.Text = string.Empty;
                        TxtDomicilioClientes.Text = string.Empty;

                        MessageBox.Show("Registro agregado");
                        CargarGridClientes();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void BtnEditarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                int renglonSeleccionado = DgvClientes.CurrentRow.Index;
                string dato = DgvClientes.Rows[renglonSeleccionado].Cells["Id"].Value.ToString();

                int.TryParse(dato, out int clienteId);
                if (clienteId == 0)
                {
                    throw new Exception("No se pudo obtener el Id");
                }

                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "UPDATE Clientes" +
                        " SET Nombre = '" + TxtNombreClientes.Text + "'," +
                        " Telefono = '" + TxtTelefonoClientes.Text + "'," +
                        " Domicilio = '" + TxtDomicilioClientes.Text + "'" +
                        " WHERE Id = " + clienteId;

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        con.Open();

                        int registrosAfectados = cmd.ExecuteNonQuery();
                        if (registrosAfectados == 0)
                        {
                            throw new Exception("No se actualizo registro");
                        }

                        TxtNombreClientes.Text = string.Empty;
                        TxtTelefonoClientes.Text = string.Empty;
                        TxtDomicilioClientes.Text = string.Empty;

                        MessageBox.Show("Registro actualizado");
                        CargarGridClientes();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEliminarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                int renglonSeleccionado = DgvClientes.CurrentRow.Index;
                string dato = DgvClientes.Rows[renglonSeleccionado].Cells["Id"].Value.ToString();

                int.TryParse(dato, out int clienteId);
                if (clienteId == 0)
                {
                    throw new Exception("No se pudo obtener el Id");
                }

                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "DELETE FROM Clientes" +
                        " WHERE Id = " + clienteId;

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
                        CargarGridClientes();
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
