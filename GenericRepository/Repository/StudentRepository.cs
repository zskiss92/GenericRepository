using GenericRepository.Data;
using GenericRepository.Models;

namespace GenericRepository.Repository
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        private readonly ApplicationDbContext _db;

        public StudentRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Student student)
        {
            var objFromDb = _db.Students.FirstOrDefault(x => x.Id == student.Id);
            objFromDb.FirstName = student.FirstName;
            objFromDb.LastName = student.LastName;
        }
    }
}
