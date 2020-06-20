using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data 
{

    public class MockCommanderRepo : ICommanderRepo
    {
        public Command GetCommandById(int id)
        {
            return new Command()
            {
                id = id, howTo = "Make an Omelet", line = "Get eggs", platform = "Pan"

            };
        }

        public IEnumerable<Command> GetCommands()
        {
            var Commands = new List<Command> {
                new Command{ id = 1, howTo = "Make a toast", line = "Get bread,cheese and ham slices", platform = "Toaster" },
                new Command { id = 2, howTo = "Make a cup of coffee", line = "Boil water and add coffee", platform = "Boiler and cup"},
                new Command { id = 3, howTo = "Make an Omelet", line = "Get eggs", platform = "Pan" }
            };

            return Commands;
        }

        void ICommanderRepo.CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        bool ICommanderRepo.dbSaveChanges()
        {
            throw new System.NotImplementedException();
        }

        Command ICommanderRepo.GetCommandById(int id)
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<Command> ICommanderRepo.GetCommands()
        {
            throw new System.NotImplementedException();
        }
    }



}