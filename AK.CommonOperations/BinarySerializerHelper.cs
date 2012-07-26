using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AK.CommonOperations
{
    /// <summary>
    /// Helper for binary serialization 
    /// </summary>
    public static class BinarySerializerHelper
    {
        public static readonly BinaryFormatter Formatter = new BinaryFormatter();

        /// <summary>
        /// Serializes the specified obj.
        /// </summary>
        /// <param name="obj">The obj.</param>
        /// <returns></returns>
        public static byte[] Serialize(object obj)
        {
            using (var serializationStream = new MemoryStream())
            {
                Formatter.Serialize(serializationStream, obj);
                return serializationStream.ToArray();
            }
        }

        /// <summary>
        /// Deserializes the specified serialized byte array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serializedByteArray">The serialized byte array.</param>
        /// <returns></returns>
        public static T Deserialize<T>(byte[] serializedByteArray)
        {
            using (var serializationStream = new MemoryStream(serializedByteArray))
            {
                return (T)Formatter.Deserialize(serializationStream);
            }
        }
    }
}