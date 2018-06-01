using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FactorTest
{
    public class FruitFactory
    {
        public static T CreateInstance<T>(string nameSpace, string className)
        {
            string fullClassName = nameSpace + "." + className;
            return (T)Assembly.Load(nameSpace).CreateInstance(fullClassName);
        }

        public static T CreateInstance<T>(string fullTypeName)
        {
            return (T)Activator.CreateInstance(Type.GetType(fullTypeName));
        }
    }

    public abstract class AbsFruit
    {
        protected string Name { get; set; }
        public abstract void Show();
    }
    class Strawberry : AbsFruit
    {
        public Strawberry()
        {
            Name = "草莓";
        }
        public override void Show()
        {
            Console.WriteLine("水果类型：" + Name);
        }
    }
}
