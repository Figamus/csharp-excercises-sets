using System;
using System.Collections.Generic;

namespace dictionaries {
    class Program {
        static void Main (string[] args) {
            // Create an empty HashSet named Showroom that will contain strings
            HashSet<string> Showroom = new HashSet<string> ();

            // Add four of your favorite car model names to the set.
            Showroom.Add ("F-150");
            Showroom.Add ("Mustang");
            Showroom.Add ("Altima");
            Showroom.Add ("GTR");

            // Print to the console how many cars are in your show room.
            foreach (string car in Showroom)
            {
                Console.WriteLine($"There is a(n) {car} is in the showroom");
            }

            // Pick one of the items in your show room and add it to the set again.
            Showroom.Add ("GTR");

            Console.WriteLine("");
            
            // Print your showroom again, and notice how there's still only one representation of that model in there.
            foreach (string car in Showroom)
            {
                Console.WriteLine($"There is still only a(n) {car} is in the showroom");
            }

            Console.WriteLine("");

            // Create another set named UsedLot and add two more car model strings to it.
            HashSet<string> UsedLot = new HashSet<string> ();
            Showroom.Add ("Trans-Am");
            Showroom.Add ("350Z");

            // Use the UnionWith() method on Showroom to add in the two models you added to UsedLot.
            Showroom.UnionWith (UsedLot);
            foreach (string car in Showroom)
            {
                Console.WriteLine($"Both Lots have a(n) {car}");
            }

            Console.WriteLine("");

            // You've sold one of your cars. Remove it from the set with the Remove() method.
            Showroom.Remove ("350Z");
            foreach (string car in Showroom)
            {
                Console.WriteLine($"There is only {car} after selling the 350Z");
            }

            Console.WriteLine("");
            // Now create another HashSet of cars in a variable Junkyard. Someone who owns a junkyard full of old cars has approached you about buying the entire inventory. In the new set, add some different cars, but also add a few that are the same as in the Showroom set.
            HashSet<string> Junkyard = new HashSet<string> ();
            Junkyard.Add ("F-150");
            Junkyard.Add ("Camry");
            Junkyard.Add ("Altima");
            Junkyard.Add ("GTO");

            Console.WriteLine("");
            // Create a new HashSet of your show room with HashSet<string> clone = new HashSet<string>(Showroom);
            HashSet<string> clone = new HashSet<string> (Showroom);

            // Use the IntersectWith() method on the clone to see which cars exist in both the show room and the junkyard.
            clone.IntersectWith (Junkyard);
            foreach (string car in clone)
            {
                Console.WriteLine ($"{car} Exists in both");
            }

            Console.WriteLine("");
            // Now you're ready to buy the cars in the junkyard. Use the UnionWith() method to combine the junkyard into your showroom.
            Showroom.UnionWith (Junkyard);

            // Use the Remove() method to remove any cars that you acquired from the junkyard that you don't want in your showroom.
            Showroom.Remove ("Camry");
            foreach (string car in Showroom) {
                Console.WriteLine ($"There is a {car} left");
            }
        }
    }
}