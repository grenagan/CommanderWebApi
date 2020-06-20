
using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data 
{

    public interface ICommanderRepo
    {
         IEnumerable<Command> GetCommands();
         Command GetCommandById(int id);

         void CreateCommand(Command cmd);

         bool dbSaveChanges();
        
    } 


    

}