using GenericRepository.Models;

namespace GenericRepository.Repository
{
    public interface IStudentRepository : IRepository<Student>
    {
        void Update(Student student);
        void Save();
    }
}
