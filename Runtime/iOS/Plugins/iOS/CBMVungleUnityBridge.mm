#import "CBMDelegates.h"
#import "ChartboostUnityUtilities.h"
#import <ChartboostMediationAdapterVungle/ChartboostMediationAdapterVungle-Swift.h>

extern "C" {

    const char * _CBMVungleAdapterAdapterVersion(){
        return toCStringOrNull([VungleAdapterConfiguration adapterVersion]);
    }

    const char * _CBMVungleAdapterPartnerSDKVersion(){
        return toCStringOrNull([VungleAdapterConfiguration partnerSDKVersion]);
    }

    const char * _CBMVungleAdapterPartnerId(){
        return toCStringOrNull([VungleAdapterConfiguration partnerID]);
    }

    const char * _CBMVungleAdapterPartnerDisplayName(){
        return toCStringOrNull([VungleAdapterConfiguration partnerDisplayName]);
    }

    void _CBMVungleAdapterSetGDPRStatusOverride(BOOL gdprStatus){
        [VungleAdapterConfiguration setGDPRStatusOverride:gdprStatus];
    }

    void _CBMVungleAdapterSetCCPAStatusOverride(BOOL ccpaStatus){
        [VungleAdapterConfiguration setCCPAStatusOverride:ccpaStatus];
    }
}
