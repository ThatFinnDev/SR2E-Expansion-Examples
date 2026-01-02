namespace ExampleExpansion.Commands;

internal class AdditionCommand : SR2ECommand
{
    public override string ID => "addition";
    // Use <> for mandatory arguments and [] for optional arguments
    public override string Usage => "addition <number1> [number2]";
    // Specify the command type, you can also specify multiple categories
    public override CommandType type => CommandType.Fun;

    public override List<string> GetAutoComplete(int argIndex, string[] args)
    {
        if (argIndex == 0)
            return new List<string> { "1", "5", "10", "20", "30", "50" };
        if (argIndex == 1)
            return new List<string> { "1", "5", "10", "20", "30", "50" };

        return null;
    }

    public override bool Execute(string[] args)
    {
        // This command requires exactly 2 arguments
        if (!args.IsBetween(2,2)) return SendNoArguments();

        // Parse argument into float and if it fails, return fails
        // TryParseFloat automatically sends an error message
        if (!TryParseFloat(args[0], out float number1)) return false;
        
        if (!TryParseFloat(args[1], out float number2)) return false;
        
        SendMessage($"The sum of {args[0]} and {args[1]} is {number1+number2}");
        
        //Return true if the command was a success
        return true;
    }
}
