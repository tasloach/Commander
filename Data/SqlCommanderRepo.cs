using System;
using System.Collections.Generic;
using System.Linq;
using Commander.Models;

namespace Commander.Data
{
    /// <inheritdoc cref="ICommanderRepo"/>
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;

        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }

        /// <inheritdoc />
        public void CreateCommand(Command command)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            _context.Add(command);
        }

        /// <inheritdoc />
        public void DeleteCommand(Command command)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            _context.Commands.Remove(command);
        }

        /// <inheritdoc />
        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        /// <inheritdoc />
        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }
        /// <inheritdoc />

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }

        /// <inheritdoc />
        public void UpdateCommand(Command command)
        {
            //Nothing
        }
    }
}