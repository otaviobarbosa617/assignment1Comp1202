//COMP 1202 - George Brown College
// Assignment #1
// Student: Otavio Anacleto Pereira Barbosa
// Student ID: 101337690

using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarations
            int jumpersNumber;
            int qualify = 0;
            int notQualify = 0;
            float jumpAverage;
            float highestJump = 0;
            int highestJumper = 0;
            float jump1;
            float jump2;
            float jump3;

            // Input competitor number or break
            Console.Write("Please enter a competitor number (0 to quit and print the final results) ");
            jumpersNumber = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Please enter three jumps heights: ");
                string jumps = Console.ReadLine();
                string[] values = jumps.Split(' ');

                float.TryParse((values[0]), out jump1);
                float.TryParse((values[1]), out jump2);
                float.TryParse((values[2]), out jump3);

                if ((float.TryParse((values[0]), out jump1) == false) | (float.TryParse((values[1]), out jump2) == false) | (float.TryParse((values[2]), out jump3) == false))
                {
                    Console.WriteLine("invalid");
                    Console.Write("");
                }
                else
                {
                    jumpAverage = (jump1 + jump2 + jump3) / 3.0F;

                    if (jumpAverage >= 1.5F)
                    {
                        Console.WriteLine("{0} \t\t {1:N2} \t\t qualifies", jumpersNumber, jumpAverage);
                        qualify++;

                        if (jumpAverage > highestJump)
                        {
                            highestJump = jumpAverage;
                            highestJumper = jumpersNumber;
                        }
                    }
                    else
                    {
                        Console.WriteLine("{0} \t\t {1:N2} \t\t does not qualifies", jumpersNumber, jumpAverage);
                        notQualify++;
                    }

                    Console.Write("Please enter a competitor number (0 to quit and print the final results) ");
                    jumpersNumber = int.Parse(Console.ReadLine());

                }

            } while (jumpersNumber != 0);

            Console.WriteLine("{0} jumpers qualified.", qualify);
            Console.WriteLine("{0} jumpers did not qualify.", notQualify);
            Console.WriteLine("The highest jumper was contestant {0} with an average height of {1:N2} metres.", highestJumper, highestJump);
            Console.ReadKey();

        }
    }
}

