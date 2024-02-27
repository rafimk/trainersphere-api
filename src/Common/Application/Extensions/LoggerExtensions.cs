﻿using Application.EventBus;
using Domain.Primitives;
using Microsoft.Extensions.Logging;
using Shared.Errors;

namespace Application.Extensions;

/// <summary>
/// Contains extension methods for the <see cref="ILogger"/> class.
/// </summary>
public static class LoggerExtensions
{
    /// <summary>
    /// Formats and writes an error log message for the specified domain event and error.
    /// </summary>
    /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
    /// <param name="domainEvent">The domain event.</param>
    /// <param name="error">The error.</param>
    public static void LogError(this ILogger logger, IDomainEvent domainEvent, Error error) =>
        logger.LogError("Error while processing domain event: {DomainEventId} - {Error}", domainEvent.Id, error);

    /// <summary>
    /// Formats and writes an error log message for the specified integration event and error.
    /// </summary>
    /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
    /// <param name="integrationEvent">The integration event.</param>
    /// <param name="error">The error.</param>
    public static void LogError(this ILogger logger, IIntegrationEvent integrationEvent, Error error) =>
        logger.LogError("Error while processing integration event: {IntegrationEventId} - {Error}", integrationEvent.Id, error);
}
