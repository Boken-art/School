using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shool2
{
    class User
    {

        public string name;
        public string sur;
        public string date;
        public string pasword;
        public string studentid;
        public User()
        {

        }
        public User(string name, string sur,string date, string pasword,string studentid)
        {
            this.name = name;
            this.sur = sur;
            this.date = date;
            this.pasword = pasword;
            this.studentid = studentid;
        }
        //hi world
        public string Date
        {
            get => date;
            set => date = value;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Sur
        {
            get { return sur; }
            set { sur = value; }
        }
       
        public string Pasword
        {
            get { return pasword; }
            set { pasword = value; }
        }
        public string Studentid
        {
            get { return studentid; }
         
        }

    }
}
