using MelonLoader;
using BTD_Mod_Helper;
using SashaTest;

[assembly: MelonInfo(typeof(SashaTest.SashaTest), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace SashaTest;

public class SashaTest : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<SashaTest>("SashaTest loaded!");
    }
}