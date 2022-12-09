---
permalink: /ManualInstallation.html
title: Manual Installation
description: the flat-pack Kiea instructions, written in Kerbalese, unusally present
tags: installation,directions,page,kerbal,ksp,zer0Kerbal,zedK
---

<!-- ManualInstallation.md v1.1.8.1
SpaceY Lifters (SYL)
created: 01 Oct 2019
updated: 29 Jul 2022 -->

<!-- based upon work by Lisias -->

# SpaceY Lifters (SYL)

[Home](./index.md)

Parts for large lifting rockets, 5m rocket parts and large SRBs, and matching decouplers for Kerbal Space Program.

## Installation Instructions

### Using CurseForge/OverWolf app or CKAN

You should be all good! (check for latest version on CurseForge)

### If Downloaded from CurseForge/OverWolf manual download

To install, place the `NecroBones` folder inside your Kerbal Space Program's GameData folder:

* **REMOVE ANY OLD VERSIONS OF THE PRODUCT BEFORE INSTALLING**
  * Delete `<KSP_ROOT>/GameData/NecroBones/SpaceYLifters`
* Extract the package's `NecroBones` folder into your KSP's GameData folder as follows:
  * `<PACKAGE>/NecroBones/` --> `<KSP_ROOT>/GameData`
    * Overwrite any preexisting folder/file(s).
  * you should end up with `<KSP_ROOT>/GameData/NecroBones/SpaceYLifters`

### If Downloaded from SpaceDock / GitHub / other

To install, place the `GameData` folder inside your Kerbal Space Program folder:

* **REMOVE ANY OLD VERSIONS OF THE PRODUCT BEFORE INSTALLING**
  * Delete `<KSP_ROOT>/GameData/NecroBones/SpaceYLifters`
* Extract the package's `GameData` folder into your KSP's root folder as follows:
  * `<PACKAGE>/GameData` --> `<KSP_ROOT>`
    * Overwrite any preexisting file.
  * you should end up with `<KSP_ROOT>/GameData/NecroBones/SpaceYLifters`

## The following file layout must be present after installation

```markdown
<KSP_ROOT>
  + [GameData]
    + [NecroBones]
      + [SpaceY Corporation (SYC)][SYC]
        ...
      + [SpaceYLifters][SYL]
        + [Compatibility]
          ...
        + [Config]
          ...
        + [Contracts]
          ...
        + [Localization]
          ...
        + [Parts]
          ...
        * #.#.#.#.htm
        * Attributions.htm
        * CC-BY-NC-SA-4.0.txt
        * changelog.md
          ManualInstallation.htm
        * readme.htm
        * SpaceYLifters.version
        ...
      ...
    ...
    * ModuleManager.ConfigCache
  * KSP.log
  ...
```

### Dependencies

* [SpaceY Corporation (SYC)][SYC]

[SYC]: https://forum.kerbalspaceprogram.com/index.php?/topic/209446-*/ "SpaceY Corporation (SYC)"