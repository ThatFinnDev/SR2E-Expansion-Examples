namespace ExampleExpansion.Commands;

internal class ManualLoadingCommand : SR2ECommand
{
    public override string ID => "manual";
    public override string Usage => "manual";
    // DontLoad will stop the command from registering automatically, check ExpansionEntrypoint
    public override CommandType type => CommandType.Miscellaneous | CommandType.DontLoad;

    public override bool Execute(string[] args)
    {
        // This command requires no arguments
        if (!args.IsBetween(0,0)) return SendNoArguments();

        SendMessage("This command was manually registered");
        return true;
    }
}
