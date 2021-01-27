using System;
using System.Collections.Generic;
using System.Text;

namespace GamingPlatform
{
    class GamerManager : IGamerService
    {
        IUserValidation userValidation;

        public GamerManager(IUserValidation userValidation)
        {
            this.userValidation = userValidation;
        }

        public void Add(Gamer gamer)
        {
            if (userValidation.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt olundu.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız oldu.");
            }
        }

        public void Delete(Gamer gamer)
        {

            Console.WriteLine("Kayıt silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }
    }
}
