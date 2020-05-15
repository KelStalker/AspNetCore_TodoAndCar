using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;
using AspNetCoreTodo.Services;


namespace AspNetCoreTodo.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteItemsAsync();
    }
}

/* P33 of the book */
public class TodoController : Controller
{
    private readonly ITodoItemService _todoItemService;
    public TodoController(ITodoItemService todoItemService)
    {
        _todoItemService = todoItemService;
    }
    public IActionResult Index()
    {

        // Get to-do items from database
        // Put items into a model
        // Pass the view to a model and render
    }
}