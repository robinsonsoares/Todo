using System;
using System.Collections.Generic;
using Todo.Domain.Entities;
using Todo.Domain.Repositories;

namespace Todo.Domain.Tests.Repositories
{
    public class FakeTodoRepository : ITodoRepository
    {
        public void Create(TodoItem todo)
        {

        }

        TodoItem ITodoRepository.GetById(Guid id, string user)
        {
            return new TodoItem("Titulo Aqui", "Brian Bob", DateTime.Now);
        }

        public void Update(TodoItem todo)
        {

        }

        IEnumerable<TodoItem> ITodoRepository.GetAll(string user)
        {
            throw new NotImplementedException();
        }

        IEnumerable<TodoItem> ITodoRepository.GetAllDone(string user)
        {
            throw new NotImplementedException();
        }

        IEnumerable<TodoItem> ITodoRepository.GetAllUndone(string user)
        {
            throw new NotImplementedException();
        }

        IEnumerable<TodoItem> ITodoRepository.GetByPeriod(string user, DateTime date, bool done)
        {
            throw new NotImplementedException();
        }
    }
}