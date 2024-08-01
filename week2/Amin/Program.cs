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
            case "week2":
                System.Console.WriteLine("Week 2 Assignment");
                Week2Assignment();
                break;
            default:
                System.Console.WriteLine("Invalid input given");
                break;
        }

    }

    static void Week2Assignment(){

        // int input
        System.Console.Write("Enter a number:");

        // assign input to cns and star
        string n = Console.ReadLine();
        int cns_input = int.Parse(n);
        int star_input = int.Parse(n);

        // star
        Week2Model input = new Week2Model{
            CnS = cns_input,
            StarCount = star_input
        };

        Week2Controller controller = new Week2Controller();
        System.Console.WriteLine("Count and Say:");
        string result = controller.cns_output(input);
        Console.WriteLine($"The {n}th sequence in the count-and-say sequence is: {result}");
        System.Console.WriteLine("Diamond:");
        controller.star_output(input);
    }
}