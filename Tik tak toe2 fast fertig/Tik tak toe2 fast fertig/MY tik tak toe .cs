using System;

namespace Neuse_tik_tak_toe
{
    class Program
    {


        static void Main(string[] args)
        {   int eingabe = 0;
          // Array
            string[,] feld = new string[3, 3];
            int zähler = 0;
            feld[0, 0] = "1";
            feld[0, 1] = "2";
            feld[0, 2] = "3";
            feld[1, 0] = "4";
            feld[1, 1] = "5";
            feld[1, 2] = "6";
            feld[2, 0] = "7";
            feld[2, 1] = "8";
            feld[2, 2] = "9";
            while (true)
            {
               
                
                
                
                
                
              FeldAusgeben(feld);
                try
                {
                    Console.Write(" Feld auswählen!: ");
                    eingabe = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nur Zahlen");
                    Console.ReadLine();



                }
                catch (OverflowException)
                {
                    Console.WriteLine("Hör Auf das zu Probieren!!!!!!!!!!! ");
                }
                if ((eingabe >= 11) || (eingabe <= 0))
                {
                    Console.WriteLine("Nur zahlen von 1 bis 10"); Console.ReadLine();
                }
                else
                {
                    zähler++;
                }
   

                if (zähler % 2 == 1)

                { Console.ForegroundColor = ConsoleColor.Red;
                    switch (eingabe)
                    {
                        case 1: feld[0, 0] = "X"; break;
                        case 2: feld[0, 1] = "X"; break;
                        case 3: feld[0, 2] = "X"; break;
                        case 4: feld[1, 0] = "X"; break;
                        case 5: feld[1, 1] = "X"; break;
                        case 6: feld[1, 2] = "X"; break;
                        case 7: feld[2, 0] = "X"; break;
                        case 8: feld[2, 1] = "X"; break;
                        case 9: feld[2, 2] = "X"; break;

                    }
                    Console.ResetColor();

                }
                else if (zähler % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    switch (eingabe)
                    {
                        case 1: feld[0, 0] = "Ö"; break;
                        case 2: feld[0, 1] = "Ö"; break;
                        case 3: feld[0, 2] = "Ö"; break;
                        case 4: feld[1, 0] = "Ö"; break;
                        case 5: feld[1, 1] = "Ö"; break;
                        case 6: feld[1, 2] = "Ö"; break;
                        case 7: feld[2, 0] = "Ö"; break;
                        case 8: feld[2, 1] = "Ö"; break;
                        case 9: feld[2, 2] = "Ö"; break;
                    }
                 Console.ResetColor();
                }
               
                FeldAusgeben(feld);

                

                if (((feld[0, 0] == "Ö") && (feld[0, 1] == "Ö") && (feld[0, 2] == "Ö")) || ((feld[1, 0] == "Ö") && (feld[1, 1] == "Ö") && (feld[1, 2] == "Ö")) || ((feld[2, 0] == "Ö") && (feld[2, 1] == "Ö") && (feld[2, 2] == "Ö")) || ((feld[0, 0] == "Ö") && (feld[1, 0] == "Ö") && (feld[2, 0] == "Ö")) || ((feld[0, 1] == "Ö") && (feld[1, 1] == "Ö") && (feld[2, 1] == "Ö")) || ((feld[0, 2] == "Ö") && (feld[1, 2] == "Ö") && (feld[2, 2] == "Ö")) || ((feld[0, 0] == "Ö") && (feld[1, 1] == "Ö") && (feld[2, 2] == "Ö")) || ((feld[0, 2] == "Ö") && (feld[1, 1] == "Ö") && (feld[2, 0] == "Ö")))
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Ö hat gewonnen");
                    Console.ReadLine();
                    break;
                }

                else if (((feld[0, 0] == "X") && (feld[0, 1] == "X") && (feld[0, 2] == "X")) || ((feld[1, 0] == "X") && (feld[1, 1] == "X") && (feld[1, 2] == "X")) || ((feld[2, 0] == "X") && (feld[2, 1] == "X") && (feld[2, 2] == "X")) || ((feld[0, 0] == "X") && (feld[1, 0] == "X") && (feld[2, 0] == "X")) || ((feld[0, 1] == "X") && (feld[1, 1] == "X") && (feld[2, 1] == "X")) || ((feld[0, 2] == "X") && (feld[1, 2] == "X") && (feld[2, 2] == "X")) || ((feld[0, 0] == "X") && (feld[1, 1] == "X") && (feld[2, 2] == "X")) || ((feld[0, 2] == "X") && (feld[1, 1] == "X") && (feld[2, 0] == "X")))
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("x hat gewonnen");
                    Console.ReadLine();
                    break;
                }
                
                else if(feld[0,0] != "1" && feld[0, 1] != "2" && feld[0, 2] != "3" && feld[1, 0] != "4" && feld[1, 1] != "5" && feld[1, 2] != "6" && feld[2, 0] != "7" && feld[2, 1] != "8" && feld[2, 2] != "9")
             
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Unetnschieden");
                    Console.ReadLine();
                    break;  // else if (zähler >= 9)
                }
                
            
            
            
            
            
            
            
            }
        }

       
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        private static void FeldAusgeben(string[,] feld)
        {
            Console.Clear();
            Console.WriteLine("User  1 ==  x (X Starts)");
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {feld[0, 0]}  |  {feld[0, 1]}  |  {feld[0, 2]}");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {feld[1, 0]}  |  { feld[1, 1]}  |  { feld[1, 2]}");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {feld[2, 0]}  |  {feld[2, 1]}  |  {feld[2, 2]}");
            Console.WriteLine("     |     |      ");
        }
    
    
    }
}













          

          

         

          

           

          
