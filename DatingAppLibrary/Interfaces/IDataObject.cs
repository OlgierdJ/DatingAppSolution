using System;
using System.Collections.Generic;
using System.Text;

namespace DatingAppLibrary.Interfaces
{
    public interface IDataObject<T>
    {
        /// <summary>
        /// Reads a single object via the object ID.
        /// </summary>
        /// <param name="ObjectID">ID of generic object.</param>
        /// <returns>Generic object.</returns>
        T Get(int ObjectID);
        /// <summary>
        /// Reads generic list.
        /// </summary>
        /// <returns>Generic list.</returns>
        IEnumerable<T> GetAll();
        /// <summary>
        /// Adds a new object to a generic list.
        /// </summary>
        /// <param name="newObject">New instantiation of the generic object to be added to the list.</param>
        /// <returns>Newly added instantiation of the generic object.</returns>
        T Create(T newObject);
        /// <summary>
        /// Updates an object.
        /// </summary>
        /// <param name="changedObject">Generic object that was changed.</param>
        /// <returns>Newly updated object.</returns>
        T Update(T changedObject);
        /// <summary>
        /// Deletes a single object via the object ID.
        /// </summary>
        /// <param name="ObjectID">ID of generic object.</param>
        /// <returns>Generic object.</returns>
        T Delete(int objectID);
    }
}
