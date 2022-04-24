using Aplication.Interfaces;
using Aplication.Wrappers;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;


namespace Aplication.Feactures.Cultivo.Commands.CreateCultivoCommand
{
    public  class CreateCultivoCommand : IRequest<Response<int>>
    {
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
    }

    public class CreateCultivoCommandHandler : IRequestHandler<CreateCultivoCommand, Response<int>>
    {
        private readonly IRepositoryAsync<Domain.Entities.Cultivo> _repositoryAsync;
        private readonly IMapper _mapper;

        public CreateCultivoCommandHandler(IRepositoryAsync<Domain.Entities.Cultivo> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }
        public async Task<Response<int>> Handle(CreateCultivoCommand request, CancellationToken cancellationToken)
        {
           
            
            var newRecord = _mapper.Map<Domain.Entities.Cultivo>(request);
            var data = await _repositoryAsync.AddAsync(newRecord);

            return new Response<int>(data.id);
        }
    }
}
