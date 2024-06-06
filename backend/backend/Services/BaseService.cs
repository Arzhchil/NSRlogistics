using AutoMapper;
using backend.Data;

namespace backend.Services
{
    /// <summary>
    /// Базовый сервис со всеми базовыми настройками для всех сервисов-наследников
    /// </summary>
    public abstract class BaseService
    {
        public DataContext context { get; private set; }
        public IMapper mapper { get; private set; }

        public BaseService(DataContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

    }
}
