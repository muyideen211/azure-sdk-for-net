// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Projects
{
    /// <summary> The SasCredentialType. </summary>
    public readonly partial struct SasCredentialType : IEquatable<SasCredentialType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SasCredentialType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SasCredentialType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SASValue = "SAS";

        /// <summary> SAS. </summary>
        public static SasCredentialType SAS { get; } = new SasCredentialType(SASValue);
        /// <summary> Determines if two <see cref="SasCredentialType"/> values are the same. </summary>
        public static bool operator ==(SasCredentialType left, SasCredentialType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SasCredentialType"/> values are not the same. </summary>
        public static bool operator !=(SasCredentialType left, SasCredentialType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SasCredentialType"/>. </summary>
        public static implicit operator SasCredentialType(string value) => new SasCredentialType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SasCredentialType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SasCredentialType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
