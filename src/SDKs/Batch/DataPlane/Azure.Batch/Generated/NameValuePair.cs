// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a name-value pair.
    /// </summary>
    public partial class NameValuePair : IPropertyMetadata
    {
        #region Constructors

        internal NameValuePair(Models.NameValuePair protocolObject)
        {
            this.Name = protocolObject.Name;
            this.Value = protocolObject.Value;
        }

        #endregion Constructors

        #region NameValuePair

        /// <summary>
        /// Gets the name in the name-value pair.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the value in the name-value pair.
        /// </summary>
        public string Value { get; }

        #endregion // NameValuePair

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata

        #region Internal/private methods


        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects.
        /// </summary>
        internal static IList<NameValuePair> ConvertFromProtocolCollection(IEnumerable<Models.NameValuePair> protoCollection)
        {
            ConcurrentChangeTrackedModifiableList<NameValuePair> converted = UtilitiesInternal.CollectionToThreadSafeCollectionIModifiable(
                items: protoCollection,
                objectCreationFunc: o => new NameValuePair(o));

            return converted;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects, in a frozen state.
        /// </summary>
        internal static IList<NameValuePair> ConvertFromProtocolCollectionAndFreeze(IEnumerable<Models.NameValuePair> protoCollection)
        {
            ConcurrentChangeTrackedModifiableList<NameValuePair> converted = UtilitiesInternal.CollectionToThreadSafeCollectionIModifiable(
                items: protoCollection,
                objectCreationFunc: o => new NameValuePair(o).Freeze());

            converted = UtilitiesInternal.CreateObjectWithNullCheck(converted, o => o.Freeze());

            return converted;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects, with each object marked readonly
        /// and returned as a readonly collection.
        /// </summary>
        internal static IReadOnlyList<NameValuePair> ConvertFromProtocolCollectionReadOnly(IEnumerable<Models.NameValuePair> protoCollection)
        {
            IReadOnlyList<NameValuePair> converted =
                UtilitiesInternal.CreateObjectWithNullCheck(
                    UtilitiesInternal.CollectionToNonThreadSafeCollection(
                        items: protoCollection,
                        objectCreationFunc: o => new NameValuePair(o).Freeze()), o => o.AsReadOnly());

            return converted;
        }

        #endregion // Internal/private methods
    }
}