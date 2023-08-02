using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONParse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (StreamReader r = new StreamReader("C:\\response.json"))
            {
                string json = r.ReadToEnd();
                List<Receipt> items = JsonConvert.DeserializeObject<List<Receipt>>(json);

                Console.WriteLine(items[0].description);
   
                Console.ReadKey();
            }

            
        }
    }
}
