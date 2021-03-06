using System;
using System.IO;

namespace Couchbase.Core.IO.Serializers
{
    /// <summary>
    /// Provides an interface for serialization and deserialization of K/V pairs.
    /// </summary>
    public interface ITypeSerializer
    {
        /// <summary>
        /// Deserializes the specified buffer into the <see cref="Type"/> T specified as a generic parameter.
        /// </summary>
        /// <typeparam name="T">The <see cref="Type"/> specified as the type of the value.</typeparam>
        /// <param name="buffer">The buffer to deserialize from.</param>
        /// <returns>The <see cref="Type"/> instance representing the value of the key.</returns>
        T Deserialize<T>(ReadOnlyMemory<byte> buffer);

        /// <summary>
        /// Deserializes the specified stream into the <see cref="Type"/> T specified as a generic parameter.
        /// </summary>
        /// <typeparam name="T">The <see cref="Type"/> specified as the type of the value.</typeparam>
        /// <param name="stream">The stream.</param>
        /// <returns>The <see cref="Type"/> instance representing the value of the key.</returns>
        T Deserialize<T>(Stream stream);

        /// <summary>
        /// Serializes the specified object onto a stream.
        /// </summary>
        /// <param name="stream">The stream to receive the serialized object.</param>
        /// <param name="obj">The object to serialize.</param>
        void Serialize(Stream stream, object obj);
    }
}
