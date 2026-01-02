using ExampleExpansion.Commands;
using SR2E.Expansion;
using SR2E.Managers;

namespace ExampleExpansion;


public class ExampleExpansionEntrypoint : SR2EExpansionV3
{
    public override void OnInitializeMelon()
    {
        AddLanguages(EmbeddedResourceEUtil.LoadString("translations.csv"));
    }

    public override void LoadCommands()
    {
        SR2ECommandManager.RegisterCommand(new ManualLoadingCommand());
    }
}

