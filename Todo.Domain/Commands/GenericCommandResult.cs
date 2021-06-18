namespace Todo.Domain.Commands.Contracts
{
    public class GenericCommandResult : ICommandResult
    {
        public GenericCommandResult() { }

        public GenericCommandResult(bool success, string messsage, object data)
        {
            Success = success;
            Messsage = messsage;
            Data = data;
        }

        public bool Success { get; set; }
        public string Messsage { get; set; }
        public object Data { get; set; }

    }
}