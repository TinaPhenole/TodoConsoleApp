using System;
using System.Collections.Generic;

namespace TodoApp
{
    class Program
    {
        static void Main()
        {
            TodoManager todoManager = new TodoManager();

            //Test-code, add user interface here later
            //todoManager.AddTodoItem("Rasta hunden");
            //todoManager.AddTodoItem("Rasta den andra hunden");
            System.Console.WriteLine("Vad vill du lägga till?");
            string inmatning = Console.ReadLine();
            todoManager.AddTodoItem(inmatning); 

            //todoManager.AddTodoItem("Rensa kattlådan");



            Console.WriteLine("Vad vill du göra?");
            Console.WriteLine("1. Lägg till en uppgift");
            Console.WriteLine("2. Ändra uppgift status?");
            Console.WriteLine("3. Ta bort en uppgift");
            Console.WriteLine("4. Avsluta?");   // Avsluta?
            // Ta inmatning            
            string yourChoice = Console.ReadLine();
            int selection = Convert.ToInt32(yourChoice);  // convert int

            // Utvärdera inmatning, switch
            switch (selection)
            {
                case 1:
                AddToDo(todoManager);  // Lägg till uppgift Skapa en metod som tar in en todomanager som argument.

                break;

                case 2:
                ToggleToDoStatus(todoManager);// Markera en uppgift som färdig / ofärdig
                break;

                case 3:
                // Ta bort en uppgift
                break;

                case 4:
                Environment.Exit(-1); // Avsluta
                break;

                default:
                Console.WriteLine("Mata in en siffra mellan 1 - 4!");
                break;
            }
            // är det 1, kör addtodo
            // är det 2, ...
            
            todoManager.SetTodoItem(0, true); // pekar på första
            todoManager.RemoveTodoItem(1); // pekar på andra.
        }

        private static void ToggleToDoStatus(TodoManager todoManager)
        {
            for (int i = 0; i < length; i++)
            {
                
            }// meny på vilka uppgifter som finns, for loop
            // vilken uppgift vill användaren markera?
            // vad vill de göra med uppgiften?
            // ändrar uppgiftens status
            // "Uppgiften ...... är nu färdig / satt som ej påbörjad"
        }

        private static void AddToDo(TodoManager todoManager)
        {
            Console.WriteLine(" Vad vill du lägga till?"); // Fråga efter vad användaren vill lägga till
            string addedDoes = Console.ReadLine();   // Läs in inmatning
            todoManager.AddTodoItem(addedDoes);  // Lägg till i listan
            
        }
    }
}