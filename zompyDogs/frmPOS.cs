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
using ZompyDogsDAO;
using ZompyDogsLib.Controladores;

namespace zompyDogs
{
    public partial class frmPOS : Form
    {

        public static readonly string con_string = "Data Source=MACARENA\\SQLEXPRESS;Initial Catalog=DB_ZompyDogs;Integrated Security=True;Encrypt=False";
        public static SqlConnection conn = new SqlConnection(con_string);

        public BienvenidaAdmin FormPrincipal { get; set; }
        public EmpleadoBienvenida EmpleadoFormPrincipal { get; set; }
        private PedidosDAO _pedidosDAO;
        public BindingSource _bndsrcPedido;
        private ControladorGeneradoresDeCodigo _controladorGeneradorCodigo;

        private string nuevoCodigoPedido;

        private string pedidoPlatilo;
        private string pedidoCodigo;
        private int pedidoCantidad;
        public decimal totalaPagar = 0;

        public frmPOS()
        {
            InitializeComponent();
            CargarMenu("Entrada");
            AddCategoria();
            GeneradordeCodigoPedidoFromForm();

            _pedidosDAO = new PedidosDAO();
            _controladorGeneradorCodigo = new ControladorGeneradoresDeCodigo();
            _bndsrcPedido = new BindingSource();

            _bndsrcPedido.DataSource = _pedidosDAO.platillosLista;
            dgvPedido.DataSource = _bndsrcPedido;

            btnQtyLess.Enabled = false;
            txtPlatilloOrden.Enabled = false;

            dgvPedido.Columns["Codigo"].HeaderText = "Codigo";
            dgvPedido.Columns["Codigo"].DataPropertyName = "Codigo";

            dgvPedido.Columns["PlatilloNombre"].HeaderText = "Platillo";
            dgvPedido.Columns["PlatilloNombre"].DataPropertyName = "PlatilloNombre";
            dgvPedido.Columns["Precio_Unitario"].HeaderText = "Precio";
            dgvPedido.Columns["Precio_Unitario"].DataPropertyName = "Precio_Unitario";

            dgvPedido.Columns["TotalProducto"].Visible = false;
            dgvPedido.Columns["Categoria"].Visible = false;
            dgvPedido.Columns["Descripcion"].Visible = false;
            dgvPedido.Columns["ImagenPlatillo"].Visible = false;

        }
        private void GeneradordeCodigoPedidoFromForm()
        {
            nuevoCodigoPedido = _controladorGeneradorCodigo.GeneradordeCodigoPedidos();
            txtCodigoGenerado.Text = nuevoCodigoPedido;
        }
        private void AddCategoria()
        {
            string qry = "SELECT * FROM Categoria";
            SqlCommand cmd = new SqlCommand(qry, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();

            try
            {
                conn.Open();
                da.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las categorías: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            categoryPanel.Controls.Clear();
            categoryPanel.AutoScroll = true;

            int buttonHeight = 80;
            int buttonWidth = 150;
            int yOffset = -2;

            foreach (DataRow row in dataTable.Rows)
            {
                Button btnCategory = new Button();
                btnCategory.Cursor = Cursors.Hand;
                btnCategory.BackColor = Color.Green;
                btnCategory.ForeColor = Color.White;
                btnCategory.Size = new Size(buttonWidth, buttonHeight);
                btnCategory.Text = row["Categoria"].ToString();

                btnCategory.Location = new Point(-2, categoryPanel.Controls.Count * (buttonHeight + yOffset));

                btnCategory.Click += (sender, e) =>
                {
                    CargarMenu(btnCategory.Text);
                };

                categoryPanel.Controls.Add(btnCategory);
            }
        }

        private void CargarMenu(string categoria)
        {
            using (SqlConnection conn = new SqlConnection(con_string))
            {
                string query = "SELECT Codigo, Platillo, Descripcion, Precio, Imagen FROM v_DetallesMenu WHERE Categoria = @Categoria";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Categoria", categoria);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();


                flpPOSPanel.Controls.Clear();
                bool hasResults = false;

                while (reader.Read())
                {
                    hasResults = true;

                    // Crear panel contenedor para cada platillo
                    Panel panelPlatillo = new Panel();
                    panelPlatillo.BorderStyle = BorderStyle.FixedSingle;

                    Panel panelNombrePlatillo = new Panel();
                    panelNombrePlatillo.Size = new Size(204, 51);
                    panelNombrePlatillo.Dock = DockStyle.Top;

                    Panel panelPrecio = new Panel();
                    panelPrecio.Size = new Size(339, 215);
                    panelPrecio.Dock = DockStyle.Bottom;

                    PictureBox pbxPlatillo = new PictureBox();
                    pbxPlatillo.Size = new Size(155, 154);
                    pbxPlatillo.Location = new Point(30, 10);
                    pbxPlatillo.SizeMode = PictureBoxSizeMode.Zoom;
                    if (reader["Imagen"] != DBNull.Value)
                    {
                        string imageFileName = reader["Imagen"].ToString();
                        string projectPath = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
                        string imagePath = Path.Combine(projectPath, "Imagenes", imageFileName);

                        if (File.Exists(imagePath))
                        {
                            pbxPlatillo.Image = Image.FromFile(imagePath);
                        }
                        else
                        {
                            MessageBox.Show($"La imagen no se encontró en la ruta: {imagePath}");
                        }
                    }

                    Label lblPlatillo = new Label();
                    lblPlatillo.Text = reader["Platillo"].ToString();
                    lblPlatillo.Location = new Point(3, 14);
                    lblPlatillo.AutoSize = true;
                    lblPlatillo.Font = new Font("Arial", 12, FontStyle.Bold);

                    Label lblCodigoPlatillo = new Label();
                    lblCodigoPlatillo.Text = reader["Codigo"].ToString();
                    lblCodigoPlatillo.Location = new Point(8, 8);
                    lblCodigoPlatillo.AutoSize = true;
                    lblCodigoPlatillo.Font = new Font("Arial", 4, FontStyle.Regular);

                    Label lblPrecio = new Label();
                    lblPrecio.Text = $"L.{reader["Precio"].ToString()}";
                    lblPrecio.Location = new Point(20, 5);
                    lblPrecio.AutoSize = true;
                    lblPrecio.Font = new Font("Arial", 10, FontStyle.Bold);

                    TextBox txtDescripcion = new TextBox();
                    if (reader["Descripcion"] != DBNull.Value)
                    {
                        txtDescripcion.Text = reader["Descripcion"].ToString();
                        txtDescripcion.Size = new Size(196, 92);
                        txtDescripcion.Location = new Point(8, 28);
                        txtDescripcion.Multiline = true;
                        txtDescripcion.ReadOnly = true;
                        txtDescripcion.ScrollBars = ScrollBars.Vertical;
                    }
                    else
                    {
                        txtDescripcion.Hide();
                        txtDescripcion.Size = new Size(0, 3);
                    }

                    Button btnAgregarPlatillo = new Button();
                    btnAgregarPlatillo.Text = "Agregar";
                    btnAgregarPlatillo.Location = new Point(4, 128);
                    btnAgregarPlatillo.AutoSize = true;
                    btnAgregarPlatillo.Size = new Size(176, 42);
                    btnAgregarPlatillo.BackColor = Color.ForestGreen;
                    btnAgregarPlatillo.ForeColor = Color.White;

                    btnAgregarPlatillo.Click += (sender, e) =>
                    {
                        int cantidad = 1;
                        ZompyDogsDAO.PedidosDAO.PlatilloDetalle nuevoPlatillo = new ZompyDogsDAO.PedidosDAO.PlatilloDetalle
                        {
                            PlatilloNombre = lblPlatillo.Text,
                            Precio_Unitario = decimal.Parse(lblPrecio.Text.Replace("L.", "").Trim()),
                            Cantidad = cantidad,
                            Codigo = lblCodigoPlatillo.Text,
                        };

                        _pedidosDAO.platillosLista.Add(nuevoPlatillo);

                        _bndsrcPedido.ResetBindings(false);
                        CalcularTotal();
                    };

                    panelPlatillo.Controls.Add(panelNombrePlatillo);
                    panelPlatillo.Controls.Add(panelPrecio);
                    panelPlatillo.Controls.Add(pbxPlatillo);

                    panelNombrePlatillo.Controls.Add(lblPlatillo);

                    panelPrecio.Controls.Add(lblPrecio);
                    panelPrecio.Controls.Add(txtDescripcion);
                    panelPrecio.Controls.Add(btnAgregarPlatillo);

                    int totalHeight = panelNombrePlatillo.Height + panelPrecio.Height + pbxPlatillo.Height;
                    int maxWidth = Math.Max(panelNombrePlatillo.Width, Math.Max(panelPrecio.Width, pbxPlatillo.Width));

                    panelPlatillo.Size = new Size(maxWidth, totalHeight);

                    // Agregar el panel al FlowLayoutPanel
                    flpPOSPanel.Controls.Add(panelPlatillo);
                }

                if (!hasResults)
                {
                    Label lblFLP = new Label();
                    lblFLP.Text = "No se encontraron platillos en esta categoría.";
                    lblFLP.Location = new Point(20, 5);
                    lblFLP.AutoSize = true;
                    lblFLP.Font = new Font("Arial", 14, FontStyle.Bold);
                    flpPOSPanel.Controls.Add(lblFLP);
                }

                reader.Close();
            }
        }
        private void dgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvPedido.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {
                pedidoCodigo = filaSeleccionada.Cells["Codigo"].Value.ToString();
                pedidoPlatilo = filaSeleccionada.Cells["PlatilloNombre"].Value.ToString();
                pedidoCantidad = Convert.ToInt32(filaSeleccionada.Cells["Cantidad"].Value);


                txtPlatilloOrden.Text = pedidoPlatilo;
                txtCantidad.Text = pedidoCantidad.ToString();
            }

        }
        private void btnQtyMore_Click(object sender, EventArgs e)
        {
            pedidoCantidad++;
            txtCantidad.Text = pedidoCantidad.ToString();

            if (pedidoCantidad == 2)
            {
                btnQtyLess.Enabled = true;
            }


        }
        private void btnQtyLess_Click(object sender, EventArgs e)
        {
            if (pedidoCantidad == 1)
            {
                btnQtyLess.Enabled = false;
            }
            else if (pedidoCantidad > 1)
            {
                pedidoCantidad--;
                txtCantidad.Text = pedidoCantidad.ToString();
            }

        }
        private void btnEliminarOrden_Click(object sender, EventArgs e)
        {
            if (dgvPedido.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvPedido.SelectedRows[0];

                string codigoPlatillo = filaSeleccionada.Cells["Codigo"].Value.ToString();

                var platilloAEliminar = _pedidosDAO.platillosLista.FirstOrDefault(p => p.Codigo == codigoPlatillo);

                if (platilloAEliminar != null)
                {
                    _pedidosDAO.platillosLista.Remove(platilloAEliminar);

                    _bndsrcPedido.ResetBindings(false);

                    MessageBox.Show("Platillo eliminado de la orden.");
                    CalcularTotal();
                }
                else
                {
                    MessageBox.Show("No se encontró el platillo en la lista.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un platillo para eliminar.");
            }
        }
        private void CalcularTotal()
        {


            foreach (var pedido in _pedidosDAO.platillosLista)
            {
                decimal precio = pedido.Precio_Unitario;
                int cantidad = pedido.Cantidad;

                totalaPagar += precio * cantidad;
            }

            lblTotalAPagar.Text = $"{totalaPagar}";
        }

        private void btnConfirmarPedido_Click(object sender, EventArgs e)
        {
            if (_pedidosDAO.platillosLista.Count == 0)
            {
                MessageBox.Show("No hay platillos en el pedido. Agrega al menos un platillo antes de confirmar.");
                return;
            }

            ZompyDogsDAO.PedidosDAO.PedidoDetalle nuevoPedido = new ZompyDogsDAO.PedidosDAO.PedidoDetalle
            {
                CodigoPedido = txtCodigoGenerado.Text,
                CodigoEmpleado = "EMP001",
                FechaDelPedido = DateTime.Now,
                TotalDeProductos = _pedidosDAO.platillosLista.Sum(p => p.Cantidad),
                Sub_Total = _pedidosDAO.platillosLista.Sum(p => p.Precio_Unitario * p.Cantidad),
                I_S_V = _pedidosDAO.platillosLista.Sum(p => p.Precio_Unitario * p.Cantidad) * 0.15m, // ISV del 15%
                TOTAL_Pagar = totalaPagar,
                MetodoDePago = "Efectivo", // Cambia según el método de pago seleccionado en el formulario
                Estado = "Pendiente" // Estado inicial del pedido
            };

            // Llamar a GuardarPedido para almacenar el pedido en la base de datos
            bool exito = _pedidosDAO.GuardarPedido(nuevoPedido, _pedidosDAO.platillosLista);

            if (exito)
            {
                MessageBox.Show("El pedido se ha guardado exitosamente.");
                _pedidosDAO.platillosLista.Clear(); // Limpiar la lista después de guardar el pedido
                _bndsrcPedido.ResetBindings(false);
                CalcularTotal();
            }
            else
            {
                MessageBox.Show("Hubo un problema al guardar el pedido. Inténtalo nuevamente.");
            }
        }
    }
}
