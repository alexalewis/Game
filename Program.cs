using System;

namespace Game
{
  class Program
  {
    static void Main(string[] args)
    {
      //Welcome the user to the game
      Console.WriteLine("Welcome to the game!");
      //User picks a difficulty level
      Console.WriteLine("Which difficulty do you want to play? You can choose easy, normal, or impossible.");
      var userInput = Console.ReadLine().ToLower();
      if (userInput == "normal")
      {
        Console.WriteLine("You picked normal mode");
        //Tell user to pick which hand they want to throw
        Console.WriteLine("Pick either rock, paper, or scissors");
        //Accept user input for which hand they have chosen
        var userHand = Console.ReadLine().ToLower();
        //Computer randomly generates a hand
        Random rnd = new Random();
        string[] computer = { "rock", "paper", "scissors" };
        int compChoice = rnd.Next(computer.Length);
        var computerChoice = computer[compChoice];
        //Validating user input
        if (userHand == "rock" || userHand == "paper" || userHand == "scissors")
        {
          //Deciding the winner
          if (userHand == "rock" && computerChoice == "paper")
          {
            Console.WriteLine("The computer chose " + computerChoice + " and won!");
          }
          else if (userHand == "paper" && computerChoice == "scissors")
          {
            Console.Write("The computer chose " + computerChoice + " and won!");
          }
          else if (userHand == "scissors" && computerChoice == "rock")
          {
            Console.Write("The computer chose " + computerChoice + " and won!");
          }
          else if (userHand == "paper" && computerChoice == "rock")
          {
            Console.Write("The computer chose " + computerChoice + " and you chose " + userHand + " so you win!");
          }
          else if (userHand == "scissors" && computerChoice == "paper")
          {
            Console.WriteLine("The computer chose " + computerChoice + " and you chose " + userHand + " so you win!");
          }
          else if (userHand == "rock" && computerChoice == "scissors")
          {
            Console.WriteLine("The computer chose " + computerChoice + " and you chose " + userHand + " so you win!");
          }
          else if (userHand == "rock" && computerChoice == "rock")
          {
            Console.WriteLine("The computer chose " + computerChoice + " so it's a tie!");
          }
          else if (userHand == "paper" && computerChoice == "paper")
          {
            Console.WriteLine("The computer chose " + computerChoice + " so it's a tie!");
          }
          else if (userHand == "scissors" && computerChoice == "scissors")
          {
            Console.WriteLine("The computer chose " + computerChoice + " so it's a tie!");
          }
        }
        else
        {
          Console.WriteLine("You didn't pick rock, paper, or scissors. Please pick again!");
        }


      }
      else if (userInput == "easy")
      {
        Console.WriteLine("You picked easy mode");
        //Tell user to pick which hand they want to throw
        Console.WriteLine("Pick either rock, paper, or scissors");
        //Accept user input for which hand they have chosen
        var userHand = Console.ReadLine().ToLower();
        if (userHand == "paper")
        {
          Console.WriteLine("The computer chose rock so you win!");
        }
        else if (userHand == "rock")
        {
          Console.WriteLine("The computer chose scissors so you win!");
        }
        else if (userHand == "scissors")
        {
          Console.WriteLine("The computer chose paper so you win!");
        }
        else
        {
          Console.WriteLine("You didn't pick rock, paper, or scissors. Please pick again!");
        }

      }
      else if (userInput == "impossible")
      {
        Console.WriteLine("You picked impossible mode");
        //Tell user to pick which hand they want to throw
        Console.WriteLine("Pick either rock, paper, or scissors");
        //Accept user input for which hand they have chosen
        var userHand = Console.ReadLine().ToLower();
        if (userHand == "paper")
        {
          Console.WriteLine("The computer chose scissors so you lose!");
        }
        else if (userHand == "rock")
        {
          Console.WriteLine("The computer chose paper so you lose!");
        }
        else if (userHand == "scissors")
        {
          Console.WriteLine("The computer chose rock so you lose!");
        }
        else
        {
          Console.WriteLine("You didn't pick rock, paper, or scissors. Please pick again!");
        }
      }

      else
      {
        Console.WriteLine("You didn't pick which mode you wanted to play. Try again.");
      }
    }
  }
}






