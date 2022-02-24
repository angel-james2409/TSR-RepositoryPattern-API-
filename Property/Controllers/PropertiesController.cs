using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Property.Models;
using Property.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Property.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertiesController : ControllerBase
    {
        private readonly IProperties _properties;

        private readonly IWebHostEnvironment _env;
        public PropertiesController(IProperties properties, IWebHostEnvironment env)
        {

            _properties = properties;
            _env = env;
        }
        [HttpPost("Create")]
        public string Create([FromBody] Properties properties)
        {
           
            return _properties.CreateProperties(properties);
        }
        [HttpGet("GetProperties")]
        public IActionResult GetAllProperties()
        {
            var prop = _properties.GetProperties();
            return Ok(prop);
        }
        [HttpPost("GetTypeFilteredProperties")]
        public IActionResult GetTypeFilteredProperties(string type)
        {
            var prop = _properties.GetTypeFilterProperties(type);
            return Ok(prop);
        }
        [HttpPost("GetValueFilteredProperties")]
        public IActionResult GetValueFilteredProperties(string estimatedValue)
        {
            var prop = _properties.GetValueFilterProperties(estimatedValue);
            return Ok(prop);
        }
        [HttpPost("GetAreaFilteredProperties")]
        public IActionResult GetAreaFilteredProperties(string area)
        {
            var prop = _properties.GetAreaFilterProperties(area);
            return Ok(prop);
        }
        [HttpDelete("{propertyid}")]
        public string Delete(int propertyid)
        {
           
            return _properties.Delete(propertyid);


        }
    }
}
