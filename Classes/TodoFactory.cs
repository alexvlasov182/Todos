using System;

namespace Todos.Classes;

public class TodoFactory
{
  List<Todo> todos = new() { new Todo { Id = 1, Completed = true, Title = "Do something" } };

  public List<Todo> Get() => todos.GetRange(0, todos.Count);

  public bool Update(object completed, Todo todo)
  {
    try
    {
      todo.Completed = (bool)completed;
    }
    catch
    {
      return false;
    }

    return true;
  }
  public void Delete(Todo todo) => todos.Remove(todo);
  public void Add(string description)
  {
    if (description.Length.Equals(0)) throw new ArgumentException("Illegal to-do description.");
    try
    {
      var id = todos.Count().Equals(0) ? 1 : todos.Max(t => t.Id) + 1;
      var todo = new Todo { Id = id, Completed = false, Title = description };
      todos.Add(todo);
    }
    catch { throw; }
  }
}


