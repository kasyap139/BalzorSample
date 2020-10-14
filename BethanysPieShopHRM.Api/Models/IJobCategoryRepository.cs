using System.Collections.Generic;
using LeicaInstallation.Shared;

namespace LeicaInstallationServer.Api.Models
{
    public interface IJobCategoryRepository
    {
        IEnumerable<JobCategory> GetAllJobCategories();
        JobCategory GetJobCategoryById(int jobCategoryId);
    }
}
