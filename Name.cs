using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_a_Name_Class
{
    public class Name
    {
        private string _firstName;
        private string _lastName;
        private string _title;

        public Name(string firstName, string lastName, string title)
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
    }
}

