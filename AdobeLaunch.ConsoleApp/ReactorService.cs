﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AdobeLaunch.Client;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace AdobeLaunch.ConsoleApp
{
    public class ReactorService : BackgroundService
    {
        private readonly ReactorApi _reactorApi;
        private readonly ILogger _logger;

        public ReactorService(ReactorApi reactorApi, ILoggerFactory loggerFactory)
        {
            _reactorApi = reactorApi;
            _logger = loggerFactory.CreateLogger<ReactorService>();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var test = await _reactorApi.Client.Companies().ConfigureAwait(false);
            // Console.WriteLine(JsonConvert.SerializeObject(JsonConvert.DeserializeObject(test), Formatting.Indented));
        }
    }
}