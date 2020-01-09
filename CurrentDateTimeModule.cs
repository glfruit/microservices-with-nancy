using System;
 using System.Threading.Tasks;
using Nancy;

namespace ms_tutorial
{
    public class CurrentDateTimeModule : NancyModule
    {
        public CurrentDateTimeModule()
        {
            Get("/", _ => DateTime.UtcNow);
        }
    }
}