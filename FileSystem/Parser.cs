namespace FileSystem;

public class Parser
{
    public List<string> commands;

    public Parser(List<string> commands)
    {
        this.commands = commands;
    }

    public string ParseCommand(string command)
    {
        return command;
    }

    public string ParseParameters(string parameter)
    {
        return parameter;
    }
}