using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAttributes
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public class YearOfBirthAttribute : Attribute
    {
        public int YearOfBirth(int idade)
        {
            return (System.DateTime.Today.Year - idade); 
        }
    }
}
