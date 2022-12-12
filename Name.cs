using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_a_Name_Class
{
    public class Name
    {
        private string _title;
        private string _firstName;
        private string _lastName;

        public Name(string title, string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            _title = title; 
        }

        public Name(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            _title = "";
        }

        public string FirstName 
        {  
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Initials
        {
            get { return _firstName.Substring(0, 1) + _lastName.Substring(0, 1); }
        }

        public string UserName
        {
            get
            {
                return _firstName.Substring(0, 3) + _lastName.Substring(0, 3);
            }
        }

        public override string ToString() { 
            return (_title + " " + _firstName + " " + _lastName).Trim(); 
        }

    }
}

