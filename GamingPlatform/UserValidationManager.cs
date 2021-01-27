﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GamingPlatform
{
    class UserValidationManager:IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1996 && gamer.FirstName == "Talha" && gamer.LastName == "Gedik" && gamer.IdentityNumber == 12345)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
