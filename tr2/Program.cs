using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace tr2
{
    class Program
    {
        static void Main(string[] args)
        {
            var points = 0;
        start:
            
            string[] listwords = new string[15];
            listwords[0] = "exams";
            listwords[1] = "mobile";
            listwords[2] = "computer";
            listwords[3] = "pakistan";
            listwords[4] = "country";
            listwords[5] = "icecream";
            listwords[6] = "rose";
            listwords[7] = "apple";
            listwords[8] = "programming";
            listwords[9] = "csharp";
            listwords[10] = "pencil";
            listwords[11] = "laptop";
            listwords[12] = "biryani";
            listwords[13] = "hahaha";
            listwords[14] = "fun";
            Random randGen = new Random();

           

            string[] listwords2 = new string[10];

             previos:
            Console.Clear();
            Console.WriteLine("\n\n\t\t---Welcome to Memory Test Game---");
            Console.WriteLine("\t\t1 = Start the game.");
            Console.WriteLine("\t\t2 = What to do.");
            Console.WriteLine("\t\t3 = Group Members");
            Console.WriteLine("\t\t4 = Exit");

            int sel = Convert.ToInt32(Console.ReadLine());

            if (sel == 1)
            {
                ssd:
                Console.Clear();
                Console.WriteLine("\n\n\t\t---Welcome to Memory Test Game---");
                Console.WriteLine("\t\t1 = Easy.");
                Console.WriteLine("\t\t2 = Normal.");
                Console.WriteLine("\t\t3 = Hard");
                Console.WriteLine("\t\t4 = Previous");
                int asd = Convert.ToInt32(Console.ReadLine());
                if (asd == 1)
                {
                sucess:
                    for (int i = 0; i < 10; i++)
                    {
                        var idx = randGen.Next(0, 14);
                        string mysteryWord = listwords[idx];
                        listwords2[i] = mysteryWord;

                    }
                    Console.Clear();
                    Console.WriteLine("\n\n\t\tPrepare your MIND to Remenber 3 words with index Numbers");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("\n\n\t\t\tReady");
                    Thread.Sleep(800);
                    Console.Clear();
                    Console.WriteLine("\n\n\t\t\t3");
                    Thread.Sleep(800);
                    Console.Clear();
                    Console.WriteLine("\n\n\t\t\t2");
                    Thread.Sleep(800);
                    Console.Clear();
                    Console.WriteLine("\n\n\t\t\t1");
                    Thread.Sleep(800);
                    Console.Clear();
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("\n\n\t\tWelcome to Memory Game!!!!!!!!!!");
                        Console.WriteLine(" \t\t\t{0} = {1}", i, listwords2[i]);
                        Thread.Sleep(1000);
                        Console.Clear();

                    }
                    Console.WriteLine("\n\n\t\tWelcome to Memory Game!!!!!!!!!!");
                    Random num = new Random();
                    var numm = num.Next(0, 3);
                    Console.WriteLine("\n\t\tNow tell the word that comes on {0} number", numm);
                    string guess;
                    guess = Console.ReadLine();

                    if (guess == listwords2[numm])
                    {
                        //Console.WriteLine("you won");
                        points = points + 1;
                        Console.WriteLine("\n\n\t\tYour Current Score is = {0}", points);
                        Thread.Sleep(800);
                        Console.Clear();
                        goto sucess;

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\t\tYou Played Memory Game in Easy Mode");
                        Console.WriteLine("\t\tYou Guessed the Answer Wrong.");
                        Console.WriteLine("\t\tYour Final Score is {0} ", points);
                        Console.WriteLine("\t\tIf you want to play again then press 9");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 9)
                        {

                            Console.Clear();
                            goto start;
                        }
                        else
                            Console.Clear();
                    }

                }
                else if(asd==2)
                {
                sucess:
                    for (int i = 0; i < 10; i++)
                    {
                        var idx = randGen.Next(0, 14);
                        string mysteryWord = listwords[idx];
                        listwords2[i] = mysteryWord;

                    }
                    Console.Clear();
                    Console.WriteLine("\n\n\t\tPrepare your MIND to Remenber 5 words with index Numbers");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("\n\n\t\t\tReady");
                    Thread.Sleep(800);
                    Console.Clear();
                    Console.WriteLine("\n\n\t\t\t3");
                    Thread.Sleep(800);
                    Console.Clear();
                    Console.WriteLine("\n\n\t\t\t2");
                    Thread.Sleep(800);
                    Console.Clear();
                    Console.WriteLine("\n\n\t\t\t1");
                    Thread.Sleep(800);
                    Console.Clear();
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("\n\n\t\tWelcome to Memory Game!!!!!!!!!!");
                        Console.WriteLine(" \t\t\t{0} = {1}", i, listwords2[i]);
                        Thread.Sleep(1000);
                        Console.Clear();

                    }
                    Console.WriteLine("\n\n\t\tWelcome to Memory Game!!!!!!!!!!");
                    Random num = new Random();
                    var numm = num.Next(0, 5);
                    Console.WriteLine("\n\t\tNow tell the word that comes on {0} number", numm);
                    string guess;
                    guess = Console.ReadLine();

                    if (guess == listwords2[numm])
                    {
                        //Console.WriteLine("you won");
                        points = points + 1;
                        Console.WriteLine("\n\n\t\tYour Current Score is = {0}", points);
                        Thread.Sleep(800);
                        Console.Clear();
                        goto sucess;

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\t\tYou Played Memory Game in Normal Mode");
                        Console.WriteLine("\t\tYou Guessed the Answer Wrong.");
                        Console.WriteLine("\t\tYour Final Score is {0} ", points);
                        Console.WriteLine("\t\tIf you want to play again then press 9");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 9)
                        {

                            Console.Clear();
                            goto start;
                        }
                        else
                            Console.Clear();
                    }
                }
                else if (asd == 3)
                {
                sucess:
                    for (int i = 0; i < 10; i++)
                    {
                        var idx = randGen.Next(0, 14);
                        string mysteryWord = listwords[idx];
                        listwords2[i] = mysteryWord;

                    }
                    Console.Clear();
                    Console.WriteLine("\n\n\t\tPrepare your MIND to Remenber 10 words with index Numbers");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("\n\n\t\t\tReady");
                    Thread.Sleep(800);
                    Console.Clear();
                    Console.WriteLine("\n\n\t\t\t3");
                    Thread.Sleep(800);
                    Console.Clear();
                    Console.WriteLine("\n\n\t\t\t2");
                    Thread.Sleep(800);
                    Console.Clear();
                    Console.WriteLine("\n\n\t\t\t1");
                    Thread.Sleep(800);
                    Console.Clear();
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("\n\n\t\tWelcome to Memory Game!!!!!!!!!!");
                        Console.WriteLine(" \t\t\t{0} = {1}", i, listwords2[i]);
                        Thread.Sleep(1000);
                        Console.Clear();

                    }
                    Console.WriteLine("\n\n\t\tWelcome to Memory Game!!!!!!!!!!");
                    Random num = new Random();
                    var numm = num.Next(0, 9);
                    Console.WriteLine("\n\t\tNow tell the word that comes on {0} number", numm);
                    string guess;
                    guess = Console.ReadLine();

                    if (guess == listwords2[numm])
                    {
                        //Console.WriteLine("you won");
                        points = points + 1;
                        Console.WriteLine("\n\n\t\tYour Current Score is = {0}", points);
                        Thread.Sleep(800);
                        Console.Clear();
                        goto sucess;

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\t\tYou Played Memory Game in Hard Mode");
                        Console.WriteLine("\t\tYou Guessed the Answer Wrong.");
                        Console.WriteLine("\t\tYour Final Score is {0} ", points);
                        Console.WriteLine("\t\tIf you want to play again then press 9");


                        Console.WriteLine("{0}", listwords2[numm]);


                        int choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 9)
                        {

                            Console.Clear();
                            goto start;
                        }
                        else
                            Console.Clear();
                    }
                }
                else if (asd == 4)
                {
                    Console.Clear();
                    goto previos;
                }
                else
                {
                    goto ssd;
                }



            }
            else if (sel == 2)
            {
                Console.Clear();
                Console.WriteLine("\n\n\t\t\t---Help---");
                Console.WriteLine("\n\t\tSystem will show you ten random words.What you have to do is Remember all the word and");
                
                Console.WriteLine("\n\t\tsequence after system will asks you to guess the word came on a certain number.");
                Console.WriteLine("\n\t\tIf you guess the word correctly you will be questioned  same and if you lost");
                Console.WriteLine("\n\t\tYou will be taken to the result screen with your score and option to play again or not..");
                Console.WriteLine("\n\n\n\t\tEasy Mode : in this mode you have to guess from 3 words");
                Console.WriteLine("\n\n\n\t\tNormal mode : in this mode you have to guess from 5 words");
                Console.WriteLine("\n\n\n\t\t Hard Mode : in this mode you have to guess from 10 words");
                Console.WriteLine("\n\n\n\t\tNOTE : NUMBERS ON SCREEN ARE ALL INDEX NUMBERS eg starts from 0.");
                Console.WriteLine("\n\n\t\t\tpress any key to go back to main menu...");
                Console.ReadKey();
                goto start;
            }
            else if(sel==3)
            {
                Console.Clear();
                Console.WriteLine("\n\n\t\t|--------------------------------------|");
                Console.WriteLine("\t\t|    Name            |   Roll no.      |");
                Console.WriteLine("\t\t|--------------------------------------|");
                Console.WriteLine("\t\t| Rimsha Kanwal      |    17814156-029 |");
                Console.WriteLine("\t\t|--------------------------------------|");
                Console.WriteLine("\t\t| Nayab Ansar        |    17814156-024 |");
                Console.ReadKey();
                goto start;

            }
            
            else if (sel == 4)
            {
                Console.Clear();
            }
            else
            {
                goto previos;
            }
        }






        


    }
}
             