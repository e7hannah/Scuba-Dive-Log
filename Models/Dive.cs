using System.ComponentModel.DataAnnotations;

namespace Scuba_Dive_Log.Models
{
    public class Dive
    {
        [Key]
        public Guid Id 
        { get; set; }

        [Required]
       [Display(Name = "Dive Site")]
        public string DiveSite
        { get; set; }

        [Required]
        [Display(Name = "Date/Time")]
        public DateTime DiveDate
        { get; set; }

        [Required]
        [Display(Name = "Buddy #")]
        public int DiveBuddy
        { get; set; }

        [Required]
        [Display(Name = "Dive Type")]
        public DiveType DiveType
        { get; set; }

        [Required]
        [Display(Name = "Max Depth (ft)")]
        public float MaxDepth
        { get; set; }

        [Required]
        [Display(Name = "Dive Time (min)")]
        public int DiveTime
        { get; set; }

        [Display(Name = "Water Type")]
        public WaterType WaterType
        { get; set; }

        [Display(Name = "Body of Water")]
        public BodyOfWater BodyOfWater
        { get; set; }

        [Display(Name = "Weather")]
        public Weather Weather
        { get; set; }

        [Display(Name = "Water Temp (*F)")]
        public float WaterTemperature
        { get; set; }

        [Display(Name = "Visibility")]
        public float Visibility
        { get; set; }

        [Display(Name = "Waves")]
        public Waves Waves
        { get; set; }

        [Display(Name = "Current")]
        public Current Current
        { get; set; }

        [Display(Name = "Surge")]
        public Surge Surge
        { get; set; }

        [Display(Name = "Suit Type")]
        public string? SuitType
        { get; set; }

        [Display(Name = "Weight (lbs)")]
        public int Weight
        { get; set; }

        [Display(Name = "Weighting")]
        public Weighting Weighting
        { get; set; }

        [Display(Name = "Cylinder Type")]
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
