namespace ExampleExpansion.Commands;

internal class ErrorCommand : SR2ECommand
{
    public override string ID => "error";
    public override string Usage => "error";
    public override CommandType type => CommandType.Common;

    public override bool Execute(string[] args)
    {
        // This command requires no arguments
        if (!args.IsBetween(0,0)) return SendNoArguments();

        
        // Every "Send" function that sends an error, ALWAYS returns false
        return SendError("This is a custom error!");
    }
}