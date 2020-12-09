using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.IO;
namespace lab12
{
    public class Reflector
    {
        public Reflector()
        {
        }

        static public string AssemblyName(Type type) //Done
        {
            return Assembly.GetAssembly(type).GetName().FullName;
        }

        static public bool HasPublicContainers(Type type) //Done
        {
            if(type.GetConstructors().Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static public IEnumerable<string> GetPublicMethods(Type type) //Done
        {
            return type.GetMethods().Select(t => t.Name);
            //return type.GetMethods(BindingFields.Public).Select(t => t.Name);

        }

        static public IEnumerable<string> GetFieldsAndProperties(Type type)
        {
            /*List<string> listOfFieldsAndProperties = new List<string>();
            foreach(var f in type.GetFields().Select(t => t.Name))
            {
                listOfFieldsAndProperties.Add(f);
            }

            foreach(var p in type.GetProperties().Select(t => t.Name))
            {
                listOfFieldsAndProperties.Add(p);
            }*/

            return type.GetFields().Select(t => t.Name).Concat(type.GetFields().Select(t => t.Name));
        }

        static public IEnumerable<string> GetInterfaces(Type type) //Done
        {
            return type.GetInterfaces().Select(t => t.Name);
        }

        static public IEnumerable<string> GetMethodsWithParam(Type classType, Type methodType) //Done
        {
            return classType.GetType().GetMethods().Where(t => t.GetParameters().Select(parameter => parameter.ParameterType).Contains(methodType)).Select(method => method.Name);
            //return classType.GetType().GetMethods(BindingFlags.DeclaredOnly).Where(t => t.GetParameters().Select(parameter => parameter.ParameterType).Contains(methodType)).Select(method => method.Name);
            //BindingFlags.DeclaredOnly не работает?
        }

        static public object Invoke(Type type, string methodName, string filePath)
        {
            List<string> parameters = File.ReadAllText(filePath).Split('\n').ToList();
            object obj = Activator.CreateInstance(type);

            MethodInfo methodToInvoke = type.GetMethod(methodName);

            string[] methodParams = methodToInvoke.GetParameters().Select(p => p.ParameterType.Name).ToArray();

            /*string[] arrOfParamObj = new string[methodParams.Count];
            for (int i = 0; i < methodParams.Count; i++)
            {
                arrOfParamObj[i] = methodParams[i];
            }*/

            methodToInvoke.Invoke(obj, methodParams);
            return obj;
        }

        static public object Create(Type type) //зачем здесь обобщенный метод???
        {
            return Activator.CreateInstance(type);
        }

        static public object Create(Type type, params object[] arrOfParams)
        {
            return Activator.CreateInstance(type, arrOfParams);
        }
    }
}
