// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> The current provisioning state. </summary>
    public readonly partial struct AppAttachPackageProvisioningState : IEquatable<AppAttachPackageProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AppAttachPackageProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AppAttachPackageProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string ProvisioningValue = "Provisioning";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";

        /// <summary> Succeeded. </summary>
        public static AppAttachPackageProvisioningState Succeeded { get; } = new AppAttachPackageProvisioningState(SucceededValue);
        /// <summary> Provisioning. </summary>
        public static AppAttachPackageProvisioningState Provisioning { get; } = new AppAttachPackageProvisioningState(ProvisioningValue);
        /// <summary> Failed. </summary>
        public static AppAttachPackageProvisioningState Failed { get; } = new AppAttachPackageProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static AppAttachPackageProvisioningState Canceled { get; } = new AppAttachPackageProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="AppAttachPackageProvisioningState"/> values are the same. </summary>
        public static bool operator ==(AppAttachPackageProvisioningState left, AppAttachPackageProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AppAttachPackageProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(AppAttachPackageProvisioningState left, AppAttachPackageProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AppAttachPackageProvisioningState"/>. </summary>
        public static implicit operator AppAttachPackageProvisioningState(string value) => new AppAttachPackageProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AppAttachPackageProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AppAttachPackageProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
