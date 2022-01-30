using Microsoft.Extensions.Hosting;
using Serilog;
using System;

namespace Transacao.API.Configuration
{
    public static class LogAplicacao
    {
        public static Action<HostBuilderContext, LoggerConfiguration> Configure =>
           (context, configuration) =>
           {   
               configuration
                    .Enrich.FromLogContext()
                    .WriteTo.Console()
                    .ReadFrom.Configuration(context.Configuration);
           };
    }
}
