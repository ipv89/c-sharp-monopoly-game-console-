using System;
using System.Collections.Generic;
using System.Text;

using MolopolyGame.Testing;

namespace MolopolyGame
{
     /// <summary>
    /// Main class for the program
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
          //  _LandOnTest theTest = new _LandOnTest();
           // theTest.TestLandOn();

            //return;
           //Community_Chest theCom = new Community_Chest();
         //   Player thenPlayer = new Player();

//theCom.draw_card(thenPlayer);
         //   return;

            

            Game game = new Monopoly();

            game.initializeGame();
        }

     
    }
}
