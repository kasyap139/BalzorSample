using LeicaInstallationServer.App.Services;
using LeicaInstallation.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeicaInstallationServer.App.Pages
{
    public partial class EmployeeDetail
    {
		[Parameter]
		public string EmployeeId { get; set; }

		public Environments Environments { get; set; } = new Environments();

		[Inject]
		public IEmployeeDataService EmployeeDataService { get; set; }

		protected async override Task OnInitializedAsync()
		{
			Environments = await EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));
		}
	}
}
