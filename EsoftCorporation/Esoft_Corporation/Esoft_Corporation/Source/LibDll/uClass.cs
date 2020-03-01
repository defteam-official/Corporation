using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esoft_Corporation.Source.LibDll.ElementLib;

namespace Esoft_Corporation.Source.LibDll
{
    class uClass
    {
        #region -- Structure --

        private string _email;
        private string _password;
        private string _rule;
        private string _name;
        private string _surname;
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Rule
        {
            get { return _rule; }
            set { _rule = value; }
        }
        #endregion

        #region -- Functional --



        #endregion

        
    }
}
