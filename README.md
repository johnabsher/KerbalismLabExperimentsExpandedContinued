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

- All of these experiments are accessible via stock parts.  
- Any modded parts using the stock experiments should be tagged correctly.  
- Additional support has been manually configured for:
  - **ScanSat**
  - **Nertea's Near Future** and **Far Future** parts  

I don't play with DMagic or other science mods, so support for those is not included. However, if you want to add support, submit a PR updating `InstrumentTagging.cfg`. If it looks sensible, I will accept it.

### For Modders: 
Experiments take configuration parameters defined [in the Kerbalism docs](https://github.com/Kerbalism/Kerbalism/wiki/TechGuide-~-PartModules-~-Experiment). 

Experiments are tagged in the `InstrumentTagging.cfg` - if you find a part that should be tagged and isn't, please submit a PR. That is also where you would add mod support.

The DLL is a very simple part module that does basically nothing - it just implements a `{type}LabExperimentPackage` which is then attached to relevant parts as needed. It also adds notes to the VAB so you can select appropriately.

