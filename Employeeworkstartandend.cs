using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Employeeworkstartandend 
    {
        public int emp_id { get; set; }
        public string Emp_date { get; set; }
        public string Emp_hourstert { get; set; }
        public string Emp_hourend { get; set; }
        public Employeeworkstartandend(int _id, string _date, string _hourstart, string _hourend) 
        {
            this.emp_id = _id;
            this.Emp_date = _date;
            this.Emp_hourstert = _hourstart;
            this.Emp_hourend = _hourend;
        }



        public Employeeworkstartandend()
        {

        }


        public void ListAllEmployeeworked()
        {
            Console.WriteLine("\n\t" + emp_id + "\t" + Emp_date + "\t" + Emp_hourstert + "\t" + "\t" + Emp_hourend );
        }

        public static List<Employeeworkstartandend> Add_employeeworked(List<Employeeworkstartandend> employeeworkstartandend, Employeeworkstartandend empw)
        {
            employeeworkstartandend.Add(empw);
            return employeeworkstartandend;
        }

    }
}
