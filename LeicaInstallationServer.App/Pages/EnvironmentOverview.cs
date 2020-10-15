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
using System.Net.Sockets;

namespace LeicaInstallationServer.App.Pages
{
    public partial class EnvironmentOverview
    {
		public IEnumerable<Environments> Employees { get; set; }
        public string statusOfPC;

        [Inject]
		public IEnvironmentDataService EmployeeDataService { get; set; }
	
		protected async override Task OnInitializedAsync()
		{
			Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
            statusOfPC = IsPortOpen("test");
        }

        public  string IsPortOpen(string host)
        {

            using (TcpClient tcpClient = new TcpClient())
            {
                try
                {
                    tcpClient.Connect("10.10.150.130", 8080);
                    return "Connected";
                }
                catch (Exception)
                {
                    //if (IsTurnedOn(host) == "OFF")
                    //{
                    //    return "Powered Off";
                    //}
                    //return "Host Disconnected";
                    return "Disconnected";
                }
            }
        }
    }
}
