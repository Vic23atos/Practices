using System.Threading.Tasks;

namespace src.ServiceWithDependencies
{
    public interface IRepository
    {
        public Task<Entity> GetById(int id);
        public Task<Entity> Insert(Entity entity);

        public Task<Entity> Update(Entity entity);
        public Task<Entity> Delete(int id);
    }
}