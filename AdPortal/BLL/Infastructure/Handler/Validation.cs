using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Infastructure.Handler
{
    public class Validation
    {
        public static bool Validate(string value, string salt, string hash)
           => Hash.Create(value, salt) == hash;
    }
}
