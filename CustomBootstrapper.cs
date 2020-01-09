using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;
using Nancy.Configuration;

namespace ms_tutorial
{
    public class CustomBootstrapper : DefaultNancyBootstrapper
    {
        public override void Configure(INancyEnvironment environment)
        {
            environment.Tracing(enabled: false, displayErrorTraces: true);
        }
    }
}