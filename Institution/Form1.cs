using static System.DateTime;
namespace Institution
{
    public partial class Form1 : Form
    {
        Student[] students = {
           new Student("������", "��������",
           new DateTime(1983, 5, 23), "�������� ���", "���221"),
           new Student("������", "����������",
           new DateTime(1993, 7, 12), "�������� ���", "���221")
        };

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
                this.richTextBox2.Clear();
                foreach (Student item in students)
                    this.richTextBox2.Text += item.Show();
            }
            else if (this.radioButton2.Checked)
            {
                this.richTextBox2.Text = "�����������";
            }
            else if (this.radioButton3.Checked)
            {
                this.richTextBox2.Text = "�������������";
            }
            else if(this.radioButton4.Checked)
            {
                this.richTextBox2.Text = "������� ������� ����������";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add add = new Add();
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
    }
}
class Human
{
    protected string _firstName;
    protected string _lastName;
    protected string _secondName;
    protected DateTime _birthDate;

    public Human(string fName, string lName ,DateTime date)
    {
        _firstName = fName;
        _lastName = lName;
        _birthDate = date;
    }

    public Human(string fName, string lName,string sName, DateTime date)
    {
        _firstName = fName;
        _lastName = lName;
        _secondName = sName;
        _birthDate = date;
    }

    //Form1 form1 = Application.OpenForms[0] as Form1;
    public string Show()
    {

        return $"\n�������: {_lastName} \n���: {_firstName} \n���� ��������: {_birthDate.ToShortDateString()}";
    }
}
class Student : Human
{
    string _institution;
    string _groupName;
    public Student(string fName, string lName, DateTime date, string institution, string gName) : base(fName, lName, date)
    {
        _institution = institution;
        _groupName = gName;
    }
    public string Show()
    {
        return $"�������: {_lastName} \n���: {_firstName} \n���� ��������: {_birthDate.ToShortDateString()} \n����� � {_institution},������ {_groupName}\n\n";
    }

}
