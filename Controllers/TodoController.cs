using Microsoft.AspNetCore.Mvc;


public class TodoController : Controller
{
    // http://localhost:1234/todo/getnome
    public string GetNome()
    {
        return "Fulano";
    }
}