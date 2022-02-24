using Property.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Property.Repository
{
    public interface IProperties
    {
        string CreateProperties(Properties properties);
        ICollection<Properties> GetProperties();
        List<Properties> GetTypeFilterProperties(string Type);
        List<Properties> GetValueFilterProperties(string estimatedValue);
        List<Properties> GetAreaFilterProperties(string area);
        string Delete(int PropertyId);
        

    }
}
