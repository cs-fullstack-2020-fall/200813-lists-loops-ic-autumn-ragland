# 20 08 13 Lists and Loops In Class Practice
### Set Up
- Create a new .NET console application by running `dotnet new console -o Practice`
- In the Program class Main method change the default output to `20 08 13 Practice`
- Create `Developer` class
- Create a `SeniorDeveloper` class that extends the `Developer` class

### Assignment
### Part 1
- The base class `Developer` should have properties : specialty(enum with options frontend and backend), teamName(string), tasks(list of strings)
- Define the specialty and teamName in the constructor
- Define a method to display the developer's specialty, team name, and number of tasks in the console
- Define a method to allow the user to add multiple tasks to a developer's list of tasks until they input 'done' then display the number of tasks total and all tasks in the task list
### Part 2
- In the `SeniorDeveloper` class inherit all properties from the `Developer` base class and add the property hasReviewedSprint(boolean)
- Overwrite the inherited method to display a developer's information to include the hasReviewedSprint property in thr output 
- Define a method to update the hasReviewedSprint property
### Part 3
- Create an instance of the `Developer` class 
- Create an instance of the `SeniorDeveloper` class
- Use the appropriate methods on each instance