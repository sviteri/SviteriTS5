using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SviteriTS5.Models
{
    public interface IEstudiante
    {
        Task<List<Estudiante>> GetStudentsAsync();
        Task<Estudiante> GetStudentByIdAsync(int id);
        Task AddStudentAsync(Estudiante student);
        Task UpdateStudentAsync(Estudiante student);
        Task DeleteStudentAsync(int id);
    }
}
