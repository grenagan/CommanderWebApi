using System;
using System.Collections.Generic;
using System.Linq;
using Commander.Models;

namespace Commander.Data
{

    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;

        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }

        public void CreateCommand(Command cmd)
        {
            if(cmd == null)
            {
               throw new ArgumentNullException();
            }
           _context.Add(cmd);
        
        }

        public bool dbSaveChanges()
        {
            _context.SaveChanges();
            return true;
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(x => x.id == id);
        }

        public IEnumerable<Command> GetCommands()
        {
            return _context.Commands.ToList();
        }
    }


}