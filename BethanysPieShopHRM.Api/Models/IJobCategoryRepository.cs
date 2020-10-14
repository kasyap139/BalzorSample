using System.Collections.Generic;
using BethanysPieShopHRM.Shared;

namespace LeicaInstallationServer.Api.Models
{
    public interface IJobCategoryRepository
    {
        IEnumerable<JobCategory> GetAllJobCategories();
        JobCategory GetJobCategoryById(int jobCategoryId);
    }
}
