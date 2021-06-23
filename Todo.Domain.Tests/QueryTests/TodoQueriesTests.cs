
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Entities;
using Todo.Domain.Queries;

namespace Todo.Domain.Tests.QueryTests
{
    [TestClass]
    public class TodoQueryTests
    {

        private List<TodoItem> _items;

        public TodoQueryTests()
        {
            _items = new List<TodoItem>();
            _items.Add(new TodoItem("Tarefa 1", "usuarioA", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 2", "usuarioB", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 3", "brianbob", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 4", "usuarioC", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 5", "brianbob", DateTime.Now));
        }


        [TestMethod]
        public void Deve_retornar_tarefas_apneas_do_usuario_brianbob()
        {

            var result = _items.AsQueryable().Where(TodoQueries.GetAll("brianbob"));
            Assert.AreEqual(2, result.Count());

        }

    }
}