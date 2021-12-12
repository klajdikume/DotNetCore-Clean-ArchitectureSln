using CoreCleanArchitecture.Domain.Models;
using CoreCleanArchitecture.Domain.Interfaces;
using CoreCleanArchitecture.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCleanArchitecture.Infrastructure.Data.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ProjectDbContext context;

        public ProjectRepository(ProjectDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Project> GetProjects()
        {
            return this.context.Projects;
        }
    }
}
