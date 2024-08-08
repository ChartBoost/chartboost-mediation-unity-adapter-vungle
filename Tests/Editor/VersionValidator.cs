using Chartboost.Editor;
using Chartboost.Logging;
using Chartboost.Mediation.Vungle;
using NUnit.Framework;

namespace Chartboost.Tests.Editor
{
    internal class VersionValidator
    {
        private const string UnityPackageManagerPackageName = "com.chartboost.mediation.unity.adapter.vungle";
        private const string NuGetPackageName = "Chartboost.CSharp.Mediation.Unity.Adapter.Vungle";
        
        [SetUp]
        public void SetUp() 
            => LogController.LoggingLevel = LogLevel.Debug;
            
        [Test]
        public void ValidateVersion() 
            => VersionCheck.ValidateVersions(UnityPackageManagerPackageName, NuGetPackageName, VungleAdapter.AdapterUnityVersion);
    }
}
