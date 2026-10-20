namespace PROYECTO_PROGRAMACION_DSCV__1
{
    partial class frmClientes
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            lblerrortel = new Label();
            txtcorreo = new TextBox();
            lblcorreo = new Label();
            txtnumerotel = new TextBox();
            lbltelefono = new Label();
            txtApellidos = new TextBox();
            lblApellidos = new Label();
            txtnombrecliente = new TextBox();
            lblnombrecliente = new Label();
            txtIdCliente = new TextBox();
            lblIdcliente = new Label();
            errprovider = new ErrorProvider(components);
            btnguardar = new Button();
            btnmodificar = new Button();
            btneliminar = new Button();
            button4 = new Button();
            label7 = new Label();
            txtbuscar = new TextBox();
            btnbuscar = new Button();
            label8 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errprovider).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, -2);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1473, 52);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(38, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(349, 31);
            label1.TabIndex = 3;
            label1.Text = "SurDigital - Gestión de Clientes";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(-3, 51);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1513, 49);
            panel2.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(589, 10);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(50, 28);
            label6.TabIndex = 2;
            label6.Text = "Salir";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(383, 10);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(195, 28);
            label5.TabIndex = 2;
            label5.Text = "Ordenes de Servicio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(274, 10);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(84, 28);
            label4.TabIndex = 2;
            label4.Text = "Equipos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(151, 10);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 28);
            label3.TabIndex = 2;
            label3.Text = "Tecnicos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 10);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 0;
            label2.Text = "Clientes";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(lblerrortel);
            groupBox1.Controls.Add(txtcorreo);
            groupBox1.Controls.Add(lblcorreo);
            groupBox1.Controls.Add(txtnumerotel);
            groupBox1.Controls.Add(lbltelefono);
            groupBox1.Controls.Add(txtApellidos);
            groupBox1.Controls.Add(lblApellidos);
            groupBox1.Controls.Add(txtnombrecliente);
            groupBox1.Controls.Add(lblnombrecliente);
            groupBox1.Controls.Add(txtIdCliente);
            groupBox1.Controls.Add(lblIdcliente);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(16, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(303, 503);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Cliente";
            // 
            // lblerrortel
            // 
            lblerrortel.AutoSize = true;
            lblerrortel.ForeColor = Color.Red;
            lblerrortel.Location = new Point(13, 460);
            lblerrortel.Name = "lblerrortel";
            lblerrortel.Size = new Size(257, 25);
            lblerrortel.TabIndex = 9;
            lblerrortel.Text = "El número debe tener 8 dígitos";
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(10, 417);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(260, 31);
            txtcorreo.TabIndex = 8;
            // 
            // lblcorreo
            // 
            lblcorreo.AutoSize = true;
            lblcorreo.Location = new Point(14, 389);
            lblcorreo.Name = "lblcorreo";
            lblcorreo.Size = new Size(157, 25);
            lblcorreo.TabIndex = 7;
            lblcorreo.Text = "Correo electrónico";
            // 
            // txtnumerotel
            // 
            txtnumerotel.Location = new Point(10, 338);
            txtnumerotel.Name = "txtnumerotel";
            txtnumerotel.Size = new Size(260, 31);
            txtnumerotel.TabIndex = 6;
            txtnumerotel.TextChanged += txtnumerotel_TextChanged;
            txtnumerotel.Validating += txtnumerotel_Validating;
            // 
            // lbltelefono
            // 
            lbltelefono.AutoSize = true;
            lbltelefono.Location = new Point(14, 310);
            lbltelefono.Name = "lbltelefono";
            lbltelefono.Size = new Size(160, 25);
            lbltelefono.TabIndex = 6;
            lbltelefono.Text = "Número telefónico";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(10, 249);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(211, 31);
            txtApellidos.TabIndex = 5;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(10, 221);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(86, 25);
            lblApellidos.TabIndex = 4;
            lblApellidos.Text = "Apellidos";
            // 
            // txtnombrecliente
            // 
            txtnombrecliente.Location = new Point(10, 161);
            txtnombrecliente.Name = "txtnombrecliente";
            txtnombrecliente.Size = new Size(211, 31);
            txtnombrecliente.TabIndex = 4;
            // 
            // lblnombrecliente
            // 
            lblnombrecliente.AutoSize = true;
            lblnombrecliente.Location = new Point(10, 133);
            lblnombrecliente.Name = "lblnombrecliente";
            lblnombrecliente.Size = new Size(78, 25);
            lblnombrecliente.TabIndex = 2;
            lblnombrecliente.Text = "Nombre";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(14, 78);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(256, 31);
            txtIdCliente.TabIndex = 1;
            // 
            // lblIdcliente
            // 
            lblIdcliente.AutoSize = true;
            lblIdcliente.Location = new Point(0, 50);
            lblIdcliente.Name = "lblIdcliente";
            lblIdcliente.Size = new Size(153, 25);
            lblIdcliente.TabIndex = 0;
            lblIdcliente.Text = "Cédula (9 Dígitos)";
            lblIdcliente.Click += label7_Click;
            // 
            // errprovider
            // 
            errprovider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errprovider.ContainerControl = this;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(427, 166);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(118, 44);
            btnguardar.TabIndex = 4;
            btnguardar.Text = "guardar";
            btnguardar.UseVisualStyleBackColor = true;
            // 
            // btnmodificar
            // 
            btnmodificar.Location = new Point(573, 166);
            btnmodificar.Name = "btnmodificar";
            btnmodificar.Size = new Size(118, 44);
            btnmodificar.TabIndex = 5;
            btnmodificar.Text = "Modificar";
            btnmodificar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(725, 166);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(118, 44);
            btneliminar.TabIndex = 6;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(883, 166);
            button4.Name = "button4";
            button4.Size = new Size(118, 44);
            button4.TabIndex = 7;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(427, 273);
            label7.Name = "label7";
            label7.Size = new Size(240, 25);
            label7.TabIndex = 8;
            label7.Text = "Buscar por nombre o cédula:";
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(427, 301);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(408, 31);
            txtbuscar.TabIndex = 9;
            // 
            // btnbuscar
            // 
            btnbuscar.Location = new Point(883, 301);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(118, 31);
            btnbuscar.TabIndex = 10;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(427, 378);
            label8.Name = "label8";
            label8.Size = new Size(0, 25);
            label8.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(421, 376);
            button1.Name = "button1";
            button1.Size = new Size(721, 541);
            button1.TabIndex = 12;
            button1.Text = "AQUÍ SE PONDRÍA UNA TABLA PARA BUSCAR ";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 1155);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(btnbuscar);
            Controls.Add(txtbuscar);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(btneliminar);
            Controls.Add(btnmodificar);
            Controls.Add(btnguardar);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmClientes";
            Text = "frmClientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errprovider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Label lblIdcliente;
        private TextBox txtIdCliente;
        private TextBox txtnumerotel;
        private Label lbltelefono;
        private TextBox txtApellidos;
        private Label lblApellidos;
        private TextBox txtnombrecliente;
        private Label lblnombrecliente;
        private TextBox txtcorreo;
        private Label lblcorreo;
        private ErrorProvider errprovider;
        private Label lblerrortel;
        private Button button4;
        private Button btneliminar;
        private Button btnmodificar;
        private Button btnguardar;
        private Button btnbuscar;
        private TextBox txtbuscar;
        private Label label7;
        private Button button1;
        private Label label8;
    }
}