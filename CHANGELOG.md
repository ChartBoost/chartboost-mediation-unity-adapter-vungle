# Changelog
All notable changes to this project will be documented in this file using the standards as defined at [Keep a Changelog](https://keepachangelog.com/en/1.0.0/). This project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0).

### Version 5.0.6 *(2026-01-30)*
This version of the Vungle Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-vungle:5.7.6.+`
  * iOS: `ChartboostMediationAdapterVungle: ~> 5.7.7.0`

### Version 5.0.5 *(2025-11-20)*
This version of the Vungle Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-vungle:5.7.6.+`
  * iOS: `ChartboostMediationAdapterVungle: ~> 5.7.6.0`

### Version 5.0.4 *(2025-09-26)*
This version of the Vungle Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-vungle:5.7.5.+`
  * iOS: `ChartboostMediationAdapterVungle: ~> 5.7.6.0`

### Version 5.0.3 *(2025-06-02)*
This version of the Vungle Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-vungle:5.7.5.+`
  * iOS: `ChartboostMediationAdapterVungle: ~> 5.7.5.0`

### Version 5.0.2 *(2025-06-02)*
This version of the Vungle Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-vungle:5.7.5.+`
  * iOS: `ChartboostMediationAdapterVungle: ~> 5.7.4.0`

### Version 5.0.1 *(2024-10-23)*
This version of the Vungle Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-vungle:5.7.4.+`
  * iOS: `ChartboostMediationAdapterVungle: ~> 5.7.4.0`

### Version 5.0.0 *(2024-08-08)*

First version of the Chartboost Mediation Unity SDK - Vungle Adapter.

#Added
- Support for the following `Vungle` dependencies. Notice adapter dependencies are optimistic and any patches and hot-fixes will be automatically picked up.:
    * Android: `com.chartboost:chartboost-mediation-adapter-vungle:5.7.4.+`
    * iOS: `ChartboostMediationAdapterVungle ~> 5.7.3.0`
    
- `VungleAdapter.cs` with Configuration Properties for `Vungle`.
- The following properties have been added in `VungleAdapter.cs`
    * `string AdapterUnityVersion`
    * `string AdapterNativeVersion`
    * `string PartnerSDKVersion`
    * `string PartnerIdentifier`
    * `string PartnerDisplayName`
    * `bool BackButtonImmediatelyEnabled`
    * `VungleAdOrientation? AdOrientation`
    * `bool VerboseLogging`

- The following methods have been added in `VungleAdapter.cs`
    * `void SetGDPRStatusOverride(bool gdprStatus)`
    * `void SetCCPAStatusOverride(bool ccpaStatus)`
