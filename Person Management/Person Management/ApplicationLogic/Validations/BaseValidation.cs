using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Management.ApplicationLogic.Validations
{
    class BaseValidation
    {

        public static bool IsLength(string text,int length)
        {
            if (text.Length==length)
            {
                return true;
            }
            return false;
        }

        public static bool IsContainsNumbers(string text)
        {
            foreach (char letter in text)
            {
                if (char.IsDigit(letter))
                {
                    return true;
                }
            }
            return false;
        }


        public static bool IsLetterExist(string text,char targetLetter)
        {
            foreach (char letter in text)
            {
                if (letter==targetLetter)
                {
                    return true;
                }
            }
            return false;
        }


    }
}
