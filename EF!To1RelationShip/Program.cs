using EF_To1RelationShip;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("One to One RlationShip!");
MyDbContext Context = new MyDbContext();
//CRUD Operators
//get data , data SELECT

Engine MyEngine = Context.Engines.Include(x => x.Car).SingleOrDefault(x => x.Id.Equals(3));
Console.WriteLine(MyEngine.Car.Brand);

//Update data
Car car1 = Context.Cars.SingleOrDefault(x => x.Id == 1);
car1.Model = "Avensis";
car1.Year = 2024;
Context.Update(car1);
Context.SaveChanges();

//create data - INSERT DATA
//Car car2 = new Car();
//car2.Brand = "Opel";
//car2.Model = "vectra";
//car2.Year = 2021;
//Context.Add(car2);
//Context.SaveChanges();

//Engine engine2 = new Engine();
//engine2.Volume = 4;
//engine2.NumberOfPistons = 3;
//engine2.CarId = 6;
//Context.Add(engine2);
//Context.SaveChanges();

//DELETE DATA
//Car car8 = Context.Cars.SingleOrDefault(x=>x.Id == 8);
//Context.Cars.Remove(car8);
//Context.SaveChanges();
//Car car7 = Context.Cars.FirstOrDefault(x => x.Id == 7);
//Context.Cars.Remove(car7);
//Context.SaveChanges();

Car car6 = Context.Cars.FirstOrDefault(x => x.Id.Equals(6));
car6.Brand = "New Brand";
car6.Model = "New Model";
car6.Year = 2000;
Context.Update(car6);
Context.SaveChanges();
