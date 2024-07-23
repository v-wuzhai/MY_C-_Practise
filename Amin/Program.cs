using System;
using helloworld.models;
using helloworld.controller;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using Newtonsoft.Json;

class Program{
    static void Main (string [] args){
        System.Console.WriteLine("Choose assignment:");
        if (args.Length == 0){
            System.Console.WriteLine("No assignment was choosed");
            return;
        }
        string assignment = args[0].ToLower();
        switch (assignment){
            case "week1":
                System.Console.WriteLine("Week 1 Assignment");
                Week1Assignment();
                break;
            default:
                System.Console.WriteLine("Invalid input given");
                break;
        }

    }

    static void Week1Assignment() {
        // Week 1 Assignment
        System.Console.Write("Enter your name:");
        string name = Console.ReadLine();
        System.Console.Write("Enter your age:");
        string agenumber = Console.ReadLine();
        int age;
        if (!int.TryParse(agenumber, out age)) {
            Console.WriteLine("Invalid age input.");
            return;
        }
        System.Console.Write("Unlease your moto! :");
        string moto = Console.ReadLine();

        Week1Model user = new Week1Model {
            Name = name,
            Age = age,
            Moto = moto,
        };
        Week1Controller userController =  new Week1Controller();
        userController.UserDetails(user);
    }

}