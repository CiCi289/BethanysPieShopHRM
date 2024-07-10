﻿using BethanysPieShopHRM.Services;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Components.Pages
{
  public partial class EmployeeDetail
  {
    [Parameter]
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; } = new Employee();
    protected override void OnInitialized()
    {
      Employee = MockDataService.Employees.Single(e => e.EmployeeId == EmployeeId);
      Console.WriteLine($"Employee found: {Employee.FirstName} {Employee.LastName}");
    }
  }

}
