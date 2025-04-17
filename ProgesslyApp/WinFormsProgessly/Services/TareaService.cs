using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsProgessly.Data;
using WinFormsProgessly.Entities;

namespace WinFormsProgessly.Services
{
  
        public class TareaService
        {
            private readonly ProgesslyContext _context;

            public TareaService()
            {
                _context = new ProgesslyContext();
            }

            public List<TareaModel> GetAllTareasFromDb()
            {
                return _context.Tareas.ToList();
            }

            public void AddTarea(TareaModel tarea)
            {
                _context.Tareas.Add(tarea);
                _context.SaveChanges();
            }

            public void UpdateTarea(TareaModel tarea)
            {
                _context.Tareas.Update(tarea);
                _context.SaveChanges();
            }

            public void DeleteTarea(int id)
            {
                var tarea = _context.Tareas.Find(id);
                if (tarea != null)
                {
                    _context.Tareas.Remove(tarea);
                    _context.SaveChanges();
                }
            }

            public TareaModel GetTareaById(int id)
            {
                return _context.Tareas.Find(id);
            }
        }
    }

