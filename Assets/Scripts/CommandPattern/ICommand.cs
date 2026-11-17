public interface ICommand
{
    void Execute();
    void Undo();
}

public class MoveUpCommand : ICommand
{
    private PlayerController Player;
    public MoveUpCommand(PlayerController player)
    {
        Player = player;
    }
    public void Execute()
    {
        Player.MoveUp();
    }
    public void Undo()
    {
        Player.MoveDown();
    }
}

public class MoveDownCommand : ICommand
{
    private PlayerController Player;

    public MoveDownCommand(PlayerController player)
    {
        Player = player;
    }

    public void Execute()
    {
        Player.MoveDown();
    }

    public void Undo()
    {
        Player.MoveUp();
    }
}

public class MoveRightCommand : ICommand
{
    private PlayerController Player;

    public MoveRightCommand(PlayerController player)
    {
        Player = player;
    }

    public void Execute()
    {
        Player.MoveRight();
    }

    public void Undo()
    {
        Player.MoveLeft();
    }
}

public class MoveLeftCommand : ICommand
{
    private PlayerController Player;

    public MoveLeftCommand(PlayerController player)
    {
        Player = player;
    }

    public void Execute()
    {
        Player.MoveLeft();
    }

    public void Undo()
    {
        Player.MoveRight();
    }
}