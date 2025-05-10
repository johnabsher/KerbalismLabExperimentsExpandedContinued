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
