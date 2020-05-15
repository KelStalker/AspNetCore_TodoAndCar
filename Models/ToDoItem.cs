using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreTodo.Models
{
    public class TodoItem
    {
        public Guid Id { get; set; }
        public bool IsDone { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTimeOffset? DueAt { get; set; }
    }
}
/* This class defines what the database will need to store for each to-do
item: an ID, a title or name, whether the item is complete, and what the
due date is. Each line defines a property of the class: */