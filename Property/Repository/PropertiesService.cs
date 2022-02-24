using Property.Data;
using Property.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Property.Repository
{
    public class PropertiesService : IProperties
    {
        private PropetyContext _proj;
        public PropertiesService(PropetyContext proj)
        {
            _proj = proj;
        }
        public string CreateProperties(Properties properties)
        {
            _proj.Properties.Add(properties);
            _proj.SaveChanges();
            return "Created Sucessfully";
        }

        public List<Properties> GetTypeFilterProperties(string  type)
        {          

            return _proj.Properties.Where(x => x.Type == type ).ToList();
        }

        public ICollection<Properties> GetProperties()
        {
            return _proj.Properties.OrderBy(x => x.Type).ToList();
        }

        public string Delete(int propertyId)
        {
            Properties prop = _proj.Properties.Where(x => x.PropertyId == propertyId).Single<Properties>();
            _proj.Properties.Remove(prop);
            _proj.SaveChanges();
            return "Deleted Successfully";
        }

        public List<Properties> GetValueFilterProperties(string estimatedValue)
        {
            return _proj.Properties.Where(x => x.EstimatedValue == estimatedValue).ToList();
        }

        public List<Properties> GetAreaFilterProperties(string area)
        {
            return _proj.Properties.Where(x => x.Area == area).ToList();
        }
    }
}
