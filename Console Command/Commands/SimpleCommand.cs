namespace StarlightExampleExpansion.Commands;

internal class SimpleCommand : StarlightCommand
{
    public override string ID => "simple";
    public override string Usage => "simple";
    public override CommandType type => CommandType.Common;

    public override bool Execute(string[] args)
    {
        // This command requires no arguments
        if (!args.IsBetween(0,0)) return SendNoArguments();

        SendMessage("Yay, it worked!");
        return true;
    }
}
