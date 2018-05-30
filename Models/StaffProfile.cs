using HMTCoreVue.Infrastructure;

namespace HMTCoreVue.Models
{
    public class StaffProfile {
        public string Name {get;set;}
        public string Title {get;set;}
        public Location Location {get;set;}
        public string LocationDescription => this.Location.GetDescription();
        public string Bio {get;set;}
        public string SpecialJobDesignation {get;set;}
        public string ImagePath {get;set;}
        public int OrderIndex {get;set;}
    }
}