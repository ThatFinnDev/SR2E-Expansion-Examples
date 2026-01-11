using System.IO;
using Il2CppMonomiPark.SlimeRancher;
using SR2E.Expansion;
using SR2E.Saving;
using SR2E.Storage;
using SR2E.Utils;

namespace ExampleExpansion;


public class ExampleExpansionEntrypoint : SR2EExpansionV3
{
    public override void OnInitializeMelon()
    {
        AddLanguages(EmbeddedResourceEUtil.LoadString("translations.csv"));
    }
}

