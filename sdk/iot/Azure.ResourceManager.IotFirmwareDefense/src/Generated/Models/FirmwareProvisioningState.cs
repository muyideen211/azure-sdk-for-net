// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    /// <summary> The status of a firmware analysis job. </summary>
    public readonly partial struct FirmwareProvisioningState : IEquatable<FirmwareProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FirmwareProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FirmwareProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string PendingValue = "Pending";
        private const string ExtractingValue = "Extracting";
        private const string AnalyzingValue = "Analyzing";

        /// <summary> The request has successfully completed. </summary>
        public static FirmwareProvisioningState Succeeded { get; } = new FirmwareProvisioningState(SucceededValue);
        /// <summary> There was an error during the request. </summary>
        public static FirmwareProvisioningState Failed { get; } = new FirmwareProvisioningState(FailedValue);
        /// <summary> The request was canceled. </summary>
        public static FirmwareProvisioningState Canceled { get; } = new FirmwareProvisioningState(CanceledValue);
        /// <summary> The request is queued and awaiting execution. </summary>
        public static FirmwareProvisioningState Pending { get; } = new FirmwareProvisioningState(PendingValue);
        /// <summary> The Firmware is currently being extracted. </summary>
        public static FirmwareProvisioningState Extracting { get; } = new FirmwareProvisioningState(ExtractingValue);
        /// <summary> Analysis is being run on the firmware. </summary>
        public static FirmwareProvisioningState Analyzing { get; } = new FirmwareProvisioningState(AnalyzingValue);
        /// <summary> Determines if two <see cref="FirmwareProvisioningState"/> values are the same. </summary>
        public static bool operator ==(FirmwareProvisioningState left, FirmwareProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FirmwareProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(FirmwareProvisioningState left, FirmwareProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="FirmwareProvisioningState"/>. </summary>
        public static implicit operator FirmwareProvisioningState(string value) => new FirmwareProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FirmwareProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FirmwareProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
