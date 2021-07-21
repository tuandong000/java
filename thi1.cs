﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Cylinder
    {
        static void Main(string[] args)
        {
            Result();
        }
        static void Process(double Radius, double Height)
        {
            double BaseArea = Radius * Radius  *Math.PI;
            double LateralArea = 2 *  Math.PI* Radius * Height;
            double TotalArea = 2 * Math.PI* Radius *(Height + Radius);
            double Volume = Math.PI * Radius* Radius *Height;
            Console.WriteLine($"Base: {Math.Round(BaseArea, 2)}  | Lateral: {Math.Round(LateralArea, 2)}  | Total; {Math.Round(TotalArea, 2)}  | Volume: {Math.Round(Volume, 2)}");
        }

        static void Result()
        {
            Console.WriteLine("Enter the dimenstions os the cylinder");
            Console.WriteLine("Radius:");
            double Radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Height:");
            double Height = double.Parse(Console.ReadLine());
            Console.WriteLine("cylinder Characteristics");
            Console.WriteLine($"Radius: {Radius}, Height: {Height}");
            Process(Radius,Height);
             Console.WriteLine($"Radius: {Radius}, Height: {Height}");
        }

    }
}