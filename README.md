### Kerbalism Lab Experiments Expanded Continued

This mod is derived from RoadWarrior9's excellent work adding new experiments (Original forum thread: [Kerbalism Lab Experiments Expanded](https://forum.kerbalspaceprogram.com/topic/205823-kerbalism-314-kerbalism-lab-experiments-expanded/))

There hasn't been any activity in that thread for many years, so I'm releasing my updated fork.

![Screenshot 2025-05-10 104047](https://github.com/user-attachments/assets/5ae48346-f6ab-4be8-b8d6-329cee7b557e)

![Screenshot 2025-05-10 104346](https://github.com/user-attachments/assets/d96a9deb-5c1e-43e0-8ebe-a608e9639fd0)

![Screenshot 2025-05-10 104700](https://github.com/user-attachments/assets/cac6bcf8-05c0-4db4-b079-f853d2ac31a2)

### Overview

This mod adds **65 new lab experiments** that can be configured and run in any Kerbalism lab module. Stock KSP labs were too overpowered, so Kerbalism nerfed them, but in doing so made mobile labs and scientists mostly useless. This mod aims to make labs more useful and provide an incentive to build stations and crew them with appropriately leveled scientists.

Here is a [link to the list of experiments](https://docs.google.com/spreadsheets/d/11c_Hf4BjlJEgW0vxni9YcIaKGvTLEcg0nvcFTa3ASqg/edit?gid=0#gid=0).

Each experiment is in its own config file, so you can include only the experiments you are interested in. In-game, when configuring the lab experiment in the VAB, you will see an `S<number>` at the beginning of each description. `S` stands for science value, and the number represents the base science value you get for running the experiment.

Pretty much all these new experiments have some Crew and/or part requirements. The way part requirements work is through a special `LabExperimentPackage` module that is added to parts via a Module Manager Patch. There are currently 17 different types of experiments:

- atmosphere
- biology
- drill
- fluid
- gravity
- greenhouse
- highenergy
- magnetometer
- materials
- multispectral
- plasma
- radar
- radio
- spectrometer
- surface
- telescope
- visual

### Mod Support

- All of these experiments are accessible via stock parts or stock-derived fallback parts supplied by this mod.
- Any modded parts using the stock experiments should be tagged correctly.
- Additional support has been manually configured for:
  - **ScanSat**
  - **Nertea's Near Future** and **Far Future** parts  
- The following Kerbalism configurations have been specifically tested and should work as intended:
  - Kerbalism Default
  - SIMPLEX Kerbalism
  - Kerbalism Science-Only
  - Kerbalism RO

I don't play with DMagic or other science mods, so support for those is not included. However, if you want to add support, submit a PR updating `InstrumentTagging.cfg`. If it looks sensible, I will accept it.

### Required Parts

Some experiments require a matching lab experiment package part. The current package support rules are:

| Category | Rule | Stock / fallback | Kerbalism | SSPX | SpaceDust / FFT | SCANsat |
| --- | --- | --- | --- | --- | --- | --- |
| Atmosphere | Parts with Kerbalism's `atmosphereAnalysis` experiment qualify; SpaceDust gas analysis also qualifies. | <ul><li>Atmospheric Fluid Spectro-Variometer</li></ul> |  |  | <ul><li>SpaceDust: PT-SN1-FER Trace Gas Analyzer</li></ul> |  |
| Biology | Parts with Kerbalism's `mysteryGoo` experiment qualify. | <ul><li>Mystery Goo Containment Unit</li></ul> | <ul><li>Mobile Processing Lab MPL-LG-2</li></ul> | <ul><li>SDV-X 'Cronus' Extensible Centrifuge</li><li>PMA-4 'Nature' Science Lab</li><li>PXL-2 'Fate' Deep-Space Laboratory Module</li><li>SDV-6 'Delphi' Science Module</li></ul> |  |  |
| Drill | Parts with `Drill` in the part name or a resource harvester module qualify. | <ul><li>Drill-O-Matic Junior Mining Excavator</li><li>Drill-O-Matic Mining Excavator</li></ul> | <ul><li>Pump-O-Matic Junior Oceanic Resource Extractor</li><li>Pump-O-Matic Oceanic Resource Extractor</li></ul> |  |  |  |
| Fluid | The atmospheric sensor is tagged for fluid experiments. | <ul><li>Atmospheric Fluid Spectro-Variometer</li></ul> |  |  |  |  |
| Gravity | Parts with Kerbalism's `gravityScan` experiment qualify. | <ul><li>GRAVMAX Negative Gravioli Detector</li></ul> |  |  |  |  |
| Greenhouse | Uses Kerbalism's `Greenhouse` requirement when the active profile provides greenhouse support; otherwise KLEEC greenhouse experiments have no part requirement. |  | <ul><li>Greenhouse</li></ul> | <ul><li>PAS-G 'G4RD3N' Hydroponics Cupola</li><li>PPD-F412M Hydroponics Module</li><li>PXL-R4NCH-3R Hydroponics Module</li><li>PXL-F15H Aquaculture Module</li><li>SDV-4 'Demeter' Cultivation Module</li><li>SDV-G2 'Villa' Cultivation Dome</li></ul> |  |  |
| High Energy | FFT antimatter scanning qualifies when installed; KLEEC also supplies a guaranteed stock-derived fallback package. | <ul><li>High Energy Experiment Package</li></ul> |  |  | <ul><li>FFT: CRANE Gamma Ray Spectrometer</li></ul> |  |
| Magnetometer | Parts with Kerbalism's `magnetometer` experiment qualify. | <ul><li>Magnetometer Boom</li></ul> |  |  |  |  |
| Materials | Parts with Kerbalism's `mobileMaterialsLab` experiment qualify. | <ul><li>SC-9001 Science Jr.</li></ul> | <ul><li>Mobile Processing Lab MPL-LG-2</li></ul> | <ul><li>SDV-X 'Cronus' Extensible Centrifuge</li><li>PMA-4 'Nature' Science Lab</li><li>PXL-2 'Fate' Deep-Space Laboratory Module</li><li>SDV-6 'Delphi' Science Module</li></ul> |  |  |
| Multispectral | Stock orbital resource scanning qualifies; SCANsat multispectral scanners also qualify. | <ul><li>M4435 Narrow-Band Scanner</li></ul> |  |  |  | <ul><li>MS-R Enhanced Multispectral Scanner</li><li>MS-1 Multispectral Scanner</li><li>MS-2A Advanced Multispectral Scanner</li></ul> |
| Plasma | The stock survey scanner qualifies. | <ul><li>M700 Survey Scanner</li></ul> |  |  |  |  |
| Radar | Stock survey scanning qualifies; SCANsat radar and SAR parts also qualify. | <ul><li>M700 Survey Scanner</li></ul> |  |  |  | <ul><li>R-3B Radar Altimeter</li><li>R-EO-1 Radar Antenna</li><li>SAR-X Antenna</li><li>SAR-C Antenna</li><li>SAR-L Antenna</li></ul> |
| Radio | KLEEC supplies a guaranteed stock-derived radio telescope fallback. | <ul><li>RA-100T Radio Telescope</li></ul> |  |  |  |  |
| Spectrometer | Stock narrow-band scanning qualifies; SCANsat resource scanners, FFT gas scanning, and SpaceDust spectrometry also qualify. | <ul><li>M4435 Narrow-Band Scanner</li></ul> |  |  | <ul><li>FFT: CHROMA Imaging Spectrometer</li><li>SpaceDust: PT-L00K-ER Spectrographic Gas Scanner</li></ul> | <ul><li>SCAN-R Resource Mapper</li><li>SCAN-RX Hyperspectral Resource Mapper</li><li>SCAN-R2 Advanced Resource Mapper</li></ul> |
| Surface | Stock surface scanning qualifies. | <ul><li>Surface Scanning Module</li></ul> |  |  |  |  |
| Telescope | Infrared telescope experiments qualify; SpaceDust telescopes also qualify. | <ul><li>SENTINEL Infrared Telescope</li></ul> |  |  | <ul><li>SpaceDust: PT-EDW1N Spectral Telescope</li></ul> |  |
| Visual | Cupolas and visual observation experiments qualify; SCANsat recon imagers also qualify. | <ul><li>PPD-12 Cupola Module</li></ul> |  | <ul><li>PAS-C 'Porthole' Observation Window</li><li>PMA-C 'Panoptes' Observation Module</li><li>PXL-9 'Vista' Astrogation Module</li><li>SDV-G4 'Astrolabe' Observation Dome</li></ul> |  | <ul><li>VS-1 High Resolution Imager</li><li>VS-11 Classified Reconnaissance Imager</li><li>VS-3 Advanced High Resolution Imager</li></ul> |

### For Modders: 
Experiments take configuration parameters defined [in the Kerbalism docs](https://github.com/Kerbalism/Kerbalism/wiki/TechGuide-~-PartModules-~-Experiment). 

Experiments are tagged in the `InstrumentTagging.cfg` - if you find a part that should be tagged and isn't, please submit a PR. That is also where you would add mod support.

The DLL is a very simple part module that does basically nothing - it just implements a `{type}LabExperimentPackage` which is then attached to relevant parts as needed. It also adds notes to the VAB so you can select appropriately.

### Package Availability

The stock patches attach package modules to matching science parts where possible. KLEEC also creates stock-derived fallback parts for package types that otherwise would not be guaranteed in a pure stock + Kerbalism install, including radio and high-energy packages. Greenhouse experiments have no part requirement by default, but use Kerbalism's `Greenhouse` requirement when the Kerbalism Default profile is installed without Kerbalism Science-Only.

### Duration Tuning

Experiment duration is controlled by each experiment's `duration` value and the global `LabDataRateMultiplier`. The default multiplier is `1`; setting it to `2` makes KLEEC lab experiments take twice as long, while `0.5` makes them finish in half the time.

KLEEC stages ModuleManager patches as settings in `:BEFORE[KerbalismLabExperimentsExpandedContinued]`, lab setup and fallback part creation in `:FOR[KerbalismLabExperimentsExpandedContinued]`, and final value application in `:AFTER[KerbalismLabExperimentsExpandedContinued]`. This keeps final value copying before Kerbalism removes its temporary settings node. Global tuning patches can run in `:BEFORE[KerbalismLabExperimentsExpandedContinued]`.

Example user patch:

```cfg
@KERBALISM_GROUP_SETTINGS:NEEDS[FeatureScience]:BEFORE[KerbalismLabExperimentsExpandedContinued]
{
	@LAB_EXPERIMENTS
	{
		@LabDataRateMultiplier = 2
	}
}
```

Some orbital biome experiments are intentionally shorter because the vessel must pass over the target biome. The currently intentional short orbital-biome experiments are `CATS`, `CubeRRT`, `GEDI`, `ISSAC`, `ECOSTRESS`, `SPOC`, `TAPAR-1`, `BeaverCube`, and `SOCP-7`.

If you want those short biome experiments to take twice as long, apply a patch like this in your own config. It runs in `:FINAL` so it adjusts the rendered Kerbalism experiment modules directly. Add the remaining short-biome experiment IDs to the `|` list as needed.

```cfg
@PART[*]:HAS[@MODULE[Experiment]]:FINAL
{
	@MODULE[Experiment]:HAS[#experiment_id[kerbalism_CATS|kerbalism_CubeRRT]]
	{
		@data_rate /= 2
	}
}
```
