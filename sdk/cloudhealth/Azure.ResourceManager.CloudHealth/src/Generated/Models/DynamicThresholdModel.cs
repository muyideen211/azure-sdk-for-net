// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CloudHealth.Models
{
    /// <summary> ML-based model variants. </summary>
    public readonly partial struct DynamicThresholdModel : IEquatable<DynamicThresholdModel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DynamicThresholdModel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DynamicThresholdModel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AnomalyDetectionValue = "AnomalyDetection";

        /// <summary> Anomaly detection model. </summary>
        public static DynamicThresholdModel AnomalyDetection { get; } = new DynamicThresholdModel(AnomalyDetectionValue);
        /// <summary> Determines if two <see cref="DynamicThresholdModel"/> values are the same. </summary>
        public static bool operator ==(DynamicThresholdModel left, DynamicThresholdModel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DynamicThresholdModel"/> values are not the same. </summary>
        public static bool operator !=(DynamicThresholdModel left, DynamicThresholdModel right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DynamicThresholdModel"/>. </summary>
        public static implicit operator DynamicThresholdModel(string value) => new DynamicThresholdModel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DynamicThresholdModel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DynamicThresholdModel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
