using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace FileSystem;

public class CommandFactory
{
    public ICommand GetCommand(string command, IOutputwriter outputwriter)
    {
    }

    public IList<string> GetCommands()
    {
        return new List<string>();
    }
}