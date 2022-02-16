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
    }

    public enum DiveType
    { Shore, Boat, Other}
}
