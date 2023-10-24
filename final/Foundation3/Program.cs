using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();
        Address lectureAddress = new Address("1111 NotARealPlace St", "Cleveland", "TN", "USA");
        events.Add(new Lecture("Talk About Planes", "Lecture", "A talk about planes and how they relate to the gospel", "10/21/2024", "7:00 PM", lectureAddress, "Dieter F. Uchtdorf", 600));
        Address receptionAddress = new Address("4544 AFakeLocation Rd", "Benton", "TN", "USA");
        events.Add(new Reception("Blair Wedding Reception", "Reception", "A celebration of Cindy and Pierre's marriage", "6/11/2024", "11:00 AM", receptionAddress, "afakeemailaddress@gmail.com"));
        Address outdoorGatheringAddress = new Address("5885 IAmMakingThisUpAsIGo Blvd", "Turtle Town", "TN", "USA");
        events.Add(new OutdoorGathering("Community Hike", "Outdoor Activity", "A chance to see the outdoors while networking with those in your community", "9/2/2024", "8:30 AM", outdoorGatheringAddress, "partly cloudy"));

        foreach (Event _event in events)
        {
            _event.DisplayMarketingMessage();
            Console.WriteLine("--------------------------------------");
        }
    }
}