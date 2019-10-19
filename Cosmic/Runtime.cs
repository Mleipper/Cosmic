﻿using System.Threading.Tasks;
using CommandLine;
using Cosmic.Commands.Connect;
using Cosmic.Commands.Query;

namespace Cosmic
{
    public class Runtime
    {
        public async Task<int> ExecuteAsync(string[] args)
        {
            return await Parser.Default.ParseArguments<ConnectOptions, QueryOptions>(args)
                .MapResult(
                  (ConnectOptions o) => new ConnectCommand().ExecuteAsync(o),
                  (QueryOptions o) => new QueryCommand().ExecuteAsync(o),
                  errs => Task.FromResult(1));
        }
    }
}
