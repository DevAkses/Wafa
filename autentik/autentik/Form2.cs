﻿using System;
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
    public partial class Form2 : Form
    {
        private Form1.User user;

        public Form2(Form1.User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Tampilkan pesan selamat datang untuk user
            label1.Text = "Selamat datang, " + user.username + "!";
        }
    }
}
