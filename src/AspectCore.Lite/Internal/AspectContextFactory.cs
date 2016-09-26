﻿using AspectCore.Lite.Core;
using System;

namespace AspectCore.Lite.Internal
{
    internal class AspectContextFactory: IAspectContextFactory
    {
        private readonly IServiceProvider _serviceProvider;
        public AspectContextFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public AspectContext Create()
        {
            return new AspectContext(null, null, null, null, _serviceProvider);
        }
    }
}