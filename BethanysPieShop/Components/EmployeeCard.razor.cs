﻿using BethanysPieShop.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.Components
{
    public partial class EmployeeCard
    {
        [Parameter]
        public Employee Employee { get; set; } = default!;
        [Parameter]
        public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        public void NavigateToDetails(Employee selectedEmployee)
        {
            NavigationManager.NavigateTo($"/employeedetail/{selectedEmployee.EmployeeId}");
        }
    }
}
