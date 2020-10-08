using System;
using System.Linq;

namespace PasswordValidatorMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            PasswordValidate(Console.ReadLine());
        }  
        
        static void PasswordValidate(string n1)
        {
            string Validation = CheckLength(n1);

            if (Validation != null)
            {
                Console.WriteLine(Validation);
            }

            string ValidationTwo = ValidateContainsOnlyDigitAndLetters(n1);

            if(ValidationTwo != null)
            {
                Console.WriteLine(ValidationTwo);
            }

            string ValidationThree = ValidateHasLeastTwoDigits(n1);

            if(ValidationThree != null)
            {
                Console.WriteLine(ValidationThree);
            }

            if(Validation == null && ValidationTwo == null && Validation == null)
            {
                Console.WriteLine("Password is valid");
            }
        }
        
        static string CheckLength(string n1)
        {
            string res = " ";
            if(n1.Length < 6 || n1.Length > 10)
            {
                res = "Password must be between 6 and 10 characters";
            }
            return res;
        }

        static string ValidateContainsOnlyDigitAndLetters(string n1)
        {
            string res = " ";
            for (int i = 0; i < n1.Length; i++)
            {
                if(!char.IsLetterOrDigit(n1[i]))
                {
                    res = "Password must consist only of letters and digits";
                    break;
                }
                
            }
            return res;
        }
        
        static string ValidateHasLeastTwoDigits(string n1)
        {
            int counter = 0;
            string res = "Password must have at least two digits";
            foreach  (char c in n1)
            {
                if(char.IsDigit(c))
                {
                    counter++;
                }

                if(counter == 2)
                {
                    break;
                }
            }

            return res;
        }

        
    }
}
