using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20 08 13 Practice"); // method message

            // define an instance of the Developer class 
            Developer dev1 = new Developer(Specialty.fontend, "Omega");
            // call Developer class methods on instace
            dev1.DisplayProps(); // output props
            dev1.AddTasks(); // add and display tasks
            
            // define an instance of th SeniorDeveloper class - derived from Developer class
            SeniorDeveloper senDev1 = new SeniorDeveloper(Specialty.backend, "Alpha", false);
            // call Developer and Senior Developer Class methods on instance- derived from developer class
            senDev1.DisplayProps(); // output props
            senDev1.UpdateSprint(); // update and display if dev has reviewed sprint
            senDev1.AddTasks(); // add and display tasks
        }
    }
}
