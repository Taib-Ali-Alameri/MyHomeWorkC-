using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangSchoolApi
{
   public interface IEmployee
    {
        int Id { get; set; }

        string FirstName { get; set; }
        decimal Salary { get; set; }
    }
}
