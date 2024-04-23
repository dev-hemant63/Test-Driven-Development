using Repository.DTO_s;

namespace Repository.Interfaces
{
    public interface IStudent
    {
        Task<object> Save(StudentReq req);
    }
}
