using CoreCleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCleanArchitecture.Domain.Interfaces
{
    public interface IProjectRepository
    {
        IEnumerable<Project> GetProjects();
    }
}
