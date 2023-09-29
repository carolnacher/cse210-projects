using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

       Job job1 = new Job();
       job1._jobTitle =  "Software Engineer";
       job1._company = "Microsoft";
       job1._startYear = 2010;
       job1._endYear = 2017;

       
       
       Job job2 = new Job();
       job2._jobTitle= "Manager" ;
       job2._company = "Apple";
       job2._startYear = 2014;
       job2._endYear = 2022;
       

       Resume myResume = new Resume();

       myResume._name = "Alison Rose";
       myResume._JobsList.Add(job1);
       myResume._JobsList.Add(job2);
    
    
       Console.WriteLine("Hello Learning02 World!");

       myResume.Display();

       


       

        
       
       }
}