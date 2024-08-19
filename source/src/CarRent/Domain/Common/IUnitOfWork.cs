namespace CarRent.Domain.Common
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
