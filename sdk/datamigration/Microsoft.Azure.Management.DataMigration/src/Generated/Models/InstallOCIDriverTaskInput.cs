// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Input for the service task to install an OCI driver.
    /// </summary>
    public partial class InstallOCIDriverTaskInput
    {
        /// <summary>
        /// Initializes a new instance of the InstallOCIDriverTaskInput class.
        /// </summary>
        public InstallOCIDriverTaskInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InstallOCIDriverTaskInput class.
        /// </summary>
        /// <param name="driverPackageName">Name of the uploaded driver package
        /// to install.</param>
        public InstallOCIDriverTaskInput(string driverPackageName = default(string))
        {
            DriverPackageName = driverPackageName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the uploaded driver package to install.
        /// </summary>
        [JsonProperty(PropertyName = "driverPackageName")]
        public string DriverPackageName { get; set; }

    }
}