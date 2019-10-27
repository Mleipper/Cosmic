﻿using Cosmic.Aliases;
using System;
using System.Threading.Tasks;

namespace Cosmic.Commands.Aliases
{
    public class AliasesCommand : Command<AliasesOptions>
    {
        protected override Task<int> ExecuteCommandAsync(AliasesOptions options)
        {
            var aliasProcessor = new AliasProcessor();

            var now = DateTime.UtcNow;

            foreach (var group in aliasProcessor.Groups)
            {
                Console.WriteLine($"{group.Name} aliases");
                foreach (var alias in group.Aliases)
                {
                    Console.WriteLine($"  {alias.Key.PadRight(16)} {alias.Generate(now).PadRight(32)} {alias.Description}");
                }
            }

            return Task.FromResult(0);
        }
    }
}
