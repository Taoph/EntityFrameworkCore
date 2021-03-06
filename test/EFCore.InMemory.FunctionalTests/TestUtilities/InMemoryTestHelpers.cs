// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Diagnostics.InMemory.Internal;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.EntityFrameworkCore.TestUtilities
{
    public class InMemoryTestHelpers : TestHelpers
    {
        protected InMemoryTestHelpers()
        {
        }

        public static InMemoryTestHelpers Instance { get; } = new InMemoryTestHelpers();

        public override IServiceCollection AddProviderServices(IServiceCollection services)
            => services.AddEntityFrameworkInMemoryDatabase();

        protected override void UseProviderOptions(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseInMemoryDatabase(nameof(InMemoryTestHelpers));

        public override LoggingDefinitions LoggingDefinitions { get; } = new InMemoryLoggingDefinitions();
    }
}
