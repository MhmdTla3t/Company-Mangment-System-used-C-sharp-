using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Vacation
    {
        public int vacation_id { get; set; }
        public int emp_id { get; set; }
        public int numofday { get; set; }

        public Vacation() { }
        public Vacation(int v_id ,int e_id, int _numday)
        {
            this.vacation_id = v_id;
            this.emp_id = e_id;
            this.numofday = _numday;
        }


        public void view_vacation()
        {
            Console.WriteLine("\n\t\t" + vacation_id + "\t\t" + emp_id + "\t\t" + numofday);

        }

    }
}
