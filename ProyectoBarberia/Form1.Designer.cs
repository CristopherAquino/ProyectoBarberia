namespace Proyecto_Pagos_Eventos
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Barra_de_Titulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.Barra_Abajo = new System.Windows.Forms.Panel();
            this.label_NomUsuario = new System.Windows.Forms.Label();
            this.textBox_Usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Contraseña = new System.Windows.Forms.TextBox();
            this.pictureBox_IconoUsuario = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Barra_de_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_IconoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // Barra_de_Titulo
            // 
            this.Barra_de_Titulo.BackColor = System.Drawing.SystemColors.Desktop;
            this.Barra_de_Titulo.Controls.Add(this.btnMinimizar);
            this.Barra_de_Titulo.Controls.Add(this.btnCerrar);
            this.Barra_de_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra_de_Titulo.Location = new System.Drawing.Point(0, 0);
            this.Barra_de_Titulo.Name = "Barra_de_Titulo";
            this.Barra_de_Titulo.Size = new System.Drawing.Size(300, 41);
            this.Barra_de_Titulo.TabIndex = 0;
            this.Barra_de_Titulo.Paint += new System.Windows.Forms.PaintEventHandler(this.Barra_de_Titulo_Paint);
            this.Barra_de_Titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Barra_de_Titulo_MouseMove);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMinimizar.Image = global::Proyecto_Pagos_Eventos.Properties.Resources.icons8_minimizar_la_ventana_32;
            this.btnMinimizar.Location = new System.Drawing.Point(250, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(16, 16);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCerrar.Image = global::Proyecto_Pagos_Eventos.Properties.Resources.icons8_cerrar_ventana_32;
            this.btnCerrar.Location = new System.Drawing.Point(272, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 16);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Barra_Abajo
            // 
            this.Barra_Abajo.BackColor = System.Drawing.SystemColors.Desktop;
            this.Barra_Abajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Barra_Abajo.Location = new System.Drawing.Point(0, 480);
            this.Barra_Abajo.Name = "Barra_Abajo";
            this.Barra_Abajo.Size = new System.Drawing.Size(300, 20);
            this.Barra_Abajo.TabIndex = 1;
            this.Barra_Abajo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_NomUsuario
            // 
            this.label_NomUsuario.AutoSize = true;
            this.label_NomUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NomUsuario.ForeColor = System.Drawing.Color.Black;
            this.label_NomUsuario.Location = new System.Drawing.Point(28, 176);
            this.label_NomUsuario.Name = "label_NomUsuario";
            this.label_NomUsuario.Size = new System.Drawing.Size(66, 21);
            this.label_NomUsuario.TabIndex = 2;
            this.label_NomUsuario.Text = "Usuario";
            this.label_NomUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_Usuario
            // 
            this.textBox_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Usuario.Location = new System.Drawing.Point(31, 201);
            this.textBox_Usuario.Multiline = true;
            this.textBox_Usuario.Name = "textBox_Usuario";
            this.textBox_Usuario.Size = new System.Drawing.Size(236, 36);
            this.textBox_Usuario.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contraseña";
            // 
            // textBox_Contraseña
            // 
            this.textBox_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Contraseña.Location = new System.Drawing.Point(33, 264);
            this.textBox_Contraseña.Multiline = true;
            this.textBox_Contraseña.Name = "textBox_Contraseña";
            this.textBox_Contraseña.PasswordChar = '*';
            this.textBox_Contraseña.Size = new System.Drawing.Size(236, 34);
            this.textBox_Contraseña.TabIndex = 5;
            this.textBox_Contraseña.TextChanged += new System.EventHandler(this.textBox_Contraseña_TextChanged);
            // 
            // pictureBox_IconoUsuario
            // 
            this.pictureBox_IconoUsuario.Image = global::Proyecto_Pagos_Eventos.Properties.Resources.user_icon_icons_com_57997;
            this.pictureBox_IconoUsuario.Location = new System.Drawing.Point(103, 62);
            this.pictureBox_IconoUsuario.Name = "pictureBox_IconoUsuario";
            this.pictureBox_IconoUsuario.Size = new System.Drawing.Size(90, 109);
            this.pictureBox_IconoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_IconoUsuario.TabIndex = 6;
            this.pictureBox_IconoUsuario.TabStop = false;
            this.pictureBox_IconoUsuario.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(32, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(300, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox_IconoUsuario);
            this.Controls.Add(this.textBox_Contraseña);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Usuario);
            this.Controls.Add(this.label_NomUsuario);
            this.Controls.Add(this.Barra_Abajo);
            this.Controls.Add(this.Barra_de_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Barra_de_Titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_IconoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Barra_de_Titulo;
        private System.Windows.Forms.Panel Barra_Abajo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Label label_NomUsuario;
        private System.Windows.Forms.TextBox textBox_Usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Contraseña;
        private System.Windows.Forms.PictureBox pictureBox_IconoUsuario;
        private System.Windows.Forms.Button button1;
    }
}

