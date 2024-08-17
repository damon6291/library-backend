using Microsoft.OpenApi.Attributes;
using System.ComponentModel;

namespace library_backend.Models.Enums
{
    public enum EnumBookCategory
    {
        [Description("Fiction")]
        fiction = 1,
        [Description("Non-fiction")]
        nonfiction = 2,
        [Description("Novel")]
        novel = 3,
        [Description("Romance")]
        romance = 4,
        [Description("Children")]
        children = 5,
        [Description("Biography")]
        biography = 6,
        [Description("Autobiography")]
        autobiography = 7,
        [Description("Mystery")]
        mystery = 8
    }
}
