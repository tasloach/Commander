using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    /// <summary>
    /// An interface for communicating with the CommanderDB.
    /// </summary>
    public interface ICommanderRepo
    {
        /// <summary>
        /// Saves changes to the database.
        /// </summary>
        /// <returns>Returns <c>true</c> if the save was successful, else <c>false</c>.</returns>
        bool SaveChanges();

        /// <summary>
        /// Retrieves all of the Commands in the CommanderDB.
        /// </summary>
        /// <returns>Returns all of the Commands in the CommanderDB.</returns>
        IEnumerable<Command> GetAllCommands();

        /// <summary>
        /// Retrieves the Command with the given <paramref name="id"/>.
        /// </summary>
        /// <param name="id">The ID of the requested command.</param>
        /// <returns>Returns the Command associated with the given ID.</returns>
        Command GetCommandById(int id);

        /// <summary>
        /// Creates a Command in the database.
        /// </summary>
        /// <param name="command">The command to be created.</param>
        void CreateCommand(Command command);

        /// <summary>
        /// Updates the Command.
        /// </summary>
        /// <param name="command">The Command to be updated.</param>
        void UpdateCommand(Command command);

        /// <summary>
        /// Deletes the Command from the database.
        /// </summary>
        /// <param name="command">The Command to be removed.</param>
        void DeleteCommand(Command command);
    }
}