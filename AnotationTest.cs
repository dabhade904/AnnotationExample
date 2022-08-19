using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataAnotation
{
    public class AnotationTest
    {
        public static void Display()
        {
            Console.WriteLine("Employee class validation");
            Console.WriteLine("------------------------");

            Employer emp = new Employer();
            emp.Name = "Sa";
            emp.Age = 17;
            emp.PhoneNumber = "8888948943";
            emp.Email = "dabhade904@gmail.com";

            ValidationContext context = new ValidationContext(emp, null, null);
            List<ValidationResult> result = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(emp, context, result, true);
            if (!valid)
            {
                foreach(ValidationResult totalRes in result)
                {
                    Console.WriteLine("Member Name :{0}", totalRes.MemberNames.First(), Environment.NewLine);
                    Console.WriteLine("Error Msg :: {0}{1}", totalRes.ErrorMessage, Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Name : " + emp.Name);
                Console.WriteLine("Name : " + emp.Age);
                Console.WriteLine("Name : " + emp.PhoneNumber);
                Console.WriteLine("Name : " + emp.Email);
            }
        }
    }
}
