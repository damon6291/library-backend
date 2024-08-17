using System.ComponentModel;

namespace library_backend.Models.Enums
{
    public enum EnumRole
    {
        [Description("Customer")]
        customer = 1,
        [Description("Librarian")]
        librarian = 2,
    }
}
