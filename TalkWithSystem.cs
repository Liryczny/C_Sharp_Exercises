using System;
public class TalkWithSystem
{
  public static void Main(string[] args)
  {
     string response = "";
     Console.WriteLine("SYSTEM: What's up");
     Console.Write("USER: ");
     response = Console.ReadLine().ToUpper();

     if (response == "GOOD")
     {
       Console.WriteLine("SYSTEM: That's good");
     }
     else
     {
       Console.WriteLine("SYSTEM: That's bad");
     }
  }
}

