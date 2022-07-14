using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Management.ApplicationLogic.Validations
{
    class UserValidations : BaseValidation
    {
        public static bool IsValidations(string fin ,string email)
        {
            return IsFin(fin) & IsEmail(email);
        }


        public static bool IsFin(string fin)
        {
            return IsLength(fin, 7) && IsContainsNumbers(fin);
        }

        public static bool IsEmail(string email)
        {
            return IsLetterExist(email, '@');
        }

    }
}
