using LeicaInstallationServer.App.Services;
using LeicaInstallation.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace LeicaInstallationServer.App.Pages
{
    public partial class EmployeeOverview
    {
		public IEnumerable<Employee> Employees { get; set; }

		[Inject]
		public IEmployeeDataService EmployeeDataService { get; set; }
	
		protected async override Task OnInitializedAsync()
		{
			Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
		}
	}
}
