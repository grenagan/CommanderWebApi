using System.Collections.Generic;
using AutoMapper;
using Commander.Data;
using Commander.Dtos;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;


namespace commander.Controllers{


[Route("api/commands")]
[ApiController]
public class CommandsController : ControllerBase
{

        private readonly ICommanderRepo _repository;
        private readonly IMapper _mapper;

        public CommandsController(ICommanderRepo Repository,IMapper mapper)
    {
        _repository = Repository;
        _mapper = mapper;
    }


//    private readonly MockCommanderRepo _repository = new MockCommanderRepo();

    [HttpGet]
    public ActionResult<IEnumerable<CommandReadDto>> GetCommands()
    {
        var commandItems = _repository.GetCommands();

        return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandItems));


    }

    [HttpGet("{id}", Name="GetCommandById")]
    public ActionResult<CommandReadDto> GetCommandById(int id)
    {
        var commandItem = _repository.GetCommandById(id);

        if(commandItem != null)
        {
           return Ok(_mapper.Map<CommandReadDto>(commandItem)); 
        }
        return NotFound();
    }

    [HttpPost]
    public ActionResult<CommandReadDto> CreateCommand(CommandCreateDto  cmd)
    {
        var commandItem = _mapper.Map<Command>(cmd);

         _repository.CreateCommand(commandItem);
        if(_repository.dbSaveChanges())
        {
            var cmdReadDto = _mapper.Map<CommandReadDto>(commandItem);
            return CreatedAtRoute(nameof(GetCommandById), new {id = cmdReadDto.id}, cmdReadDto);

        }
        return NotFound();


    }



}

}