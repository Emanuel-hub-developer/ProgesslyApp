using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsProgessly.Data;
using WinFormsProgessly.Entities;

namespace WinFormsProgessly.Services
{
    public class ResponsableService
    {
        private readonly ProgesslyContext _context;

        public ResponsableService()
        {
            _context = new ProgesslyContext();
        }

        public List<ResponsableModel> GetAllResponsableFromDb()
        {
            return _context.Responsables.ToList();
        }

        public void AddResponsable(ResponsableModel responsable)
        {
            _context.Responsables.Add(responsable);
            _context.SaveChanges();
        }

        public void UpdateResponsable(ResponsableModel responsable)
        {
            _context.Responsables.Update(responsable);
            _context.SaveChanges();
        }

        public void DeleteResponsable(int id)
        {
            var responsable = _context.Responsables.Find(id);
            if (responsable != null)
            {
                _context.Responsables.Remove(responsable);
                _context.SaveChanges();
            }
        }

        public ResponsableModel GetResponsableById(int id)
        {
            return _context.Responsables.Find(id);
        }
    }
}
