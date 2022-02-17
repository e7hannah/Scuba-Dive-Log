using System.ComponentModel.DataAnnotations;

namespace Scuba_Dive_Log.Models
{
    public class Dive
    {
        [Key]
        public Guid Id 
        { get; set; }
        public string DiveSite
        { get; set; }
        public DateTime DiveDate
        { get; set; }
        public int DiveBuddy
        { get; set; }
        public DiveType DiveType
        { get; set; }
        public float MaxDepth
        { get; set; }
        public int DiveTime
        { get; set; }
        public WaterType WaterType
        { get; set; }
        public BodyOfWater BodyOfWater
        { get; set; }
        public Weather Weather
        { get; set; }
        public float WaterTemperature
        { get; set; }
        public float Visibility
        { get; set; }
        public Waves Waves
        { get; set; }
        public Current Current
        { get; set; }
        public Surge Surge
        { get; set; }
        public string SuitType
        { get; set; }
        public int Weight
        { get; set; }
        public Weighting Weighting
        { get; set; }
        public CylinderType CylinderType
        { get; set; }
    }

    public enum DiveType
    { Shore, Boat, Other}

    public enum WaterType
    { Salt, Fresh}

    public enum BodyOfWater
    { Ocean, Lake, Quarry, River, Other}

    public enum Weather
    { Sunny, Partly_Cloudy, Cloudy, Rainy, Windy, Foggy}
    public enum Waves
    { None, Small, Medium, Large}
    public enum Current
    { None, Light, Medium, Heavy}
    public enum Surge
    { Light, Medium, Heavy}
    public enum Weighting
    { Light, Good, Heavy}
    public enum CylinderType
    { Steel, Aluminum, Other}
    
}
