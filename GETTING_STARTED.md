## Getting Started

You will need to clone the repo using GitHub desktop or a similiar tool, since using the download zip button does not seem to download all the files properly.

### Prerequisites

Import [PolyToolkit](https://www.assetstore.unity3d.com/en/#!/content/104464) from the Unity Asset Store.

(Optional) Import [ProBuilder](https://assetstore.unity.com/packages/tools/modeling/probuilder-111418 "probuilder") from the Unity Asset Store.


### Importing new models

Select Poly in the file menu, and click browse assets. From there you can search for 3D models to import into your project. See the Wiki for other sources

### Setting up new scenes

Click File - New Scene, and drag in the Room prefab from the Prefabs folder. Then drag in the [VRTK_SDKManager] prefab and the Controllers prefab. Set the Right and Left Controller variable of the [VRTK_SDKManager] to the controllers you just made.

### Using other VR SDKs

By default, VR-Educational-Toolkit uses SteamVR, which supports a variety of PC-based headsets. However because VRET uses VRTK, it is easy to add support for other SDKs. [See here for setup info](https://github.com/thestonefox/VRTK/blob/master/Assets/VRTK/Documentation/GETTING_STARTED.md).
