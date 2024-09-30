using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Concrete.Adapters;
using InterfaceAbstractDemo.Entities;


Customer customer1= new Customer();
customer1.FirstName = "Emre";
customer1.LastName = "Dağlar";
customer1.DateOfBirth = new DateTime(1996, 8, 3);
customer1.NationalityId = 28382842068;


BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisCheckManager());

customerManager.Save(customer1);

Console.ReadLine();