// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.SiteRecovery;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for PossibleOperationsDirections.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PossibleOperationsDirections
    {
        [EnumMember(Value = "PrimaryToRecovery")]
        PrimaryToRecovery,
        [EnumMember(Value = "RecoveryToPrimary")]
        RecoveryToPrimary
    }
}
