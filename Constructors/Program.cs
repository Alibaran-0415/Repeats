Customer customer1 = new Customer();
Customer customer2 = new Customer();
customer2.FirstName = "Test";
Console.WriteLine(customer2.FirstName);


class Customer
{
    public Customer()
    {
        Console.WriteLine("Yapıcı metod çalıştı.");
    }

    public Customer(int id,string firstName,string lastName,string city)
    {
        Id= id;
        FirstName= firstName;
        LastName= lastName;
        City= city;
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}