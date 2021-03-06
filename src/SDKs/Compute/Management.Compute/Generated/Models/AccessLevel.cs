// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for AccessLevel.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(AccessLevelConverter))]
    public struct AccessLevel : System.IEquatable<AccessLevel>
    {
        private AccessLevel(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly AccessLevel None = "None";

        public static readonly AccessLevel Read = "Read";


        /// <summary>
        /// Underlying value of enum AccessLevel
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for AccessLevel
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type AccessLevel
        /// </summary>
        public bool Equals(AccessLevel e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to AccessLevel
        /// </summary>
        public static implicit operator AccessLevel(string value)
        {
            return new AccessLevel(value);
        }

        /// <summary>
        /// Implicit operator to convert AccessLevel to string
        /// </summary>
        public static implicit operator string(AccessLevel e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum AccessLevel
        /// </summary>
        public static bool operator == (AccessLevel e1, AccessLevel e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum AccessLevel
        /// </summary>
        public static bool operator != (AccessLevel e1, AccessLevel e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for AccessLevel
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is AccessLevel && Equals((AccessLevel)obj);
        }

        /// <summary>
        /// Returns for hashCode AccessLevel
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
