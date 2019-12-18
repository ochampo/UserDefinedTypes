using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedTypes
{
    public class Program
    {
        public bool CheckID(EmployeeClass employee)
        {
            

            if(employee.Id.ToString().Length > 5)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        static void Main(string[] args)
        {
            EmployeeStrut worker = new EmployeeStrut();
            worker.Name = "dan";
            worker.Id = 1776;
            worker.type = EmployeeType.IT;


            EmployeeClass employee = new EmployeeClass();
            employee.Name = "peter";
            employee.Id = 1553;
            worker.type = EmployeeType.Recruiter;


            CheckID(employee);
        }
    }
   public  class EmployeeClass
    {
        public string Name;
        public int Id;
        public EmployeeType type;
    }

   public  struct EmployeeStrut
    {
        public string Name;
        public int Id;
        public EmployeeType type;
    }

   public enum EmployeeType
    {
        IT,
        Recruiter

    }


}
