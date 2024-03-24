using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    public class ReadFile
    {
        public static List<Personnel> ReadFromJson(string jsonContent)
        {
            List<Personnel> personnelList = JsonConvert.DeserializeObject<List<Personnel>>(jsonContent);
            return personnelList;
        }
    }
}

