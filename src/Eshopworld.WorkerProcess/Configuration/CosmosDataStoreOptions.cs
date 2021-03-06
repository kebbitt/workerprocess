﻿using Microsoft.Azure.Documents;

namespace EShopworld.WorkerProcess.Configuration
{
    /// <summary>
    /// The <see cref="CosmosDataStoreOptions"/> class
    /// </summary>
    public class CosmosDataStoreOptions
    {
        /// <summary>
        /// The database
        /// </summary>
        public string Database { get; set; } = "WorkerProcess";

        /// <summary>
        /// The document collection
        /// </summary>
        public string Collection { get; set; } = "WorkerLeases";

        /// <summary>
        /// The consistency level for the store
        /// </summary>
        public ConsistencyLevel ConsistencyLevel { get; set; } = ConsistencyLevel.Strong;

        /// <summary>
        /// The offer through put used when creating the collection
        /// </summary>
        public int OfferThroughput { get; set; } = 400;
    }
}
