using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Pagos_Eventos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        // Variables de posicion (Para evento de mover barra de titulo con el puntero del mosue)

        int PosY = 0;
        int PosX = 0;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Barra_de_Titulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Barra_de_Titulo_MouseMove(object sender, MouseEventArgs e)
        {

            // Evento para movimiento de barra de titulo

            if (e.Button != MouseButtons.Left)

            {
                PosX = e.X;
                PosY = e.Y;
            }

            else
           
            {
                Left = Left + (e.X - PosX);
                Top = Top + (e.Y - PosY);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if ((textBox_Usuario.Text == "Admin") && (textBox_Contraseña.Text == "1234"))
            
            {
                Form Interfaz = new Form2();
                Interfaz.Show();
                this.Hide();
            }  
            
            else if ((textBox_Usuario.Text != "") && (textBox_Contraseña.Text != ""))
            {
                MessageBox.Show("Error - Usuario o Contraseña no validos");
            }
            */
            Form Interfaz = new Form2();
            Interfaz.Show();
            this.Hide();
        }

        private void textBox_Contraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
