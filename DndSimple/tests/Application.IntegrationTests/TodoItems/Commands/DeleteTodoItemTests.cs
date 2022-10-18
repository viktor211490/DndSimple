﻿using DndSimple.Application.Common.Exceptions;
using DndSimple.Application.TodoItems.Commands.CreateTodoItem;
using DndSimple.Application.TodoItems.Commands.DeleteTodoItem;
using DndSimple.Application.TodoLists.Commands.CreateTodoList;
using DndSimple.Domain.Entities;
using FluentAssertions;
using NUnit.Framework;

using static Testing;

namespace DndSimple.Application.IntegrationTests.TodoItems.Commands;
public class DeleteTodoItemTests : BaseTestFixture
{
    [Test]
    public async Task ShouldRequireValidTodoItemId()
    {
        var command = new DeleteTodoItemCommand(99);

        await FluentActions.Invoking(() =>
            SendAsync(command)).Should().ThrowAsync<NotFoundException>();
    }

    [Test]
    public async Task ShouldDeleteTodoItem()
    {
        var listId = await SendAsync(new CreateTodoListCommand
        {
            Title = "New List"
        });

        var itemId = await SendAsync(new CreateTodoItemCommand
        {
            ListId = listId,
            Title = "New Item"
        });

        await SendAsync(new DeleteTodoItemCommand(itemId));

        var item = await FindAsync<TodoItem>(itemId);

        item.Should().BeNull();
    }
}
