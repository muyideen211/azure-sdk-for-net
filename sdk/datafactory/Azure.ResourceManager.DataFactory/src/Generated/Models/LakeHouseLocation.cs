// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The location of Microsoft Fabric Lakehouse Files dataset. </summary>
    public partial class LakeHouseLocation : DatasetLocation
    {
        /// <summary> Initializes a new instance of <see cref="LakeHouseLocation"/>. </summary>
        public LakeHouseLocation()
        {
            DatasetLocationType = "LakeHouseLocation";
        }

        /// <summary> Initializes a new instance of <see cref="LakeHouseLocation"/>. </summary>
        /// <param name="datasetLocationType"> Type of dataset storage location. </param>
        /// <param name="folderPath"> Specify the folder path of dataset. Type: string (or Expression with resultType string). </param>
        /// <param name="fileName"> Specify the file name of dataset. Type: string (or Expression with resultType string). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal LakeHouseLocation(string datasetLocationType, DataFactoryElement<string> folderPath, DataFactoryElement<string> fileName, IDictionary<string, BinaryData> additionalProperties) : base(datasetLocationType, folderPath, fileName, additionalProperties)
        {
            DatasetLocationType = datasetLocationType ?? "LakeHouseLocation";
        }
    }
}
