using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uhler.Common.Helpers
{
    public static class VikingsHelper
    {
        public static Dictionary<int, string> Vikings
         {
           get
              {
                    Dictionary<int, string> vikings = new Dictionary<int, string>();

                vikings.Add(3, "Blair Walsh");
                vikings.Add(5, "Teddy Bridgewater");
                vikings.Add(6, "Taylor Heinicke");
                vikings.Add(8, "Sam Bradford");
                vikings.Add(11, "Laquon Treadwell");
                vikings.Add(14, "Stefon Diggs");
                vikings.Add(28, "Adrian Peterson");
                vikings.Add(33, "Ronnie Hillman");
                vikings.Add(21, "Jerick MchKinnon");
                vikings.Add(13, "Shaun Hill");
                vikings.Add(72, "Jake Long");
                vikings.Add(29, "Xavier Rhodes");
                vikings.Add(82, "Kyle Rudolph");
                vikings.Add(22, "Harrison Smith");
                vikings.Add(76, "Alex Boone");
                vikings.Add(84, "Cordarrelle Patterson");
                vikings.Add(44, "Matt Asiata");
                vikings.Add(20, "Mackensie Alexander");
                vikings.Add(26, "Trae Waynes");
                vikings.Add(19, "Adam Thielen");
                vikings.Add(23, "Terence Newman");
                vikings.Add(55, "Anthony Barr");
                vikings.Add(99, "Danielle Hunter");
                vikings.Add(52, "Chad Greenway");
                vikings.Add(73, "Sharrif Floyd");
                vikings.Add(98, "Linval Joseph");
                vikings.Add(24, "Captain Munnerlyn");
                vikings.Add(27, "Jayron Kearse");
                vikings.Add(35, "Marcus Sherels");
                vikings.Add(17, "Jarius Wright");
                vikings.Add(34, "Andrew Sendejo");
                vikings.Add(71, "Andre Smith");
                vikings.Add(96, "Brian Robinson");
                vikings.Add(32, "Antone Exum");
                vikings.Add(40, "Kentrell Brothers");
                vikings.Add(48, "Zach Line");
                vikings.Add(63, "Brandon Fusco");
                vikings.Add(61, "Joe Berger");
                vikings.Add(64, "Willie Beavers");
                vikings.Add(68, "T.J. Clemmings");
                vikings.Add(41, "Anthony Harris");
                vikings.Add(57, "Audie Cole");
                vikings.Add(83, "MyCole Pruitt");
                vikings.Add(85, "Rhett Ellison");
                vikings.Add(59, "Emmanuel Lamur");
                vikings.Add(79, "Mike Harris");
                vikings.Add(78, "Jeremiah Sirles");

                return vikings;
            }
            
           }

        public static string GetVikingName(int playerNumber)
        {

            if (Vikings.ContainsKey(playerNumber))
                return Vikings[playerNumber];
            else
                return "N/A";
        }
    }
}
