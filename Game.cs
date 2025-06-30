using System;
using System.Collections.Generic;

namespace AGA // Adad Gomshede Amjadi
{
    class Game
    {
        static void Main(string[] args)
        {
            int score = 0;
            int totalRounds = 5;
            Random rnd = new Random();

            List<string> operators = new List<string> { "+", "-", "*", "/", "sqrt" };

            PrintBox(" AGA - Adad Gomshede Amjadi ");
            PrintLine(" Version: G1.1 ");
            PrintLine("");
            PrintLine(" Dar har round, amalgar gomshode ra peyda konid.");
            PrintLine(" Amalgar ha: +  -  *  /  sqrt");
            PrintLine(" (In each round, find the missing operator)");
            PrintLine("");

            for (int round = 1; round <= totalRounds; round++)
            {
                int a = rnd.Next(1, 21);
                int b = rnd.Next(1, 21);
                string op = operators[rnd.Next(operators.Count)];

                double result = 0;
                string question = "";

                if (op == "+")
                {
                    result = a + b;
                    question = $"{a} [] {b} = {result}";
                }
                else if (op == "-")
                {
                    result = a - b;
                    question = $"{a} [] {b} = {result}";
                }
                else if (op == "*")
                {
                    result = a * b;
                    question = $"{a} [] {b} = {result}";
                }
                else if (op == "/")
                {
                    b = rnd.Next(1, 10);
                    a = b * rnd.Next(1, 10);
                    result = a / b;
                    question = $"{a} [] {b} = {result}";
                }
                else if (op == "sqrt")
                {
                    a = rnd.Next(1, 16);
                    result = Math.Sqrt(a);
                    result = Math.Round(result, 2);
                    question = $"[] {a} = {result}";
                }

                PrintLine("");
                PrintLine($" Round {round} of {totalRounds} ");
                PrintLine(" Soal: " + question);
                PrintLine(" (Question: " + question.Replace("[]", "?") + ")");

                Print(" Amalgar gomshode ra vared konid (+, -, *, /, sqrt): ");
                string input = Console.ReadLine().Trim();

                if (input == op)
                {
                    PrintBox(" Dorost! ");
                    score++;
                }
                else
                {
                    PrintBox(" Esmhteb ast. Amalgar dorost: '" + op + "' bud. ");
                }
            }

            PrintBox(" Bazi tamoom shod! Emtiyaz: " + score + " az " + totalRounds + " ");
            PrintLine(" (Game over! Your score: " + score + " out of " + totalRounds + ") ");
            PrintLine("");
            PrintLine(" Baraye khoroj ENTER ra bezanid. ");
            Console.ReadLine();
        }

        static void PrintBox(string message)
        {
            string border = new string('=', message.Length + 4);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(border);
            Console.WriteLine($"|  {message}  |");
            Console.WriteLine(border);
            Console.ResetColor();
        }

        static void PrintLine(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        static void Print(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(msg);
            Console.ResetColor();
        }
    }
}
