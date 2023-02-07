using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Institution
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Add_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Заполняем данные для студента";
            label10.Text = "учёбы";
            label11.Text = "учёбы";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Заполняем данные для преподавателя";
            label10.Text = "работы";
            label11.Text = "работы не определена";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Заполняем данные для специалиста";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Заполняем данные для младшего научного сотрудника";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
