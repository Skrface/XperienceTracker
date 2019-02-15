using System;
using System.Collections.Generic;
using System.Text;

namespace XpTracker.Backend.Core.DI
{
    /// <summary>
    /// reference a service provider used for D.I.
    /// </summary>
    /// <remarks>DO NOT USE THIS UNLESS YOU KNOW EXACTLY WHAT YOU ARE DOING</remarks>
    public static class ServiceLocator
    {
        public static IServiceProvider ServiceProvider { get; set; }
    }
}
