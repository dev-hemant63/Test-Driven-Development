using Persistence;
using Repository.DTO_s;
using Repository.Interfaces;

namespace Repository.Services
{
    public class Student:IStudent
    {
        private readonly IContext _context;
        public Student(IContext context)
        {
            _context = context;
        }
        public async Task<object> Save(StudentReq req)
        {
            var res = await _context.ExceProcAsync<object>("Proc_SaveStudent",new
            {
                req.Name
            },System.Data.CommandType.StoredProcedure);
            return res;
        }
    }
}
