using SQLite;
using SviteriTS5.Models;

namespace SviteriTS5.Libs
{
    public class EstudianteDatabase
    {
        private SQLiteAsyncConnection _database;

        public EstudianteDatabase()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "students.db3");

            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Estudiante>().Wait();
        }

        public async Task<List<Estudiante>> GetStudentsAsync()
        {
            return await _database.Table<Estudiante>().ToListAsync();
        }

        public async Task<Estudiante> GetStudentByIdAsync(int id)
        {
            return await _database.Table<Estudiante>().Where(s => s.Id == id).FirstOrDefaultAsync();
        }

        public async Task AddStudentAsync(Estudiante student)
        {
            await _database.InsertAsync(student);
        }

        public async Task UpdateStudentAsync(Estudiante student)
        {
            await _database.UpdateAsync(student);
        }

        public async Task DeleteStudentAsync(int id)
        {
            var student = await GetStudentByIdAsync(id);
            if (student != null)
            {
                await _database.DeleteAsync(student);
            }
        }
    }
}
