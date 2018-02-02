using System.ComponentModel;

namespace HMTCoreVue.Infrastructure
{
    public enum Location {
        Unknown = 0,
        [Description("Alexandria, VA")]
        Alexandria = 1,
        [Description("Woodbridge, VA")]
        Woodbridge = 2,
        [Description("Fredericksburg, VA")]
        Fredericksburg = 3
    }
}