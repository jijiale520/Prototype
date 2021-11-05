using System;
using Prototype.Properties;

namespace Prototype
{
    internal class Program
    {
        public static void Main(string[] args)
        {
             Video v1 = new Video();
             v1.SetName("原型模式教学");
             v1.SetDateTime(DateTime.Now);
             v1.SetVisionNum(1);
             Console.WriteLine("name = {0}, datetime = {1}, hashCode = {2}, vision = {3}",
                 v1.GetName(), v1.GetDateTime(), v1.GetHashCode(), v1.GetVisionNum());

             Video v2 = v1.DeepCopy();
             // Video v2 = v1.XMLDeepCopy();
             v2.SetDateTime(DateTime.Today);
             v2.SetVisionNum(2);
             Console.WriteLine("name = {0}, datetime = {1}, hashCode = {2}, vision = {3}", 
                 v2.GetName(), v2.GetDateTime(), v2.GetHashCode(), v2.GetVisionNum());
             
             Console.WriteLine("name = {0}, datetime = {1}, hashCode = {2}, vision = {3}", 
                 v1.GetName(), v1.GetDateTime(), v1.GetHashCode(), v1.GetVisionNum());
        }
    }
}