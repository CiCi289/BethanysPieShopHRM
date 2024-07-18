using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Client.Components
{
  public partial class QuickViewPopup : ComponentBase
  {
    [Parameter]
    public Employee? Employee { get; set; }
    private Employee? _employee;
    protected override void OnParametersSet() //changes _employee: acc to para set
    {
      _employee = Employee;
    }
    public void Close()
    {
      _employee = null;
    }
  }
}
