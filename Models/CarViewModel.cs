// Worked LATE with Paul to complete this file for the assignment due 9am 15May2020
namespace AspNetCoreTodo.Models
{
    public class CarViewModel
    {
        public CarItem[] Items { get; set; }
    }
}
/*
Often, the model(entity) you store in the database is similar but not
exactly the same as the model you want to use in MVC(the view model).
In this case, the TodoItem model represents a single item in the
database, but the view might need to display two, ten, or a hundred todo
items (depending on how badly the user is procrastinating).
Because of this, the view model should be a separate class that holds an
array of TodoItem s:
*/
