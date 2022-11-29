using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            int choice2 = 0;
            int choice3 = 0;
            int choice4 = 0;
            List<Emplyee> emplyee = new List<Emplyee>();
            emplyee.Add(new Emplyee(123, "ahmed", "sohag", 01201214, "male"));

            List<Employeeworkstartandend> employeeworkstartandends = new List<Employeeworkstartandend>();
            employeeworkstartandends.Add(new Employeeworkstartandend(123, "1/2/1999", "09:00am", "02:00pm"));

            List<ClientServes> gestresev = new List<ClientServes>();
            gestresev.Add(new ClientServes(123, "mody", "012124", "male", "1/1/1235","10:00am", "18/1/2000","02:00pm"));

            List<Payroll> payroll = new List<Payroll>();
            payroll.Add(new Payroll("123",1,12,13.5,12.5,"1/2/1999"));


            List<Vacation> vacation = new List<Vacation>();
            vacation.Add(new Vacation(12, 13, 14));




#pragma warning disable CS0164 // This label has not been referenced
        Main_Menu:
#pragma warning restore CS0164 // This label has not been referenced
            Console.WriteLine("\n.................Empolyee and Client Managment System.................\n\n");
            Console.WriteLine("Welcome To Main Menu, Please Enter Your Choice\n");
            Console.WriteLine("Press 1 to About Empolyees");
            Console.WriteLine("Press 2 to About ClientServes");
            //Console.WriteLine("Press 3 to Add Payroll");
          

            Console.WriteLine("Press 3 to Exit Program");






            Console.Write("\nEnter Your Choice : ");
            string input = Console.ReadLine();

            while (true)
            {
                if (int.TryParse(input, out choice))
                {
                    if (choice.Equals(1))
                    {
                        Console.WriteLine("1 Press");
                        Console.Clear();
                        Console.WriteLine("\n.................Empolyee Managment System.................\n\n");
                        Console.WriteLine("Welcome To Empolyee, Please Enter Your Choice\n");
                        Console.WriteLine("Press 1 to Information about employee day ");
                        Console.WriteLine("Press 1 to list all employees");
                        Console.WriteLine("Press 2 to add a new employee");
                        Console.WriteLine("Press 3 to Update employee");
                        Console.WriteLine("Press 4 to Delete employee");
                        Console.WriteLine("Press 6 to View Vacation Days");
                        Console.WriteLine("Press 7 to Add Payroll");
                        Console.WriteLine("Press 5 to return to main menu");



                        Console.Write("\nEnter Your Choice : ");
                        string input2 = Console.ReadLine();

                        while (true)
                        {
                            if (int.TryParse(input2, out choice2))
                            {

                                if (choice2.Equals(2))
                                {
                                    Console.WriteLine("\t\t\t-------Empolyee Details-------");
                                    Console.WriteLine("\n\tID \t Name \tAddress \tPhone \tGender");

                                    emplyee.ForEach(p => p.ListAllEmployee());

                                    Console.Write("\nEnter Your Choice : ");
                                    input2 = Console.ReadLine();
                                }


                                //#add employee after check id 
                                else if (choice2.Equals(3))
                                {
                                    Console.WriteLine("\n\t\t\t------- Add Empolyee -------");

                                    Emplyee emp = new Emplyee();
                                    Console.Write("Enter Empolyee ID : ");
                                    int Emp_id = Convert.ToInt32(Console.ReadLine());
                                    var empinfo = emplyee.Where(e => e.emp_id == Emp_id).FirstOrDefault();

                                    if (empinfo == null)
                                    {
                                        empinfo = emp;
                                        empinfo.emp_id = 0;
                                    }
                                    if (Emp_id != null)
                                    {
                                        if (empinfo.Emp_id != Emp_id || empinfo.Emp_id != null)
                                        {
                                            emp.Emp_id = Emp_id;
                                            Console.Write("Enter Name : ");
                                            emp.emp_name = Console.ReadLine();
                                            Console.Write("Enter Address : ");
                                            emp.emp_address = Console.ReadLine();
                                            Console.Write("Enter Phone : ");
                                            emp.emp_phone = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Enter Gender : ");
                                            emp.emp_gender = Console.ReadLine();



                                            emplyee.Where(e => e.emp_id == emp.Emp_id);
                                            emplyee.Where(e => e.emp_name == emp.emp_name);
                                            emplyee.Where(e => e.Emp_address == emp.Emp_address);
                                            emplyee.Where(e => e.Emp_phone == emp.Emp_phone);
                                            emplyee.Where(e => e.Emp_gender == emp.Emp_gender);
                                            emplyee.Add(emp); Console.WriteLine("\n\tEmployee with id: " + Emp_id + " Added successfully");
                                        }
                                        else
                                        {
                                            Console.WriteLine("\n\tEmployee " + empinfo.Emp_id + " Already Exist, Choice Again Options");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Employee with id: " + Emp_id + " does not exist");
                                    }




                                    Console.Write("\nEnter Your Choice : ");
                                    input2 = Console.ReadLine();


                                }




                                //#update employee by using id
                                else if (choice2.Equals(4))
                                {

                                    Console.Write("Enter Empolyee_ID for Update Empolyee Profile : ");
                                    int emp_id = Convert.ToInt32(Console.ReadLine());
                                    Emplyee emp = new Emplyee();

                                    var empinfo = emplyee.Where(e => e.Emp_id == emp_id).FirstOrDefault();
                                    if (empinfo != null)
                                    {
                                        emp.Emp_id = emp_id;
                                        Console.Write("Enter Name : ");
                                        emp.emp_name = Console.ReadLine();
                                        Console.Write("Enter Address : ");
                                        emp.Emp_address = Console.ReadLine();
                                        Console.Write("Enter Phone : ");
                                        emp.Emp_phone = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Enter Role : ");
                                        emp.emp_gender = Console.ReadLine();



                                        emplyee.Where(e => e.Emp_id == emp_id).FirstOrDefault().emp_id = emp.emp_id;
                                        emplyee.Where(e => e.Emp_id == emp_id).FirstOrDefault().emp_name = emp.emp_name;

                                        emplyee.Where(e => e.Emp_id == emp_id).FirstOrDefault().Emp_address = emp.emp_address;
                                        emplyee.Where(e => e.emp_id == emp_id).FirstOrDefault().emp_phone = emp.Emp_phone;
                                        emplyee.Where(e => e.emp_id == emp_id).FirstOrDefault().emp_gender = emp.emp_gender;

                                        Console.WriteLine("\n\tEmployee with id: " + emp_id + " updated successfully");


                                    }
                                    else
                                    {
                                        Console.WriteLine("\n\tEmployee with id: " + emp_id + " does not exist.");

                                    }



                                    /*delete employeel*/

                                    Console.Write("\nEnter Your Choice : ");
                                    input2 = Console.ReadLine();



                                }
                                else if (choice2.Equals(5))
                                {
                                    Console.Write("\n\tEnter Empolyee_ID TO Delete Empolyee! : ");
                                    int emp_id = Convert.ToInt32(Console.ReadLine());
                                    emplyee.RemoveAll(e => e.Emp_id == emp_id);
                                    Console.Write("\nEnter your Choice : ");
                                    input2 = Console.ReadLine();
                                }


                                /*vaction*/






                                else if (choice2.Equals(6))
                                {
                                    Console.WriteLine("3 Press");
                                    Console.Clear();
                                    Console.WriteLine("\n.................Empolyee Managment System.................\n\n");
                                    Console.WriteLine("Welcome To Vacation, Please Enter Your Choice\n");
                                    Console.WriteLine("Press 1 to view vacation days");
                                    Console.WriteLine("Press 2 to Add vacation days");
                                    Console.WriteLine("Press 3 to return to main menu");


                                    Console.Write("\nEnter Your Choice : ");
                                    string input3 = Console.ReadLine();

                                    while (true)
                                    {
                                        if (int.TryParse(input3, out choice3))
                                        {
                                            if (choice3.Equals(1))
                                            {

                                                Console.WriteLine("\n\n\t\t  -------Vacation Details-------");
                                                Console.WriteLine("\n\t\tVac_ID \t\tEmp_ID\t\tno_days\t\t");
                                                vacation.ForEach(p => p.view_vacation());

                                                Console.Write("\nEnter Your Choice : ");
                                                input3 = Console.ReadLine();
                                            }
                                            else if (choice3.Equals(2))
                                            {
                                                Vacation vac = new Vacation();
                                                Console.Write("\nEnter Vacation ID : ");
                                                int vac_id = Convert.ToInt32(Console.ReadLine());
                                                var vacinfo = vacation.Where(e => e.vacation_id == vac_id).FirstOrDefault();

                                                if (vacinfo == null)
                                                {
                                                    vacinfo = vac;
                                                    vacinfo.vacation_id = 0;
                                                }


#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                                                if (vac_id != null)
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                                                {
                                                    if (vacinfo.vacation_id != vac_id || vacinfo.vacation_id == null)
                                                    {
                                                        vac.emp_id = vac_id;
                                                        Console.Write("Enter Empolyee ID : ");
                                                        vac.emp_id = Convert.ToInt32(Console.ReadLine());
                                                        Console.Write("Enter numberOfDays: ");
                                                        vac.emp_id = Convert.ToInt32(Console.ReadLine());


                                                        vacation.Where(e => e.emp_id == vac.emp_id);
                                                        vacation.Where(e => e.emp_id == vac.emp_id);
                                                        vacation.Where(e => e.numofday == vac.numofday);

                                                        vacation.Add(vac);

                                                        Console.WriteLine("\n\t Vacation with id: " + vac_id + " Added successfully");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("\n\t Vacation with id: " + vac_id + " Already Exist, Choice Again Options");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Vacation with id: " + vac_id + " does not exist");
                                                }
                                                Console.Write("\nEnter Your Choice : ");
                                                input3 = Console.ReadLine();

                                            }
                                            else if (choice3.Equals(3))
                                            {
                                                Console.Clear();
                                                goto Main_Menu;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid Choice, Try Again");
                                                Console.Write("\nEnter Your Choice : ");
                                                input3 = Console.ReadLine();
                                            }


                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid Choice, Try Again");
                                            Console.Write("\nEnter Your Choice : ");
                                            input3 = Console.ReadLine();
                                        }
                                    }



                                }





                                /****payroll*****/




                                else if (choice2.Equals(7))
                                {
                                    Console.WriteLine("2 Press");
                                    Console.Clear();
                                    Console.WriteLine("\n.................Empolyee Managment System.................\n\n");
                                    Console.WriteLine("Welcome To Payroll, Please Enter Your Choice\n");
                                    Console.WriteLine("Press 1 to Insert new payroll entry");
                                    Console.WriteLine("Press 2 view payroll history for an employee");
                                    Console.WriteLine("Press 3 to return to main menu");

                                    Console.Write("\nEnter Your Choice : ");
                                   string input3 = Console.ReadLine();

                                    while (true)
                                    {
                                        if (int.TryParse(input3, out choice3))
                                        {
                                            if (choice3.Equals(1))
                                            {
                                                Payroll pay = new Payroll();
                                                Console.Write("Enter Payroll ID : ");
                                                int pay_id = Convert.ToInt32(Console.ReadLine());
                                                var payinfo = payroll.Where(a => a.payrollId == pay_id).FirstOrDefault();

                                                if (payinfo == null)
                                                {
                                                    payinfo = pay;
                                                    payinfo.payrollId = 0;
                                                }




#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                                                if (pay_id != null)
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                                                {
                                                    if (payinfo.payrollId != pay_id || payinfo.payrollId == null)
                                                    {
                                                        pay.payrollId = pay_id;
                                                        Console.Write("Enter empolyee ID : ");
                                                        pay.emp_id =(Console.ReadLine());
                                                        Console.Write("Enter Worked Hours : ");
                                                        pay.emp_hourwork = Convert.ToDouble(Console.ReadLine());
                                                        Console.Write("Enter Hourly Rate : ");
                                                        pay.Emp_hourrate = Convert.ToDouble(Console.ReadLine());
                                                        Console.Write("Enter Date --12/12/2020-- : ");
                                                        pay.date = Console.ReadLine();


                                                        payroll.Where(e => e.emp_id == pay.emp_id);
                                                        payroll.Where(e => e.emp_id == pay.emp_id);
                                                        payroll.Where(e => e.emp_hourwork == pay.emp_hourwork);
                                                        payroll.Where(e => e.Emp_hourrate == pay.Emp_hourrate);
                                                        payroll.Where(e => e.date == pay.date);

                                                        payroll.Add(pay);

                                                        Console.WriteLine("\n\tEmployee with id: " + pay_id + " Added successfully");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("\n\tEmployee " + pay_id + " Already Exist, Choice Again Options");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Employee with id: " + pay_id + " does not exist");
                                                }


                                                Console.Write("\nEnter Your Choice : ");
                                                input3 = Console.ReadLine();
                                            }
                                            else if (choice3.Equals(2))
                                            {
                                                Console.WriteLine("\n  \t\t\t\t-------Payroll Details-------");
                                                Console.WriteLine("\n\t\tEmp_ID \t\tpay_ID\t\tWork_hours\thourly_work\t\tDate \t");
                                                payroll.ForEach(p => p.veiwhistory());

                                                Console.Write("\nEnter Your Choice : ");
                                                input3 = Console.ReadLine();
                                            }
                                            else if (choice3.Equals(3))
                                            {
                                                Console.Clear();
                                                goto Main_Menu;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid Choice, Try Again");
                                                Console.Write("\nEnter Your Choice : ");
                                                input3 = Console.ReadLine();
                                            }


                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid Choice, Try Again");
                                            Console.Write("\nEnter Your Choice : ");
                                            input3 = Console.ReadLine();
                                        }
                                    }

                                }










                                else if (choice2.Equals(5))
                                {
                                    Console.Clear();
                                    goto Main_Menu;
                                }

                                /*********************Employee serves*/
                                else if (choice2.Equals(1))
                                {

                                    Console.WriteLine("\n.................Empolyee Day Managment Work System.................\n\n");
                                    Console.WriteLine("Welcome To Main Menu, Please Enter Your Choice\n");
                                    Console.WriteLine("Press 1 to Empstart");
                                    Console.WriteLine("Press 2 to Empend ");
                                    Console.WriteLine("Press 3 to exit Program");






                                    Console.Write("\nEnter Your Choice : ");
                                    string input3 = Console.ReadLine();

                                    while (true)
                                    {
                                        if (int.TryParse(input3, out choice3))
                                        {
                                            if (choice3.Equals(1))
                                            {
                                                Console.WriteLine("1 Press");
                                                Console.Clear();
                                                Console.WriteLine("\n.................Empolyee Day Start.................\n\n");
                                                Console.WriteLine("Welcome To Empolyee, Please Enter Your Choice\n");
                                                Console.WriteLine("Press 1 to list all employees");
                                                Console.WriteLine("Press 2 to add a new employee");
                                                Console.WriteLine("Press 3 to Update employee");

                                                Console.WriteLine("Press 4 to return to main menu");

                                                Console.Write("\nEnter Your Choice : ");
                                                string input4 = Console.ReadLine();

                                                while (true)
                                                {
                                                    if (int.TryParse(input4, out choice4))
                                                    {

                                                        if (choice4.Equals(1))
                                                        {
                                                            Console.WriteLine("\t\t\t-------Empolyee Details-------");
                                                            Console.WriteLine("\n\tID \t Dataday  \tHourin \t\tHourout");

                                                            employeeworkstartandends.ForEach(p => p.ListAllEmployeeworked());

                                                            Console.Write("\nEnter Your Choice : ");
                                                            input4 = Console.ReadLine();
                                                        }


                                                        //#add employee after check id 
                                                        else if (choice4.Equals(2))
                                                        {
                                                            Console.WriteLine("\n\t\t\t------- Add Empolyee hourstart-------");


                                                            Console.Write("Enter Empolyee ID : ");
                                                            int Emp_id = Convert.ToInt32(Console.ReadLine());
                                                            Employeeworkstartandend empw = new Employeeworkstartandend();
                                                            var empinfowork = employeeworkstartandends.Where(e => e.emp_id == Emp_id).FirstOrDefault();

                                                            if (empinfowork == null)
                                                            {
                                                                empinfowork = empw;
                                                                empinfowork.emp_id = 0;
                                                            }
                                                            if (Emp_id != null)
                                                            {
                                                                if (empinfowork.emp_id != Emp_id || empinfowork.emp_id != null)
                                                                {

                                                                    empw.emp_id = Emp_id;
                                                                    Console.Write("Enter Date : ");
                                                                    empw.Emp_date = Console.ReadLine();
                                                                    Console.Write("Enter Hourstart : ");
                                                                    empw.Emp_hourstert = Console.ReadLine();
                                                                    Console.Write("Enter Hourend : ");
                                                                    empw.Emp_hourstert = Console.ReadLine();

                                                                    employeeworkstartandends.Where(e => e.emp_id == empw.emp_id);
                                                                    employeeworkstartandends.Where(e => e.Emp_date == empw.Emp_date);
                                                                    employeeworkstartandends.Where(e => e.Emp_hourstert == empw.Emp_hourstert);
                                                                    employeeworkstartandends.Where(e => e.Emp_hourend == empw.Emp_hourend);



                                                                    employeeworkstartandends.Add(empw); Console.WriteLine("\n\tEmployee with id: " + Emp_id + " Added successfully");
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("\n\tEmployee " + empinfowork.emp_id + " Already Exist, Choice Again Options");
                                                                }
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Employee with id: " + Emp_id + " does not exist");
                                                            }




                                                            Console.Write("\nEnter Your Choice : ");
                                                            input4 = Console.ReadLine();


                                                        }




                                                        //#update employee by using id
                                                        else if (choice4.Equals(3))
                                                        {

                                                            Console.Write("Enter Empolyee_ID for Update Empolyee Profile : ");
                                                            int emp_id = Convert.ToInt32(Console.ReadLine());
                                                            Employeeworkstartandend empw = new Employeeworkstartandend();

                                                            var empinfowork = employeeworkstartandends.Where(e => e.emp_id == emp_id).FirstOrDefault();
                                                            if (empinfowork != null)
                                                            {
                                                                empw.emp_id = emp_id;
                                                                Console.Write("Enter Date : ");
                                                                empw.Emp_date = Console.ReadLine();
                                                                Console.Write("Enter Hourstart : ");
                                                                empw.Emp_hourstert = Console.ReadLine();
                                                                Console.Write("Enter Hourend : ");
                                                                empw.Emp_hourend = (Console.ReadLine());




                                                                employeeworkstartandends.Where(e => e.emp_id == emp_id).FirstOrDefault().emp_id = empw.emp_id;
                                                                employeeworkstartandends.Where(e => e.emp_id == emp_id).FirstOrDefault().Emp_date = empw.Emp_date;
                                                                employeeworkstartandends.Where(e => e.emp_id == emp_id).FirstOrDefault().Emp_hourstert = empw.Emp_hourstert;
                                                                employeeworkstartandends.Where(e => e.emp_id == emp_id).FirstOrDefault().Emp_hourend = empw.Emp_hourend;



                                                                Console.WriteLine("\n\tEmployee with id: " + emp_id + " updated successfully");


                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("\n\tEmployee with id: " + emp_id + " does not exist.");

                                                            }



                                                            Console.Write("\nEnter Your Choice : ");
                                                            input4 = Console.ReadLine();


                                                            /*delete employeel*/





                                                        }











                                                        else if (choice4.Equals(4))
                                                        {
                                                            Console.Clear();
                                                            goto Main_Menu;
                                                        }

                                                        else
                                                        {
                                                            Console.WriteLine("Invalid Choice, Try Again");
                                                            Console.Write("\nEnter Your Choice : ");
                                                            input4 = Console.ReadLine();
                                                        }

                                                    }


                                                }
                                            }








                                            else if (int.TryParse(input3, out choice3))
                                            {
                                                if (choice3.Equals(2))
                                                {
                                                    Console.WriteLine("1 Press");
                                                    Console.Clear();
                                                    Console.WriteLine("\n.................Empolyee Day End.................\n\n");
                                                    Console.WriteLine("Welcome To Empolyee, Please Enter Your Choice\n");
                                                    Console.WriteLine("Press 1 to list all employees");
                                                    Console.WriteLine("Press 2 to add a new employee");
                                                    Console.WriteLine("Press 3 to Update employee");

                                                    Console.WriteLine("Press 4 to return to main menu");

                                                    Console.Write("\nEnter Your Choice : ");
                                                    string input4 = Console.ReadLine();

                                                    while (true)
                                                    {
                                                        if (int.TryParse(input4, out choice4))
                                                        {

                                                            if (choice4.Equals(1))
                                                            {
                                                                Console.WriteLine("\t\t\t-------Empolyee Details-------");
                                                                Console.WriteLine("\n\tID \t Dataday  \tHourin \t\tHourout");

                                                                employeeworkstartandends.ForEach(p => p.ListAllEmployeeworked());

                                                                Console.Write("\nEnter Your Choice : ");
                                                                input4 = Console.ReadLine();
                                                            }


                                                            //#add employee after check id 
                                                            else if (choice4.Equals(2))
                                                            {
                                                                Console.WriteLine("\n\t\t\t------- Add Empolyee hourstart-------");


                                                                Console.Write("Enter Empolyee ID : ");
                                                                int Emp_id = Convert.ToInt32(Console.ReadLine());
                                                                Employeeworkstartandend empw = new Employeeworkstartandend();
                                                                var empinfowork = employeeworkstartandends.Where(e => e.emp_id == Emp_id).FirstOrDefault();

                                                                if (empinfowork == null)
                                                                {
                                                                    empinfowork = empw;
                                                                    empinfowork.emp_id = 0;
                                                                }
                                                                if (Emp_id != null)
                                                                {
                                                                    if (empinfowork.emp_id != Emp_id || empinfowork.emp_id != null)
                                                                    {

                                                                        empw.emp_id = Emp_id;
                                                                        Console.Write("Enter Date : ");
                                                                        empw.Emp_date = Console.ReadLine();
                                                                        Console.Write("Enter Hourstart : ");
                                                                        empw.Emp_hourstert = Console.ReadLine();
                                                                        Console.Write("Enter Hourend : ");
                                                                        empw.Emp_hourstert = Console.ReadLine();

                                                                        employeeworkstartandends.Where(e => e.emp_id == empw.emp_id);
                                                                        employeeworkstartandends.Where(e => e.Emp_date == empw.Emp_date);
                                                                        employeeworkstartandends.Where(e => e.Emp_hourstert == empw.Emp_hourstert);
                                                                        employeeworkstartandends.Where(e => e.Emp_hourend == empw.Emp_hourend);



                                                                        employeeworkstartandends.Add(empw); Console.WriteLine("\n\tEmployee with id: " + Emp_id + " Added successfully");
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("\n\tEmployee " + empinfowork.emp_id + " Already Exist, Choice Again Options");
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Employee with id: " + Emp_id + " does not exist");
                                                                }




                                                                Console.Write("\nEnter Your Choice : ");
                                                                input4 = Console.ReadLine();


                                                            }




                                                            //#update employee by using id
                                                            else if (choice4.Equals(3))
                                                            {

                                                                Console.Write("Enter Empolyee_ID for Update Empolyee Profile : ");
                                                                int emp_id = Convert.ToInt32(Console.ReadLine());
                                                                Employeeworkstartandend empw = new Employeeworkstartandend();

                                                                var empinfowork = employeeworkstartandends.Where(e => e.emp_id == emp_id).FirstOrDefault();
                                                                if (empinfowork != null)
                                                                {
                                                                    empw.emp_id = emp_id;
                                                                    Console.Write("Enter Date : ");
                                                                    empw.Emp_date = Console.ReadLine();
                                                                    Console.Write("Enter Hourstart : ");
                                                                    empw.Emp_hourstert = Console.ReadLine();
                                                                    Console.Write("Enter Hourend : ");
                                                                    empw.Emp_hourend = (Console.ReadLine());




                                                                    employeeworkstartandends.Where(e => e.emp_id == emp_id).FirstOrDefault().emp_id = empw.emp_id;
                                                                    employeeworkstartandends.Where(e => e.emp_id == emp_id).FirstOrDefault().Emp_date = empw.Emp_date;
                                                                    employeeworkstartandends.Where(e => e.emp_id == emp_id).FirstOrDefault().Emp_hourstert = empw.Emp_hourstert;
                                                                    employeeworkstartandends.Where(e => e.emp_id == emp_id).FirstOrDefault().Emp_hourend = empw.Emp_hourend;



                                                                    Console.WriteLine("\n\tEmployee with id: " + emp_id + " updated successfully");


                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("\n\tEmployee with id: " + emp_id + " does not exist.");

                                                                }



                                                                Console.Write("\nEnter Your Choice : ");
                                                                input4 = Console.ReadLine();


                                                                /*delete employeel*/





                                                            }











                                                            else if (choice4.Equals(4))
                                                            {
                                                                Console.Clear();
                                                                goto Main_Menu;
                                                            }

                                                            else
                                                            {
                                                                Console.WriteLine("Invalid Choice, Try Again");
                                                                Console.Write("\nEnter Your Choice : ");
                                                                input4 = Console.ReadLine();
                                                            }

                                                        }


                                                    }
                                                }


                                                else if (choice3.Equals(3))
                                                {
                                                    Console.WriteLine("4 Press");
                                                    Console.Clear();
                                                    System.Environment.Exit(0);
                                                }
                                            }
                                        }
                                    }
                                }



                                else
                                {
                                    Console.WriteLine("Invalid Choice, Try Again");
                                    Console.Write("\nEnter Your Choice : ");
                                    input2 = Console.ReadLine();
                                }

                            }


                        }

                    }






































                    /************** int gest save************/



                    else if (choice.Equals(2))
                    {
                        Console.WriteLine("1 Press");
                        Console.Clear();
                        Console.WriteLine("\n.................Client Managment System.................\n\n");
                        Console.WriteLine("Welcome To Gest, Please Enter Your Choice\n");
                        Console.WriteLine("Press 1 to list all Client");
                        Console.WriteLine("Press 2 to add a new ClientServes");
                        Console.WriteLine("Press 3 to Update ClientServes");
                        Console.WriteLine("Press 4 to Delete ClientServes");
                        Console.WriteLine("Press 5 to return to main menu");

                        Console.Write("\nEnter Your Choice : ");
                        string input2 = Console.ReadLine();
                        while (true)
                        {
                            if (int.TryParse(input2, out choice2))
                            {
                                if (choice2.Equals(1))
                                {
                                    Console.WriteLine("\t\t\t-------Empolyee Details-------");
                                    Console.WriteLine("\n\tID \t Name \t phone\t\tGender \t Datein \t Hourin \t Dateout \t Hourout");

                                    gestresev.ForEach(g => g.ListAllGest());

                                    Console.Write("\nEnter Your Choice : ");
                                    input2 = Console.ReadLine();
                                }
                                else if (choice2.Equals(2))
                                {
                                    Console.WriteLine("\n\t\t\t------- Add Empolyee -------");

                                    ClientServes ges = new ClientServes();
                                    Console.Write("Enter Gest ID : ");
                                    int Ges_id = Convert.ToInt32(Console.ReadLine());
                                    var gesinfo = gestresev.Where(s => s.Gestid == Ges_id).FirstOrDefault();

                                    if (gesinfo == null)
                                    {
                                        gesinfo = ges;
                                        gesinfo.Gestid = 0;
                                    }
                                    if (Ges_id != null)
                                    {
                                        if (gesinfo.Gestid != Ges_id || gesinfo.Gestid != null)
                                        {
                                            ges.Gestid = Ges_id;
                                            Console.Write("Enter Name : ");
                                            ges.GesName = Console.ReadLine();
                                            Console.Write("Enter Phone : ");
                                            ges.Gesphone = Console.ReadLine();
                                            Console.Write("Enter Gender : ");
                                            ges.Gesgender = Console.ReadLine();
                                            Console.Write("Enter Datein : ");
                                            ges.Gesdatein = Console.ReadLine();
                                            Console.Write("Enter Hourin : ");
                                            ges.Gesthourin = Console.ReadLine();
                                            Console.Write("Enter Dateout : ");
                                            ges.Gesdateout = Console.ReadLine();
                                            Console.Write("Enter Hourout : ");
                                            ges.Gesthourout = Console.ReadLine();


                                            gestresev.Where(s => s.Gestid == ges.Gestid);
                                            gestresev.Where(s => s.GesName == ges.GesName);
                                            gestresev.Where(s => s.Gesphone == ges.Gesphone);
                                            gestresev.Where(s => s.Gesgender == ges.Gesgender);
                                            gestresev.Where(s => s.Gesdatein == ges.Gesdatein);
                                            gestresev.Where(s => s.Gesthourin == ges.Gesthourin);
                                            gestresev.Where(s => s.Gesdateout == ges.Gesdateout);
                                            gestresev.Where(s => s.Gesthourout == ges.Gesthourout);
                                            gestresev.Add(ges); Console.WriteLine("\n\tGest with id: " + Ges_id + " Added successfully");





                                        }
                                        else
                                        {
                                            Console.WriteLine("\n\tGest " + gesinfo.Gestid + " Already Exist, Choice Again Options");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Employee with id: " + Ges_id + " does not exist");
                                    }




                                    Console.Write("\nEnter Your Choice : ");
                                    input2 = Console.ReadLine();
                                }


                                //#update Gest by using id
                                else if (choice2.Equals(3))
                                {

                                    Console.Write("Enter Gest_ID for Update Gest information : ");
                                    int gest_id = Convert.ToInt32(Console.ReadLine());
                                    ClientServes ges = new ClientServes();

                                    var gesinfo = gestresev.Where(e => e.Gestid == gest_id).FirstOrDefault();
                                    if (gesinfo != null)
                                    {
                                        ges.Gestid = gest_id;
                                        Console.Write("Enter Name : ");
                                        ges.GesName = Console.ReadLine();
                                        Console.Write("Enter Phone : ");
                                        ges.Gesphone = Console.ReadLine();
                                        Console.Write("Enter Gender : ");
                                        ges.Gesgender = Console.ReadLine();
                                        Console.Write("Enter Datein : ");
                                        ges.Gesdatein = Console.ReadLine();
                                        Console.Write("Enter Hourin : ");
                                        ges.Gesthourin = Console.ReadLine();
                                        Console.Write("Enter Dateout : ");
                                        ges.Gesdateout = Console.ReadLine();
                                        Console.Write("Enter Hourout : ");
                                        ges.Gesthourout = Console.ReadLine();


                                        gestresev.Where(e => e.Gestid == gest_id).FirstOrDefault().Gestid = ges.Gestid;
                                        gestresev.Where(e => e.Gestid == gest_id).FirstOrDefault().GesName = ges.GesName;
                                        gestresev.Where(e => e.Gestid == gest_id).FirstOrDefault().Gesphone = ges.Gesphone;
                                        gestresev.Where(e => e.Gestid == gest_id).FirstOrDefault().Gesgender = ges.Gesgender;
                                        gestresev.Where(e => e.Gestid == gest_id).FirstOrDefault().Gesdatein = ges.Gesdatein;
                                        gestresev.Where(e => e.Gestid == gest_id).FirstOrDefault().Gesthourin = ges.Gesthourin;
                                        gestresev.Where(e => e.Gestid == gest_id).FirstOrDefault().Gesdateout = ges.Gesdateout;
                                        gestresev.Where(e => e.Gestid == gest_id).FirstOrDefault().Gesdateout = ges.Gesdateout;




                                        Console.WriteLine("\n\tGest with id: " + gest_id + " updated successfully");


                                    }
                                    else
                                    {
                                        Console.WriteLine("\n\tGest with id: " + gest_id + " does not exist.");

                                    }


                                    /*delete Gest information*/


                                    Console.Write("\nEnter Your Choice : ");
                                    input2 = Console.ReadLine();
                                }
                                else if (choice2.Equals(4))
                                {
                                    Console.Write("\n\tEnter Gest_ID TO Delete Empolyee! : ");
                                    int gest_id = Convert.ToInt32(Console.ReadLine());
                                    gestresev.RemoveAll(e => e.Gestid == gest_id);

                                    Console.Write("\nEnter Your Choice : ");
                                    input2 = Console.ReadLine();
                                }
                                else if (choice2.Equals(5))
                                {
                                    Console.Clear();
                                    goto Main_Menu;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Choice, Try Again");
                                    Console.Write("\nEnter Your Choice : ");
                                    input2 = Console.ReadLine();
                                }


                            }

                        }
                    }



                    /*payroll***************/



//                    else if (choice.Equals(3))
//                    {
//                        Console.WriteLine("2 Press");
//                        Console.Clear();
//                        Console.WriteLine("\n.................Empolyee Managment System.................\n\n");
//                        Console.WriteLine("Welcome To Payroll, Please Enter Your Choice\n");
//                        Console.WriteLine("Press 1 to Insert new payroll entry");
//                        Console.WriteLine("Press 2 view payroll history for an employee");
//                        Console.WriteLine("Press 3 to return to main menu");

//                        Console.Write("\nEnter Your Choice : ");
//                        string input2 = Console.ReadLine();

//                        while (true)
//                        {
//                            if (int.TryParse(input2, out choice2))
//                            {
//                                if (choice2.Equals(1))
//                                {
//                                    Payroll pay = new Payroll();
//                                    Console.Write("Enter Payroll ID : ");
//                                    int pay_id = Convert.ToInt32(Console.ReadLine());
//                                    var payinfo = payroll.Where(a => a.payrollId == pay_id).FirstOrDefault();

//                                    if (payinfo == null)
//                                    {
//                                        payinfo = pay;
//                                        payinfo.payrollId = 0;
//                                    }




//#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
//                                    if (pay_id != null)
//#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
//                                    {
//                                        if (payinfo.payrollId != pay_id || payinfo.payrollId == null)
//                                        {
//                                            pay.payrollId = pay_id;
//                                            Console.Write("Enter empolyee ID : ");
//                                            Console.Write("Enter Worked Hours : ");
//                                            pay.emp_hourwork = Convert.ToDouble(Console.ReadLine());
//                                            Console.Write("Enter Hourly Rate : ");
//                                            pay.Emp_hourrate = Convert.ToDouble(Console.ReadLine());
//                                            Console.Write("Enter Date --12/12/2020-- : ");
//                                            pay.date = Console.ReadLine();


//                                            payroll.Where(e => e.emp_id == pay.emp_id);
//                                            payroll.Where(e => e.emp_id == pay.emp_id);
//                                            payroll.Where(e => e.emp_hourwork == pay.emp_hourwork);
//                                            payroll.Where(e => e.Emp_hourrate == pay.Emp_hourrate);
//                                            payroll.Where(e => e.date == pay.date);

//                                            payroll.Add(pay);

//                                            Console.WriteLine("\n\tEmployee with id: " + pay_id + " Added successfully");
//                                        }
//                                        else
//                                        {
//                                            Console.WriteLine("\n\tEmployee " + pay_id + " Already Exist, Choice Again Options");
//                                        }
//                                    }
//                                    else
//                                    {
//                                        Console.WriteLine("Employee with id: " + pay_id + " does not exist");
//                                    }


//                                    Console.Write("\nEnter Your Choice : ");
//                                    input2 = Console.ReadLine();
//                                }
//                                else if (choice2.Equals(2))
//                                {
//                                    Console.WriteLine("\n  \t\t\t\t-------Payroll Details-------");
//                                    Console.WriteLine("\n\t\tPay_ID \t\tEmp_ID\t\tWork_hours\thourly_work\tDate \t");
//                                    payroll.ForEach(p => p.veiwhistory());

//                                    Console.Write("\nEnter Your Choice : ");
//                                    input2 = Console.ReadLine();
//                                }
//                                else if (choice2.Equals(3))
//                                {
//                                    Console.Clear();
//                                    goto Main_Menu;
//                                }
//                                else
//                                {
//                                    Console.WriteLine("Invalid Choice, Try Again");
//                                    Console.Write("\nEnter Your Choice : ");
//                                    input2 = Console.ReadLine();
//                                }


//                            }
//                            else
//                            {
//                                Console.WriteLine("Invalid Choice, Try Again");
//                                Console.Write("\nEnter Your Choice : ");
//                                input2 = Console.ReadLine();
//                            }
//                        }

//                    }



                    //                    else if (choice.Equals(4))
                    //                    {
                    //                        Console.WriteLine("3 Press");
                    //                        Console.Clear();
                    //                        Console.WriteLine("\n.................Empolyee Managment System.................\n\n");
                    //                        Console.WriteLine("Welcome To Vacation, Please Enter Your Choice\n");
                    //                        Console.WriteLine("Press 1 to view vacation days");
                    //                        Console.WriteLine("Press 2 to Add vacation days");
                    //                        Console.WriteLine("Press 3 to exit Program");


                    //                        Console.Write("\nEnter Your Choice : ");
                    //                        string input2 = Console.ReadLine();

                    //                        while (true)
                    //                        {
                    //                            if (int.TryParse(input2, out choice2))
                    //                            {
                    //                                if (choice2.Equals(1))
                    //                                {

                    //                                    Console.WriteLine("\n\n\t\t  -------Vacation Details-------");
                    //                                    Console.WriteLine("\n\t\tVac_ID \t\tEmp_ID\t\tno_days\t\t");
                    //                                    vacation.ForEach(p => p.view_vacation());

                    //                                    Console.Write("\nEnter Your Choice : ");
                    //                                    input2 = Console.ReadLine();
                    //                                }
                    //                                else if (choice2.Equals(2))
                    //                                {
                    //                                    Vacation vac = new Vacation();
                    //                                    Console.Write("\nEnter Vacation ID : ");
                    //                                    int vac_id = Convert.ToInt32(Console.ReadLine());
                    //                                    var vacinfo = vacation.Where(e => e.vacation_id == vac_id).FirstOrDefault();

                    //                                    if (vacinfo == null)
                    //                                    {
                    //                                        vacinfo = vac;
                    //                                        vacinfo.vacation_id = 0;
                    //                                    }


                    //#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                    //                                    if (vac_id != null)
                    //#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                    //                                    {
                    //                                        if (vacinfo.vacation_id != vac_id || vacinfo.vacation_id == null)
                    //                                        {
                    //                                            vac.emp_id = vac_id;
                    //                                            Console.Write("Enter Empolyee ID : ");
                    //                                            vac.emp_id = Convert.ToInt32(Console.ReadLine());
                    //                                            Console.Write("Enter numberOfDays: ");
                    //                                            vac.emp_id = Convert.ToInt32(Console.ReadLine());


                    //                                            vacation.Where(e => e.emp_id == vac.emp_id);
                    //                                            vacation.Where(e => e.emp_id == vac.emp_id);
                    //                                            vacation.Where(e => e.numofday == vac.numofday);

                    //                                            vacation.Add(vac);

                    //                                            Console.WriteLine("\n\t Vacation with id: " + vac_id + " Added successfully");
                    //                                        }
                    //                                        else
                    //                                        {
                    //                                            Console.WriteLine("\n\t Vacation with id: " + vac_id + " Already Exist, Choice Again Options");
                    //                                        }
                    //                                    }
                    //                                    else
                    //                                    {
                    //                                        Console.WriteLine("Vacation with id: " + vac_id + " does not exist");
                    //                                    }
                    //                                    Console.Write("\nEnter Your Choice : ");
                    //                                    input2 = Console.ReadLine();

                    //                                }
                    //                                else if (choice2.Equals(3))
                    //                                {
                    //                                    Console.Clear();
                    //                                    goto Main_Menu;
                    //                                }
                    //                                else
                    //                                {
                    //                                    Console.WriteLine("Invalid Choice, Try Again");
                    //                                    Console.Write("\nEnter Your Choice : ");
                    //                                    input2 = Console.ReadLine();
                    //                                }


                    //                            }
                    //                            else
                    //                            {
                    //                                Console.WriteLine("Invalid Choice, Try Again");
                    //                                Console.Write("\nEnter Your Choice : ");
                    //                                input2 = Console.ReadLine();
                    //                            }
                    //                        }



                    //                    }
                    else if (choice.Equals(3))
                    {
                        Console.WriteLine("4 Press");
                        Console.Clear();
                        System.Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Choice invaild, Try Again");
                        Console.Write("\nEnter Your Choice : ");
                        input = Console.ReadLine();
                    }
                    }
                    else
                    {
                        Console.WriteLine("Choice invaild, Try Again");
                        Console.Write("\nEnter Your Choice : ");
                        input = Console.ReadLine();
                    }

                }






                Console.ReadKey();

                    }
                }
            }
        
    










































