namespace Admin.Domain.Commands.Input;

public class DeleteProductCommand
{
    public DeleteProductCommand(int id)
    {
        Id = id;
    }
    public int Id { get; private set; }
}