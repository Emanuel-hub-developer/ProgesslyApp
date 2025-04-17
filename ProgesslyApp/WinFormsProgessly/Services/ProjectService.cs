using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsProgessly.Data;
using WinFormsProgessly.Entities;

namespace WinFormsProgessly.Services
{
    public class ProjectService
    {
        
            private readonly ProgesslyContext _context;

            public ProjectService()
            {
                _context = new ProgesslyContext();
            }

            public List<ProjectModel> GetAllProjectsFromDb()
            {
                return _context.Projects.ToList();
            }

            public void AddProject(ProjectModel project)
            {
                _context.Projects.Add(project);
                _context.SaveChanges();
            }

            public void UpdateProject(ProjectModel project)
            {
                _context.Projects.Update(project);
                _context.SaveChanges();
            }

            public void DeleteProject(int id)
            {
                var project = _context.Projects.Find(id);
                if (project != null)
                {
                    _context.Projects.Remove(project);
                    _context.SaveChanges();
                }
            }

            public ProjectModel GetProjectById(int id)
            {
                return _context.Projects.Find(id);
            }
        
    }
}
