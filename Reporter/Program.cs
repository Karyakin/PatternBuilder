﻿// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using Reporter.Implementations;
using Reporter.Implementations.BurgerBuilder;
using Reporter.Implementations.EmployeeBuilder;
using Reporter.Implementations.HouseBuilder;
using Reporter.Models.Burger;
using Reporter.Models.Employees;
using Reporter.Models.House;

#region employees

List<Employee> employees = new()
{
    new Employee() {Name = "Ivan", Salary = 100},
    new Employee() {Name = "Boris", Salary = 300},
    new Employee() {Name = "Dima", Salary = 500}
};

var builder = new EmployeeReportBuilder(employees);
var director = new EmployeeReportDirector(builder);

director.Build();

var report = builder.GetReport();

//Console.WriteLine("report\n" + report);


var fluentBuilder = new FluentEmployeeReportBuilder(employees);
var fluentDirector = new FluentEmployeeReportDirector(fluentBuilder);

fluentDirector.Build();

var fluentReport = fluentBuilder.GetReport();

//Console.WriteLine("fluentReport\n" + fluentReport);
//Console.ReadKey();

#endregion

#region Burger

List<BigMac> components = new()
{
    new BigMac(){Name = "BigMac",Size = "Max", Cheese = true},
    new BigMac(){Name = "BigMacMiddle",Size = "Middle", Cheese = true},
    new BigMac(){Name = "BigLight",Size = "Light", Cheese = true},
};

var bigMacBuilder = new BigMacBuilder(components);
var bigMacDirector = new BigMacDirector(bigMacBuilder);
bigMacDirector.Build();

var bigmac = bigMacBuilder.CreateBigMac();


//Console.WriteLine("bigMac\n" + bigmac);
//Console.ReadKey();

    
    
#endregion

#region House

var newRoof = new Roof()
{
    Name = "Буржуйская",
    Kind = "Металлочерепица",
    Price = 100
};
var newWall = new Wall()
{
    Name = "Бронированная",
    Kind = "Железобитон",
    Price = 3000
};

var houseBuilder = new HouseBuilder(newRoof, newWall);
var houseDirector = new HouseBuilderDirector(houseBuilder);


houseDirector.Build();

var house = houseBuilder.GetHouse();

Console.WriteLine($"Roof.Name: {house.Roof.Name}, Roof.Kind: {house.Roof.Kind}, Roof.Price: {house.Roof.Price}");
Console.WriteLine($"Wall.Name: {house.Wall.Name}, Wall.Kind: {house.Wall.Kind}, Wall.Price: {house.Wall.Price}");
Console.ReadKey();


string test;

#endregion