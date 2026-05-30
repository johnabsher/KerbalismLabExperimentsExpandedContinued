using UnityEngine;

namespace KerbalismLabExperimentsExpandedContinued
{
    public class BaseLabExperimentPackage : PartModule
    {
        public override string GetInfo()
        {
            return GetPrettyName();
        }

        public virtual string GetPrettyName()
        {
            return "Base Lab Experiment Package";
        }
    }

    public class DrillLabExperimentPackage : BaseLabExperimentPackage
    {
        public override string GetPrettyName()
        {
            return "Drill Lab Experiment Package";
        }
    }

    public class HighEnergyLabExperimentPackage : BaseLabExperimentPackage
    {
        public override string GetPrettyName()
        {
            return "High Energy Lab Experiment Package";
        }
    }

    public class MultispectralLabExperimentPackage : BaseLabExperimentPackage
    {
        public override string GetPrettyName()
        {
            return "Multispectral Lab Experiment Package";
        }
    }

    public class SurfaceLabExperimentPackage : BaseLabExperimentPackage
    {
        public override string GetPrettyName()
        {
            return "Surface Lab Experiment Package";
        }
    }

    public class TelescopeLabExperimentPackage : BaseLabExperimentPackage
    {
        public override string GetPrettyName()
        {
            return "Telescope Lab Experiment Package";
        }
    }

    public class VisualLabExperimentPackage : BaseLabExperimentPackage
    {
        public override string GetPrettyName()
        {
            return "Visual Lab Experiment Package";
        }
    }

    public class MaterialsLabExperimentPackage : BaseLabExperimentPackage
    {
        public override string GetPrettyName()
        {
            return "Materials Lab Experiment Package";
        }
    }

    public class AtmosphereLabExperimentPackage : BaseLabExperimentPackage
    {
        public override string GetPrettyName()
        {
            return "Atmosphere Lab Experiment Package";
        }
    }

    public class FluidLabExperimentPackage : BaseLabExperimentPackage
    {
        public override string GetPrettyName()
        {
            return "Fluid Lab Experiment Package";
        }
    }

    public class GravityLabExperimentPackage : BaseLabExperimentPackage
    {
        public override string GetPrettyName()
        {
            return "Gravity Lab Experiment Package";
        }
    }

    public class PlasmaLabExperimentPackage : BaseLabExperimentPackage
    {
        public override string GetPrettyName()
        {
            return "Plasma Lab Experiment Package";
        }
    }

    public class BiologyLabExperimentPackage : BaseLabExperimentPackage
    {
        public override string GetPrettyName()
        {
            return "Biology Lab Experiment Package";
        }
    }

    public class SpectrometerLabExperimentPackage : BaseLabExperimentPackage
    {
        public override string GetPrettyName()
        {
            return "Spectrometer Lab Experiment Package";
        }
    }

    public class MagnetometerLabExperimentPackage : BaseLabExperimentPackage
    {
        public override string GetPrettyName()
        {
            return "Magnetometer Lab Experiment Package";
        }
    }

    public class RadarLabExperimentPackage : BaseLabExperimentPackage
    {
        public override string GetPrettyName()
        {
            return "Radar Lab Experiment Package";
        }
    }

    public class RadioLabExperimentPackage : BaseLabExperimentPackage
    {
        public override string GetPrettyName()
        {
            return "Radio Lab Experiment Package";
        }
    }
}