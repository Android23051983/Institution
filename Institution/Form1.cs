using static System.DateTime;
namespace Institution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Student student =
            new Student("������", "��������",
            new DateTime(1983, 5, 23), "�������� ���", "���221");
            this.richTextBox2.Text = student.Show();
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
    protected DateTime _birthDate;

    public Human(string fName, string lName, DateTime date)
    {
        _firstName = fName;
        _lastName = lName;
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
        return $"�������: {_lastName} \n���: {_firstName} \n���� ��������: {_birthDate.ToShortDateString()} \n����� � {_institution},������ {_groupName}";
    }

}
