namespace StarlightExampleExpansion.Commands;

internal class TranslateCommand : StarlightCommand
{
    public override string ID => "translate";
    public override string Usage => "translate";
    public override CommandType type => CommandType.Miscellaneous;

    public override bool Execute(string[] args)
    {
        // This command requires no arguments
        if (!args.IsBetween(0,0)) return SendNoArguments();

        
        // The translations are defined in Assets/translations.csv
        SendMessageTr("cmd.translate.success","hello");
        // or:
        // SendMessage(Tr("cmd.translate.success","hello"));
        return true;
    }
}
