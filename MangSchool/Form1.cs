using MangSchoolApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangSChool
{

    public partial class Form1 : Form
    {

        Label header,
              Employeeid,
              Employeename,
              Employeetype,
              Employeesalary,
              Employeecount,
              totalSalary,
              displayEmployeecount,
              displaytotalSalary;
        TextBox textEmployeeid,
                textEmployeename,
                textEmployeesalary;
        Button add,
               clear;
        ComboBox comEmployeetype;


     static   List<IEmployee> employees= new List<IEmployee>();        

        public Form1()
        {
             //InitializeComponent();

            initallze();
         


        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
          
        }

        //function ADD
          public void Add_click(object sender, EventArgs e) {

              if (textEmployeeid.Text.Trim() != "" && textEmployeename.Text.Trim() != "" && textEmployeesalary.Text.Trim() != ""&&comEmployeetype.SelectedItem!=null)
              {
                  IEmployee employee = EmployeeFactory.GetEmployeeInstane(comEmployeetype, Convert.ToInt32(textEmployeeid.Text), textEmployeename.Text, Convert.ToDecimal(textEmployeesalary.Text));
                  employees.Add(employee);

                  displaytotalSalary.Text = employees.Sum(s => s.Salary).ToString();
                  displayEmployeecount.Text = employees.Count.ToString();
              }
              else
              MessageBox.Show("Please Inter The Value To Box");

          }

        // function Clear
          public void Clear_click(object sender, EventArgs e)
          {
              textEmployeeid.Clear();
              textEmployeename.Clear();
              textEmployeesalary.Clear();
              
          }

        public void initallze()
        {    // form
            this.Width = 500;
            this.Height = 400;
            this.Load += Form1_Load;

            // label header
             header = new Label();
            header.Width = 500;
            header.Height = 80;
            header.Text = "SChool";
            header.ForeColor = Color.Azure;
            header.BackColor = Color.Aqua;
            header.Font = new Font(FontFamily.Families[0], 25, FontStyle.Bold);
            header.Text.ToUpper();
            header.TextAlign = ContentAlignment.MiddleLeft;

            this.Controls.Add(header);
            //label  Employeeid
            Employeeid = new Label();
            Employeeid.Text = " EmployeeId:";
            Employeeid.Height = 20;
            Employeeid.Width = 80;

            Employeeid.Location = new Point(40, 100);

            this.Controls.Add(Employeeid);

            //label  Employeename
            Employeename = new Label();
            Employeename.Text = "EmployeeName:";
            Employeename.Location = new Point(40, 125);
            Employeename.Width = 80;
            this.Controls.Add(Employeename);

            //label EmployeType
            Employeetype = new Label();
            Employeetype.Text = "Employeetype:";
            Employeetype.Location = new Point(40, 150);
            Employeetype.Width = 80;
            this.Controls.Add(Employeetype);



            // label    Employeesalary
            Employeesalary = new Label();
            Employeesalary.Text = "Employeesalary:";
            Employeesalary.Location = new Point(40, 175);
            Employeesalary.Width = 80;
            this.Controls.Add(Employeesalary);




            // textbox id
            textEmployeeid = new TextBox();
            textEmployeeid.Width = 80;
            textEmployeeid.Location = new Point(200, 100);
            textEmployeeid.KeyPress += key;
            this.Controls.Add(textEmployeeid);

            // text Name
            textEmployeename = new TextBox();
            textEmployeename.Width = 180;
            textEmployeename.Location = new Point(200, 125);
            this.Controls.Add(textEmployeename);

           

            // text slary
            textEmployeesalary = new TextBox();
            textEmployeesalary.Width = 80;
            textEmployeesalary.Location = new Point(200, 175);
            textEmployeesalary.KeyPress += key;
            this.Controls.Add(textEmployeesalary);

            //combobox  type
            comEmployeetype = new ComboBox();
            comEmployeetype.Width = 120;
            comEmployeetype.Location = new Point(200, 150);
            comEmployeetype.DataSource = Enum.GetValues(typeof(EmployeeType));
            this.Controls.Add(comEmployeetype);

            //button add
            add = new Button();
            add.Width = 70;
            add.Height = 50;
            add.Location = new Point(320, 170);
            add.Text = "ADD";
            add.Click += Add_click;
            this.Controls.Add(add);

            // button clear
            clear = new Button();
            clear.Width = 70;
            clear.Height = 50;
            clear.Location = new Point(390, 170);
            clear.Text = "Clear";
            clear.Click += Clear_click;
            this.Controls.Add(clear);


            // label  Employeecount
            Employeecount = new Label();
            Employeecount.Text = "Employeecount:";
            Employeecount.Location = new Point(40, 270);

            this.Controls.Add(Employeecount);

            // label  totalSalary
            totalSalary = new Label();
            totalSalary.Text = "totalSalary:";
            totalSalary.Location = new Point(40, 295);

            this.Controls.Add(totalSalary);

            //label displayEmployeecount
            displayEmployeecount = new Label();
            displayEmployeecount.Text = "--:";
            displayEmployeecount.Location = new Point(150, 270);

            this.Controls.Add(displayEmployeecount);


            //label displaytotalSalary
            displaytotalSalary = new Label();
            displaytotalSalary.Text = "--:";
            displaytotalSalary.Location = new Point(150, 295);

            this.Controls.Add(displaytotalSalary);

        }
        //function test text
        private void SetEnable(object sender, EventArgs e)
        { 
           
        
        }

        //
        private void key(object s, KeyPressEventArgs e)
        {

            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete))
                e.Handled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void comEmployeetype_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
   

}