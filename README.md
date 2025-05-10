<<<<<<< HEAD
<<<<<<< HEAD
# KerbalismLabExperimentsExpandedContinued
Adding 60+ new Kerbalism lab experiments to KSP
=======


### For Modders: Experiment Configuration (from [Kerbalism docs](https://kerbalism.readthedocs.io/en/latest/modders/modules.html#experiment))
---------------------------------------------
REQUIREMENTS field acceptible parameters from code:
```

			OrbitMinInclination,
			OrbitMaxInclination,
			OrbitMinEccentricity,
			OrbitMaxEccentricity,
			OrbitMinArgOfPeriapsis,
			OrbitMaxArgOfPeriapsis,

			TemperatureMin,
			TemperatureMax,
			AltitudeMin,
			AltitudeMax,
			RadiationMin,
			RadiationMax,
			Shadow,
			Sunlight,
			CrewMin,
			CrewMax,
			CrewCapacityMin,
			CrewCapacityMax,
			VolumePerCrewMin,
			VolumePerCrewMax,
			Greenhouse,
			AtmosphereAltMin,
			AtmosphereAltMax,

			SunAngleMin,
			SunAngleMax,

			AbsoluteZero,
			InnerBelt,
			OuterBelt,
			MagneticBelt,
			Magnetosphere,
			InterStellar,

			SurfaceSpeedMin,
			SurfaceSpeedMax,
			VerticalSpeedMin,
			VerticalSpeedMax,
			SpeedMin,
			SpeedMax,
			DynamicPressureMin,
			DynamicPressureMax,
			StaticPressureMin,
			StaticPressureMax,
			AtmDensityMin,
			AtmDensityMax,
			AltAboveGroundMin,
			AltAboveGroundMax,

			Part,
			Module,
			MaxAsteroidDistance,

			AstronautComplexLevelMin,
			AstronautComplexLevelMax,
			TrackingStationLevelMin,
			TrackingStationLevelMax,
			MissionControlLevelMin,
			MissionControlLevelMax,
			AdministrationLevelMin,
			AdministrationLevelMax,
```
Situation from code:
```
	public enum ScienceSituation : byte
	{
		None          = byte.MaxValue,
		// stock situations
		SrfLanded     = 0,
		SrfSplashed   = 1,
		FlyingLow     = 2,
		FlyingHigh    = 3,
		InSpaceLow    = 4,
		InSpaceHigh   = 5,
		// Kerbalism extensions
		Surface       = 11,
		Flying        = 12,
		Space         = 13,
		BodyGlobal    = 14
	}

	public enum VirtualBiome : byte
	{
		None               = 0,
		NoBiome            = byte.MaxValue, // if used, will be registered as the global, biome-agnostic situation 
		NorthernHemisphere = 254,
		SouthernHemisphere = 253,
		InnerBelt          = 252,
		OuterBelt          = 251,
		Magnetosphere      = 250,
		Interstellar       = 249,
		Reentry            = 248,
		Storm              = 247
	}
```
BodyCondition from code:\
```
	Atmospheric
	NonAtmospheric
	Gaseous
	Solid
	Oceanic
	HomeBody
	HomeBodyAndMoons
	Planets
	Moons
	Suns
	SpecificBody
```

Localization Strings:
```
    #KERBALISM_ExperimentInfo_Unknown = Desconocido // "Unknown"
    #KERBALISM_Experimentinfo_Datasize = Data size // "Data size"
    #KERBALISM_Experimentinfo_generatesample = Will generate a sample. // "Will generate a sample."
    #KERBALISM_Experimentinfo_Samplesize = Sample size: // "Sample size:"
    #KERBALISM_Experimentinfo_Samplemass = Sample mass: // "Sample mass:"
    #KERBALISM_Experimentinfo_Situations = Situations:\n // "Situations:\n"
    #KERBALISM_Experimentinfo_Asteroid = Asteroid samples can be taken by kerbals on EVA // "Asteroid samples can be taken by kerbals on EVA"
    #KERBALISM_Experimentinfo_scannerarm = Analyse with a scanner arm // "Analyse with a scanner arm"
    #KERBALISM_Experimentinfo_smallRoc = Collectable on EVA as a sample // "Collectable on EVA as a sample"
    #KERBALISM_Experimentinfo_smallRoc2 = Can't be collected on EVA // "Can't be collected on EVA"
    #KERBALISM_Experimentinfo_smallRoc3 = Found on <<1>>'s : // "Found on <<1>>'s :"
    #KERBALISM_Experimentinfo_Bodiesallowed = Bodies allowed: // "Bodies allowed:"
    #KERBALISM_Experimentinfo_Bodiesnotallowed = Bodies not allowed: // "Bodies not allowed:"
    #KERBALISM_Experimentinfo_BodyCondition1 = atmospheric // "atmospheric"
    #KERBALISM_Experimentinfo_BodyCondition2 = non-atmospheric // "non-atmospheric"
    #KERBALISM_Experimentinfo_BodyCondition3 = gaseous // "gaseous"
    #KERBALISM_Experimentinfo_BodyCondition4 = solid // "solid"
    #KERBALISM_Experimentinfo_BodyCondition5 = oceanic // "oceanic"
    #KERBALISM_Experimentinfo_BodyCondition6 = home body // "home body"
    #KERBALISM_Experimentinfo_BodyCondition7 = home body and its moons // "home body and its moons"
    #KERBALISM_Experimentinfo_BodyCondition8 = planets // "planets"
    #KERBALISM_Experimentinfo_BodyCondition9 = moons // "moons"
    #KERBALISM_Experimentinfo_BodyCondition10 = suns // "suns"
```
>>>>>>> ecae4d5 (Update and rename README.txt to README.md)
=======
### Kerbalism Lab Experiments Expanded Continued

This mod is derived from RoadWarrior9's excellent work adding new experiments (Original forum thread: [Kerbalism Lab Experiments Expanded](https://forum.kerbalspaceprogram.com/topic/205823-kerbalism-314-kerbalism-lab-experiments-expanded/))

There hasn't been any activity in that thread for many years, so I'm releasing my updated fork.

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

- All of these experiments are accessible via stock parts.  
- Any modded parts using the stock experiments should be tagged correctly.  
- Additional support has been manually configured for:
  - **ScanSat**
  - **Nertea's Near Future** and **Far Future** parts  

I don't play with DMagic or other science mods, so support for those is not included. However, if you want to add support, submit a PR updating `InstrumentTagging.cfg`. If it looks sensible, I will accept it.

### For Modders: 
Experiments take configuration parameters defined [in the Kerbalism docs](https://kerbalism.readthedocs.io/en/latest/modders/modules.html#experiment). 

Experiments are tagged in the `InstrumentTagging.cfg` - if you find a part that should be tagged and isn't, please submit a PR. That is also where you would add mod support.

The DLL is a very simple part module that does basically nothing - it just implements a `{type}LabExperimentPackage` which is then attached to relevant parts as needed. It also adds notes to the VAB so you can select appropriately.
>>>>>>> acd5085 (Updating Readme)
