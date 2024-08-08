
using Chartboost.Constants;
using Chartboost.Mediation.Vungle.Common;
using UnityEngine;

namespace Chartboost.Mediation.Vungle.Android
{
    internal sealed class VungleAdapter : IVungleAdapter
    {
        private const string VungleAdapterConfiguration = "com.chartboost.mediation.vungleadapter.VungleAdapterConfiguration";

        private const string FunctionGetBackButtonImmediatelyEnabled = "getBackBtnImmediatelyEnabled";
        private const string FunctionSetBackButtonImmediatelyEnabled = "setBackBtnImmediatelyEnabled";
        private const string FunctionIntValue = "intValue";
        private const string FunctionGetAdOrientation = "getAdOrientation";
        private const string FunctionSetAdOrientation = "setAdOrientation";
        private const string FunctionSetGdprStatusOverride = "setGdprStatusOverride";
        private const string FunctionSetCcpaStatusOverride = "setCcpaStatusOverride";
        
        [RuntimeInitializeOnLoadMethod]
        private static void RegisterInstance()
        {
            if (Application.isEditor)
                return;
            Vungle.VungleAdapter.Instance = new VungleAdapter();
        }
        
        /// <inheritdoc/>
        public string AdapterNativeVersion
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(VungleAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetAdapterVersion);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerSDKVersion 
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(VungleAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerSdkVersion);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerIdentifier
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(VungleAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerId);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerDisplayName 
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(VungleAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerDisplayName);
            }
        }

        /// <inheritdoc/>
        public bool BackButtonImmediatelyEnabled
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(VungleAdapterConfiguration);
                return adapterConfiguration.Call<bool>(FunctionGetBackButtonImmediatelyEnabled);
            }
            set
            {
                using var adapterConfiguration = new AndroidJavaObject(VungleAdapterConfiguration);
                adapterConfiguration.Call(FunctionSetBackButtonImmediatelyEnabled, value);
            }
        }
        
        /// <inheritdoc/>
        public VungleAdOrientation? AdOrientation {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(VungleAdapterConfiguration);
                using var nativeOrientationValue = adapterConfiguration.Call<AndroidJavaObject>(FunctionGetAdOrientation);

                if (nativeOrientationValue == null) 
                    return null;
                
                var nativeIntValue = nativeOrientationValue.Call<int>(FunctionIntValue);

                if (nativeIntValue == -1)
                    return null;

                return (VungleAdOrientation)nativeIntValue;
            }
            set
            {
                using var adapterConfiguration = new AndroidJavaObject(VungleAdapterConfiguration);

                if (value.HasValue)
                {
                    var valueAsInt = (int)value;
                    adapterConfiguration.Call(FunctionSetAdOrientation, valueAsInt.GetNativeInt());
                }
                else
                {
                    const int valueAsInt = -1;
                    adapterConfiguration.Call(FunctionSetAdOrientation, valueAsInt.GetNativeInt());
                }
            }
        }

        /// <inheritdoc/>
        public void SetGDPRStatusOverride(bool gdprStatus)
        {
            using var adapterConfiguration = new AndroidJavaObject(VungleAdapterConfiguration);
            adapterConfiguration.Call(FunctionSetGdprStatusOverride, gdprStatus);
        }

        /// <inheritdoc/>
        public void SetCCPAStatusOverride(bool ccpaStatus)
        {
            using var adapterConfiguration = new AndroidJavaObject(VungleAdapterConfiguration);
            adapterConfiguration.Call(FunctionSetCcpaStatusOverride, ccpaStatus);
        }
    }
}
