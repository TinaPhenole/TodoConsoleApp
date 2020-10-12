using System.Collections.Generic;

namespace TodoApp
{
    class TodoManager
    {
        List<TodoItem> listOfTodoItems = new List<TodoItem>();

        public void AddTodoItem(string title)
        {
            TodoItem newTodoItem = new TodoItem();
            newTodoItem.Title = title;
            listOfTodoItems.Add(newTodoItem);
        }

        public void SetTodoItem(int index, bool isDone)
        {
            listOfTodoItems[index].IsDone = isDone;
        }

        public void RemoveTodoItem(int index)
        {
            listOfTodoItems.RemoveAt(index);
        }

        public List<string> ShowUsToDoes()
        {

            List<string> output = new List<string>();
            for (int i = 0; i < listOfTodoItems.Count; i++)
            {
                string done = ""; //Utvärdera
                if (listOfTodoItems[i].IsDone) // 1 // 2
                {
                    done = "Färdig";

                }
                else
                {
                    done = "Ej påbörjad";

                }
                // Rasta hunden är färdig // 1
                // mata papegojjan är ej påbörjad // 2
                // ...

                // för varje todoitem, lägg till detta i output på ett formaterat sätt med siffra och status
                output.Add($"{i} - {listOfTodoItems[i].Title} - är {done}");

            }
            return output;
        }
    }
}