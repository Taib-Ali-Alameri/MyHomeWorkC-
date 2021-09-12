using MangSchoolApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangSChool
{
    public enum EmployeeType
    {
        Teacher,
        HeadOfDepartment,
        HeadMaster
    }

   
   
  
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }

    public class Teacher : IEmployeeBase
    {


        public override decimal Salary { get { return (base.Salary + (base.Salary * 0.02m)); } }
    }

    public class HeadOfDepartment :IEmployeeBase
    {

        public override decimal Salary { get { return (base.Salary + (base.Salary * 0.03m)); } }
    }
    public class HeadMaster : IEmployeeBase
    {
        public override decimal Salary { get { return (base.Salary + (base.Salary * 0.04m)); } }
    }


    public static class EmployeeFactory
    {

        public static IEmployee GetEmployeeInstane(ComboBox comEmployeeType, int id, string firstName, decimal salary)
        {

            IEmployee employee = null;

            switch (comEmployeeType.Text)
            {
                case "Teacher":
                    employee = new Teacher { Id = id, FirstName = firstName, Salary = salary };
                    break;
                case "HeadOfDepartment":
                    employee = new HeadOfDepartment { Id = id, FirstName = firstName, Salary = salary };
                    break;
                case "HeadMaster":
                    employee = new HeadMaster { Id = id, FirstName = firstName, Salary = salary };
                    break;
                default:
                    break;

            }
            return employee;


        }
    }
}
