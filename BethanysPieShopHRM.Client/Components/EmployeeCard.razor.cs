using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Client.Components
{
  public partial class EmployeeCard
  {

    [Parameter] //parent component will pass down data to EmployeeCard,
                //pass that to this component as para
    public Employee Employee { get; set; } = default!;

    [Parameter] //invoke this event if clicked inside Card,
                //then trigger ShowQuickViewPopup in Overview
    public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }

    protected override void OnInitialized()
    {
      if (string.IsNullOrEmpty(Employee.LastName))
      {
        throw new Exception("Last name cant be empty");
      }
    }
  }
}
