using System;
using static System.Console;

namespace MultiDArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] produce = { { "Apples", "Bannas", "Stawberries", "Star Fruit"},
                                     {"Hamburger","Pork Loin", "Turkey", "Blueberries" },
                                        {"Yogurt","Milk", "Cheese", "Cheese Curds" } };

            string[,] badProduce = new string[3, 3];

            badProduce[0, 0] = "cat food"; //set values
            badProduce[0, 1] = "Baby food";
            badProduce[0, 2] = "Grey Meat";

            WriteLine("{0} is bad but {1} is good", badProduce[0, 2], produce[1, 1]);

            //Print out multidimensional array

            for(int x = 0; x < 3; ++x)
            {
                for(int y = 0; y < 4; ++y)
                {
                    Write("\t{0}", produce[x, y]);
                }
                WriteLine("");
            }

            string searchItem = ReadLine();

            //search of multi dimensional array
            int foundX = -1; // position of the item in the x axis
            int foundY = -1; // position of the item in the y axis
            for (int x = 0; x < 3; ++x)
            {
                for (int y = 0; y < 4; ++y)
                {
                    if(produce[x, y] == searchItem)
                    {
                        //gets the position of the item in the multidimensional array
                        foundX = x;
                        foundY = y;

                        //exit the loop
                        x = 4;
                        y = 4;
                    }
                }
                
            }

            if(foundX >= 0)
            {
                WriteLine("{0} is avaible and probably hasn't expired", produce[foundX, foundY]);
            }
            else
            {
                WriteLine("No one eats that, buy some blue berries instead");
            }
        }
    }
}
