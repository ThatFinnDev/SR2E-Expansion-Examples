namespace ExampleExpansion.Commands;

internal class TranslateCommand : SR2ECommand
{
    public override string ID => "translate";
    public override string Usage => "translate";
    public override CommandType type => CommandType.Miscellaneous;

    public override bool Execute(string[] args)
    {
        // This command requires no arguments
        if (!args.IsBetween(0,0)) return SendNoArguments();

        SendMessage(translation("cmd.translate.success","hello"));
        return true;
    }
}
