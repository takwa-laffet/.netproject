// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
//1er methode en utilisant le constructeur par defaut
/*Plane plane = new Plane();
plane.PlaneType = PlaneType.Airbus;
plane.Capacity = 200;
plane.ManufactureDate = DateTime.Now;
Console.WriteLine(plane);*/
//2eme methode en utilisant instanciation intuitive
/*Plane plane = new Plane
{
    PlaneType = PlaneType.Boing,
    Capacity = 300,
    ManufactureDate = DateTime.Now
};
Console.WriteLine(plane);
*/
//3eme methode en utilisant le constructeur specifique
/*Plane plane = new Plane(400, DateTime.Now, PlaneType.Airbus);
Console.WriteLine(plane);*/
//PARTIE 3 : POLYMORPHISME DE SURCHARGE
/*Passenger passanger = new Passenger
{
    FirstName = "Moussa",
    LastName = "Diallo",
    EmailAddress = "a@a.com"
};
Console.WriteLine("checkProfile 1:"+passanger.CheckProfile("Moussa", "Diallo"));
Console.WriteLine("checkProfile 2:" + passanger.CheckProfile("Moussa", "Diallo","b@b.com"));
*/

