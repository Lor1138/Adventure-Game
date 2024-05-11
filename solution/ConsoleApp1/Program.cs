// See https://aka.ms/new-console-template for more information
/*
 * Wehnimer
 * by Laura Manocchia Date 5/10/2024
 *  
 * This work is a derivative of 
 * "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
 * https://creativecommons.org/licenses/by/4.0/
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Game
    {
        static string CharacterName = "Jane Doe";
        //Change color of dialogs
        public static void StartGame()
        {
            Console.WriteLine("Wehnimers!");
            Console.WriteLine("Welcome to Wehnimer You will be exploring the fantastic world of Fantasy");
            NameCharacter();
        }


        public static void NameCharacter()
        {
            Console.WriteLine(" Please choose a name");
            CharacterName = Console.ReadLine();
            Console.WriteLine("Great! Your character is now named " + CharacterName);
            Console.ReadLine();
        }

    }


    class Item
    {

    }
    class Program
    {
        static void Main()
        {
            //TODO move title into its own function
            Console.Title = "ASCII Art";
            string title = @"
_______  _______ _________ _______ 
(  ____ \(  ____ )\__   __/(  ____ \
| (    \/| (    )|   ) (   | (    \/
| (__    | (____)|   | |   | |      
|  __)   |  _____)   | |   | |      
| (      | (         | |   | |      
| (____/\| )      ___) (___| (____/\
(_______/|/       \_______/(_______/

 _______           _______  _______ _________
(  ___  )|\     /|(  ____ \(  ____ \\__   __/
| (   ) || )   ( || (    \/| (    \/   ) (   
| |   | || |   | || (__    | (_____    | |   
| |   | || |   | ||  __)   (_____  )   | |   
| | /\| || |   | || (            ) |   | |   
| (_\ \ || (___) || (____/\/\____) |   | |   
(____\/_)(_______)(_______/\_______)   )_(  
                                             ";
            Console.WriteLine(title);
            Console.Read();
            Console.WriteLine("Press enter to continue...");
            Console.ReadKey();
            Console.Clear();
            Game.StartGame();
            Console.ReadKey();
        }

    }


}
