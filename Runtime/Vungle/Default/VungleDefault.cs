using Chartboost.Logging;
using Chartboost.Mediation.Vungle.Common;

namespace Chartboost.Mediation.Vungle.Default
{
    internal class VungleDefault : IVungleAdapter
    {
        /// <inheritdoc/>
        public string AdapterNativeVersion => VungleAdapter.AdapterUnityVersion;

        /// <inheritdoc/>
        public string PartnerSDKVersion => VungleAdapter.AdapterUnityVersion;
        
        /// <inheritdoc/>
        public string PartnerIdentifier => "vungle";
        
        /// <inheritdoc/>
        public string PartnerDisplayName => "Vungle";

        /// <inheritdoc/>
        public bool BackButtonImmediatelyEnabled { get; set; }
        
        /// <inheritdoc/>
        public VungleAdOrientation? AdOrientation { get; set; }

        /// <inheritdoc/>
        public void SetGDPRStatusOverride(bool gdprStatus)
            => LogController.Log($"{nameof(SetGDPRStatusOverride)} does nothing on {nameof(VungleDefault)}", LogLevel.Info);

        /// <inheritdoc/>
        public void SetCCPAStatusOverride(bool ccpaStatus)
            => LogController.Log($"{nameof(SetGDPRStatusOverride)} does nothing on {nameof(VungleDefault)}", LogLevel.Info);
    }
}
