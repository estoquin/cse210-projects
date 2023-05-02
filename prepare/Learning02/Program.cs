using System;

class Program
{
    static void Main(string[] args)
    {
        // Job 1
        Job job1 = new Job();
        job1._jobTitle = "Salesforce Developer";
        job1._company = "Cambalache Technologies";
        job1._startYear = 2019;
        job1._endYear = 2021;
        // job1.Display();

        // Job 2
        Job job2 = new Job();
        job2._jobTitle = "Software Developer";
        job2._company = "Zimmic";
        job2._startYear = 2021;
        job2._endYear = 2023;
        // job2.Display();

        // Resume
        Resume myResume = new Resume();
        myResume._name = "Nicolas Estoquin";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
}