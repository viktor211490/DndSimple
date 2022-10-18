﻿using System.Globalization;
using CsvHelper.Configuration;
using DndSimple.Application.TodoLists.Queries.ExportTodos;

namespace DndSimple.Infrastructure.Files.Maps;
public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).ConvertUsing(c => c.Done ? "Yes" : "No");
    }
}
