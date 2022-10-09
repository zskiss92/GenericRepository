namespace GenericRepository.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository Student { get; }

        void Save();
    }
}
