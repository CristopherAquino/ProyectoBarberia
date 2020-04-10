using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Proyecto_Pagos_Eventos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // Variables de posicion (Para evento de mover barra de titulo con el puntero del mosue)
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.Black;
            }

        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        //Movimiento del panel
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
            Form Interfaz = new Menu();
            Interfaz.Show();
            this.Hide();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text != "Usuario")
                {
                    lbMsgU.Visible = false;
                    if (txtpass.Text != "Contraseña")
                    {
                        lbMsgP.Visible = false;
                        this.Hide();
                        Menu Menu = new Menu();
                        Menu.Show();
                    }
                    else msgErrorP("Ingrese Contraseña");
                }
                else msgErrorU("Ingrese Nombre de Usuario");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void msgErrorU(string msg)
        {
            lbMsgU.Text = msg;
            lbMsgU.Visible = true;
        }

        private void msgErrorP(string msg)
        {
            lbMsgP.Text = msg;
            lbMsgP.Visible = true;
        }
    }
}
