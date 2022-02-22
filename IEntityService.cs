using System.Threading.Tasks;

namespace src.ServiceWithDependencies
{
    public interface IEntityService
    {
        public Task<Dto> Create(Entity entity);
        public Task Delete(int id);
    }
}