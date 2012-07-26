using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace AK.CommonOperations
{
    public static class DataContractJsonSerializerHelper
    {
        // ReSharper disable InconsistentNaming
        private static readonly SortedList<Type, DataContractJsonSerializer> _serializers = new SortedList<Type, DataContractJsonSerializer>();
        // ReSharper restore InconsistentNaming

        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static DataContractJsonSerializer Get<T>()
        {
            DataContractJsonSerializer serializer;
            if (_serializers.TryGetValue(typeof(T), out serializer))
            {
                return serializer;
            }
            serializer = new DataContractJsonSerializer(typeof(T));
            _serializers.Add(typeof(T), serializer);
            return serializer;
        }

        /// <summary>
        /// Gets the specified type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public static DataContractJsonSerializer Get(Type type)
        {
            DataContractJsonSerializer serializer;
            if (_serializers.TryGetValue(type, out serializer))
            {
                return serializer;
            }
            serializer = new DataContractJsonSerializer(type);
            _serializers.Add(type, serializer);
            return serializer;
        }

        /// <summary>
        /// Serializes the specified obj.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">The obj.</param>
        /// <returns></returns>
        public static string Serialize<T>(T obj)
        {
            using (var memoryStream = new MemoryStream())
            using (var streamReader = new StreamReader(memoryStream))
            {
                var ser = Get<T>();
                ser.WriteObject(memoryStream, obj);
                memoryStream.Flush();
                memoryStream.Seek(0, SeekOrigin.Begin);
                return streamReader.ReadToEnd();
            }
        }

        /// <summary>
        /// Serializes the specified obj.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">The obj.</param>
        /// <param name="encoding">The encoding.</param>
        /// <returns></returns>
        public static string Serialize<T>(T obj, Encoding encoding)
        {
            using (var memoryStream = new MemoryStream())
            using (var streamReader = new StreamReader(memoryStream, encoding))
            {
                var ser = Get<T>();
                ser.WriteObject(memoryStream, obj);
                memoryStream.Flush();
                memoryStream.Seek(0, SeekOrigin.Begin);
                return streamReader.ReadToEnd();
            }
        }


        /// <summary>
        /// Deserializes the specified serialized string.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serializedString">The serialized string.</param>
        /// <returns></returns>
        public static T Deserialize<T>(string serializedString)
        {
            using (var memoryStream = new MemoryStream())
            using (var streamWriter = new StreamWriter(memoryStream))
            {
                var ser = Get<T>();
                streamWriter.Write(serializedString);
                streamWriter.Flush();
                memoryStream.Flush();
                memoryStream.Seek(0, SeekOrigin.Begin);
                return (T)ser.ReadObject(memoryStream);
            }
        }

        /// <summary>
        /// Deserializes the specified serialized string.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serializedString">The serialized string.</param>
        /// <param name="encoding">The encoding.</param>
        /// <returns></returns>
        public static T Deserialize<T>(string serializedString, Encoding encoding)
        {
            using (var memoryStream = new MemoryStream())
            using (var streamWriter = new StreamWriter(memoryStream, encoding))
            {
                var ser = Get<T>();
                streamWriter.Write(serializedString);
                streamWriter.Flush();
                memoryStream.Flush();
                memoryStream.Seek(0, SeekOrigin.Begin);
                return (T)ser.ReadObject(memoryStream);
            }
        }
    }
}