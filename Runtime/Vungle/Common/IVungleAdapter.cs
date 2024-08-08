using Chartboost.Mediation.Adapters;

namespace Chartboost.Mediation.Vungle.Common
{
    #nullable enable
    /// <summary>
    /// The Chartboost Mediation Vungle adapter.
    /// </summary>
    internal interface IVungleAdapter : IPartnerAdapterConfiguration
    {
        /// <summary>
        /// Flag to optionally set to specify whether the back button will be immediately enabled during the video ad, or it will be inactive until the on screen close button appears (the default behavior). It can be set at any time and will take effect on the next ad request.
        /// <br/>
        /// If the platform supports it, the back button allows the user to skip the video ad and proceed to the post-roll if one exists. If the ad does not have a post-roll, it simply ends.
        /// </summary>
        public bool BackButtonImmediatelyEnabled { get; set; }
 
        /// <summary>
        /// If the platform supports it, Vungle will check if it has an ad that can be rendered in the specified orientation. This flag can be set at any time and will take effect on the next ad request.
        /// </summary>
        public VungleAdOrientation? AdOrientation { get; set; }

        /// <summary>
        /// Use to manually set the GDPR consent status on the Vungle SDK.
        /// This is generally unnecessary as the Mediation SDK will set the consent status automatically based on the latest consent info.
        /// </summary>
        public void SetGDPRStatusOverride(bool gdprStatus);

        /// <summary>
        /// Use to manually set the CCPA consent status on the Vungle SDK.
        /// This is generally unnecessary as the Mediation SDK will set the consent status automatically based on the latest consent info.
        /// </summary>
        public void SetCCPAStatusOverride(bool ccpaStatus);
    }
}
