using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppTestActual.Services
{
    /// <summary>
    ///     The template for the general datastore implimenting all of the CRUD (Create/Read/Update/Delete) Methods.
    ///     ALL METHODS SHOULD RUN ASYNCRONOUSLY
    /// </summary>
    /// <typeparam name="T">The type of the model which this datastore CRUDs</typeparam>
    public interface IDataStore<T>
    {
        /// <summary>
        ///     Create an Item of type T in the datastore
        /// </summary>
        /// <param name="item">The Type this class impliments</param>
        /// <returns>True if successful</returns>
        Task<bool> AddItemAsync(T item);

        /// <summary>
        ///     Update an Item of type T in the datastore
        /// </summary>
        /// <param name="item">The Type this class impliments</param>
        /// <returns>True if successful</returns>
        Task<bool> UpdateItemAsync(T item);

        /// <summary>
        ///     Delete an Item of type T in the datastore
        /// </summary>
        /// <param name="item">The Type this class impliments</param>
        /// <returns>True if successful</returns>
        Task<bool> DeleteItemAsync(T item);

        /// <summary>
        ///     Delete an Item of type T in the datastore
        /// </summary>
        /// <param name="item">The Type this class impliments</param>
        /// <returns>The requested item from the database</returns>
        Task<T> GetItemAsync(string id);

        /// <summary>
        ///     Gets multiple items from the database
        /// </summary>
        /// <param name="id">The ParentId of the model, else leave null</param>
        /// <returns>The requested items from the database</returns>
        Task<IEnumerable<T>> GetItemsAsync(string id = null);

        /// <summary>
        ///     Initializes the datastore
        /// </summary>
        /// <returns>Task to be awaited</returns>
        Task InitializeAsync();

        /// <summary>
        ///     Gets the latest info from the database
        /// </summary>
        /// <returns>True if successful</returns>
        Task<bool> PullLatestAsync();

        /// <summary>
        ///     Sync with the database
        /// </summary>
        /// <returns>Task to be awaited</returns>
        Task<bool> SyncAsync();
    }
}