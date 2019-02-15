using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Text;

namespace XpTracker.Backend.Core.Helper
{
    /// <summary>
    /// the cache mechanism used in XpTracker app
    /// </summary>
    public class XpTrackerMemoryCache
    {
        private MemoryCache Cache { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        public XpTrackerMemoryCache()
        {
            Cache = new MemoryCache(new MemoryCacheOptions()
            //{
            //    SizeLimit = 1024
            //}
            );
        }

        /// <summary>
        /// try and get the value
        /// </summary>
        /// <typeparam name="TItem"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool TryGetValue<TItem>(object key, out TItem value)
        {
            return Cache.TryGetValue(key, out value);
        }

        /// <summary>
        /// add a value to the cache
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="expirationInSeconds"></param>
        /// <param name="isSliding"></param>
        public void AddValueToCache(string key, object value, int expirationInSeconds, bool isSliding)
        {
            // Set cache options.
            var cacheEntryOptions = new MemoryCacheEntryOptions();
            var timespan = TimeSpan.FromSeconds(expirationInSeconds);
            if (isSliding)
            { // Keep in cache for this time, reset time if accessed.
                cacheEntryOptions.SetSlidingExpiration(timespan);
            }
            else
            {
                cacheEntryOptions.SetAbsoluteExpiration(timespan);
            }

            // Save data in cache.
            Cache.Set(key, value, cacheEntryOptions);
        }

        internal void RemoveValueFromCache(string cacheKey)
        {
            Cache.Remove(cacheKey);
        }
    }
}
