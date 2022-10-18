using DndSimple.Application.Common.Mappings;
using DndSimple.Domain.Entities;

namespace DndSimple.Application.TodoLists.Queries.ExportTodos;
public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
