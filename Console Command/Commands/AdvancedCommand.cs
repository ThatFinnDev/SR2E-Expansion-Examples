namespace StarlightExampleExpansion.Commands;

internal class AdvancedCommand : StarlightCommand
{
    public override string ID => "advanced";
    // Use <> for mandatory arguments and [] for optional arguments
    public override string Usage => "advanced <text> [text]";
    // Specify the command type, you can also specify multiple categories
    public override CommandType type => CommandType.Fun;

    public override List<string> GetAutoComplete(int argIndex, string[] args)
    {
        // Get vaccables as autocomplete as an example
        if (argIndex == 0)
            return LookupEUtil.GetVaccableStringListByPartialName(args == null ? null : args[0], true,MAX_AUTOCOMPLETE.Get());
        if (argIndex == 1)
            return new List<string> { "1", "5", "10", "20", "30", "50" };

        return null;
    }
    public override bool Execute(string[] args)
    {
        // This command requires 1-2 arguments
        if (!args.IsBetween(1,2)) return SendNoArguments();

        // This command only works in a save
        if (!inGame) return SendLoadASaveFirst();
        
        SendMessage("The first argument is "+args[0]);
        if(args.Length==2)
            SendMessage("The second argument is "+args[1]);
        
        //Return true if the command was a success
        return true;
    }

    public override void AfterGameContext(GameContext gameContext)
    {
        // Acquire custom things for your command
    }
}
