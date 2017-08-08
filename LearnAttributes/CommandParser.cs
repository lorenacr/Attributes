using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace LearnAttributes
{
    public static class CommandParser
    {
        public static object Parse(object command)
        {
            IEnumerable<PropertyInfo> properties = command.GetType().GetProperties();

            if (properties.Any(p => p.HasAttribute(typeof(UppercaseAttribute))))
            {
                PropertyInfo property = properties.FirstOrDefault(p => p.HasAttribute(typeof(UppercaseAttribute)));
                string capitalized = Capitalize(property.GetValue(command, null));
                property.SetValue(command, capitalized);
            }

            if (properties.Any(p => p.HasAttribute(typeof(YearOfBirthAttribute))))
            {
                PropertyInfo property = properties.FirstOrDefault(p => p.HasAttribute(typeof(YearOfBirthAttribute)));
                int yearOfBirth = AgeToYearOfBirth(property.GetValue(command, null));
                property.SetValue(command, yearOfBirth);
            }

            return command;
        }

        private static string Capitalize(object name)
        {
           return name.ToString().ToUpper();           
        }

        private static int AgeToYearOfBirth(object age)
        {
            return (System.DateTime.Today.Year - Convert.ToInt16(age));
        }
    }
}
