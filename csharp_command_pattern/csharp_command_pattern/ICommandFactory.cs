namespace command_design_pattern
{
    internal interface ICommandFactory
    {
        string CommandName { get; }

        ICommand MakeCommand(string arg);
    }
}