namespace MinecraftForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonBuscar = new Button();
            label1 = new Label();
            textBoxId = new TextBox();
            label2 = new Label();
            textBoxNombre = new TextBox();
            textBoxNivel = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxFecha = new TextBox();
            buttonCrear = new Button();
            buttonEliminar = new Button();
            buttonActualizar = new Button();
            dataGridView1 = new DataGridView();
            buttonBuscarinventario = new Button();
            comboBoxRareza = new ComboBox();
            comboBoxTipo = new ComboBox();
            button1 = new Button();
            pictureBoxImagen = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).BeginInit();
            SuspendLayout();
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = SystemColors.MenuHighlight;
            buttonBuscar.Location = new Point(327, 43);
            buttonBuscar.Margin = new Padding(3, 4, 3, 4);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(102, 31);
            buttonBuscar.TabIndex = 0;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Orange;
            label1.Location = new Point(17, 32);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // textBoxId
            // 
            textBoxId.BackColor = SystemColors.GradientActiveCaption;
            textBoxId.Location = new Point(106, 43);
            textBoxId.Margin = new Padding(3, 4, 3, 4);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(114, 27);
            textBoxId.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Orange;
            label2.Location = new Point(17, 98);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            textBoxNombre.BackColor = SystemColors.GradientActiveCaption;
            textBoxNombre.Location = new Point(106, 91);
            textBoxNombre.Margin = new Padding(3, 4, 3, 4);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(114, 27);
            textBoxNombre.TabIndex = 4;
            // 
            // textBoxNivel
            // 
            textBoxNivel.BackColor = SystemColors.GradientActiveCaption;
            textBoxNivel.Location = new Point(106, 149);
            textBoxNivel.Margin = new Padding(3, 4, 3, 4);
            textBoxNivel.Name = "textBoxNivel";
            textBoxNivel.Size = new Size(114, 27);
            textBoxNivel.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Orange;
            label3.Location = new Point(17, 156);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 6;
            label3.Text = "Nivel:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Orange;
            label4.Location = new Point(17, 211);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 7;
            label4.Text = "Fecha de creacion:";
            // 
            // textBoxFecha
            // 
            textBoxFecha.BackColor = SystemColors.GradientActiveCaption;
            textBoxFecha.Location = new Point(162, 207);
            textBoxFecha.Margin = new Padding(3, 4, 3, 4);
            textBoxFecha.Name = "textBoxFecha";
            textBoxFecha.Size = new Size(151, 27);
            textBoxFecha.TabIndex = 8;
            // 
            // buttonCrear
            // 
            buttonCrear.BackColor = SystemColors.Highlight;
            buttonCrear.Location = new Point(327, 82);
            buttonCrear.Margin = new Padding(3, 4, 3, 4);
            buttonCrear.Name = "buttonCrear";
            buttonCrear.Size = new Size(102, 31);
            buttonCrear.TabIndex = 9;
            buttonCrear.Text = "Crear Jugador";
            buttonCrear.UseVisualStyleBackColor = false;
            buttonCrear.Click += buttonCrear_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = SystemColors.Highlight;
            buttonEliminar.Location = new Point(327, 160);
            buttonEliminar.Margin = new Padding(3, 4, 3, 4);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(129, 31);
            buttonEliminar.TabIndex = 10;
            buttonEliminar.Text = "Eliminar Jugador";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonActualizar
            // 
            buttonActualizar.BackColor = SystemColors.Highlight;
            buttonActualizar.Location = new Point(327, 121);
            buttonActualizar.Margin = new Padding(3, 4, 3, 4);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(143, 31);
            buttonActualizar.TabIndex = 11;
            buttonActualizar.Text = "Actualizar Jugador";
            buttonActualizar.UseVisualStyleBackColor = false;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Menu;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 324);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(385, 273);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonBuscarinventario
            // 
            buttonBuscarinventario.BackColor = SystemColors.Highlight;
            buttonBuscarinventario.Location = new Point(400, 285);
            buttonBuscarinventario.Margin = new Padding(3, 4, 3, 4);
            buttonBuscarinventario.Name = "buttonBuscarinventario";
            buttonBuscarinventario.Size = new Size(179, 31);
            buttonBuscarinventario.TabIndex = 13;
            buttonBuscarinventario.Text = "Buscar Inventario por ID";
            buttonBuscarinventario.UseVisualStyleBackColor = false;
            buttonBuscarinventario.Click += buttonBuscarinventario_Click;
            // 
            // comboBoxRareza
            // 
            comboBoxRareza.BackColor = Color.Sienna;
            comboBoxRareza.FormattingEnabled = true;
            comboBoxRareza.Location = new Point(240, 285);
            comboBoxRareza.Margin = new Padding(3, 4, 3, 4);
            comboBoxRareza.Name = "comboBoxRareza";
            comboBoxRareza.Size = new Size(138, 28);
            comboBoxRareza.TabIndex = 15;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.BackColor = Color.Sienna;
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(62, 285);
            comboBoxTipo.Margin = new Padding(3, 4, 3, 4);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(138, 28);
            comboBoxTipo.TabIndex = 16;
            comboBoxTipo.SelectedIndexChanged += comboBoxTipo_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Plum;
            button1.Location = new Point(89, 247);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(246, 31);
            button1.TabIndex = 20;
            button1.Text = "Seleccione la opcion que deseas";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.BackColor = Color.Transparent;
            pictureBoxImagen.Location = new Point(486, 365);
            pictureBoxImagen.Margin = new Padding(3, 4, 3, 4);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Size = new Size(171, 173);
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagen.TabIndex = 21;
            pictureBoxImagen.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LawnGreen;
            label5.Location = new Point(379, 19);
            label5.Name = "label5";
            label5.Size = new Size(162, 20);
            label5.TabIndex = 22;
            label5.Text = "CENTRO DE OPCIONES";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(671, 600);
            Controls.Add(label5);
            Controls.Add(pictureBoxImagen);
            Controls.Add(button1);
            Controls.Add(comboBoxTipo);
            Controls.Add(comboBoxRareza);
            Controls.Add(buttonBuscarinventario);
            Controls.Add(dataGridView1);
            Controls.Add(buttonActualizar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonCrear);
            Controls.Add(textBoxFecha);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxNivel);
            Controls.Add(textBoxNombre);
            Controls.Add(label2);
            Controls.Add(textBoxId);
            Controls.Add(label1);
            Controls.Add(buttonBuscar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBoxId;
        private Label label2;
        private TextBox textBoxNombre;
        private TextBox textBoxNivel;
        private Label label3;
        private Label label4;
        private TextBox textBoxFecha;
        private Button button2;
        private Button buttonBuscar;
        private Button buttonCrear;
        private Button buttonEliminar;
        private Button buttonActualizar;
        private DataGridView dataGridView1;
        private Button buttonBuscarinventario;
        private ComboBox comboBoxRareza;
        private ComboBox comboBoxTipo;
        private PictureBox pictureBoxImagen;
        private Label label5;
    }
}
