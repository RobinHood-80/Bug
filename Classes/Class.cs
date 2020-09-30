using Microsoft.AspNetCore.Components.Server.Circuits;
using Microsoft.Extensions.Logging;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Bug.Classes
{

    public class CustomCircuitHandler : CircuitHandler
    {
        private ILogger _logger;

        public CustomCircuitHandler(Microsoft.Extensions.Logging.ILogger l)
        {
            _logger = l;
        }
        
        public override Task OnCircuitClosedAsync(Circuit circuit, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"OnCircuitClosed {circuit.Id}");
            return base.OnCircuitClosedAsync(circuit, cancellationToken);
        }

        public override Task OnCircuitOpenedAsync(Circuit circuit, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"OnCircuitOpened {circuit.Id}");
            return base.OnCircuitOpenedAsync(circuit, cancellationToken);
        }

        public override Task OnConnectionDownAsync(Circuit circuit, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"OnConnectionDown {circuit.Id}");
            return base.OnConnectionDownAsync(circuit, cancellationToken);
        }

        public override Task OnConnectionUpAsync(Circuit circuit, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"OnConnectionUp {circuit.Id}");
            return base.OnConnectionUpAsync(circuit, cancellationToken);
        }

        
    }

}
