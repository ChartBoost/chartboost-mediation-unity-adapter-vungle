# Chartboost Mediation Unity SDK - Vungle Adapter

Provides a list of externally configurable properties pertaining to the partner SDK that can be retrieved and set by publishers. 

Dependencies for the adapter are now embedded in the package, and can be found at `com.chartboost.mediation.unity.adapter.vungle/Editor/VungleAdapterDependencies.xml`.

# Installation

## Using the public [npm registry](https://www.npmjs.com/search?q=com.chartboost.mediation.unity.adapter.vungle)

In order to add the Chartboost Mediation Unity SDK - Vungle Adapter to your project using the npm package, add the following to your Unity Project's ***manifest.json*** file. The scoped registry section is required in order to fetch packages from the NpmJS registry.

```json
"dependencies": {
    "com.chartboost.mediation.unity.adapter.vungle": "5.0.0",
    ...
},
"scopedRegistries": [
{
    "name": "NpmJS",
    "url": "https://registry.npmjs.org",
    "scopes": [
    "com.chartboost"
    ]
}
]
```
## Using the public [NuGet package](https://www.nuget.org/packages/Chartboost.CSharp.Mediation.Unity.Adapter.Vungle)

To add the Chartboost Mediation Unity SDK - Vungle Adapter to your project using the NuGet package, you will first need to add the [NugetForUnity](https://github.com/GlitchEnzo/NuGetForUnity) package into your Unity Project.

This can be done by adding the following to your Unity Project's ***manifest.json***

```json
  "dependencies": {
    "com.github-glitchenzo.nugetforunity": "https://github.com/GlitchEnzo/NuGetForUnity.git?path=/src/NuGetForUnity",
    ...
  },
```

Once <code>NugetForUnity</code> is installed, search for `Chartboost.CSharp.Mediation.Unity.Adapter.Vungle` in the search bar of Nuget Explorer window(Nuget -> Manage Nuget Packages).
You should be able to see the `Chartboost.CSharp.Mediation.Unity.Adapter.Vungle` package. Choose the appropriate version and install.

# Usage
The following code block exemplifies usage of the `VungleAdapter.cs` configuration class.

## IPartnerAdapterConfiguration Properties

```csharp

// AdapterUnityVersion - The partner adapter Unity version, e.g: 5.0.0
Debug.Log($"Adapter Unity Version: {VungleAdapter.AdapterUnityVersion}");

// AdapterNativeVersion - The partner adapter version, e.g: 5.12.5.0.0
Debug.Log($"Adapter Native Version: {VungleAdapter.AdapterNativeVersion}");

// PartnerSDKVersion - The partner SDK version, e.g: 12.5.0
Debug.Log($"Partner SDK Version: {VungleAdapter.PartnerSDKVersion}");

// PartnerIdentifier - The partner ID for internal uses, e.g: Vungle
Debug.Log($"Partner Identifier: {VungleAdapter.PartnerIdentifier}");

// PartnerDisplayName - The partner name for external uses, e.g: Vungle
Debug.Log($"Partner Display Name: {VungleAdapter.PartnerDisplayName}");
```

## Back Button Inmediately Enabled

If the platform supports it, Vungle will check if it has an ad that can be rendered in the specified orientation. This flag can be set at any time and will take effect on the next ad request.

```csharp
// Enabled
VungleAdapter.BackButtonImmediatelyEnabled = true;

// Disabled
VungleAdapter.BackButtonImmediatelyEnabled = false;
```

## Ad Orientation
If the platform supports it, Vungle will check if it has an ad that can be rendered in the specified orientation. This flag can be set at any time and will take effect on the next ad request.

```csharp
// Portrait
VungleAdapter.AdOrientation = VungleAdOrientation.PORTRAIT;

// Landscape
VungleAdapter.AdOrientation = VungleAdOrientation.LANDSCAPE;

// Auto-Rotate
VungleAdapter.AdOrientation = VungleAdOrientation.AUTO_ROTATE;
```

## Set GDPR Status Override
Use to manually set the GDPR consent status on the Vungle SDK. This is generally unnecessary as the Mediation SDK will set the consent status automatically based on the latest consent info.

```csharp
// Consent
VungleAdapter.SetGDPRStatusOverride(true);


// No Consent
VungleAdapter.SetGDPRStatusOverride(false);
```

## Set CCPA Status Override

Use to manually set the CCPA consent status on the Vungle SDK. This is generally unnecessary as the Mediation SDK will set the consent status automatically based on the latest consent info.

```csharp
// Consent
VungleAdapter.SetCCPAStatusOverride(true);

// No Consent
VungleAdapter.SetCCPAStatusOverride(false);
```