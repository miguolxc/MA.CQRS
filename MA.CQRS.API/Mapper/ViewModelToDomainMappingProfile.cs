using AutoMapper;
using MA.CQRS.API.Models;
using MA.CQRS.Domain.Commands.Model;

namespace MA.CQRS.API.Mapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CreateUserDto, NewUserCommand>()
                .ConstructUsing(c => new NewUserCommand(c.Name, c.Address));
        }
    }
}
