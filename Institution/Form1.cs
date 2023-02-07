using static System.DateTime;
namespace Institution
{
    public partial class Form1 : Form
    {
        Student[] students = {
           new Student("Андрей", "Щербаков",
           new DateTime(1983, 5, 23), "Академия ТОР", "СПУ221"),
           new Student("Андрей", "Комиссаров",
           new DateTime(1993, 7, 12), "академия ТОР", "СПУ221")
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
                this.richTextBox2.Text = "Специалисты";
            }
            else if (this.radioButton3.Checked)
            {
                this.richTextBox2.Text = "Преподователи";
            }
            else if(this.radioButton4.Checked)
            {
                this.richTextBox2.Text = "Младшие научные сотрудники";
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

        return $"\nФамилия: {_lastName} \nИмя: {_firstName} \nДата рождения: {_birthDate.ToShortDateString()}";
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
        return $"Фамилия: {_lastName} \nИмя: {_firstName} \nДата рождения: {_birthDate.ToShortDateString()} \nУчусь в {_institution},группа {_groupName}\n\n";
    }

}
