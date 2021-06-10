using Newtonsoft.Json;
using SilverWorkJsonLoader.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverWorkJsonLoader
{
    public class JsonLoader
    {
        public List<LoanDataModel> ParseJsonInFile(string fileName)
        {
            List<LoanDataModel> items;
            using (StreamReader r = new StreamReader(fileName))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<LoanDataModel>>(json);

            }
            return items;
        }
    }
}
