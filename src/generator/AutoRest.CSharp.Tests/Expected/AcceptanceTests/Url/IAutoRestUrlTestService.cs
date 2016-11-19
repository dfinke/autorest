// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsUrl
{
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Test Infrastructure for AutoRest
    /// </summary>
    public partial interface IAutoRestUrlTestService : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        Newtonsoft.Json.JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        Newtonsoft.Json.JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// A string value 'globalItemStringPath' that appears in the path
        /// </summary>
        string GlobalStringPath { get; set; }

        /// <summary>
        /// should contain value null
        /// </summary>
        string GlobalStringQuery { get; set; }


        /// <summary>
        /// Gets the IPaths.
        /// </summary>
        IPaths Paths { get; }

        /// <summary>
        /// Gets the IQueries.
        /// </summary>
        IQueries Queries { get; }

        /// <summary>
        /// Gets the IPathItems.
        /// </summary>
        IPathItems PathItems { get; }

    }
}

