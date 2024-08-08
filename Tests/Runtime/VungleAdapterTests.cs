using Chartboost.Logging;
using Chartboost.Mediation.Vungle;
using Chartboost.Mediation.Vungle.Common;
using Chartboost.Tests.Runtime;
using NUnit.Framework;

namespace Chartboost.Tests
{
    internal class VungleAdapterTests
    {
        [SetUp]
        public void SetUp()
        {
            LogController.LoggingLevel = LogLevel.Debug;
            Assert.AreEqual(null, VungleAdapter.AdOrientation);
        }

        [TearDown]
        public void TearDown()
        {
            VungleAdapter.AdOrientation = null;
            Assert.AreEqual(null,  VungleAdapter.AdOrientation);
        }

        [Test]
        public void AdapterNativeVersion()
            => TestUtilities.TestStringGetter(() => VungleAdapter.AdapterNativeVersion);

        [Test]
        public void PartnerSDKVersion()
            => TestUtilities.TestStringGetter(() => VungleAdapter.PartnerSDKVersion);

        [Test]
        public void PartnerIdentifier()
            => TestUtilities.TestStringGetter(() => VungleAdapter.PartnerIdentifier);

        [Test]
        public void PartnerDisplayName()
            => TestUtilities.TestStringGetter(() => VungleAdapter.PartnerDisplayName);

        [Test]
        public void BackButtonImmediatelyEnabled() 
            => TestUtilities.TestBooleanAccessor(() => VungleAdapter.BackButtonImmediatelyEnabled, value => VungleAdapter.BackButtonImmediatelyEnabled = value);

        [Test]
        public void AdOrientationPortrait()
        {
            VungleAdapter.AdOrientation = VungleAdOrientation.PORTRAIT;
            Assert.AreEqual(VungleAdOrientation.PORTRAIT,  VungleAdapter.AdOrientation);
        }

        [Test]
        public void AdOrientationLandscape()
        {
            VungleAdapter.AdOrientation = VungleAdOrientation.LANDSCAPE;
            Assert.AreEqual(VungleAdOrientation.LANDSCAPE,  VungleAdapter.AdOrientation);
        }

        [Test]
        public void AdOrientationAutoRotate()
        {
            VungleAdapter.AdOrientation = VungleAdOrientation.AUTO_ROTATE;
            Assert.AreEqual(VungleAdOrientation.AUTO_ROTATE,  VungleAdapter.AdOrientation);
        }

        [Test, Order(0)]
        public void SetGDPRStatusTrue()
            => VungleAdapter.SetGDPRStatusOverride(true);
        
        [Test, Order(1)]
        public void SetGDPRStatusFalse()
            => VungleAdapter.SetGDPRStatusOverride(false);

        [Test, Order(0)]
        public void SetCCPAStatusTrue()
            => VungleAdapter.SetCCPAStatusOverride(true);
            
        [Test, Order(1)]
        public void SetCCPAStatusFalse()
            => VungleAdapter.SetCCPAStatusOverride(false);
    }
}
