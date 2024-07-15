﻿using BethanysPieShopHRM.Contracts.Services;
using BethanysPieShopHRM.Services;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Runtime.CompilerServices;

namespace BethanysPieShopHRM.Components.Pages
{
  public partial class EmployeeOverview
  {
    public List<Employee> Employees { get; set; } = default!; //better than default! may be? = new List<Employee>();
    private Employee? _selectedEmployee;
    private string Title = "Employee Overview";

    [Inject]
    public IEmployeeDataService? EmployeeDataService { get; set; }

    protected async override Task OnInitializedAsync()
    {
      Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
    }

    public void ShowQuickViewPopup(Employee selctedEmployee) //sets emp value, also for QuickViewPopup comp
    {
      _selectedEmployee = selctedEmployee;
    }
  }
}
