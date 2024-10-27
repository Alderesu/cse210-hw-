using System;
using System.Collections.Generic;

namespace ExerciseTrackingProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>
            {
                new Running(new DateTime(2022, 11, 3), 30, 3.0), // This remains in miles for running
                new Cycling(new DateTime(2022, 11, 4), 45, 15.0), // Speed in mph but will calculate distance in km
                new Swimming(new DateTime(2022, 11, 5), 30, 20) // 20 laps in the swimming pool
            };

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}