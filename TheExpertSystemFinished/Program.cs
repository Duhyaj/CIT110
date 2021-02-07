using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheExpertSystem
{
    class Program
    {
        public static string userResponse { get; private set; }

        static void Main(string[] args)

        {
            // ****************************************
            // *  The Expert System                   *
            // *  James (Jay) Hudson                  *
            // *  Converse and give how old a user is *
            // *  in multiple formats.                *
            // *  2/3/2021                            *
            // ****************************************

            string userName;
            string userReponse;
            string bornYear;
            string bornMonth;
            string bornDay;
            DateTime today;
            DateTime Birthday;

            //
            // Math Declarations
            //

            double userSec;
            double userMin;
            double userHour;
            double userDay;
            double userWeek;
            double userMonth;
            double userYear;
            bool userAlien = true;

            //
            // Console Construction and design
            //

            Console.CursorVisible = true;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetWindowSize(92, 40);
            Console.Beep();
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\t\tHOW LONG YOU HAVE BEEN AN EARTHLING!");
            Console.WriteLine();
            Console.WriteLine("\tPress any key to continue");
            Console.ReadKey();
            Console.Clear();


            today = DateTime.UtcNow;
            Console.WriteLine(value: $"Hello Today is {DateTime.Now}.");
            Console.WriteLine();
            Console.WriteLine("My name is Jay Hudson");
            Console.WriteLine();
            Console.WriteLine("What is your name?");
            Console.WriteLine();
            userName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Greetings Earthling {userName}, Would you like to know how long you have dwelt on Planet Earth?");
            Console.WriteLine();
            userResponse = Console.ReadLine();
            if (userResponse == "yes"
                || userResponse == "Yes")
            {
                //
                // User Input Screen
                //

                Console.CursorVisible = true;
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Clear();
                Console.WriteLine("\n\t\tThe Age Equation");
                Console.WriteLine();
                Console.WriteLine("We will need to collect some data to give you that information.");
                Console.WriteLine();
                Console.WriteLine("What is the year you first inhabited this Planet?");
                Console.WriteLine();
                bornYear = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine($"What is the Month of that year {userName}");
                Console.WriteLine();
                bornMonth = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("What is the day of that month?");
                Console.WriteLine();
                bornDay = Console.ReadLine();
                Console.WriteLine();
                DateTime userBirthday = DateTime.Parse($"{ bornMonth},{ bornDay},{bornYear}");
                Console.WriteLine();
                Console.WriteLine($"So {userName}, your first day on the planet was {userBirthday.ToShortDateString()}");
                Console.WriteLine();
                Console.WriteLine("Press any button to see your data!");
                Console.Read();
                Console.Clear();

                //
                // Results page
                //

                TimeSpan userAge = DateTime.Now.Subtract(userBirthday);

                //
                // Years on Earth
                //

                Console.WriteLine("Your Time on Planet Earth in years is...");
                userYear = Math.Round(userAge.TotalDays / 365.25, 2);
                Console.WriteLine();
                Console.WriteLine($"{userYear} Years");
                Console.WriteLine();
                Console.WriteLine($"That is a Lot of Years {userName}!");
                Console.WriteLine();
                Console.WriteLine("Press any button to continue");
                Console.ReadKey();
                Console.Clear();

                //
                // Months on Earth
                //

                userMonth = Math.Round(userAge.TotalDays / 30, 2);
                Console.WriteLine();
                Console.WriteLine($"{userMonth} Months!");
                Console.WriteLine();
                Console.WriteLine($"Man Earthling {userName}, That really is a long time!");
                Console.WriteLine();
                Console.WriteLine("Press any button to continue");
                Console.ReadKey();
                Console.Clear();

                //
                // Weeks on Earth
                //

                userWeek = Math.Round(userAge.TotalDays / 7, 2);
                Console.WriteLine();
                Console.WriteLine($"{userWeek} Weeks!");
                Console.WriteLine();
                Console.WriteLine($"Is it really THAT MANY WEEKS, {userName},?!");
                Console.WriteLine();
                Console.WriteLine("Press any button to continue");
                Console.ReadKey();
                Console.Clear();

                //
                // Days on Earth
                //

                userDay = Math.Round(userAge.TotalDays, 2);
                Console.WriteLine();
                Console.WriteLine($"{userDay} Days!");
                Console.WriteLine();
                Console.WriteLine($"{userName}, That many days must really be taking a toll on your body!");
                Console.WriteLine();
                Console.WriteLine("Press any button to continue");
                Console.ReadKey();
                Console.Clear();

                //
                // Hours on Earth
                //

                userHour = Math.Round(userAge.TotalHours, 2);
                Console.WriteLine();
                Console.WriteLine($"{userHour} Hours!");
                Console.WriteLine();
                Console.WriteLine($"I Didn't know an Earthling could live that many hours, {userName}");
                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();

                //
                // Minutes on Earth
                //

                userMin = Math.Round(userAge.TotalMinutes, 2);
                Console.WriteLine();
                Console.WriteLine($"{userMin} Minutes!");
                Console.WriteLine();
                Console.WriteLine($"WOW! How may Minutes can one Earthling live {userName}?");
                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();

                //
                // seconds on Earth
                //

                userSec = Math.Round(userAge.TotalSeconds, 2);
                Console.WriteLine($"{userSec} Seconds!");
                Console.WriteLine();
                Console.WriteLine($"I just can't believe there are that many Seconds in a lifetime {userName}!");
                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();

                //
                // Make a chart
                //

                //
                // Headers
                //

                Console.Clear();
                Console.CursorVisible = false;

                Console.WriteLine();
                Console.WriteLine(
                    "YEARS".PadLeft(9) +
                    "MONTHS".PadLeft(9) +
                    "WEEKS".PadLeft(9) +
                    "DAYS".PadLeft(11) +
                    "HOURS".PadLeft(11) +
                    "MINUTES".PadLeft(13) +
                    "SECONDS".PadLeft(15)
                    );
                Console.WriteLine(
                    "-----".PadLeft(9) +
                    "------".PadLeft(9) +
                    "-------".PadLeft(9) +
                    "--------".PadLeft(11) +
                    "---------".PadLeft(11) +
                    "-----------".PadLeft(13) +
                    "-------------".PadLeft(15)
                    );
                Console.WriteLine(
                    $"{userYear,2}".PadLeft(9) +
                    $"{userMonth,2}".PadLeft(9) +
                    $"{userWeek,2}".PadLeft(9) +
                    $"{userDay,2}".PadLeft(11) +
                    $"{userHour,2}".PadLeft(11) +
                    $"{userMin,2}".PadLeft(13) +
                    $"{userSec,2}".PadLeft(15)
                    );

                Console.WriteLine();
                Console.WriteLine($"I hope you enjoyed learning all of this information? {userName}");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();

                Console.Clear();
                Console.CursorVisible = true;
                Console.WriteLine($"{userName},do you think I am a Human or Alien?");
                Console.WriteLine();
                Console.ReadLine();
                while (userAlien)
                {
                    string userAlien1 = (Console.ReadLine());
                    if (userAlien1 == "alien" || userAlien1 == "Alien")
                    {

                        userAlien = false;

                    }

                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("I can't believe you don't think Aliens are real!");
                        Console.WriteLine();

                    }
                }

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($"Thanks for Talking to me Earthling {userName}!");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue"!);
                Console.ReadKey();
            }


            else
            {
                Console.CursorVisible = true;
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("I guess you will have to learn how Long you have been an Earthling some other time.");
            }





        }
    }
}

