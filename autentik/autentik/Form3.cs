using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autentik
{
    public partial class Form3 : Form
    {
        private Form1.User user;
        public Form3(Form1.User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Tampilkan pesan selamat datang untuk admin
            label1.Text = "Selamat datang, Admin " + user.username + "!";
        }
    }
}
