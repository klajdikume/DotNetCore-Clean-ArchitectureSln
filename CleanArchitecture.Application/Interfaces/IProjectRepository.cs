using CoreCleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IProjectRepository
    {
        // repo pattern Mediates between the domain and the data mapping layers using a collection-like interface for accessing the domain objects.
        // It acts as middle layer between the rest of the application and the data access logic

        // It is the domain entity itself
        IEnumerable<Project> GetProjects();
    }
}
