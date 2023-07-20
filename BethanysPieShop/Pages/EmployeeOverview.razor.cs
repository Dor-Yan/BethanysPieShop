using BethanysPieShop.Models;
using BethanysPieShop.Shared.Domain;

namespace BethanysPieShop.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee> Employees { get; set; } = default!;


        protected override void OnInitialized()
        {
            Employees = MockDataService.Employees;
        }

    }
}
