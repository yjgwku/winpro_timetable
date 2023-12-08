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

        private void bt_click_Click(object sender, EventArgs e)
        {

        }
        private void CLOSEBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor=SystemColors.Control;
            textBox2.BackColor = SystemColors.Control;
            
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor=Color.White;
            panel3.BackColor=Color.White;
            textBox1.BackColor = SystemColors.Control;
            panel2.BackColor=SystemColors.Control;
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
