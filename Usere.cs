using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shool2
{
    class Usere
    {

        public string name;
        public string sur;
        public string year;
        public string month;
        public string day;
        public string pasword;
        public string studentid;
        public Usere()
        {

        }
        public Usere(string name, string sur, string year, string month, string day, string pasword,string studentid)
        {
            this.name = name;
            this.sur = sur;
            this.year = year;
            this.month = month;
            this.day = day;
            this.pasword = pasword;
            this.studentid = studentid;
        }
        //hi world


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
        public string Year
        {
            get { return year; }
            set { year = value; }
        }
        public string Month
        {
            get { return month; }
            set { month = value; }
        }
        public string Day
        {
            get { return day; }
            set { day = value; }
        }
        public string Pasword
        {
            get { return pasword; }
            set { pasword = value; }
        }

    }
}
