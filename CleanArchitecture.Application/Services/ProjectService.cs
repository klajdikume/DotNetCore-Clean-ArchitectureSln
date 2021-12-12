using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository projectService;

        public ProjectService(IProjectRepository projectService)
        {
            this.projectService = projectService;
        }

        public ProjectViewModel GetProjects()
        {
            return new ProjectViewModel()
            {
                Projects = this.projectService.GetProjects()
            };
        }
    }
}
