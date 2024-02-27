using Authorization.Contracts;
using Infrastructure.EventBus;
using MassTransit;

namespace Authorization.RequestClients;

internal sealed class RequestClientConfiguration : IRequestClientConfiguration
{
    public void AddRequestClients(IRegistrationConfigurator registrationConfigurator) => 
        registrationConfigurator.AddRequestClient<IUserPermissionsRequest>();
}
