using System;

namespace GamingPlatform
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());

            gamerManager.Add(new Gamer {Id=1, BirthYear=1996,FirstName="Talha",LastName="Gedik",IdentityNumber=12345});
        }
    }
}
