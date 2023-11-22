using OOP2;

IndividualCustomer customer1 = new IndividualCustomer();
customer1.CustomerId = 1;
customer1.FirstName = "Muhammet";
customer1.LastName = "Baran";
customer1.TcNo = "56556555646";
customer1.CustomerNo = "5653465534";

CoorporateCustomer customer2 = new CoorporateCustomer();
customer2.CustomerId = 2;
customer2.CompanyName= "Test";
customer2.CustomerNo = "595865654655";
customer2.VergiNo = "3589654256534";

CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer1);
