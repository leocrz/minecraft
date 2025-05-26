using MinecraftManager.Services;
using MinecraftManager.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftForm
{
    public partial class LoginForm : Form
    {
        private InventarioService inventarioService;
        private BloqueService bloqueService;
        private string archivoUsuarios = "usuarios.txt";

        public LoginForm()
        {
            InitializeComponent();

            DatabaseManager dbManager = new DatabaseManager();
            JugadorService jugadorService = new JugadorService(dbManager);
            bloqueService = new BloqueService(dbManager);
            inventarioService = new InventarioService(dbManager, jugadorService, bloqueService);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            if (usuario == "" || contraseña == "")
            {
                MessageBox.Show("Por favor completa ambos campos.");
                return;
            }

            // Si el archivo no existe, se crea al agregar el primer usuario
            if (File.Exists(archivoUsuarios))
            {
                var lineas = File.ReadAllLines(archivoUsuarios);
                foreach (string linea in lineas)
                {
                    var partes = linea.Split('|');
                    if (partes[0] == usuario)
                    {
                        MessageBox.Show("Este usuario ya existe.");
                        return;
                    }
                }
            }

            File.AppendAllText(archivoUsuarios, usuario + "|" + contraseña + Environment.NewLine);
            MessageBox.Show("Usuario registrado correctamente.");
            txtUsuario.Clear();
            txtContraseña.Clear();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {


            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            if (!File.Exists(archivoUsuarios))
            {
                MessageBox.Show("No hay usuarios registrados.");
                return;
            }

            var lineas = File.ReadAllLines(archivoUsuarios);
            foreach (string linea in lineas)
            {
                var partes = linea.Split('|');
                if (partes.Length == 2 && partes[0] == usuario && partes[1] == contraseña)
                {
                    MessageBox.Show("Inicio de sesión exitoso.");

                    // Abre el formulario principal y cierra este
                    Form1 principal = new Form1(inventarioService, bloqueService);
                    principal.Show();
                    this.Hide();
                    return;
                }
            }

            MessageBox.Show("Usuario o contraseña incorrectos.");



        }
    }
}
