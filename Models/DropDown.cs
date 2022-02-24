using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;


namespace Scuba_Dive_Log.Models
{
    public class DropDown
    {
        public DropDown()
        {
            DiveType = new List<SelectListItem>();
        }

        [DisplayName("Dive Type")]
        public List<SelectListItem> DiveType
        {
            get;
            set;
        }
    }
}
