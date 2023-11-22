//IPersonManager customer1 = new CustomerManager();
//IPersonManager employee1 = new EmployeeManager();
ProjectManager projectManager = new ProjectManager();
projectManager.Add(new EmployeeManager());
projectManager.Update(new InternManager());
projectManager.Delete(new CustomerManager());


interface IPersonManager
{
    void Add();
    void Update();
    void Delete();
}

class CustomerManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Customer Added!");
    }

    public void Delete()
    {
        Console.WriteLine("Customer Deleted!");
    }

    public void Update()
    {
        Console.WriteLine("Customer Updated!");
    }
}

class EmployeeManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Employee Added!");
    }

    public void Delete()
    {
        Console.WriteLine("Employee Deleted!");
    }

    public void Update()
    {
        Console.WriteLine("Employee Updated!");
    }
}

class InternManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Intern Added!");
    }

    public void Delete()
    {
        Console.WriteLine("Intern Deleted!");
    }

    public void Update()
    {
        Console.WriteLine("Intern Updated!");
    }
}

class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }

    public void Update(IPersonManager personManager)
    {
        personManager.Update();
    }

    public void Delete(IPersonManager personManager)
    {
        personManager.Delete();
    }
}



