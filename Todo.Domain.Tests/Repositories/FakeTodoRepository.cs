using System;
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

    }
}