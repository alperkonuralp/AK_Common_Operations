using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace AK.CommonOperations
{
    /// <summary>
    /// Xml Serializer Factory Static Class
    /// </summary>
    public static class XmlSerializerHelper
    {
        // ReSharper disable InconsistentNaming
        private static readonly SortedList<Type, XmlSerializer> _serializers = new SortedList<Type, XmlSerializer>();
        // ReSharper restore InconsistentNaming

        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static XmlSerializer Get<T>()
        {
            XmlSerializer result;
            if (_serializers.TryGetValue(typeof(T), out result))
            {
                return result;
            }
            result = new XmlSerializer(typeof(T));
            _serializers.Add(typeof(T), result);
            return result;
        }

        /// <summary>
        /// Gets the specified type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public static XmlSerializer Get(Type type)
        {
            XmlSerializer result;
            if (_serializers.TryGetValue(type, out result))
            {
                return result;
            }
            result = new XmlSerializer(type);
            _serializers.Add(type, result);
            return result;
        }

        /// <summary>
        /// Serializes the specified obj.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">The obj.</param>
        /// <returns></returns>
        public static string Serialize(object obj)
        {
            if (obj == null)
            {
                throw new NullReferenceException();
            }
            var ser = Get(obj.GetType());
            using (var stream = new MemoryStream())
            using (var sr = new StreamReader(stream))
            {
                ser.Serialize(stream, obj);
                stream.Flush();
                stream.Seek(0, SeekOrigin.Begin);
                return sr.ReadToEnd();
            }
        }

        /// <summary>
        /// Serializes the specified obj.
        /// </summary>
        /// <param name="obj">The obj.</param>
        /// <param name="encoding">The encoding.</param>
        /// <returns></returns>
        public static string Serialize(object obj, Encoding encoding)
        {
            if (obj == null)
            {
                throw new NullReferenceException();
            }
            var ser = Get(obj.GetType());
            using (var stream = new MemoryStream())
            using (var sr = new StreamReader(stream, encoding))
            {
                ser.Serialize(stream, obj);
                stream.Flush();
                stream.Seek(0, SeekOrigin.Begin);
                return sr.ReadToEnd();
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
            var ser = Get<T>();
            using (var stream = new MemoryStream())
            using (var sw = new StreamWriter(stream))
            {
                sw.Write(serializedString);
                stream.Seek(0, SeekOrigin.Begin);
                return (T)ser.Deserialize(stream);
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
            var ser = Get<T>();
            using (var stream = new MemoryStream())
            using (var sw = new StreamWriter(stream, encoding))
            {
                sw.Write(serializedString);
                stream.Seek(0, SeekOrigin.Begin);
                return (T)ser.Deserialize(stream);
            }
        }
    }
}