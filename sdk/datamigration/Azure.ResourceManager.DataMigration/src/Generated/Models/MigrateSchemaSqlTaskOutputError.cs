// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The MigrateSchemaSqlTaskOutputError. </summary>
    public partial class MigrateSchemaSqlTaskOutputError : MigrateSchemaSqlServerSqlDBTaskOutput
    {
        /// <summary> Initializes a new instance of <see cref="MigrateSchemaSqlTaskOutputError"/>. </summary>
        internal MigrateSchemaSqlTaskOutputError()
        {
            ResultType = "ErrorOutput";
        }

        /// <summary> Initializes a new instance of <see cref="MigrateSchemaSqlTaskOutputError"/>. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Result type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="error"> Migration error. </param>
        internal MigrateSchemaSqlTaskOutputError(string id, string resultType, IDictionary<string, BinaryData> serializedAdditionalRawData, DataMigrationReportableException error) : base(id, resultType, serializedAdditionalRawData)
        {
            Error = error;
            ResultType = resultType ?? "ErrorOutput";
        }

        /// <summary> Migration error. </summary>
        public DataMigrationReportableException Error { get; }
    }
}
