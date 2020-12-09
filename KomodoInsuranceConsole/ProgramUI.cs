using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceConsole
{
    class ProgramUI
    {
        public void run()
        {
            SeedContentList();
            menu();
        }

        //Menu
        private void menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                //displaying options to user
                Console.WriteLine("select a menu option:\n" +
                    "1. Add new devloper\n" +
                    "2. View All Developers\n" +
                    "3. View Devlopers By DevloperTeams\n" +
                    "4. Update Existing Devloper teams\n" +
                    "5. Delete Existing Devloper Teams\n" +
                    "6. Exit");
            }

            //getting user input
            string input = Console.ReadLine();

            //evalute the user's input and act acordingly
            switch (input)
            {
                case "1":
                    //create new developer
                    CreateNewDevloper();
                    break;
                case "2":
                    //view all developers
                    ViewAllDevelopers();
                    break;
                case "3":
                    //View Content By Title
                    DisplayDevlopersByTeams();
                    break;
                case "4":
                    // Update Existing Content
                    UpdateExistingDeveloperTeams();
                    break;
                case "5":
                    // Delete Existing Content
                    DeleteExistingDeveloperTeams();
                    break;
                case "6":
                    Console.WriteLine("Goodbye");
                    //Exit
                    keepRunning = false;
                    break;
                default:
                    Console.WriteLine("Please enter a valid number. 1-6");
                    break;
            }
            Console.WriteLine("please press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        //CreateNewDevloper
        private void CreateNewDevloper()
        {

        }

    } 
}
