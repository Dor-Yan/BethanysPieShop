using BethanysPieShop.Models;
using BethanysPieShop.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public string EmployeeId { get; set; }
        public Employee? Employee { get; set; } = new Employee();

        protected override Task OnInitializedAsync()
        {
            Employee = MockDataService.Employees.FirstOrDefault(e => e.EmployeeId == Int32.Parse(EmployeeId));

            return base.OnInitializedAsync();
        }
    }
}
