using Microsoft.EntityFrameworkCore;
using TfsForms.Data;
using TfsForms.Models;

namespace TfsForms.Services
{
    public interface IAddData
    {
        public Task<int> SubmitData<T>(T model);
    }


    public class AddData(IDbContextFactory<ApplicationDbContext> factory) : IAddData
    {


        public async Task<int> SubmitData<T>(T model)
        {
            try
            {
                using var db = await factory.CreateDbContextAsync();

                await db.AddAsync(model);
                return await db.SaveChangesAsync();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
