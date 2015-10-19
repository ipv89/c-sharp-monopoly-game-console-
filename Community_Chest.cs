﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MolopolyGame
{
    /// <summary>
    /// This class stores all of the community chest cards
    /// </summary>

  public  class Community_Chest : Property
    {
        public Player current_player;
        public Banker the_bank;//Current Player
       public string sName;


        public Community_Chest() : this("Community Chest") { }


        public Community_Chest(string sName)
        {
            
            this.sName = sName;
        }

        public override string landOn(ref Player player)
        {

            draw_card(player);
            return base.landOn(ref player) + String.Format("You landed on something and got something");
        
        }
        //info for creating a list of actions was taken from http://stackoverflow.com/questions/4910775/can-a-list-hold-multiple-void-methods

      //Deck of comunity chest cards


     
        public List<Actionable> CardList()
        {

            List<Actionable> Community_Cards_Actions = new List<Actionable>
          
            {
                new Actionable
                    {
                          Name = "Doctor's fees – Pay $50 ",
                          Action = Doctor_fees

                    },
                new Actionable
                {
                    Name = "Advance To Go",
                    Action = advance_to_go
                }
                
                new Actionable
                {
                    Name = "It is your birthday Collect $10 from each player ",
                    Action = Card_Actions.birthday
                },
                 new Actionable
                {
                    Name = "Grand Opera Night – collect $50 from every player for opening night seats ",
                    Action = Card_Actions.Opera_Night
                },
                 new Actionable
                {
                    Name = "Income Tax refund – collect $20",
                    Action = Card_Actions.Tax_refund
                },
                 new Actionable
                {
                    Name = "Pay Hospital Fees of $100 ",
                    Action = Card_Actions.Hospital_Fees
                },
                 new Actionable
                {
                    Name = "Pay School Fees of $50",
                    Action = Card_Actions.School_Fees
                },
                 new Actionable
                {
                    Name = "Receive $25 Consultancy Fee",
                    Action = Card_Actions.Consultancy_Fee
                },
                 new Actionable
                {
                    Name = "You are assessed for street repairs – $40 per house, $115 per hotel ",
                    Action = Card_Actions.street_repairs
                },
                 new Actionable
                {
                    Name = "You have won second prize in a beauty contest– collect $10 ",
                    Action = Card_Actions.beauty_contest
                },
                 new Actionable
                {
                    Name = "You inherit $100 ",
                    Action = Card_Actions.inherit
                },
                 new Actionable
                {
                    Name = "From sale of stock you get $50 ",
                    Action = Card_Actions.sale_of_stock
                },
                 new Actionable
                {
                    Name = "Holiday Fund matures - Receive $100",
                    Action = Card_Actions.Holiday_Fund
                }
                
            };
       
          
            return Community_Cards_Actions;
         }
        //confirmed that this action runs

        public string draw_card(Player player)
        {
            List<Actionable> Community_Cards_Actions = CardList();
            current_player = player; //Current Player
            Community_Cards_Actions[0].Action.Invoke();
            return ("need to figure out how to not bother returning anything");
        }
      /**
       * Card Methods below here 
       */
        public void Doctor_fees()
        {
            
            Console.WriteLine("Doctor's fees – Pay $50 ");
            current_player.pay(50);
            the_bank.receive(50);
            Console.WriteLine("Your new balance is /n" + current_player.getBalance());
            Console.ReadLine();

        }

        public void advance_to_go()
        {
            current_player.setLocation(0, false);
            Console.WriteLine("Advance straight to GO");
        }
        

        
       

     public class Actionable
    {
        public string Name { get; set; }
        public Action Action { get; set; }
    }
    






    }

    


