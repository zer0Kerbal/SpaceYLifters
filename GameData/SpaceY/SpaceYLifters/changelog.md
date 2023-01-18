# Changelog  
  
| modName    | SpaceY Lifters (SYL)                                              |
| ---------- | ----------------------------------------------------------------- |
| license    | CC-BY-NC-SA-4.0                                                   |
| author     | NecroBones(Orvidius) and zer0Kerbal                               |
| forum      | (https://forum.kerbalspaceprogram.com/index.php?/topic/209445-*/) |
| github     | (https://github.com/zer0Kerbal/zer0Kerbal/SpaceYLifters)          |
| curseforge | (https://www.curseforge.com/kerbal/ksp-mods/SpaceYLifters)        |
| spacedock  | (https://spacedock.info/mod/88)                                   |
| ckan       | SpaceY-Lifters                                                    |

## Version 1.9.99.1-prerelease - `<Thank you NecroBones>` edition

* Released
  * 17 Jan 2023
  * for KSP 1.12.5
  * by [zer0Kerbal](https://github.com/zer0Kerbal)

### Summary 1.9.99.1

* This is the first in a series of updates to this addon. Each update will update some of the parts and patches so that instead of one massive update I can update the addon in a more manageable way.
* Phase I (initial) pass
  * parts pass started (see 1.9.99.0 for more details)
* <ghostparts.cfg> is provided for testing. This file will not be active for v2.0.0.0-release.
* Can now search for `syl` or `spacey` in the editor search bar to find all parts in this pack.
* Only updated parts are included
* Parts updated (and included in this (pre)release)
  * HeatShield
    * SYheatShield5m
  * Decouplers
    * SYdecouplerRadial2
    * SYseparator3m
    * SYseparator5m
    * SYdecoupler5m
    * SYdecouplerRadial1
  * Fairings
    * SYfairingBase5mP

### Status

* Issues

  * closes #99 - SpaceY Lifters (SYL) 1.9.99.1-prerelease `<Thank you NecroBones>` edition
  * closes #100 - 1.9.99.1 Additional Tasks
  * updates #48 - Part Asset Updates
  * updates #50 - Localization - Master
  * updates #51 - English <us-en.cfg>
  * updates #68 - Part Localization
  * updates #101 - [Log ERR] PartLoader: Compiling Part

---

## Version 1.9.99.0-adoption - `<Thank you NecroBones>`

* Released
  * on 10 Dec 2022
  * for KSP 1.12.4
  * by [zer0Kerbal](https://github.com/zer0Kerbal)

### Adoption by [zer0Kerbal](https://github.com/zer0Kerbal)

### Summary 1.9.99.0

* Adoption by zer0Kerbal
* This is the first in a series of updates to this addon. Each update will update some of the parts and patches so that instead of one massive update I can update the addon in a more manageable way.
* Phase I (initial) pass
  * parts pass started
* <ghostparts.cfg> is provided for testing. This file will not be active for v2.0.0.0-release.
* Can now search for `syl` or `spacey` in the editor search bar to find all parts in this pack.
* Only updated parts are included
* Parts updated (and included in this (pre)release)
  * Docking
    * syl-docking3m
    * syl-docking5m>
    * syl-docking7m>
  * Control
    * syl-sasR3m
    * syl-sasR5m
  * Command
    * syl-probe5m
    * syl-probe3m
  * CargoBays
    * syl-bay3m2m
    * syl-bay5m3m

### Previous Releases (Archive)

* Create
  * 1.17.1.0-release `<Archival>`
  * 1.17.0.0-release `<Archival>`
  * 1.16.0.0-release `<Archival>`
  * 1.15.1.0-release `<Archival>`
  * 1.15.0.0-release `<Archival>`
  * 1.14.0.0-release `<Archival>`
  * 1.13.2.0-release `<Archival>`
  * 1.13.1.0-release `<Archival>`
  * 1.13.0.0-release `<Archival>`
  * 1.12.9.0-release `<Archival>`
  * 1.12.8.0-release `<Archival>`
  * 1.12.7.0-release `<Archival>`
  * 1.12.6.0-release `<Archival>`
  * 1.12.5.0-release `<Archival>`
  * 1.12.4.0-release `<Archival>`
  * 1.12.2.0-release `<Archival>`
  * 1.12.1.0-release `<Archival>`
  * 1.12.0.0-release `<Archival>`
  * 1.11.5.0-release `<Archival>`
  * 1.11.4.0-release `<Archival>`
  * 1.11.3.0-release `<Archival>`
  * 1.11.2.0-release `<Archival>`
  * 1.11.1.0-release `<Archival>`
  * 1.11.0.0-release `<Archival>`
  * 1.10.0.0-release `<Archival>`
  * closes #46 - Archival Releases

### Parts 1.9.99.0

* Add
  * <ghostParts.cfg> v1.3.0.0
* Rename
  * parts to match naming scheme
    * replace `SY` with `syl-`
  * part files to match part names
* Fix
* Lint
* Reformat
* moved to SpaceY Corp
  * Agency
  * Flags
  * <themes.cfg> v2.0.0.0
* Errors
  * Parts
    * Structural
      * <SYadapter5x4/part.cfg>
    * SRBs
      * <SYSRB_Radial/SYSRBradial01.cfg>
        * missing //
      * <SYSRB_0625/SYSRB_0625L9.cfg>
        * >=1.4.5 replace scale with localScale
      * <SYSRB_0625/SYSRB_0625L6R.cfg>
        * >=1.4.5 replace scale with localScale
      * <SYSRB_0625/SYSRB_0625L5.cfg>
        * >=1.4.5 replace scale with localScale
  * Patches
    * <SpaceY-DeadlyReentry.cfg>
      * missing `MODULE`
    * <SpaceY_HotRockets.cfg>
    * <SpaceY_HeatAnimation.cfg>
    * <SpaceY_ATM.cfg>
      * deactivated (no longer needed)
    * <SpaceY_ColorChange5m.cfg>
      * missing `=` after [displayName]
    * <SpaceY_HotRockets.cfg>
      * missing multiple (9) brace sets `{}`
  * closes #70 - [BUG]{Archived releases} Errors corrected

### Asset 1.9.99.0

* create Assets/ folder
* convert
  * from mesh to MODEL
* rename
  * Rename model files to unique names
  * textures to unique names
* update
  * model pointers (.png et al to .dds)
  * model texture pointers to new names
* relocate assets to Assets/
* eliminate
  * remove duplicates textures/models
* relocate part.cfg to Parts/
* convert to .ogg
  * <srb_loop.wav> 1.507mb --> 116kb
  * <sls_loop_blend.wav> 1.507mb --> 499kb
  * <sls_loop_deep.wav> 1.507mb --> 319kb
  * <sls_loop_high.wav> 428kb --> 386kb
  * <sls_start.wav> 316kb  --> 99kb
  * <srb_heavy_loop.wav> 316kb --> 126kb
  * 5.44mb --> 1.5mb
* updates #48 - Part Asset Updates

### docs/ 1.9.99.0

* Add
  * [`_config.yml`]
  * [Attribution.md] v1.0.7.1
  * [ManualInstallation.md] v1.1.8.0
  * [404.md] v1.0.3.2
  * [LegalMumboJumbo.md] v1.0.5.1
  * [Localizations.md] v1.1.7.0
  * [Marketing.md] v1.0.1.0
  * [Notices.md] v1.0.1.0
  * [Part-Catalog.md] v1.1.4.1
  * [Why.md] v1.1.0.0
* Add docs/thumbs
* closes #44 - Create GitHub Pages

### Localization 1.9.99.0

* Create
  * Localization/
    * <en-us.cfg> v1.0.0.0
    * [readme.md] v2.1.2.0
    * [quickstart.md] v1.0.1.1
* Create
  * [SpaceYLifters.cfg] v1.0.1.0
    * adds localized tags to parts
    * fix inadvertant passengers
* closes #47 - Create Localization directory and contents
* closes #49 - Create <SpaceYLifters.cfg>
* updates #50 - Localization - Master
* updates #51 - English <us-en.cfg>
* updates #68 - Part Localization

### Cover image 1.9.99.0

* closes #45 - Create HeroLogo.png

### Status

* Issues
  * closes #40 - SpaceYLifters (SYL) 1.9.99.0-adoption `<Thank you NecroBones>` edition
  * closes #41 - 1.1.99.0 Create Legal Mumbo Jumbo
  * closes #42 - 1.1.99.0 Create Documentation
  * closes #43 - 1.1.99.0 Create Social Media Presence

---

## Version 1.17.2.0-release - `<Archival>`

* Released
  * on 02 Apr 2018
  * for KSP 1.4.1
  * by [NecroBones](https://forum.kerbalspaceprogram.com/index.php?/profile/105424-*/)

* Re-upload

### Status 1.17.2.0

* Issues
  * closes #29 - Version 1.17.2
  * closes #46 - Archival Releases
  * updated #70 - [BUG]{Archived releases} Errors corrected

---

## Version 1.17.1.0-release - `<Archival>`

* Released
  * on 02 Apr 2018
  * for KSP 1.4.1
  * by [NecroBones](https://forum.kerbalspaceprogram.com/index.php?/profile/105424-*/)

* KSP 1.4 update
* Corrected a copy/paste mistake in color-changing config.
* Status 1.17.1.0

* Issues
  * updates #46 - Archival Releases
  * closes #28 - Version 1.17.1.0
  * updated #70 - [BUG]{Archived releases} Errors corrected

---

## Version 1.17.0.0-release - `<Archival>`

* Released
  * on 02 Apr 2018
  * for KSP 1.4.1
  * by [NecroBones](https://forum.kerbalspaceprogram.com/index.php?/profile/105424-*/)

* Reworked color-changing to use KSP 1.4's mesh switcher.
* Flag decals disabled for now, since the stock mesh switcher doesn't play nicely with them.
* Disabled auto-caps on tanks, due to KSP bugs over several versions.
* Changed ModularFuelTanks config to use consolidated wildcard patch.
* Added some wildcards to TweakScale config.

* Status 1.17.0.0

* Issues
  * updates #46 - Archival Releases
  * closes #27 - Version 1.17.0.0
  * updated #70 - [BUG]{Archived releases} Errors corrected

---

## Version 1.16.0.0-release - `<Archival>`

* Released
  * on 30 Jan 2017
  * for KSP 1.4.1
  * by [NecroBones](https://forum.kerbalspaceprogram.com/index.php?/profile/105424-*/)

* SRB Update
* Corrected smoke emitter location on the 3.75m SRB, 21m length.
* Added a 30m long 3.75m SRB.
* Added a 29m long 2.5m SRB.

* Status 1.16.0.0

* Issues
  * updates #46 - Archival Releases
  * closes #26 - Version 1.16.0.0
  * updated #70 - [BUG]{Archived releases} Errors corrected

---

## Version 1.15.1.0-release - `<Archival>`

* Released
  * on 01 Jan 2017
  * for KSP 1.2.2
  * by [NecroBones](https://forum.kerbalspaceprogram.com/index.php?/profile/105424-*/)

* Compatibility Update
* Added "NEEDS" conditionals for ConnectedLivingSpace and EngineIgnitor patches, to clean up log spam.
* EngineIgnitor patches moved to their own file in the patches folder.
* Added "NEEDS" conditionals for Engineering Tech Tree compatibility.

* Status 1.15.1.0

* Issues
  * updates #46 - Archival Releases
  * closes #25 - Version 1.15.1.0
  * updated #70 - [BUG]{Archived releases} Errors corrected

---

## Version 1.15.0.0-release - `<Archival>`

* Released
  * on 21 Oct 2016
  * for KSP 1.2.2
  * by [NecroBones](https://forum.kerbalspaceprogram.com/index.php?/profile/105424-*/)

* Added new RCS sounds/effects.
* Added a linear RCS thruster.
* Updated OMS engines to use new RCS sounds and effects.
* Added two adapters that can be used with the Rose/Rosette adapter center slots.
* Updated custom part category with recent additions from here and SpaceY Expanded.
* Added some missing search tags on thrust plates / adapters.

* Status 1.15.0.0

* Issues
  * updates #46 - Archival Releases
  * closes #24 - Version 1.15.0.0
  * updated #70 - [BUG]{Archived releases} Errors corrected

---

## Version 1.14.0.0-release - `<Archival>`

* Released
  * on 12 Oct 2016
  * for KSP 1.2.0
  * by [NecroBones](https://forum.kerbalspaceprogram.com/index.php?/profile/105424-*/)

* More KSP 1.2 Compatibility & Fixes
* Landing legs should now work in the Landing Gear action group automatically again.
* 5m Fairing base null reference exception corrected, and is available again.
* Names adjusted on some thrust plates / adapters.
* Version changed to 1.14 to make it more clear this is a significant 1.2 update.

* Status 1.14.0.0

* Issues
  * updates #46 - Archival Releases
  * closes #23 - Version 1.14.0.0
  * updated #70 - [BUG]{Archived releases} Errors corrected

---

## Version 1.13.2.0-release - `<Archival>`

* Released
  * on 10 Oct 2016
  * for KSP 1.2.0
  * by [NecroBones](https://forum.kerbalspaceprogram.com/index.php?/profile/105424-*/)

* Added KSP 1.2 and KerbNet modules to probe cores.
* Landing leg suspension disabled until a 1.2 solution can be found.
  * Using ModuleAnimateGeneric for the time being, so legs can still be used.
  * Will need an Action Group, or the Default Action Groups mod, for best results.
* Categories adjusted for several parts, corresponding to 1.2 changes.

* Status 1.13.2.0

* Issues
  * updates #46 - Archival Releases
  * closes #22 - Version 1.13.2.0
  * updated #70 - [BUG]{Archived releases} Errors corrected

---

## Version 1.13.1.0-release - `<Archival>`

* Released
  * on 01 Aug 2016
  * for KSP 1.1.3
  * by [NecroBones](https://forum.kerbalspaceprogram.com/index.php?/profile/105424-*/)

* Icon-only shroud added to fairing base, for easy identification in menu.
* 5m conical bay added to custom parts tab.
* Added MM "NEEDS" conditionals to RemoteTech modules in probe cores, and moved to separate patch file.
* Deadly Reentry patch file renamed to sort properly in the folder.
* Added a compatibility exclusion for HPTechTree.

* Status 1.13.1.0

* Issues
  * updates #46 - Archival Releases
  * closes #21 - Version 1.13.1.0
  * updated #70 - [BUG]{Archived releases} Errors corrected

---

## Version 1.13.0.0-release - `<Archival>`

* Released
  * on 08 Jun 2016
  * for KSP 1.1.3
  * by [NecroBones](https://forum.kerbalspaceprogram.com/index.php?/profile/105424-*/)

* Adapters and Thrust Plates marked as passable for Connected Living Space so that they can be used for station construction, and docking ports, etc.
* Added 5m/3.75m conical payload bay.
* Adjusted the "hide if empty" rules for the tech nodes.

* Status 1.13.0.0

* Issues
  * updates #46 - Archival Releases
  * closes #20 - Version 1.13.0.0
  * updated #70 - [BUG]{Archived releases} Errors corrected

---

## Version 1.12.9.0-release - `<Archival>`

* Released
  * on 31 May 2016
  * for KSP 1.1.2
  * by [NecroBones](https://forum.kerbalspaceprogram.com/index.php?/profile/105424-*/)

* Hotfix
  * Massive Rocketry/Structure tech nodes are now set to be hidden if empty.
  * Fixed a harmless mistake in the MM patches, as part of its self cleanup.

* Status 1.12.9.0

* Issues
  * updates #46 - Archival Releases
  * closes #19 - Version 1.12.9.0
  * updated #70 - [BUG]{Archived releases} Errors corrected

---

## Version 1.12.8.0-release - `<Archival>`

* Released
  * on 31 May 2016
  * for KSP 1.1.2
  * by [NecroBones](https://forum.kerbalspaceprogram.com/index.php?/profile/105424-*/)

* Adjusted some nickname tags on engines.
* Minor tech tree and config changes in MM patches. Partly for better compatibility with Real Scale Boosters.
* Non-CTT tech nodes are now added, even if CommunityTechTree is installed.
* Gigantic Rocketry node internally renamed to match CTT. May have to re-unlock if you don't use CTT.

* Status 1.12.8.0

* Issues
  * updates #46 - Archival Releases
  * closes #18 - Version 1.12.8.0
  * updated #70 - [BUG]{Archived releases} Errors corrected

---

## Version 1.12.7.0-release - `<Archival>`

* Released
  * on 18 May 2016
  * for KSP 1.1.2
  * by [NecroBones](https://forum.kerbalspaceprogram.com/index.php?/profile/105424-*/)

* Added configs for docking ports to use IndicatorLights, if installed.
* Reworked docking alignment lights to be slightly prettier when turned off, or dim, etc.

* Status 1.12.7.0

* Issues
  * updates #46 - Archival Releases
  * closes #17 - Version 1.12.7.0
  * updated #70 - [BUG]{Archived releases} Errors corrected

---

## Version 1.12.6.0-release - `<Archival>`

* Released
  * on 12 May 2016
  * for KSP 1.1.2
  * by [NecroBones](https://forum.kerbalspaceprogram.com/index.php?/profile/105424-*/)

* Restricted liquid fuel engines, fairings, and decouplers to non-surface part testing contracts, to match SRBs.
* Changed underlying texture for Docking port alignment lights, for compatibility with IndicatorLights.
* Converted small lighting textures for docking ports to DDS format.

* Status 1.12.6.0

* Issues
  * updates #46 - Archival Releases
  * closes #16 - Version 1.12.6.0
  * updated #70 - [BUG]{Archived releases} Errors corrected

---

## Version 1.12.5.0-release - `<Archival>`

* Released
  * on 08 May 2016
  * for KSP 1.1.2
  * by [NecroBones](https://forum.kerbalspaceprogram.com/index.php?/profile/105424-*/)

* Refined the primary launch clamp's internal layout, to use as a template for later projects.
* Added basic thrust curves for SRBs. Flat profile, however thrust tapers off during last 5% of remaining propellant.

* Status 1.12.5.0

* Issues
  * updates #46 - Archival Releases
  * closes #15 - Version 1.12.5.0
  * updated #70 - [BUG]{Archived releases} Errors corrected

---

## Version 1.12.4.1-release - `<Archival>`

* Released
  * on 01 May 2016
  * for KSP 1.1.2
  * by [NecroBones](https://forum.kerbalspaceprogram.com/index.php?/profile/105424-*/)

* Corrected AVC version number. DOH!

---

## Version 1.12.4.0-release - `<Archival>`

* Released
  * on 01 May 2016
  * for KSP 1.1.2
  * by [NecroBones](https://forum.kerbalspaceprogram.com/index.php?/profile/105424-*/)

* 1.12.3.0 ?
* Updated Probe cores and reaction wheels to use IndicatorLights if available.
* Probe cores now also have a toggle option for light-up labels that correspond to the indicator lights.
* Corrected a missing texture placeholder for the 3.75m stack separator.

* Status 1.12.4.0

* Issues
  * updates #46 - Archival Releases
  * closes #14 - Version 1.12.4.0
  * updated #70 - [BUG]{Archived releases} Errors corrected

---

## Version 1.12.2.0-release - `<Archival>`

* Released
  * on 25 Apr 2016
  * for KSP 1.1.2
  * by [NecroBones](https://forum.kerbalspaceprogram.com/index.php?/profile/105424-*/)

* More search keywords on engines.
* Added colliders setting for procedural fairing base.
* Updated heat shield's staging settings to match stock changes in 1.1.
* Fixed the "always transparent" problem in the VAB for the service/cargo bays.
* Tech Tree nodes are no longer hidden if empty.
* Corrected some copy/paste mistakes with SmokeScreen rescaling settings for the small SRB particle emitters.

* Status 1.12.2.0

* Issues
  * updates #46 - Archival Releases
  * closes #13 - Version 1.12.2.0
  * updated #70 - [BUG]{Archived releases} Errors corrected

---

## Version 1.12.1.0-release - `<Archival>`

* Released
  * on 17 Apr 2016
  * for KSP 1.1.0
  * by [NecroBones](https://forum.kerbalspaceprogram.com/index.php?/profile/105424-*/)

* Tweaked leg settings.
* Moved a leg collider to allow for more accurate aerodynamic occlusion.

* Status 1.12.1.0

* Issues
  * updates #46 - Archival Releases
  * closes #12 - Version 1.12.1.0
  * updated #70 - [BUG]{Archived releases} Errors corrected

---

## Version 1.12.0.0-release - `<Archival>`

* Released
  * on 10 Apr 2016
  * for KSP 1.1.0
  * by [NecroBones](https://forum.kerbalspaceprogram.com/index.php?/profile/105424-*/)

### Tweaks

* Added 1.25m-0.625m interstage thrust plate to the TweakScale config, and default VAB custom tab.
* Drastically reduced career prices for fuel tanks, to bring them into line with stock again.
* Increased career prices for engines, to bring them into line with stock again.
* Added a 2.5m thrust plate, with 1x 1.25m and 8x 0.625m nodes (half scale version of the 5m model). 
* Adjusted leg deployment animation to reduce the "foot teleportation" problem.
* Increased damper ratio on the leg suspension.

* Status 1.12.0.0

* Issues
  * updates #46 - Archival Releases
  * closes #11 - Version 1.12.0.0
  * updated #70 - [BUG]{Archived releases} Errors corrected

---

## Version 1.11.5.0-release - `<Archival>`

* Released
  * on 05 Apr 2016
  * for KSP 1.1.0
  * by [NecroBones](https://forum.kerbalspaceprogram.com/index.php?/profile/105424-*/)

* Tweaks
  * Moved conical payload bay to Specialized Construction tech node.
  * Added a 1.25m-0.625m interstage thrust plate.
  * Softened leg suspension spring.

* Status 1.11.5.0

* Issues
  * updates #46 - Archival Releases
  * closes #10 - Version 1.11.5.0
  * updated #70 - [BUG]{Archived releases} Errors corrected

---

## Version 1.11.4.0-release - `<Archival>`

* Released
  * on 31 Mar 2016
  * for KSP 1.1.0
  * by [NecroBones](https://forum.kerbalspaceprogram.com/index.php?/profile/105424-*/)

* Hotfix
* Landing leg suspension works again. Suspension is very stiff to help prevent heavy vehicles from bobbing endlessly.

* Status 1.11.4.0

* Issues
  * updates #46 - Archival Releases
  * closes #9 - Version 1.11.4.0
  * updated #70 - [BUG]{Archived releases} Errors corrected

---

## Version 1.11.3.0-release - `<Archival>`

* Released
  * on 29 Mar 2016
  * for KSP 1.1.0
  * by [NecroBones](https://forum.kerbalspaceprogram.com/index.php?/profile/105424-*/)

* KSP 1.1.0
* Hotfix

* Landing legs updated to not be 100% deadly. Suspension still doesn't work, legs are rigid for now.
* Added menu search tags.

* Status 1.11.3.0

* Issues
  * updates #46 - Archival Releases
  * closes #8 - Version 1.11.3.0
  * updated #70 - [BUG]{Archived releases} Errors corrected

---

## Version 1.11.2.0-release - `<Archival>`

* Released
  * on 18 Mar 2016
  * for KSP 1.0.5
  * by [NecroBones](https://forum.kerbalspaceprogram.com/index.php?/profile/105424-*/)

* Removed duplicate "MODCAT" entry for the SpaceY Expanded custom menu tab.

* Status 1.11.2.0

* Issues
  * updates #46 - Archival Releases
  * closes #7 - Version 1.11.2.0
  * updated #70 - [BUG]{Archived releases} Errors corrected

---

## Version 1.11.1.0-release - `<Tweaks>`

* Released
  * on 11 Mar 2016
  * for KSP 1.0.5
  * by [NecroBones](https://forum.kerbalspaceprogram.com/index.php?/profile/105424-*/)

* Added/enhanced custom category tab for FilterExtensions (will also include SpaceY Expanded, if installed).

* Status 1.11.1.0

* Issues
  * updated #70 - [BUG]{Archived releases} Errors corrected #70
  * updates #46 - Archival Releases
  * closes #6 - Version 1.11.1

---

## Version 1.11.0.0-release - `<Tweaks>`

* Released
  * on 28 Feb 2016
  * for KSP 1.0.5
  * by [NecroBones](https://forum.kerbalspaceprogram.com/index.php?/profile/105424-*/)

* Adjusted the MM rule for DefaultActionGroups to tweak the descriptions in the radial reaction wheels.
* Added 5m color-changing to the R7 engine cluster. 
* Corrected the missing blue texture from the 3.75m tall 5m tank.

* Status 1.11.0

* Issues
  * updates #46 - Archival Releases
  * closes #5 - Version 1.11

---

## Version 1.10 (2016-02-19) - The unintentionally quick update

* SRB 10R (radial) gimbal range reduced to 2 degrees (from 4).
* Base (dry) cost of most SRBs (other than 3.75m models) increased slightly to align more with stock.
* Moved ModuleManager patches to a "Patches" folder.
* Added support for DefaultActionGroups mod, to automatically enable the SAS light on the radial reaction wheels.
* Added color switching for 5m decoupler and separator, to match 5m tanks.

---

## Version 1.9.0

* 18 Feb 2016
* Paint

* Added additional striped paint scheme to 5m tanks.
* Switched the Color-Changing config to turn off alternate paint schemes via a slightly simpler method.

---

## Version 1.8.2

* 14 Jan 2016
* Tweaks

* Consolidating tech tree for better mod compatibility:
  * Added SpaceY Expanded's tech tree nodes.
  * Added a hidden Colossal Rocketry node for future use (and for other mods if they want).
* Removed TweakScale "adapter_3_1" definition since it's redundant with default TS configs now.

---

## Version 1.8.1

* 02 Jan 2016
* Fixes

* Included ModuleManager version updated with its 2.6.16 bugfix update.
* Added a "needs" condition for TweakScale patches.
* Fixed the FilterExtensions category icon path.

---

## Version 1.8.0

* 31 Dec 2015
* Texture updates

* Moved the "SpaceY Expanded" 7.5m tank texture into this pack.
  * Repainted default appearance for 5m tanks to use it.
  * Enables color-switching for 5m tanks even without "SpaceY Expanded".
  * 3.75m fueled short nose cone repainted with it too, removed grey stripes.
  * Reduced size of original 5m tank texture, removing redundant black/white areas.
  * Repainted 5m R7 engine to match, for compatibility.
* Removed a fairing texture that was no longer in use.

---

## Version 1.7.0

* 22 Dec 2015
* More separator goodness

* Added "SpaceY_ATM.cfg" with settings to attempt to disable or dissuade ActiveTextureManagement for this mod.
  * Can optionally be deleted to return to ATM defaults.
  * ATM known to occasionally have caching issues with remapped/shared textures in my mods.
  * SpaceY is already very memory efficient and uses DDS, so ATM doesn't help much for this case.
  * May need to delete ATM's cache if using ATM and some textures still aren't appearing.
* Updated 5m stack decoupler:
  * Ejection charge reduced by half (to 400, down from 800).
  * Added built-in "sepratron" solid propellant separator motors.
  * Research cost increased slightly.
* Added slanted variants of the sepratron nose cones.
* Reduced maximum temperature for docking ports. Should burn up more easily now. ;)
* Added a default custom part tab for VAB/SPH.

---

## Version 1.6.1

* 11 Dec 2015
* Fix for nose cones

* SRB sepratron nose cones rotated 90 degrees, so that they play nice with mirror symmetry mode.

---

## Version 1.6.0

* 11 Dec 2015
* SRB Overhaul

* Added additional paint schemes to the 1.875m/2.5m/3.75m SRBs,
  * Optional, requires Firespitter or InterstellarFuelSwitch core (DLL).
* Added sepratron nose-cones for SRBs.
* Fixed a typo with the engine heat animation for the K1 engines.
* Corrected a typo with Agency mentality.
* Replaced "placeholder" textures. Smaller, and more obvious when texture reassignment has failed.

---

## Version 1.5.0

* 11 Nov 2015
* KSP 1.0.5 update

* Kiwi engine adjusted: slightly improved ISP, decreased mass, increased thrust.
* Fuel crossfeed toggle added to decouplers.
* Launch clamps updated with new contract constraints.
* Ejectatrons updated to use new contract constraints, and exhaust damage reducer, and other thermal settings.
* Updated heat shield to current stock ablator settings and contract constraints. Slightly increased ablator quantity.
* Updated conical/petal bay to use current cargo bay thermal stats and allow door deployment limit.
* Adjusted inner attachment node on conical/petal bay to be offset inward like new stock settings on cargo bays.
* Updated all engines/SRBs to use FXModuleAnimateThrottle for heat animation.
* Updated all engines/SRBs to use new standard thermal settings, and new career contract constraints.
* "Automatic Switching" button hidden for cluster engines, since it did nothing.
* Adjusted fuel tank texture settings to reduce log warnings when SpaceY Expanded is not installed.
* Fairings, decouplers/separators, and more updated to use new stock-alike thermal settings and contract constraints.
* Launch Clamps updated with new contract constraints.

---

## Version 1.4.0

* 05 Nov 2015
* More colors, balance

* Added three new colors to 5m tanks (when color switching is available): Red, Blue, and Grey.
* Diameters added to 5m fuel tank names, for easy identification in VAB menu.
* Rebalanced the weight ratios of all SRBs, to correspond to KSP 1.0.X balance:
  * Increased dry mass (did not alter propellant amounts, ISPs, thrust values, etc).
  * Wet/Dry mass ratio is on sliding scale. Larger & more advanced SRBs have better mass ratios.
* Removed stripes from procedural fairings (will affect SpaceY Expanded as well).
* Slightly improved the texture rendering for the 5m fueled nose cone in the VAB menus.

---

## Version 1.3.1

* 18 Oct 2015
* Bug fix

* Fixed the ModuleManager conditionals to detect when the prerequisite mods are missing for fuel tank appearance switching.

---

## Version 1.3.0

* 16 Oct 2015
* Engine and fuel tank Update

* HotRockets adjustments:
  * Corrected some of the internal ID assignments (M/K engines).
  * Made corrections to particle scaling for all LFO engines.
  * Switched M,R series engines to use yellow flame instead of blue (RP1/kerosene inspired). Blue will be moved to the Penguins.
* LFO engines will now animate their heat glow based on throttle (like "Better Emissives" patch) instead of temperature.
  * I've been debating this one for a while. We'll try this out and see how it goes.
  * It's contained in patch called "SpaceY_HeatAnimation.cfg". Delete it or rename the "cfg" part to disable.
  * Patch will also apply to SpaceY-Expanded engines.
* New default custom flame/particle effects for all LFO (K,M,R series) engines. 
* New engine bell art assets for the M,R series of LFO engines.
* Color switching added to 5m LFO tanks. To be enabled, requires Firespitter or InterstellarFuelSwitch, and SpaceY Expanded.

---

## Version 1.2.0

* 08 Oct 2015
* Update

* Added LC2 launch clamps to TweakScale config.
* Removed erroneous flagDecal module from LC2 launch clamps.
* Added bottom stack node and shroud to the R1 single Ratite engine.
* Added surface attachment to K1,M1,R1 engines.
  * Note: May cause some occasional goofiness with saved crafts in the VAB/SPH saved with the old versions. Best to remove, re-attach, and re-save.
* With InterstellarFuelSwitch or Firespitter, stack attachment bases can be toggled on K1,M1,R1 engines.
* Improved labeling on shrouds for K1,M1,R1 engines.

---

## Version 1.1.0

* 30 Sep 2015
* Update

* Increased connection breaking strength on many parts.
* Added second set of launch clamps, with long retraction range to reach around boosters.

---

## Version 1.0.4

* 23 Sep 2015
* Tweaks

* Fixed a double entry in the TweakScale config.
* Corrected an issue with some parts not showing up in CTT's tech tree.

---

## Version 1.0.3

* 02 Sep 2015
* Tweaks

* Increased joint breaking strength on 3.75m and 5m thrust plates.
* More file preparation to support the "SpaceY Expanded" dependency.
* Added spotlights to the docking ports.
* R1 ratite engine moved up to Very Heavy Rocketry tech node.

---

## Version 1.0.2

* 26 Aug 2015
* Tweaks

* Custom sounds disabled by default, until better ones can be located.
  * To re-enable, rename "SpaceY_CustomSounds.txt" back to "SpaceY_CustomSounds.cfg" (note the ".cfg" suffix).
* Added new "Massive Structure" tech node (when not using Community Tech Tree).
  * Moved all 5m structural/interstage adapters, docking port, and stack decouplers to this new node.
* Moved all 5m structural/interstage adapters, docking port, and stack decouplers to "Experimental Rocketry" in CTT.
* Cleaned up some of the Community Tech Tree configuration (organizing).
* Added the longest 3.75m SRB to the Gigantic Rocketry node in CTT, where it should have been.
* Added the longest 3.75m SRB to the Massive Rocketry node in non-CTT tech tree, where it should have been.

---

## Version 1.0.1

* 21 Aug 2015
* Tweaks

* Converted the 3.75m SRB textures to DDS format.
* Added missing manufacturer setting for 10R radial SRB.
* A few minor tweaks in preparation for the 7.5m spin-off pack (since this pack will be a dependency).
* Moved "README" and "CHANGELOG" to the mod's directory.
* Corrected a problem with multi-mode engine gimbal.
* R5 engine moved down to "Experimental Rocketry" node in Community Tech Tree.

---

## Version 1.0.0

* 05 Aug 2015
* New things

* Changed version numbering to 1.x to indicate we're no longer in rapid growth.
* Added a longer 5m (15m long) fuel tank.
* Added a set of 3.75m SRBs, stackable wih shrouds. (functional as lower/middle stages)
* Reworked the models/textures for the 2.5m SRBs.

---

## Version 0.17.6 (2015-07-26) - Tweaks

* Reduced heat production in all liquid fuel engines to be more stock-alike.
* Slightly reduced heat production on 1.875m and 2.5m SRBs.
* Slightly altered names on M-series and R-series engines for clarity.

---

## Version 0.17.5 (2015-07-05) - Tweaks

* Added ConductionFactor/convectionflux settings for petal bay.
* Adjusted OMS/RCS blocks' RCS thrust vectors to remove 5-degree offset (and thus minimize cosine losses).
* Moved custom engine sounds to separate "SpaceY_CustomSounds.cfg" ModuleManager file, for easy removal.

---

## Version 0.17.4 (2015-06-27) - M1 update, continued/hotfi

* Addressed a problem with new straight fairing in M1 Moa engine:
  * Removed middle attachment node that was added.
  * Replaced the 3.75m->5m cone fairing with the 2.5m straight fairing. (doubtful many people use that one anyway).
  * KNOWN ISSUE: If you used the new fairing in 0.17.3 (during the 12 hours or so it was available), the fairing will be invisible on ships already constructed.
  * requires KSP 1.0.4 to not be save-breaking

---

## Version 0.17.3 (2015-06-26) - M1 update

* Added a middle-length, 2.5m "straight" cylindrical fairing to the M1 Moa engine. (requires KSP 1.0.4 to not be save-breaking)

---

## Version 0.17.2 (2015-06-22) - KSP 1.0.3 balance update

* Updated thermal and ablator properties of heat shield, and removed transparency.
* Updated thermal settings on many parts, for stock balance, including nose cones, fairings, SRBs, Engines, etc.
* Fairing mass & thermal values updated.
* SRB ISPs rebalanced, to be equal to some of the better performing stock SRBs.
* Adjusted SRB propellant capacities and costs.

---

## Version 0.17.1 (2015-06-21) - SRB hotfi

* Corrected a problem with colliders on the new 21m long 1.875m SRB (should no longer fall through the pad).

---

## Version 0.17 (2015-06-18) - Thermal help, plus SRBs

* Increased "thermal mass" multiplier and heat conductivity for thrust plates.
* Increased "thermal mass" multiplier for structural/conical size adapters.
* Increased heat tolerance for thrust plates and size adapters.
* Shortened SRB names to "SRB" instead of "Solid Rocket Booster" to save space in the UI.
* Added a new (21m) long 1.875m SRB.
* Added a new (9m) long 0.625m SRB.

---

## Version 0.16.1 (2015-06-09) - Hotfi

* Fixed R7 engine description.
* Converted R7 supplemental texture to DDS format.

---

## Version 0.16 (2015-06-09) - New engine, etc

* Deleted an unused texture.
* Moved the large launch clamps later in the tech tree.
* Restored the R5 engine to 11,000 thrust (10% increase over the previous few versions).
* Added new R7 engine cluster with integrated fuel. 
* Adjusted sound for R5 (and new R7) engines.

---

## Version 0.15 (2015-06-04) - Tweaks & fixe

* Updated Deadly Reentry config with more current data.
* Added support for Modular Fuel Systems (Modular Fuel Tanks).
* Small tweaks to conical payload bay; shielding should theoretically work better now.
* Closed a small gap in the colliders on the conical payload bay.
* Added VAB/SPH transparency to conical payload bay. 

---

## Version 0.14.1 (2015-05-28) - Balance tweak

* Increased cost, torque, and battery capacity in both probe cores. 
* Improved ISP for most engines at extreme atmospheric pressures (Eve). 
* Changed flag/agency images back to PNG format so they'll work again.

---

## Version 0.14 (2015-05-20) - Hot fix, finalizing as 0.14

* New RCS block set to be physicsless.

---

## Version 0.13.2 (2015-05-20) - Fixes & Engine rebalancing against stock

* Corrected the 3.75m fueled nose cone to appear in the size-3 bulkhead profile.
* Corrected the manufacturer setting on the 0.625m SRBs.
* LFO Engine balance pass. Note that a lowered Vacuum ISP results in improved sea-level thrust:
  * K1 engine: Lowered vacuum ISP.
  * M1 engine: Increased mass slightly, and lowered vacuum ISP.
  * M5 engine: Increased mass, and lowered vacuum ISP.
  * M9 engine: Lowered vacuum ISP.
  * R1 engine: Increased mass slightly, raised sea-level ISP, and lowered vacuum ISP.
  * R5 engine: Raised sea-level ISP, and lowered vacuum ISP.
* Added a 5-way RCS block (without integrated engine).
* Fixed a minor texture issue with the smaller "Dibamous" RCS/OMS engine block.
* Slightly increased RCS thrust on the smaller "Dibamous" RCS/OMS engine block.

---

## Version 0.13.1 (2015-05-14) - SRB adjustments, et

* Corrected several TweakScale settings to allow scaling of various engines, plus fairings and heat shield.
* Small amount of gimbal added to 2.5m SRBs.
* Added an intermediate sized radial SRB.

---

## Version 0.13 (2015-05-09) - More heatshield goodness

* Fixed a typo in the Community Tech Tree config.
* Corrected the bulkhead profile for the new mini radial SRB so it's not listed as a size-0 stack part.
* New texture for the procedural fairing panels.
* Adjusted the procedural fairing panels to begin at upper edge of base.
* Added large (5m) heat shield.

---

## Version 0.12.3 (2015-05-08) - 1.0.2 adjustment

* Tweaked the conical cargo bay's drag cube.
* Fixed a configuration typo for the 3.75m to 2.5m thrust plate. 
* Reversed the attachment node priority order for extremely thin parts (docking ports, probe cores, thrust plates), so that they attach more easily.
* Updated "Community Tech Tree" support for compatibility with CTT's new design.
* Improved performance of monopropellant engines in atmospheric pressures > 1.
* Corrected the career-contract settings for the launch clamps so that they match stock. 
* Added NASA engine sounds to SRBs and engine clusters.
* Added a pair of small scale (0.625m) SRBs.

---

## Version 0.12.2 (2015-05-01) - 1.0.1 adjustment

* Improved gimbal on liquid-fuel engines. 
* Adjusted heat generation on all engines to correspond to KSP 1.0.1 changes.
* Adjusted all engine thrust numbers to correspond to KSP 1.0.1 changes.
* Added "drag box" settings for conical cargo bay.
* Converted textures to DDS format.

---

## Version 0.12.1 (2015-04-30) - More 1.0 adjustment

* Fixed the 5m engines to no longer cause continuous smoke on the pad.
* Tweaked the max-temps on the engines and fuel tanks. Now only 5-10% more heat tolerant than stock.
* Adjusted heat generation/dissipation values on SRBs to match stock KD25k SRB.
* Lowered ISPs of the liquid-fuel engines, due to stock rebalance.
* Tweaked some of the thrust numbers for the liquid-fuel engines.
* Tweaked ISP range of the monopropellant OMS/RCS engines to match stock. 

---

## Version 0.12 (2015-04-29) - More tweaks, KSP 1.0 update

* Slight correction to 1.875m SRBs exhaust positioning.
* KSP 1.0 compatibility pass (fixes to attachment nodes, heat scales, tech tree assignments, thrust/ISP scaling, etc)
* KSP 1.0 balance pass, and additional settings.
* Reassigned tech-tree locations.
* Removed static fairings. 
* Added 1.0-like procedural 5m fairing. 

---

## Version 0.11.0.0-release - `<Beta, minor improvement>`

* Released
  * on 18 Feb 2015
  * by [NecroBones](https://forum.kerbalspaceprogram.com/index.php?/profile/105424-*/)

* Corrected several mistakes in the Community Tech Tree patch.
* Updated the HotRockets config to have different vacuum/atmo effects.
* Added some gimbal to the 1.875m SRBs (inspired by the Space Shuttle SRB gimbal).
* Slightly updated the texture on the 1.875m SRBs, plus other minor fixes.

---

## Version 0.10.0.0-release - `<Aerodynamic and Structural Edition>`

* 06 Feb 2015
* KSP 1.0.5
* [NecroBones](https://forum.kerbalspaceprogram.com/index.php?/profile/105424-*/)

* Added "command station" settings to the probe cores for Remote Tech.
* Added 5m and 3.75m inline fairings with optional size adapters + associated nose cones.
* Added 5m and 3.75m Stack Separators.
* Added taller 5m and 3.75m fueled nose cones, in the style of the fairing nose cones.
* Added Deadly-ReEntry settings for the existing and new nose cones.
* Significantly increased torque/breaking strength of nearly all SpaceY parts.

---

## Version 0.9.1

* 21 Jan 2015
* The "rapid unplanned disassembly" mitigation edition

* Discovered that a lot of the torque/breaking strength numbers were set at 3.75m values:
* Increased torque/breaking strength of all radial reaction wheels.
* Increased torque/breaking strength of conical size-adapters. 
* Increased torque/breaking strength of all fuel tanks (which were set slightly lower than the 3.75m Kerbodyne tanks). 
* Increased torque/breaking strength of all decouplers. 
* Increased torque/breaking strength of all engines & SRBs, except the Kiwi/K1. 
* Tweaked torque/breaking strength of docking ports.
* Tweaked torque/breaking strength of petal payload bay.

---

## Version 0.9.0

* 16 Jan 2015
* Beta - WARNING - Extra node on Dibamous may be SAVE BREAKING

* Added a stack attachment node to "Dibamous" RCS/OMS pod.
* Experimentally tweaked some strength settings on the docking ports. Let me know if this helps.
* Adjusted colors on inside ring of large probe cores, to differentiate them in the VAB menu.
* Several adjustments to the rigid landing-leg stack ring:
  * Adjusted size, positioning, rotation, and number of the legs.
  * Considerably improved strength / breaking force.
  * Switched to the actual landing-leg module to call the animation, so it responds to landing gear hotkey.
* Added "SpaceX" style individual landing legs.
* Added "Super Dibamous" combined RCS/OMS pod (larger variant of "Dibamous").
* All "thrust plate" parts have had their names adjusted, and color-coding added.
* Added support for Connected Living Space, for the probe cores and docking ports. 

---

## Version 0.8.0

* 09 Jan 2015
* Beta

* Added RemoteTech support for probe cores.
* Added Engine Ignitor support for launch clamps.
* Added auto-shroud to tops of cylindrical fuel tanks.
* Altered fuel tank paint scheme to be a little more glossy, and less "satin".

---

## Version 0.7.0

* 27 Dec 2014
* Beta

* Removed the "ASAS" from the Radial Reaction Wheel texture, and slightly enhanced the gloss.
* Added multi-mode operation to M5 and R5 engines, allowing for center engine cut-off, like Saturn-V.
* Added 3.75m and 5m advanced probe cores ("Stack Guidance Systems")
* Added 5m landing-leg "ring". Warning: Must land lightly, probably 3m/s or slower. Fragility is a known issue.

---

## Version 0.6.1

* 23 Dec 2014
* Beta

* Actually applied the thrust increase for the K1 Kiwi engine that belonged in the last update.
* Corrected a few typos in part titles and descriptions.

---

## Version 0.6.0

* 23 Dec 2014
* Beta

* Removed SAS from Reaction Wheel parts, since it no longer works without being on a command pod/core.
* Updated the naming convention for all engines, SRBs, tanks, and size adapters to be clearer and more consistent.
* Added mode-switching for the M9 engine. Alternate mode engages only center engine, for landing. 
* Corrected K1 "Kiwi" engine's manufacturer so that it shows up in the SpaceY tab.
* Increased thrust slightly on K1 "Kiwi" engine.
* Increased thrust of R-series "Ratite" engines by 10%.
* Increased thrust of M-series "Moa" engines by 33%.
* Increased gimbal range of all M-series engines to 3 degrees.
* Added RCS/OMS "Dibamus" monopropellant engine and maneuvering unit.
* Slightly slowed the spool-up rate for all engines, to reduce sudden dissassembly syndrome with Z and X keys

---

## Version 0.5.1

* 16 Dec 2014
* Beta Release, 0.90 tweak

* Added an even larger SRB, a 2.5m x 23m monstrosity. :)
* Fixed manufacturer icon in VAB/SPH manufacturer-sort.
* Reduced dry-mass of fuel tanks, to be more competitive with the new Mk3 LFO tanks.

---

## Version 0.5.0

* 15 Dec 2014
* Beta Releas

* No changes strictly necessary for 0.90:
  * Engine/FuelTank split is automatic, but we went ahead and updated to explicitly categorize anyway.
  * Leaving SAS basic capability on the reaction wheel parts for now.
* New naming scheme for engines, as a parody of SpaceX's naming. Flightless birds instead of raptors. :)
  * D1 engine renamed K1 "Kiwi"
  * F1/F5/F5 "Falcon" engines renamed M1/M5/M9 "Moa" engines.
  * R1/R5 "Raptor" engines renamed R1/R5 "Ratite" engines.
* Added Heavy-Duty Launch Clamp
* Added TweakScale support for the M1 engine that was missing.
* Added missing TweakScale "adapter 3-1" scale (which was fine if you also had Modular Rocket Systems installed)
* Added HotRockets support
* Repainted the ejection arrows on the radial decouplers to be blue.
* Made several changes to the K1 engine:
  * Moved earlier in tech tree, to Heavy Rocketry, alongside Skipper instead of Mainsail. 
  * Repainted turbopumps to be blue
  * Added a cylindrical shroud, and stacking capability. 
  * Improved ISP (mostly at the vacuum end).
  * Corrected the attachment node to be 1.25m size (instead of the default of 0.625m).
* Changed several stats of the 1-way thrust plates (shrouded size adapters):
  * Moved the 3.75m->2.5m and 2.5m->1.25m units earlier in the tech tree.
  * Reduced mass of the 3.75m->2.5m and 5m->3.75m units.
  * Slightly reduced costs of all three.
  * Added a fourth size: a shorter duplicate for the 2.5m->1.25m for use with smaller engines.
* Adjusted naming convention of parts and model-numbers to be more consistent, across the entire parts list.

---

## Version 0.4.0

* 10 Dec 2014
* Beta update

* Increased gimbal range of all engines, slightly.
* Decreased dry mass of all fuel tanks slightly (dry/fueled mass ratio is now between stock 3.75m and 2.5m tanks). 
* Added "D1" 1.25m booster engine.
* Added upper-stage (with fairing) single-engine thrust-plates:
  * 5m to 3.75 adapter
  * 3.75m to 2.5 adapter
  * 2.5m to 1.25 adapter
* Added non-fueled size adapters with multiple target sizes each, with a shared texture (from the 5m to 3.75m adapter):
  * 5m to 3.75m/2.5m/1.25m adapter
  * 3.75m to 2.5m/1.25m adapter
* Added 3.75m to 2.5m conical "petal" payload bay, with functioning doors

---

## Version 0.3.0

* 03 Dec 2014
* Beta update

* Repainted 5m decoupler to match fuel tank stripes, and have blue triangles.
* Repainted 5m to 4x 2.5m adapter, to match fuel tank stripes.
* Repainted 5m to 3.75m fueled adapter tank, to match the other stripes (sensing a theme?)
  * Added external fuel pipes on 5m to 3.75m fueled adapter tank.
* Rotated engine bell pattern on F5 cluster engine, to match the R5 orientation.
* Raised center engine bell on F5 cluster, so that all five are mounted at the same height.
* Added 3.75m and 5m docking ports. (5m port is in "nanolathing" 1000-point tech-tree node)
* Added "thrust plates" with optional stacking as upper stage clusters with shrouds (with a shared texture):
  * Note: These are in the "nanolathing" 1000-point tech-tree node.
  * Added 3.75m to 5x 1.25m adapter
  * Added 3.75m to 7x 1.25m adapter
  * Added 5m to 8x 1.25 + 1x 2.5m adapter
  * Added 5m to 2x 2.5m adapter

---

## Version 0.2.1

* 25 Nov 2014
* Quick Fix

* Fixed logo path for SpaceY agency config (for career mode)
* Changed "F1" engine to have conical size-adapting fairings instead of cylindrical. 

---

## Version 0.2.0

* 25 Nov 2014
* Beta updat

* Added "Community Tech Tree" support. If CTT is installed:
  * Moves tall 2.5m SRB to "Gigantic Rocketry"
  * Moves R5 (SaturnV-like) engine to "Gigantic Rocketry"
* Changed sort-order in VAB/SPH menus for SRBs and short tank, so short versions are first. 
  * (requires delete before reinstall of mod, or else you'll get double entries)
* Added "Ejectatron", equivalent to 10x Sepratron.
* Added intermediate height fuel tank. 
* Added 5m & 3.75m external-ring ASAS reaction wheel systems.
* Added "R1" engine (single from the "R5" SaturnV-like cluster). 
  * More thrust than Mainsail, and a little lighter, but much less efficient, costs more, and doesn't stack.
* Added "F1" engine (single from the "F5"/"F9" engines clusters).
  * Less efficient and pricier, but more powerful and lighter than the Skipper. Accepts stacking in 2.5m and 3.75m.
* Slightly improved "R5" engine cluster's efficiency.
* Reduced the price and research costs of all liquid fuel engines.
* Repainted fuel tanks, conical size adapters, and engines to be less "busy", and more SaturnV-like. 
  * Slightly increased the "gloss" on tanks, so that the paint has more of a satin finish.
* Updated TweakScale settings and moved them to a file called "SpaceY-TweakScale.cfg" for easy deletion/modification.

---

## Version 0.1.0

* 17 Nov 2014

* Initial Beta test version

---
