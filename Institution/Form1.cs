using static System.DateTime;
namespace Institution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                //StudentsAdd stdAdd = new StudentsAdd();
                this.richTextBox2.Clear();

                for (int i = 0; i < StudentsAdd.students.Length; i++)
                    this.richTextBox2.Text += StudentsAdd.students[i].ToString();
            }
            else if (this.radioButton2.Checked)
            {
                this.richTextBox2.Clear();
                for (int i = 0; i < SpecialistsAdd.specialists.Length; i++)
                    this.richTextBox2.Text += SpecialistsAdd.specialists[i].ToString();
            }
            else if (this.radioButton3.Checked)
            {
                this.richTextBox2.Clear();
                for (int i = 0; i < TeachersAdd.teachers.Length; i++)
                {
                    this.richTextBox2.Text += TeachersAdd.teachers[i];
                }
            }
            else if (this.radioButton4.Checked)
            {
                this.richTextBox2.Clear();
                for (int i = 0; i < JuniorResearchAssistantsAdd.juniorResearchAssistant.Length; i++)
                {
                    this.richTextBox2.Text += JuniorResearchAssistantsAdd.juniorResearchAssistant[i];
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add add = new Add(this);
            add.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Cursor = Cursors.Hand;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}