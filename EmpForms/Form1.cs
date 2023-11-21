using EmpLib;

namespace EmpForms
{
    public partial class Form1 : Form
    {
        Employee KPMGEmp = new Employee();
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click1;
            button1.Click += Button1_Click2;

            KPMGEmp.Join += Am_Join;
            KPMGEmp.Join += Jen_Join;
            KPMGEmp.Join += Jazz_Join;

            KPMGEmp.Resign += Am_Resign;
            KPMGEmp.Resign += Jazz_Resign;
            KPMGEmp.Resign += Jen_Resign;
        }

        private void Jen_Resign(object? sender, EventArgs e)
        {
            MessageBox.Show("Jen resigned from KPMG");
        }

        private void Jazz_Resign(object? sender, EventArgs e)
        {
            MessageBox.Show("Jazz resigned from KPMG");
        }

        private void Am_Resign(object? sender, EventArgs e)
        {
            MessageBox.Show("Am resigned from KPMG");
        }

        private void Jazz_Join(object? sender, EventArgs e)
        {
            MessageBox.Show("Jazz joined KPMG successfully");
        }

        private void Jen_Join(object? sender, EventArgs e)
        {
            MessageBox.Show("Jen joined KPMG successfully");
        }

        private void Am_Join(object? sender, EventArgs e)
        {
            MessageBox.Show("Am joined KPMG successfully");
        }

        private void Button1_Click1(object? sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void Button1_Click2(object? sender, EventArgs e)
        {
            MessageBox.Show("Welcome");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the button");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KPMGEmp.TriggerJoinEvent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KPMGEmp.TriggerResignEvent();
        }
    }

}