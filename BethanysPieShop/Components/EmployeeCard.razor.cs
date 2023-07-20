using BethanysPieShop.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.Components
{
    public partial class EmployeeCard
    {
        [Parameter]
        public Employee Employee { get; set; } = default!;
    }
}
