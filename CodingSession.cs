using System;
using System.Collections.Generic;

namespace coding_tracker
{
    class CodingSession
    {
        public int Id;
        public string Duration;
        public string Date;
        public string StartTime;
        public string EndTime;

        public CodingSession()
        {
            Console.WriteLine("\n");

            // get date from user
            Console.WriteLine("enter the date as 'YYYY/MM/DD'");
            string date = Console.ReadLine();

            // validate date input is in correct format
            while (date.Length != 10)
            {
                Console.WriteLine("Input is not in a valid format. Date must be 'YYYY/MM/DD'.");
                date = Console.ReadLine();
            }

            Console.WriteLine(".");
            Console.WriteLine(".");

            // get start time input from user
            Console.WriteLine("enter the start time in 24hr format as 'HH:MM:SS'");
            StartTime = Console.ReadLine();

            // validate user input
            while(StartTime.Length != 8)
            {
                Console.WriteLine("Input is not in a valid format. Time must be 'HH:MM:SS'.");
                StartTime = Console.ReadLine();
            }

            // get end time input from user
            Console.WriteLine("enter the start time in 24hr format as 'HH:MM:SS'");
            EndTime = Console.ReadLine();

            // validate user end time input
            while (EndTime.Length != 8)
            {
                Console.WriteLine("Input is not in a valid format. Time must be 'HH:MM:SS'.");
                EndTime = Console.ReadLine();
            }

            string[] dateArr = date.Split("/");
            string[] StartTimeArr = StartTime.Split(":");

            DateTime inputDate = new(int.Parse(dateArr[0]), int.Parse(dateArr[1]), int.Parse(dateArr[2]),
                                     int.Parse(StartTimeArr[0]), int.Parse(StartTimeArr[1]), int.Parse(StartTimeArr[2]));
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(inputDate.ToString());
        }

        private void DurationCalculator()
        {

        }
    }
}
