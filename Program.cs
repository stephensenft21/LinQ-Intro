using System;
using System.Collections.Generic;
using System.Linq;
using LinqIntro;

namespace LingIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {

                10,
                11,
                34,
                99,
                45,
                15,
                56,
                72,
                91
            };
            // Where (like filter in javascript)
            List<int> numbersAbove50 = numbers.Where(num =>
            {
                return num > 50;

            }).ToList();

            List<int> evenNumbers = numbers.Where(num =>
            {

                bool isEven = num % 2 == 0;

                return isEven;

            }).ToList();

            //Where using a single line functions returns the same outputs as the above statement

            List<int> numbersLessThan50 = numbers.Where(num => num < 50).ToList();

            List<string> messages = numbers.Select(num =>

                {
                    return $"The number is {num}";

                }).ToList();
            City nashville = new City()
            {
                Name = "Nashville"
            };

            nashville.Buildings.Add(new Building()
            {
                Name = "NSS Building",
                    Stories = 5,
                    Address = "301 Plus Park Blvd"
            });

            nashville.Buildings.Add(new Building()
            {
                Name = "TPAC",
                    Stories = 23,
                    Address = "505 Deaderick Street"
            });

            nashville.Buildings.Add(new Building()
            {
                Name = "1505",
                    Stories = 6,
                    Address = "1505 Demonbreun Street"
            });

            nashville.Buildings.Add(new Building()
            {
                Name = "The Frist",
                    Stories = 3,
                    Address = "919 Broadway"
            });

            nashville.Buildings.Add(new Building()
            {
                Name = "The Batman Building",
                    Stories = 33,
                    Address = "333 Commerce Street"
            });
            List<Building> Shortbuildings = nashville.Buildings.Where(Building =>
            {

                bool isShort = Building.Stories < 10;
                return isShort;

            }).ToList();
                 
                 List<string> nashvilleAddresses = nashville.Buildings.Select(Building =>Building.Address).ToList();
                 
                 int sum = numbers.Sum();
                 
                double average = numbers.Average();
                  numbers.Sort();
List<Building> orderedByStories = nashville.Buildings 
           .OrderBy(Building => Building.Stories)
           .ToList();



           //Chain Linq methods 
           double averageHeight = nashville.Buildings
           .Select(building => building.Stories)
           .Average();

                


        }

    }
}