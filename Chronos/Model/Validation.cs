using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chronos.Model
{
    public class Validation
    {

        public string validateAlphaString()
        {
            return "ok";
        }

        /**
         * Valida se o email é valido.
         * @return      bool
         */
        public static bool ValidateEmail(string email)
        {
            bool validEmail = false;
            int indexArr = email.IndexOf('@');
            if (indexArr > 0)
            {
                int indexDot = email.IndexOf('.', indexArr);
                if (indexDot - 1 > indexArr)
                {
                    if (indexDot + 1 < email.Length)
                    {
                        string indexDot2 = email.Substring(indexDot + 1, 1);
                        if (indexDot2 != ".")
                        {
                            validEmail = true;
                        }
                    }
                }
            }
            return validEmail;
        }

    }
}