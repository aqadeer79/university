using System;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.ServiceDiscovery
{
    public static class ServiceConfigExtensions
    {
        public static ServiceConfig GetServiceConfig(this IConfiguration configuration)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            var serviceConfig = new ServiceConfig
            {
                ServiceDiscoveryAddress = new Uri("http://localhost:8500"),
                ServiceAddress = new Uri("http://localhost:80"),
                ServiceName = "DepartmentService",
                ServiceId = "department-service-1"
            };

            return serviceConfig;
        }
    }
}