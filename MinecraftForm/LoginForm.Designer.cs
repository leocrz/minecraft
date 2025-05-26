namespace MinecraftForm
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnIniciarSesion = new Button();
            btnRegistrar = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(270, 115);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(114, 27);
            txtUsuario.TabIndex = 0;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(270, 182);
            txtContraseña.Margin = new Padding(3, 4, 3, 4);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(114, 27);
            txtContraseña.TabIndex = 1;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.Gold;
            btnIniciarSesion.Location = new Point(193, 251);
            btnIniciarSesion.Margin = new Padding(3, 4, 3, 4);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(86, 31);
            btnIniciarSesion.TabIndex = 2;
            btnIniciarSesion.Text = "INGRESAR";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Gold;
            btnRegistrar.Location = new Point(384, 251);
            btnRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(86, 31);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "CREAR";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MintCream;
            label1.Location = new Point(142, 122);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 4;
            label1.Text = "USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MintCream;
            label2.Location = new Point(142, 182);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 5;
            label2.Text = "CONTRASEÑA";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(591, 384);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegistrar);
            Controls.Add(btnIniciarSesion);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "LoginForm";
            WindowState = FormWindowState.Maximized;
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnIniciarSesion;
        private Button btnRegistrar;
        private Label label1;
        private Label label2;
    }
}