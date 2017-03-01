using KickOff.Models;
using KickOff.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KickOff.Service
{
    public interface ProjectService
    {
        Project ProjectViewModelToProjectModel(ProjectViewModel projectViewModel);

        ProjectViewModel ProjectModelToProjectViewModel(Project project);

        Project PersistProject(Project project);

        Task<int> Insert(Project project);
    }
}
