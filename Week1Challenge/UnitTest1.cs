using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week1Challenge
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NameAndAge()
        {
            string firtName = "Cody";
            string lastName = "Morton";
            int age = 34;
            Console.WriteLine(age + 7);
            Console.WriteLine(age - 7);
            Console.WriteLine(age * 7);
            Console.WriteLine(age / 7);
            Console.WriteLine(age % 7);

        }
        [TestMethod]
        public void Array()
        {
            string[] Movie1 = { "Blow", "House of 1000 corpses", "Anchorman", "Wolfe of Wall Street" };
        }

        [TestMethod]
        public void ListOfDates()
        {
            List<DateTime> listOfDates = new List<DateTime>();
            DateTime today = DateTime.Today;
            listOfDates.Add(today);
            listOfDates.Add(new DateTime(2020 / 12 / 25));
            listOfDates.Add(new DateTime(2020, 3, 12));
            listOfDates.Add(new DateTime(2020, 6, 16));
        }
        [TestMethod]
        public void HowMuchSleepDidYouGet()

        {
            Console.WriteLine("How many hours of sleep did you get?");
            int hours = 4;
            if (hours >= 10)
            {

                Console.WriteLine("wow thats alot of sleep");
            }
            else if (hours >= 8 && hours < 10)
            {
                Console.WriteLine("You should be well rested");
            }

            else if (hours > 4 && hours < 8)
            {
                Console.WriteLine("bummer");
            }
            else
            {
                Console.WriteLine("oh man get some sleep");
            }
            {
                Console.WriteLine();
                    }

            }
        
    [TestMethod]
    public void HowHasYourDayBeen()
    {
        string userDay = "Okay";
        switch (userDay)
        {
            case "Great":
                Console.WriteLine("Congrats on your good day");
                break;
            case "Good":
                Console.WriteLine("it is a good day");
                   break;
            case "Okay":
                Console.WriteLine("Hopefully it will get better from here");
                break;
            case "Bad":
                Console.WriteLine("There is always tomorrow");
                break;
            case ":(":
                Console.WriteLine("I guess this is us now"); 
                break;
            default:
                Console.WriteLine("Please enter answer above");
                break;
            } 
          }

    [TestMethod]
    public void Supercalifragilisticexpialidocious()
    {
        string name = "Supercalifragilisticexpialidocious";
        foreach (char letter in name)

        {
            if (letter == 'i')
            {
                Console.WriteLine(letter);
            }
        else
        { 
        Console.WriteLine("Not an i");
    }

                }
            }
        }
    }
