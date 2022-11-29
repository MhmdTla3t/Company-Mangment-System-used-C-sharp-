using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public class Payroll 
    {
        public int payrollId;
        public string emp_id;
        public double emp_hourwork;
        public double emp_hourrate;
        public string date;


        public double Emp_hourwork { get => emp_hourwork; set => emp_hourwork = value; }
        public double Emp_hourrate { get => emp_hourrate; set => emp_hourrate = value; }
        public string Date { get => date; set => date = value; }
        public int PayrollId { get => payrollId; set => payrollId = value; }
        public string Emp_id { get => emp_id; set => emp_id = value; }

        public Payroll(string _empid,int _payrollid, int _id, double _hourwork, double _hourrate, string _date) 
        {
         
            this.payrollId = _payrollid;
            this.emp_id = _empid;
            this.emp_hourwork = _hourwork;
            this.emp_hourrate = _hourrate;
            this.date = _date;

        }

        public Payroll()
        {

        }
        public static List<Payroll> Insert_New_Entry(List<Payroll> payroll, Payroll pay)
        {
            payroll.Add(pay);
            return payroll;
        }

        public void veiwhistory()
        {
            Console.WriteLine("\n"+"\t"+"\t" + emp_id + "\t\t" + payrollId + "\t" +"\t"+ emp_hourwork+ "\t"+"\t" + Emp_hourrate + "\t\t"+"\t" + date + "\t");
        }
    }
}

