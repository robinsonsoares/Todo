using System;
using Flunt.Notifications;
using Flunt.Validations;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class CreateTodoCommand : Notifiable, Icommand
    {
        public CreateTodoCommand() { }

        public CreateTodoCommand(string title, string user, DateTime date)
        {
            Title = title;
            User = user;
            Date = date;
        }

        public string Title { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }

        public void Validate()
        {
            // Errado
            /* if (Title.Length < 4)
                throw new Exception("Titulo inválido");

            if (User.Length < 4)
                throw new Exception("Usuário inválido"); */

            //Design by Contracts
            AddNotifications(
                new Contract()
                    .Requires()
                    .HasMinLen(Title, 3, "Title", "Por favor, descreva melhor essa tarefa!")
                    .HasMinLen(User, 6, "User", "Usuário inválido!")
            );

        }
    }
}