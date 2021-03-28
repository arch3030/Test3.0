using System;

namespace _28_03_2021_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int box1, box2, box3;
            int chooseBox, chooseCube;
            int totalCube;
            int player = 1;
            

            //Introduction
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to The Nim ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The rules are simple");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1)You must pick 1 out of 3 boxes");
            Console.WriteLine("2)You can only pick 1-2 cubes (from the box) for each pick");
            Console.WriteLine("Whoever takes the last loses");

            //Setup
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nSet up");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nInput amount of cube to Box#1 : ");
            box1 = int.Parse(Console.ReadLine());
            Console.Write("Input amount of cube to Box#2 : ");
            box2 = int.Parse(Console.ReadLine());
            Console.Write("Input amount of cube to Box#3 : ");
            box3 = int.Parse(Console.ReadLine());
            totalCube = box1 + box2 + box3;



            //Pick
            Console.Write("Box#1 : {0}  Box#2 : {1}  Box#3 : {2}", box1, box2, box3);
            for (player = 1; player < 1000; player++)
             {
                 //Player 1
                 if(player %2 != 0)
                {
                    Console.Write("\nPlayer A choose the Box : ");
                    chooseBox = int.Parse(Console.ReadLine());
                    if (chooseBox == 1)
                    {
                        Console.Write("How many cube you want : ");
                        chooseCube = int.Parse(Console.ReadLine());
                        if (chooseCube <= box1)
                        {
                            Console.WriteLine("Player A takes" + (chooseCube));
                            Console.Write("Box#1 : {0}  Box#2 : {1}  Box#3 : {2}", box1 - chooseCube, box2, box3);
                        }
                    }
                    else if (chooseBox == 2)
                    {
                        Console.Write("How many cube you want : ");
                        chooseCube = int.Parse(Console.ReadLine());
                        if (chooseCube <= box2)
                        {
                            Console.WriteLine("Player A takes" + (chooseCube));
                            Console.Write("Box#1 : {0}  Box#2 : {1}  Box#3 : {2}", box1, box2 - chooseCube, box3);
                        }
                    }
                    else if (chooseBox == 3)
                    {
                        Console.Write("How many cube you want : ");
                        chooseCube = int.Parse(Console.ReadLine());
                        if (chooseCube <= box3)
                        {
                            Console.WriteLine("Player A takes" + (chooseCube));
                            Console.Write("Box#1 : {0}  Box#2 : {1}  Box#3 : {2}", box1, box2, box3 - chooseCube);
                        }
                    }
                }  
                 //player 2
                else if(player%2 == 0)
                {
                    Console.Write("\nPlayer B choose the Box : ");
                    chooseBox = int.Parse(Console.ReadLine());
                    if (chooseBox == 1)
                    {
                        Console.Write("How many cube you want : ");
                        chooseCube = int.Parse(Console.ReadLine());
                        if (chooseCube <= box1)
                        {
                            Console.WriteLine("Player A takes" + (chooseCube));
                            Console.Write("Box#1 : {0}  Box#2 : {1}  Box#3 : {2}", box1 - chooseCube, box2, box3);
                        }
                    }
                    else if (chooseBox == 2)
                    {
                        Console.Write("How many cube you want : ");
                        chooseCube = int.Parse(Console.ReadLine());
                        if (chooseCube <= box2)
                        {
                            Console.WriteLine("Player A takes" + (chooseCube));
                            Console.Write("Box#1 : {0}  Box#2 : {1}  Box#3 : {2}", box1, box2 - chooseCube, box3);
                        }
                    }
                    else if (chooseBox == 3)
                    {
                        Console.Write("How many cube you want : ");
                        chooseCube = int.Parse(Console.ReadLine());
                        if (chooseCube <= box3)
                        {
                            Console.WriteLine("Player A takes" + (chooseCube));
                            Console.Write("Box#1 : {0}  Box#2 : {1}  Box#3 : {2}", box1, box2, box3 - chooseCube);
                        }
                    }
                }
                 if(totalCube == 0)
                {
                    Console.WriteLine("GAME HAS ENDED");
                }
             }
            Console.ReadLine();
        }
    }
}
