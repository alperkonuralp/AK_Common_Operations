using System;
using System.Linq;
using System.Reflection;
using AK.CommonOperations.Properties;


namespace AK.CommonOperations
{
    /// <summary>
    /// Json.Net Serialization Helper
    /// </summary>
    public static class JsonNetSerializerHelper
    {
        private static Assembly _assembly;
        private static Type _class;
        private static MethodInfo _serializeMethod;
        private static MethodInfo _deserializeMethod;

        /// <summary>
        /// Serializes the specified obj.
        /// </summary>
        /// <param name="obj">The obj.</param>
        /// <returns></returns>
        public static string Serialize(object obj)
        {
            CheckFields();

            //return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
            return _serializeMethod.Invoke(null, new[] { obj }) as string;
        }

        /// <summary>
        /// Checks the fields.
        /// </summary>
        private static void CheckFields()
        {
            if (_assembly != null) return;

            _assembly = Assembly.Load("Newtonsoft.Json");

            if (_assembly == null) throw new AssemblyNotFoundException(String.Format(ExceptionMessages.AssemblyNotFoundExceptionMessage, "Newtonsoft.Json"));

            _class = _assembly.GetType("Newtonsoft.Json.JsonConvert");
            var mets = _class.GetMethods();
            //_serializeMethod = mets.Where(x=>x.Name == "SerializeObject"), new[] { typeof(object) });
            _serializeMethod = mets.FirstOrDefault(x =>
                                                       {
                                                           var a = x.GetParameters();
                                                           return x.Name == "SerializeObject" && a.Length == 1 &&
                                                                  a[0].ParameterType == typeof(object);
                                                       });
            //_deserializeMethod = _class.GetMethod("DeserializeObject", new[] { typeof(string) });
            _deserializeMethod = mets.FirstOrDefault(x =>
            {
                var a = x.GetParameters();
                return x.Name == "DeserializeObject" && a.Length == 1 && x.IsGenericMethod &&
                        x.ReturnType.IsGenericParameter;
            });
        }

        /// <summary>
        /// Deserializes the specified json string.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonString">The json string.</param>
        /// <returns></returns>
        public static T Deserialize<T>(string jsonString)
        {
            CheckFields();
            //return (T)Newtonsoft.Json.JsonConvert.DeserializeObject(jsonString);
            var a = _deserializeMethod.MakeGenericMethod(typeof(T));
            return (T)a.Invoke(null, new object[] { jsonString });
        }
    }
}