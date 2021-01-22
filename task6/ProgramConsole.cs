using System;
using System.Collections.Generic;

/*

Задача 6

Для интерфейса необходимо определить 1 свойство и 2 метода. 
Абстрактный класс должен содержать 3-5 свойств и 3-5 методов(включая унаследованные свойства интерфейса). 
Класс должен содержать дополнительно 2 свойства и 2 метода.
В программе реализовать работу со списком объектов, который должен содержать объекты типа интерфейса.

15. 

interface Бумага -> abstract class Тетрадь -> class Тетрадь Для Рисования.

 */

namespace Task6_15
{
    class ProgramCl
    {
        static void MainCl(string[] args)
        {
            bool work = true;

            List<IPaper> notebooks = new List<IPaper>();
            while (work)
            {
                Console.WriteLine("1) Add new DrawingNotebook");
                Console.WriteLine("2) Show list");
                Console.WriteLine("3) Exit");

                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        // string color, string quality, string coverColor, string type, bool hasExamples, string orientation
                        Console.Clear();
                        Console.WriteLine("Enter color");
                        string color = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Enter quality");
                        string quality = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Enter coverColor");
                        string  coverColor = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Enter type");
                        string  type = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Enter hasExamples");
                        Console.WriteLine("1) True");
                        Console.WriteLine("2) False");
                        int hasExamples = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Enter orientation");
                        string orientation = Console.ReadLine();
                        Console.Clear();
                        
                        notebooks.Add(new DrawingNotebook { Colour = color, Quality = quality, CoverColour = coverColor, Type = type, HasExamples = hasExamples == 1, Orientation = orientation });
                        break;
                    case 2:
                        Console.Clear();
                        foreach (var notebook in notebooks)
                        {
                            Console.WriteLine("Color - " + notebook.Colour + " Quality - " + notebook.Quality + " Draw: " + notebook.Draw() + " Shred: " + notebook.Shred());
                        }
                        Console.WriteLine("Press any button");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        work = false;
                        break;
                }
            }
        }
    }
}