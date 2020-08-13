using System;
// derived from Developer 
class SeniorDeveloper : Developer
{
    private bool hasReviewedSprint;
    // construct derived from Developer with added property
    public SeniorDeveloper(Specialty specialty, string teamName, bool sprint) : base(specialty, teamName)
    {
        this.hasReviewedSprint = sprint;
    }
    // Overwrite the inherited method to display a developer's information to include the hasReviewedSprint property in the output
    public new void DisplayProps()
    {
        Console.WriteLine($"Specialty : {this.specialty}\nTeam Name : {this.teamName}\nNumber of Tasks : {this.tasks.Count}\nHas Reviewed Sprint : {this.hasReviewedSprint}");
    }
    // update the hasReviewedSprint property
    public void UpdateSprint()
    {
        Console.WriteLine($"If senior dev has reviewed the sprint enter YES : "); // prompt
        string userInput = Console.ReadLine(); // save input
        // update prop and display message based on value of input
        if(userInput == "YES")
        {
            this.hasReviewedSprint = true;
            Console.WriteLine("The developer has reviewed the sprint");
        } else 
        {
            this.hasReviewedSprint = false;
            Console.WriteLine("The developer has not reviewed the sprint");
        }
    }
}