using BethanysPieShopHRM.Services;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Runtime.CompilerServices;

namespace BethanysPieShopHRM.Components.Pages
{
  public partial class EmployeeOverview
  {
    public List<Employee> Employees { get; set; } = default!; //better than default! may be? = new List<Employee>();
    protected async override Task OnInitializedAsync()
    {
      await Task.Delay(1000);
      Employees = MockDataService.Employees;
    }
  }
}
