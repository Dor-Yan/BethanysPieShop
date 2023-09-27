using BethanysPieShop.Models;
using BethanysPieShop.Services;
using BethanysPieShop.Shared.Domain;
using BethanysPieShop.Shared.Model;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.Pages
{
    public partial class EmployeeDetail
    {
        [Inject]
        public IEmployeeDataService? EmployeeDataService { get; set; }

        [Parameter]
        public string EmployeeId { get; set; }
        public Employee? Employee { get; set; } = new Employee();
        public List<Marker> MapMarkers { get; set; } = new List<Marker>();

        protected async override Task OnInitializedAsync()
        {
            Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));

            if(Employee.Longitude.HasValue && Employee.Latitude.HasValue)
            {
                MapMarkers = new List<Marker>()
                {
                    new Marker
                    {
                        Description = $"{Employee.FirstName} {Employee.LastName}",
                        ShowPopup = false,
                        X = Employee.Longitude.Value,
                        Y = Employee.Latitude.Value
                    }
                };
            }

        }
    }
}
