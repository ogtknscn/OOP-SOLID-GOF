using Solutions.OOP.Encapsulation;
using Solutions.OOP.Abstraction;
using Solutions.OOP.Inheritance;
using Solutions.OOP.Polymorphism;
using Solutions.OOP.Coupling;

//Coupling\\
/* The degree of interdependence between software modules; a measure of how closely connected two routines or modules are; the strength of the relationships between modules.

var order = new Order(new EmailSender());
order.PlaceOrder();
*/

// Polymorphism \\
/* The ability to present the same interface for different data types.

List<Vehicle> vehicles = new List<Vehicle>
{
    new Car("Toyota", "Corolla", 2021, 4, 4),
    new Motorcycle("Yamaha", "YZF-R6", 2021, 2)
};

foreach (var vehicle in vehicles)
{
    vehicle.Start();
    vehicle.Stop();
}
*/

// Inheritance \\
/* A mechanism in which one class acquires the properties and behavior of another class.

var car = new Car("Toyota", "Corolla", 2021, 4, 4);
car.Start();
car.Stop();
*/

// Abstraction \\
/* Less code to write, less code to maintain, and less code to test.

EmailService emailService = new EmailService();
emailService.SendEmail();
*/

// Encapsulation \\
/* The bundling of data with the methods that operate on that data.

BankAccount bankAccount = new BankAccount(100);
System.Console.WriteLine(bankAccount.GetBalance()); // 100

bankAccount.Deposit(50);
System.Console.WriteLine(bankAccount.GetBalance()); // 150

bankAccount.Withdraw(170);
System.Console.WriteLine(bankAccount.GetBalance()); // 80
*/