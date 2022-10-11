using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractise
{
    internal class DataBase<T>
    {
        List<T> objects = new List<T>();
        internal void Add(T value)
        {
            objects.Add(value);
        }
        internal void Output()
        {
            foreach (var item in objects)
            {
                Console.WriteLine(item);
            }
        }
        internal void OutputType(string type)
        {
            foreach (var item in objects)
            {
                switch (type)
                {
                    case "System.Int32":
                        try
                        {
                            int parsed = Convert.ToInt32(item);
                            var t = parsed.GetType();
                            string ts = t.ToString();
                            if (ts == type)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        }
                        catch (Exception)
                        {
                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
}
