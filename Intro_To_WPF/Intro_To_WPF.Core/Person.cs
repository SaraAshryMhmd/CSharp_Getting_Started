using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_To_WPF.Core
{
    public class Person
    {
        public string Name { get; set; }

        private string _firstName;

        public string GetFirstName()
        {
            return _firstName;
        }

        public void SetFirstName(string firstName)
        {
            _firstName = firstName;
        }
    }
}
