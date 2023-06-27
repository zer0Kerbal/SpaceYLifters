---
permalink: /ManualInstallation.html
title: Manual Installation
description: the flat-pack Kiea instructions, written in Kerbalese, unusally present
tags: installation,directions,page,kerbal,ksp,zer0Kerbal,zedK
---

<!-- ManualInstallation.md v1.0.4.0
SpaceY Lifters (SYL)
created: 10 Dec 2022
updated: 26 Jun 2022 

TEMPLATE: ManualInstallation.md v1.1.9.1
created: 01 Feb 2022
updated: 26 Apr 2023

based upon work by Lisias -->
## [SpaceY Lifters (SYL)][mod]

[Home](./index.md)

78 parts for large lifting rockets, 5m rocket parts and large SRBs, and matching decouplers for Kerbal Space Program.

## Installation Instructions

### Using CurseForge/OverWolf app or CKAN

You should be all good! (check for latest version on CurseForge)

### If Downloaded from CurseForge/OverWolf manual download

To install, place the `SpaceY` folder inside your Kerbal Space Program's GameData folder:

* **REMOVE ANY OLD VERSIONS OF THE PRODUCT BEFORE INSTALLING**
  * Delete `<KSP_ROOT>/GameData/SpaceY/SpaceYLifters`
* Extract the package's `SpaceY` folder into your KSP's GameData folder as follows:
  * `<PACKAGE>/SpaceY/` --> `<KSP_ROOT>/GameData`
    * Overwrite any preexisting folder/file(s).
  * you should end up with `<KSP_ROOT>/GameData/SpaceY/SpaceYLifters`

### If Downloaded from SpaceDock / GitHub / other

To install, place the `GameData` folder inside your Kerbal Space Program folder:

* **REMOVE ANY OLD VERSIONS OF THE PRODUCT BEFORE INSTALLING**
  * Delete `<KSP_ROOT>/GameData/SpaceY/SpaceYLifters`
* Extract the package's `GameData` folder into your KSP's root folder as follows:
  * `<PACKAGE>/GameData` --> `<KSP_ROOT>`
    * Overwrite any preexisting file.
  * you should end up with `<KSP_ROOT>/GameData/SpaceY/SpaceYLifters`

## The following file layout must be present after installation

```markdown
<KSP_ROOT>
  + [GameData]
    + [SpaceY]
      + [SpaceY Corporation (SYC)][SYC]
        + [Agencies]
          ...
        + [Compatibility]
          ...
        + [Config]
          ...
        + [Contracts]
          ...
        + [Flags]
          ...
        + [Localization]
          ...
      + [SpaceYLifters][SYL]
        + [Assets]
          ...
        + [Category]
          ...
        + [Compatibility]
          ...
        + [Config]
          ...
        + [Contracts]
          ...
        + [FX]
          ...
        + [Localization]
          ...
        + [Parts]
          ...
        + [Plugins]
          ...
        + [Sounds]
          ...
        * #.#.#.#.htm
        * Attributions.htm
        * CC-BY-NC-SA-4.0.txt
        * changelog.md
        * ManualInstallation.htm
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

THIS FILE: CC BY-ND 4.0 by [zer0Kerbal](https://github.com/zer0Kerbal)
  used with express permission from zer0Kerbal

[mod]: https://www.curseforge.com/kerbal/ksp-mods/SpaceYLifters "SpaceY Lifters (SYL)"
[SYC]: https://forum.kerbalspaceprogram.com/index.php?/topic/209446-*/ "SpaceY Corporation (SYC)"