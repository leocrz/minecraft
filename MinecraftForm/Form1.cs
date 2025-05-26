using MinecraftManager.Models;
using MinecraftManager.Services;
using MinecraftManager.Utils;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MinecraftForm
{
    public partial class Form1 : Form
    {
        public Form1(InventarioService inventarioService, BloqueService bloqueService)
        {
            InitializeComponent();

            _inventarioService = inventarioService;
            _bloqueService = bloqueService;
        }
        private readonly InventarioService _inventarioService;
        private readonly BloqueService _bloqueService;


        private void FiltrarBloques()
        {
            // Obtener las selecciones actuales
            string tipoSeleccionado = comboBoxTipo.SelectedItem?.ToString();
            string rarezaSeleccionada = comboBoxRareza.SelectedItem?.ToString();

            // Obtener todos los bloques
            var todos = _bloqueService.ObtenerTodos();

            // Filtrar por tipo si se seleccionó uno específico
            if (!string.IsNullOrEmpty(tipoSeleccionado) && tipoSeleccionado != "Todos")
            {
                todos = todos.Where(b => b.Tipo == tipoSeleccionado).ToList();
            }

            // Filtrar por rareza si se seleccionó una específica
            if (!string.IsNullOrEmpty(rarezaSeleccionada) && rarezaSeleccionada != "Todos")
            {
                todos = todos.Where(b => b.Rareza == rarezaSeleccionada).ToList();
            }

            // Asignar al DataGridView
            dataGridView1.DataSource = todos;
        }

        // ⬇️ Y estos dos también en el formulario


        private void comboBoxRareza_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarBloques();
        }














        private void buttonBuscar_Click(object sender, EventArgs e)
        {

            int id = int.Parse(textBoxId.Text);


            JugadorService jugadorService = new JugadorService(new DatabaseManager());
            Jugador jugador = jugadorService.ObtenerPorId(id);


            textBoxNombre.Text = jugador.Nombre;
            textBoxNivel.Text = jugador.Nivel.ToString();
            textBoxFecha.Text = jugador.FechaCreacion.ToString();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {


            var jugador = new Jugador
            {
                Nombre = textBoxNombre.Text,
                Nivel = int.Parse(textBoxNivel.Text) // ¡Asegúrate de que sea un número válido!
            };

            try
            {
                var servicioJugador = new JugadorService(new DatabaseManager());
                servicioJugador.Crear(jugador);

                MessageBox.Show($"¡Jugador creado exitosamente con ID {jugador.Id}!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el jugador: {ex.Message}");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBoxId.Text);
                JugadorService servicioJugador = new JugadorService(new DatabaseManager());
                servicioJugador.Eliminar(id);

                MessageBox.Show("Operación de eliminación finalizada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el jugador: {ex.Message}");
            }



        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBoxId.Text);
                string nombre = textBoxNombre.Text;
                int nivel = int.Parse(textBoxNivel.Text);

                Jugador jugador = new Jugador
                {
                    Id = id,
                    Nombre = nombre,
                    Nivel = nivel
                };

                JugadorService servicioJugador = new JugadorService(new DatabaseManager());
                servicioJugador.Actualizar(jugador);

                MessageBox.Show("Operación de actualización finalizada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el jugador: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Obtener el nombre desde la fila seleccionada
                string nombre = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();

                // Construir la ruta completa de la imagen
                string rutaImagen = Path.Combine(Application.StartupPath, "Imagenes", nombre + ".png");

                // Verificar si la imagen existe
                if (File.Exists(rutaImagen))
                {
                    pictureBoxImagen.Image = Image.FromFile(rutaImagen);
                }
                else
                {
                    pictureBoxImagen.Image = null; // O muestra una imagen por defecto si prefieres
                }
            }



        }

        private void buttonBuscarinventario_Click(object sender, EventArgs e)
        {
            try
            {
                var listaInventario = _inventarioService.ObtenerTodos();
                dataGridView1.DataSource = listaInventario;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el inventario: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var todosBloques = _bloqueService.ObtenerTodos();

            var tipos = todosBloques.Select(b => b.Tipo).Distinct().ToList();
            var rarezas = todosBloques.Select(b => b.Rareza).Distinct().ToList();

            // Agregar opción de "Todos" al inicio de cada lista
            tipos.Insert(0, "Todos");
            rarezas.Insert(0, "Todos");

            // Cargar en los ComboBox
            comboBoxTipo.Items.AddRange(tipos.ToArray());
            comboBoxRareza.Items.AddRange(rarezas.ToArray());

            // Seleccionar por defecto "Todos"
            comboBoxTipo.SelectedIndex = 0;
            comboBoxRareza.SelectedIndex = 0;

            // Mostrar la info inicial en el DataGridView
            FiltrarBloques();


            // para las imagenes


        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarBloques();








        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
