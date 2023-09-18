using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._company = "Google";
        job1._startYear = 2009;
        job1._endYear = 2019;

        Job job2 = new Job();
        job2._jobTitle = "Senior Software Developer";
        job2._company = "Microsoft";
        job2._startYear = 2020;
        job2._endYear = 2022;

        Resume resume1 = new Resume();
        resume1._name = "Michael Fink";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        
        resume1.Display();
    }
}