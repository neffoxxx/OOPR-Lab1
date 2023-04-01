using System;
using System.Collections.Generic;

namespace Labor1
{
   public class Trains
    {
        public string TrainNumber { get; set; }
        public string DestinationStation { get; set; }
        public DateTime DepartureTime { get; set; }
        public TimeSpan TravelTime { get; set; }
        public Trains(string trainNumber, string destinationStation, DateTime departureTime, TimeSpan travelTime)
        {
            TrainNumber = trainNumber;
            DestinationStation = destinationStation;
            DepartureTime = departureTime;
            TravelTime = travelTime;
        }

        public Trains(string text1, string text2, Func<string> toString, string text3)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.toString = toString;
            this.text3 = text3;
        }

        List<Trains> trains = new List<Trains>();
        private string text1;
        private string text2;
        private Func<string> toString;
        private string text3;
    }
}
