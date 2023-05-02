using System;

public class Job {

    /*---Members---*/
    /*---Members---*/
    /*---Members---*/
    public string _jobTitle, _company;
    public int _startYear, _endYear;

     /*---Methods---*/
    /*---Methods---*/
    /*---Methods---*/
    public void Display(){
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}