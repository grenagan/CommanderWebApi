using AutoMapper;
using Commander.Dtos;
using Commander.Models;

namespace commander.Profiles
{

    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
           CreateMap<Command, CommandReadDto>(); 
           CreateMap<CommandCreateDto, Command>();
        }
    }

}