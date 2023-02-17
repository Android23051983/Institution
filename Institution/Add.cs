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

        public Add(Form1 f)
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
            label7.Text = "студенту";
            label10.Text = "учёбы";
            label11.Text = "учёбы";
            this.InstitutionTextBox.Text = null;
            this.InstitutionTextBox.ForeColor = System.Drawing.Color.Black;
            this.InstitutionTextBox.ReadOnly = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Заполняем данные для преподавателя";
            label7.Text = "преподавателю";
            label10.Text = "работы";
            label11.Text = "работы";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Заполняем данные для специалиста";
            label7.Text = "специалисту";
            label10.Text = "работы";
            label11.Text = "работы";
            this.InstitutionTextBox.ReadOnly = true;
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Заполняем данные для младшего научного сотрудника";
            label7.Text = "младшему научному сотруднику";
            label10.Text = "работы";
            label11.Text = "работы";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string? RadioText = "";

            if (radioButton1.Checked)
            {
                RadioText = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                RadioText = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                RadioText = radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                RadioText = radioButton4.Text;
            }

            string? CheckText = "";
            if (checkBox1.Checked)
            {
                CheckText = checkBox1.Text;
            }
            else if (checkBox2.Checked)
            {
                CheckText = checkBox2.Text;
            }
            else if (checkBox3.Checked)
            {
                CheckText = checkBox3.Text;
            }
            else if (checkBox4.Checked)
            {
                CheckText = checkBox4.Text;
            }

            if (StudentRadioButton.Checked)
            {
                StudentsAdd.StudentAdd(lNameTextBox.Text, fNameTextBox.Text, dateTimePicker1.Value, dateTimePicker1.Value, InstitutionTextBox.Text, CheckText, RadioText);
            }

            if (SpecialistRadioButton.Checked)
            {
                SpecialistsAdd.SpecialistAdd(lNameTextBox.Text, fNameTextBox.Text, dateTimePicker1.Value, dateTimePicker2.Value, RadioText);
                StatusWorkLabel.Text = "Специалист работает по настоящее время";
            }

        }

        private void sNameTextBox_Click(object sender, EventArgs e)
        {
            sNameTextBox.Text = null;
            sNameTextBox.ForeColor = Color.Black;
        }

        private void InstitutionTextBox_Click_1(object sender, EventArgs e)
        {
            InstitutionTextBox.Text = null;
            InstitutionTextBox.ForeColor = Color.Black;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
