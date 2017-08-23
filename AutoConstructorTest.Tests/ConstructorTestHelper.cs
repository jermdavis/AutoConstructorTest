using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutoConstructorTest.Tests
{

    public static class ConstructorTestHelper
    {
        public static void InitialiseTestHelper(string path)
        {
            Assembly.ReflectionOnlyLoadFrom(path + @"\AutoConstructorTest.dll");
        }

        public static Assembly FetchAssembly(string path)
        {
            return Assembly.ReflectionOnlyLoadFrom(path);
        }

        public static IEnumerable<Type> FetchTypesToTest(Assembly assembly)
        {
            if (assembly == null)
            {
                throw new ArgumentNullException(nameof(assembly));
            }

            var x = assembly.GetTypes()
                .Where(t => t.IsClass && t.IsPublic && !t.IsAbstract)
                .Where(t => t.CustomAttributes.Where(a => a.AttributeType.Name == typeof(NoAutomaticTestAttribute).Name).Any() == false)
                .AsEnumerable();

            return x;
        }

        public static IEnumerable<ConstructorInfo> FetchConstructorsToTest(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            return type.GetConstructors(BindingFlags.Public | BindingFlags.Instance)
                .AsEnumerable();
        }

        public static string FetchDefaultValue(ParameterInfo parameter)
        {
            string defaultValue = null;
            if (parameter.ParameterType.Name == "String")
            {
                defaultValue = "String.Empty";
            }
            else if (parameter.ParameterType.IsValueType)
            {
                var v = Activator.CreateInstance(parameter.ParameterType);
                defaultValue = v.ToString().ToLower();
            }
            else
            {
                defaultValue = "new Mock<" + GenerateTypeName(parameter.ParameterType) + ">().Object";
            }

            return defaultValue;
        }

        public static string GenerateConstructorParameterList(IEnumerable<ParameterInfo> parameters)
        {
            return String.Join(", ", parameters.Select(p => p.Name));
        }

        public static string GenerateTypeName(Type t)
        {
            if (t.IsGenericType)
            {
                string name = t.FullName.Substring(0, t.FullName.IndexOf('`'));

                return name + "<" + String.Join(", ", t.GetGenericArguments().Select(a => GenerateTypeName(a))) + ">";
            }
            else
            {
                return t.FullName;
            }
        }
    }

}