using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PBO_YOVITA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = textBox1.Text;
            string Password = textBox2.Text;

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Username dan Password wajib diisi.");
            }
            else if (Username == "admin" && Password == "password")
            {
                MessageBox.Show("Login berhasil.");
                
                Form2 Form = new Form2();
                Form.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login gagal. Periksa username dan password Anda.");
            }

        }
    }
}
