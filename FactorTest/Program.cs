using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorTest
{
    class Program
    {
        static void Main1(string[] args)
        {
            ////方法一
            //AbsFruit absFruit = FruitFactory.CreateInstance<AbsFruit>("FactorTest", "Strawberry");
            //absFruit.Show();
            //Console.ReadKey();
            ////方法二
            ////string fullTypeName = typeof (Strawberry).FullName;
            //string fullTypeName = typeof(Strawberry).AssemblyQualifiedName;
            //AbsFruit absFruit2 = FruitFactory.CreateInstance<AbsFruit>(fullTypeName);
            //absFruit2.Show();
            //Console.ReadKey();
            //需求：将整型集合list中的所有元素倒序排列打印出来
            List<int> list = new List<int>() { 8, 2, 9, 4, 5,3,1,10 };
            //将匿名方法分配给 Comparison<T> 委托实例
            Comparison<int> concat1 = delegate (int i, int j) { return j - i; };
            //将 lambda 表达式分配给 Comparison<T> 委托实例
            Comparison<int> concat2 = (i, j) => i-j;

            //list.Sort(concat1);
            //list.ForEach(c => Console.WriteLine(c.ToString()));
            list.Sort((i,j)=>j-i);
            list.ForEach(c => Console.WriteLine(c.ToString()));
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Type type= typeof(UserDTO);
            string name = type.Name.Replace("DTO","Entity");
            Type type1= Type.GetType("FactorTest.service.Person");
            Object obj = Activator.CreateInstance(type1);
            string guid= Guid.NewGuid().ToString();

            //Type type1 = typeof(name);
            Console.ReadKey();
        }
        public void Get<T>()
        {
            Console.WriteLine($"{typeof(T)}");
        }
    }
}
