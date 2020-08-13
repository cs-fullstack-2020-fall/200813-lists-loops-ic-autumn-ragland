using System;
using System.Collections.Generic; // required for List

class Developer
{
    protected Specialty specialty; // enum type
    protected string teamName;
    protected List<string> tasks = new List<string>(); // empty list
    // constructor
    public Developer(Specialty specialty, string teamName)
    {   
        this.specialty = specialty;
        this.teamName = teamName;
    }
    // display the developer's specialty, team name, and number of tasks
    public void DisplayProps()
    {
        Console.WriteLine($"Specialty : {this.specialty}\nTeam Name : {this.teamName}\nNumber of Tasks : {this.tasks.Count}");
    }
    // allow the user to add multiple tasks to a developer's list of tasks until they input 'done' then display the number of tasks total and all tasks in the task list
    public void AddTasks()
    {
        string newTask = "";
        while(newTask != "done")
        {
            Console.Write("Enter a new tasks or enter done to quit : ");
            newTask = Console.ReadLine();
            this.tasks.Add(newTask);
        }
        this.tasks.Remove("done");
        Console.WriteLine($"Number of tasks total : {this.tasks.Count}");
        this.tasks.ForEach(task => Console.WriteLine($"Task : {task}"));
    }
}
// enum definition
enum Specialty
{
    fontend,backend
}