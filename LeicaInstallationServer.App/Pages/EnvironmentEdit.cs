using LeicaInstallationServer.App.Services;
using LeicaInstallation.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Diagnostics;
using System.Threading.Tasks;


namespace LeicaInstallationServer.App.Pages
{
    public partial class EnvironmentEdit
    {
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }

        [Parameter]
        public string EmployeeId { get; set; }

		[Inject]
		public NavigationManager NavigationManager { get; set; }

        public Environments Environments { get; set; } = new Environments();
		protected string Message = string.Empty;
		protected string StatusClass = string.Empty;
		protected bool Saved;

		protected override async Task OnInitializedAsync()
        {
			Saved = false;
			int.TryParse(EmployeeId, out var employeeId);

			if (employeeId == 0) //new employee is being created
			{
				//add some defaults
				Environments = new Environments { CountryId = 1, JobCategoryId = 1, BirthDate = DateTime.Now, JoinedDate = DateTime.Now };
			}
			else
			{
				Environments = await EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));
			}
		}

		protected async Task HandleValidSubmit()
		{
			Saved = false;

			if (Environments.EmployeeId == 0) //new
			{
				var addedEmployee = await EmployeeDataService.AddEmployee(Environments);
				if (addedEmployee != null)
				{
					StatusClass = "alert-success";
					Message = "New employee added successfully.";
					Saved = true;
				}
				else
				{
					StatusClass = "alert-danger";
					Message = "Something went wrong adding the new employee. Please try again.";
					Saved = false;
				}
			}
			else
			{
				await EmployeeDataService.UpdateEmployee(Environments);
				StatusClass = "alert-success";
				Message = "Environments updated successfully.";
				Saved = true;
			}
		}

		protected void HandleInvalidSubmit()
		{
			StatusClass = "alert-danger";
			Message = "There are some validation errors. Please try again.";
		}

		protected async Task DeleteEmployee()
		{
			await EmployeeDataService.DeleteEmployee(Environments.EmployeeId);

			StatusClass = "alert-success";
			Message = "Deleted successfully";

			Saved = true;
		}

		protected void NavigateToOverview()
        {
			NavigationManager.NavigateTo("/employeeoverview");
        }

		protected void OpenNotepad()
		{
			Process.Start("notepad.exe");
		}

	}
}
