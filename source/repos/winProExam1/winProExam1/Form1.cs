using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using MySql.Data.MySqlClient;
using winProExam;

namespace 프로젝트
{

    public partial class Form1 : Form

    {
        private string userId;


        public Form1()
        {
            InitializeComponent();
        }

 
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 showform2 = new Form2();
            showform2.Show();
            

        }
    }
}
