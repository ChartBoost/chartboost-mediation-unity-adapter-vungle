using System.Runtime.CompilerServices;
using Chartboost.Mediation.Vungle;
using UnityEngine.Scripting;

[assembly: AlwaysLinkAssembly]
[assembly: InternalsVisibleTo(AssemblyInfo.VungleAssemblyInfoAndroid)]
[assembly: InternalsVisibleTo(AssemblyInfo.VungleAssemblyInfoIOS)]

namespace Chartboost.Mediation.Vungle
{
    internal class AssemblyInfo
    {
        public const string VungleAssemblyInfoAndroid = "Chartboost.Mediation.Vungle.Android";
        public const string VungleAssemblyInfoIOS = "Chartboost.Mediation.Vungle.IOS";
    }
}
