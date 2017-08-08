using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAttributes
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public class UppercaseAttribute : Attribute
    {
        public string Nome { get; set; }

        public UppercaseAttribute() : base()
        {
            Console.WriteLine("UppercaseAttribute()");
        }
        public string Uppercase()
        {
            if (string.IsNullOrEmpty(Nome) == false)
            {
                return Nome.ToUpper();
            }
            else { return null; }
        }
    }
}

