using Microsoft.Data.SqlClient;
using System.Data;

namespace Ventas
{
    public partial class FrmProductos : Form
    {
        private readonly string _connectionString;
        public FrmProductos()
        {
            InitializeComponent();
            //DgvProductos.AutoGenerateColumns = false;

            _connectionString = "Server=localhost;" +
                "Database=VentasDB;" +
                "Trusted_Connection=True;" +
                "TrustServerCertificate=True";

            CargarGridProductos();
        }

        private void CargarGridProductos()
        {
            try
            {
                DgvProductos.DataSource = null;

                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "SELECT  Id,SKU,Descripcion,ValorUnitario FROM Productos";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        DataTable dtProductos = new DataTable();
                        adapter.Fill(dtProductos);

                        DgvProductos.DataSource = dtProductos;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {

        }

        private void BtnBusquedaProductos_Click(object sender, EventArgs e)
        {
            try
            {
                DgvProductos.DataSource = null;

                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "SELECT  Id,SKU, Descripcion, ValorUnitario" +
                        " FROM Productos" +
                        " WHERE Descripcion LIKE '%" + TxtBusquedaProductos.Text + "%'";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        DataTable dtProductos = new DataTable();
                        adapter.Fill(dtProductos);

                        DgvProductos.DataSource = dtProductos;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnNuevoProductos_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "INSERT INTO Productos" +
                        " (SKU,Descripcion,ValorUnitario)" +
                        " VALUES" +
                        " ('" + TxtSKUProductos.Text + "', '" + TxtDescripcionProductos.Text + "', '" + TxtValUProductos.Text + "')";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        con.Open();

                        int registrosAfectados = cmd.ExecuteNonQuery();
                        if (registrosAfectados == 0)
                        {
                            throw new Exception("No se agrego registro");
                        }

                        TxtSKUProductos.Text = string.Empty;
                        TxtDescripcionProductos.Text = string.Empty;
                        TxtValUProductos.Text = string.Empty;

                        MessageBox.Show("Registro agregado");
                        CargarGridProductos();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void BtnEditarProductos_Click(object sender, EventArgs e)
        {
            try
            {
                int renglonSeleccionado = DgvProductos.CurrentRow.Index;
                string dato = DgvProductos.Rows[renglonSeleccionado].Cells["Id"].Value.ToString();

                int.TryParse(dato, out int productoId);
                if (productoId == 0)
                {
                    throw new Exception("No se pudo obtener el Id");
                }

                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "UPDATE Productos" +
                        " SET SKU = '" + TxtSKUProductos.Text + "'," +
                        " Descripcion = '" + TxtDescripcionProductos.Text + "'," +
                        " ValorUnitario = '" + TxtValUProductos.Text + "'" +
                        " WHERE Id = " + productoId;

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        con.Open();

                        int registrosAfectados = cmd.ExecuteNonQuery();
                        if (registrosAfectados == 0)
                        {
                            throw new Exception("No se actualizo registro");
                        }

                        TxtSKUProductos.Text = string.Empty;
                        TxtDescripcionProductos.Text = string.Empty;
                        TxtValUProductos.Text = string.Empty;

                        MessageBox.Show("Registro actualizado");
                        CargarGridProductos();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEliminarProductos_Click(object sender, EventArgs e)
        {
            try
            {
                int renglonSeleccionado = DgvProductos.CurrentRow.Index;
                string dato = DgvProductos.Rows[renglonSeleccionado].Cells["Id"].Value.ToString();

                int.TryParse(dato, out int productoId);
                if (productoId == 0)
                {
                    throw new Exception("No se pudo obtener el Id");
                }

                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "DELETE FROM Productos" +
                        " WHERE Id = " + productoId;

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
                        CargarGridProductos();
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
