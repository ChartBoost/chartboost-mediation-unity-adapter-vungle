using Chartboost.Mediation.Adapters;
using Chartboost.Mediation.Vungle.Common;
using Chartboost.Mediation.Vungle.Default;

namespace Chartboost.Mediation.Vungle
{
    /// <inheritdoc cref="IVungleAdapter"/>
    public static class VungleAdapter 
    {
        internal static IVungleAdapter Instance = new VungleDefault();
        
        /// <summary>
        /// The partner adapter Unity version.
        /// </summary>
        public const string AdapterUnityVersion = "5.0.0";
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.AdapterNativeVersion"/>
        public static string AdapterNativeVersion => Instance.AdapterNativeVersion;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerSDKVersion"/>
        public static string PartnerSDKVersion => Instance.PartnerSDKVersion;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerIdentifier"/>
        public static string PartnerIdentifier => Instance.PartnerIdentifier;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerDisplayName"/>
        public static string PartnerDisplayName => Instance.PartnerDisplayName;

        /// <inheritdoc cref="IVungleAdapter.BackButtonImmediatelyEnabled"/>
        public static bool BackButtonImmediatelyEnabled
        {
            get => Instance.BackButtonImmediatelyEnabled;
            set => Instance.BackButtonImmediatelyEnabled = value;
        }

        /// <inheritdoc cref="IVungleAdapter.AdOrientation"/>
        public static VungleAdOrientation? AdOrientation
        {
            get => Instance.AdOrientation;
            set => Instance.AdOrientation = value;
        }

        /// <inheritdoc cref="IVungleAdapter.SetGDPRStatusOverride"/>
        public static void SetGDPRStatusOverride(bool gdprStatus)
            => Instance.SetGDPRStatusOverride(gdprStatus);

        /// <inheritdoc cref="IVungleAdapter.SetCCPAStatusOverride"/>
        public static void SetCCPAStatusOverride(bool ccpaStatus)
            => Instance.SetCCPAStatusOverride(ccpaStatus);
    }
}
