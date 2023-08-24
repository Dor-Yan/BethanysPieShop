using BethanysPieShop.Components.Widgets;

namespace BethanysPieShop.Pages
{
    public partial class Index
    {
        public List<Type> Widgets { get; set; } = new List<Type> { typeof(EmployeeCountWidget), typeof(InboxWidget) };
    }
}
