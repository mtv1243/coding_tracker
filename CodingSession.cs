using System;
using System.Collections.Generic;

namespace coding_tracker
{
    class CodingSession
    {
        public int Id;
        public string StartDate;
        public string EndDate;
        public string StartTime;
        public string EndTime;

        public DateTime Start;
        public DateTime End;
        public TimeSpan Duration;

        public CodingSession()
        {
            Console.WriteLine("\n");

            // get date from user
            Console.WriteLine("enter the start date as 'YYYY/MM/DD'");
            StartDate = Console.ReadLine();

            // validate date input is in correct format
            while (StartDate.Length != 10)
            {
                Console.WriteLine("Input is not in a valid format. Date must be 'YYYY/MM/DD'.");
                StartDate = Console.ReadLine();
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

            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");

            // get end date from user
            Console.WriteLine("enter the end date as 'YYYY/MM/DD'");
            EndDate = Console.ReadLine();

            // validate end date input is in correct format
            while (StartDate.Length != 10)
            {
                Console.WriteLine("Input is not in a valid format. Date must be 'YYYY/MM/DD'.");
                EndDate = Console.ReadLine();
            }

            Console.WriteLine(".");
            Console.WriteLine(".");

            // get end time input from user
            Console.WriteLine("enter the start time in 24hr format as 'HH:MM:SS'");
            EndTime = Console.ReadLine();

            // validate user end time input
            while (EndTime.Length != 8)
            {
                Console.WriteLine("Input is not in a valid format. Time must be 'HH:MM:SS'.");
                EndTime = Console.ReadLine();
            }

            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");

            // create DateTime object
            string[] startDateArr = StartDate.Split("/");
            string[] StartTimeArr = StartTime.Split(":");
            

            Start = new DateTime(int.Parse(startDateArr[0]), int.Parse(startDateArr[1]), int.Parse(startDateArr[2]),
                                 int.Parse(StartTimeArr[0]), int.Parse(StartTimeArr[1]), int.Parse(StartTimeArr[2])
                                 );

            // create End Datetime oject
            string[] endDateArr = EndDate.Split("/");
            string[] endTimeArr = EndTime.Split(":");

            End = new DateTime(int.Parse(endDateArr[0]), int.Parse(endDateArr[1]), int.Parse(endDateArr[2]),
                               int.Parse(endTimeArr[0]), int.Parse(endTimeArr[1]), int.Parse(endTimeArr[2])
                               );

            Duration = End - Start; ;

        }
    }
}
