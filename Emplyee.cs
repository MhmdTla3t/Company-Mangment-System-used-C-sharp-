using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
  public  class Emplyee
    {

        public int emp_id;
        public string emp_name;
        public string emp_address;
        public long emp_phone;
        public string emp_gender;

      
        public int Emp_id { get => emp_id; set => emp_id = value; }
        public string Emp_name { get => emp_name; set => emp_name = value; }
        public string Emp_address { get => emp_address; set => emp_address = value; }
        public long Emp_phone { get => emp_phone; set => emp_phone = value; }
        public string Emp_gender { get => emp_gender; set => emp_gender = value; }

        public Emplyee(int _id, string _name, string _addess, long _phone, string _gender)

        {
            this.emp_id = _id;
            this.emp_name = _name;
            this.emp_address = _addess;
            this.emp_phone = _phone;
            this.emp_gender = _gender;


        }

       public Emplyee() { 
}

        //public Emplyee(int id)
        //{
        //}

        public void ListAllEmployee()
        {
            Console.WriteLine("\n\t" + Emp_id + "\t" + Emp_name + "\t" + Emp_phone + "\t"+"\t" + emp_address + "\t" + emp_gender);
        }

        public static List<Emplyee>Add_employee(List<Emplyee>emplyee, Emplyee emp)
        {
            emplyee.Add(emp);
            return emplyee;
        }


    }
}    


