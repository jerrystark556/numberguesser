using System;

namespace numberguesser 
{ 
    class Program
    {
             static void Main(string[] args)
             {
                     /*app information*/
                     string Appname = "number guesser";
                     string Appauthor = "Jerry";
                     /*change color */
                     Console.ForegroundColor = ConsoleColor.Blue;
                     Console.WriteLine("{0} by {1}",Appname, Appauthor);
                     /*change color for orign*/
                     Console.ResetColor();
                     /*say your name*/
                     Console.WriteLine("你叫甚麼名字：");
                     string gamer = Console.ReadLine();
                     Console.WriteLine("哈囉，" +　gamer + "，來玩遊戲吧");
                     /*define answer and guess_count and guess_limit*/
                     int guess;
                     int answer = 67;
                     int guess_count = 0;
                     int guess_limut = 5;
                     bool win = false;
                     Console.WriteLine("請猜1到100的數字");

                     do
                     {
                           guess = Convert.ToInt32(Console.ReadLine());
                           guess_count++;

                           if (guess > answer)
                           {
                                   Console.ForegroundColor = ConsoleColor.Green;
                                   Console.WriteLine("小一點");
                                   Console.ResetColor();
                           }
                           else if(guess < answer)
                           {
                                   Console.ForegroundColor = ConsoleColor.Green;
                                   Console.WriteLine("大一點");
                                   Console.ResetColor();
                           }
                           else
                           {
                                   Console.ForegroundColor = ConsoleColor.Red;
                                   Console.WriteLine("答對啦~");
                                   Console.ResetColor();
                                   win = true;
                           }
                     
            
                     }
                     while (guess != answer && guess_count <guess_limut);
                     if(!win)
                     {
                     Console.ForegroundColor = ConsoleColor.Yellow;
                     Console.WriteLine("你輸了");
                     Console.ResetColor();
                     }
             }
             
    }
}