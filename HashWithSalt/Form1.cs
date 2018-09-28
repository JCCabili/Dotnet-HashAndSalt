using HashWithSalt.Security.Encrypt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashWithSalt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var encrypted = Encryptor.Encrypt(textBox1.Text, true);
            textBox2.Text = encrypted;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var decrypted = Encryptor.Decrypt(textBox2.Text, true);
            textBox3.Text = decrypted;
        }
    }
}
