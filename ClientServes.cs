using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class ClientServes
    {


        public int Gestid { get; set; }
        public string GesName { get; set; }
        public string Gesphone{ get; set; }
        public string Gesgender { get; set; }
        public string Gesdatein { get; set; }
        public string Gesthourin { get; set; }
        public string Gesdateout { get; set; }
        public string Gesthourout { get; set; }
        public ClientServes()
        {

        }
        public ClientServes(int _id,string _name,string _phone,string _gender,string _datein ,string _hourin, string _dateout,string _hourout)
        {
            this.Gestid = _id;
            this.GesName = _name;
            this.Gesphone = _phone;
            this.Gesgender = _gender;
            this.Gesthourin = _hourin;
            this.Gesdatein = _datein;
            this.Gesthourout = _hourout;

            this.Gesdateout = _dateout;
        }

        public void ListAllGest()
        {
            Console.WriteLine("\n\t" + Gestid + "\t" + GesName + "\t" + Gesphone + "\t" + "\t" + Gesgender + "\t" + Gesdatein + "\t" + Gesthourin + "\t\t"  +Gesdateout + "\t" + Gesthourout + "\t");
        }


        public static List<ClientServes> Add_Gest(List<ClientServes> gestresev, ClientServes ges)
        {
            gestresev.Add(ges);
            return gestresev;
        }
    }
}
