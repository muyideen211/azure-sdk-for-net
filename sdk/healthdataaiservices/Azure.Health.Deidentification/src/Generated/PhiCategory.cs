// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Health.Deidentification
{
    /// <summary> List of PHI Entities. </summary>
    public readonly partial struct PhiCategory : IEquatable<PhiCategory>
    {
        private readonly string _value;
        /// <summary> Unknown PHI Type. </summary>
        private const string UnknownValue = "Unknown";
        /// <summary> Account Number. </summary>
        private const string AccountValue = "Account";
        /// <summary> Age. </summary>
        private const string AgeValue = "Age";
        /// <summary> Biological Identifier, such as a fingerprint or retinal scan. </summary>
        private const string BioIDValue = "BioID";
        /// <summary> City. </summary>
        private const string CityValue = "City";
        /// <summary> Country or Region. </summary>
        private const string CountryOrRegionValue = "CountryOrRegion";
        /// <summary> Date. </summary>
        private const string DateValue = "Date";
        /// <summary> Device ID or serial numbers. </summary>
        private const string DeviceValue = "Device";
        /// <summary> Doctor's Name. </summary>
        private const string DoctorValue = "Doctor";
        /// <summary> Email Addresses. </summary>
        private const string EmailValue = "Email";
        /// <summary> Fax Number. </summary>
        private const string FaxValue = "Fax";
        /// <summary> Health Plan ID Numbers. </summary>
        private const string HealthPlanValue = "HealthPlan";
        /// <summary> Hospital Name. </summary>
        private const string HospitalValue = "Hospital";
        /// <summary> Id Number, eg. passport number. </summary>
        private const string IDNumValue = "IDNum";
        /// <summary> IP Address. </summary>
        private const string IPAddressValue = "IPAddress";
        /// <summary> License, eg. Driver's license or medical license. </summary>
        private const string LicenseValue = "License";
        /// <summary> Location Other, eg. Golden Gate Park. </summary>
        private const string LocationOtherValue = "LocationOther";
        /// <summary> Medical Record Number. </summary>
        private const string MedicalRecordValue = "MedicalRecord";
        /// <summary> Organization, eg. Microsoft. </summary>
        private const string OrganizationValue = "Organization";
        /// <summary> Patient Name. </summary>
        private const string PatientValue = "Patient";
        /// <summary> Phone Number. </summary>
        private const string PhoneValue = "Phone";
        /// <summary> Profession. </summary>
        private const string ProfessionValue = "Profession";
        /// <summary> Social Security Number. </summary>
        private const string SocialSecurityValue = "SocialSecurity";
        /// <summary> State. </summary>
        private const string StateValue = "State";
        /// <summary> Street. </summary>
        private const string StreetValue = "Street";
        /// <summary> Web URL. </summary>
        private const string UrlValue = "Url";
        /// <summary> Usernames, eg. a social media handle. </summary>
        private const string UsernameValue = "Username";
        /// <summary> Vehicle IDs, eg. license plate or VIN number. </summary>
        private const string VehicleValue = "Vehicle";
        /// <summary> Zip Code. </summary>
        private const string ZipValue = "Zip";

        /// <summary> Initializes a new instance of <see cref="PhiCategory"/>. </summary>
        /// <param name="value"> The value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PhiCategory(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        /// <summary> Unknown PHI Type. </summary>
        public static PhiCategory Unknown { get; } = new PhiCategory(UnknownValue);

        /// <summary> Account Number. </summary>
        public static PhiCategory Account { get; } = new PhiCategory(AccountValue);

        /// <summary> Age. </summary>
        public static PhiCategory Age { get; } = new PhiCategory(AgeValue);

        /// <summary> Biological Identifier, such as a fingerprint or retinal scan. </summary>
        public static PhiCategory BioID { get; } = new PhiCategory(BioIDValue);

        /// <summary> City. </summary>
        public static PhiCategory City { get; } = new PhiCategory(CityValue);

        /// <summary> Country or Region. </summary>
        public static PhiCategory CountryOrRegion { get; } = new PhiCategory(CountryOrRegionValue);

        /// <summary> Date. </summary>
        public static PhiCategory Date { get; } = new PhiCategory(DateValue);

        /// <summary> Device ID or serial numbers. </summary>
        public static PhiCategory Device { get; } = new PhiCategory(DeviceValue);

        /// <summary> Doctor's Name. </summary>
        public static PhiCategory Doctor { get; } = new PhiCategory(DoctorValue);

        /// <summary> Email Addresses. </summary>
        public static PhiCategory Email { get; } = new PhiCategory(EmailValue);

        /// <summary> Fax Number. </summary>
        public static PhiCategory Fax { get; } = new PhiCategory(FaxValue);

        /// <summary> Health Plan ID Numbers. </summary>
        public static PhiCategory HealthPlan { get; } = new PhiCategory(HealthPlanValue);

        /// <summary> Hospital Name. </summary>
        public static PhiCategory Hospital { get; } = new PhiCategory(HospitalValue);

        /// <summary> Id Number, eg. passport number. </summary>
        public static PhiCategory IDNum { get; } = new PhiCategory(IDNumValue);

        /// <summary> IP Address. </summary>
        public static PhiCategory IPAddress { get; } = new PhiCategory(IPAddressValue);

        /// <summary> License, eg. Driver's license or medical license. </summary>
        public static PhiCategory License { get; } = new PhiCategory(LicenseValue);

        /// <summary> Location Other, eg. Golden Gate Park. </summary>
        public static PhiCategory LocationOther { get; } = new PhiCategory(LocationOtherValue);

        /// <summary> Medical Record Number. </summary>
        public static PhiCategory MedicalRecord { get; } = new PhiCategory(MedicalRecordValue);

        /// <summary> Organization, eg. Microsoft. </summary>
        public static PhiCategory Organization { get; } = new PhiCategory(OrganizationValue);

        /// <summary> Patient Name. </summary>
        public static PhiCategory Patient { get; } = new PhiCategory(PatientValue);

        /// <summary> Phone Number. </summary>
        public static PhiCategory Phone { get; } = new PhiCategory(PhoneValue);

        /// <summary> Profession. </summary>
        public static PhiCategory Profession { get; } = new PhiCategory(ProfessionValue);

        /// <summary> Social Security Number. </summary>
        public static PhiCategory SocialSecurity { get; } = new PhiCategory(SocialSecurityValue);

        /// <summary> State. </summary>
        public static PhiCategory State { get; } = new PhiCategory(StateValue);

        /// <summary> Street. </summary>
        public static PhiCategory Street { get; } = new PhiCategory(StreetValue);

        /// <summary> Web URL. </summary>
        public static PhiCategory Url { get; } = new PhiCategory(UrlValue);

        /// <summary> Usernames, eg. a social media handle. </summary>
        public static PhiCategory Username { get; } = new PhiCategory(UsernameValue);

        /// <summary> Vehicle IDs, eg. license plate or VIN number. </summary>
        public static PhiCategory Vehicle { get; } = new PhiCategory(VehicleValue);

        /// <summary> Zip Code. </summary>
        public static PhiCategory Zip { get; } = new PhiCategory(ZipValue);

        /// <summary> Determines if two <see cref="PhiCategory"/> values are the same. </summary>
        /// <param name="left"> The left value to compare. </param>
        /// <param name="right"> The right value to compare. </param>
        public static bool operator ==(PhiCategory left, PhiCategory right) => left.Equals(right);

        /// <summary> Determines if two <see cref="PhiCategory"/> values are not the same. </summary>
        /// <param name="left"> The left value to compare. </param>
        /// <param name="right"> The right value to compare. </param>
        public static bool operator !=(PhiCategory left, PhiCategory right) => !left.Equals(right);

        /// <summary> Converts a string to a <see cref="PhiCategory"/>. </summary>
        /// <param name="value"> The value. </param>
        public static implicit operator PhiCategory(string value) => new PhiCategory(value);

        /// <summary> Converts a string to a <see cref="PhiCategory"/>. </summary>
        /// <param name="value"> The value. </param>
        public static implicit operator PhiCategory?(string value) => value == null ? null : new PhiCategory(value);

        /// <inheritdoc/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PhiCategory other && Equals(other);

        /// <inheritdoc/>
        public bool Equals(PhiCategory other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        /// <inheritdoc/>
        public override string ToString() => _value;
    }
}
