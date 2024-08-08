using System.Runtime.InteropServices;
using Chartboost.Constants;
using Chartboost.Mediation.Vungle.Common;
using UnityEngine;

namespace Chartboost.Mediation.Vungle.IOS
{
    internal sealed class VungleAdapter : IVungleAdapter
    {
        [RuntimeInitializeOnLoadMethod]
        private static void RegisterInstance()
        {
            if (Application.isEditor)
                return;
            Vungle.VungleAdapter.Instance = new VungleAdapter();
        }

        /// <inheritdoc/>
        public string AdapterNativeVersion => _CBMVungleAdapterAdapterVersion();
        
        /// <inheritdoc/>
        public string PartnerSDKVersion => _CBMVungleAdapterPartnerSDKVersion();
        
        /// <inheritdoc/>
        public string PartnerIdentifier => _CBMVungleAdapterPartnerId();
        
        /// <inheritdoc/>
        public string PartnerDisplayName => _CBMVungleAdapterPartnerDisplayName();
        
        /// <inheritdoc/>
        public bool BackButtonImmediatelyEnabled { get; set; }
        
        /// <inheritdoc/>
        public VungleAdOrientation? AdOrientation { get; set; }
        
        /// <inheritdoc/>
        public void SetGDPRStatusOverride(bool gdprStatus) 
            => _CBMVungleAdapterSetGDPRStatusOverride(gdprStatus);

        /// <inheritdoc/>
        public void SetCCPAStatusOverride(bool ccpaStatus) 
            => _CBMVungleAdapterSetCCPAStatusOverride(ccpaStatus);

        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMVungleAdapterAdapterVersion();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMVungleAdapterPartnerSDKVersion();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMVungleAdapterPartnerId();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMVungleAdapterPartnerDisplayName();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern void _CBMVungleAdapterSetGDPRStatusOverride(bool gdprStatus);
        [DllImport(SharedIOSConstants.DLLImport)] private static extern void _CBMVungleAdapterSetCCPAStatusOverride(bool ccpaStatus);
    }
}
