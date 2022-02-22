using System.Threading.Tasks;

namespace src.ServiceWithDependencies
{
    public class EntityService : IEntityService
    {
        private readonly IRepository _repository;


        public EntityService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<Dto> Create(Entity entity)
        {
            await _repository.Insert(entity);
            Dto dto = new Dto(entity.Id, entity.Name);
            return dto;
        }

        public async Task Delete(int id)
        {
            await _repository.Delete(id);
            ;
        }
    }
}