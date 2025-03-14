// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Represents of a connection's group information.</summary>
    public partial class GroupConnectivityInformation :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IGroupConnectivityInformation,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IGroupConnectivityInformationInternal
    {

        /// <summary>Backing field for <see cref="CustomerVisibleFqdn" /> property.</summary>
        private string[] _customerVisibleFqdn;

        /// <summary>Gets or sets customer visible FQDNs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string[] CustomerVisibleFqdn { get => this._customerVisibleFqdn; set => this._customerVisibleFqdn = value; }

        /// <summary>Backing field for <see cref="GroupId" /> property.</summary>
        private string _groupId;

        /// <summary>Gets or sets group id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string GroupId { get => this._groupId; set => this._groupId = value; }

        /// <summary>Backing field for <see cref="InternalFqdn" /> property.</summary>
        private string _internalFqdn;

        /// <summary>Gets or sets Internal Fqdn.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string InternalFqdn { get => this._internalFqdn; set => this._internalFqdn = value; }

        /// <summary>Backing field for <see cref="MemberName" /> property.</summary>
        private string _memberName;

        /// <summary>Gets or sets member name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string MemberName { get => this._memberName; set => this._memberName = value; }

        /// <summary>Backing field for <see cref="PrivateLinkServiceArmRegion" /> property.</summary>
        private string _privateLinkServiceArmRegion;

        /// <summary>Gets or sets the private link service arm region.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string PrivateLinkServiceArmRegion { get => this._privateLinkServiceArmRegion; set => this._privateLinkServiceArmRegion = value; }

        /// <summary>Backing field for <see cref="RedirectMapId" /> property.</summary>
        private string _redirectMapId;

        /// <summary>Gets or sets the redirect map id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RedirectMapId { get => this._redirectMapId; set => this._redirectMapId = value; }

        /// <summary>Creates an new <see cref="GroupConnectivityInformation" /> instance.</summary>
        public GroupConnectivityInformation()
        {

        }
    }
    /// Represents of a connection's group information.
    public partial interface IGroupConnectivityInformation :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets customer visible FQDNs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets customer visible FQDNs.",
        SerializedName = @"customerVisibleFqdns",
        PossibleTypes = new [] { typeof(string) })]
        string[] CustomerVisibleFqdn { get; set; }
        /// <summary>Gets or sets group id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets group id.",
        SerializedName = @"groupId",
        PossibleTypes = new [] { typeof(string) })]
        string GroupId { get; set; }
        /// <summary>Gets or sets Internal Fqdn.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets Internal Fqdn.",
        SerializedName = @"internalFqdn",
        PossibleTypes = new [] { typeof(string) })]
        string InternalFqdn { get; set; }
        /// <summary>Gets or sets member name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets member name.",
        SerializedName = @"memberName",
        PossibleTypes = new [] { typeof(string) })]
        string MemberName { get; set; }
        /// <summary>Gets or sets the private link service arm region.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the private link service arm region.",
        SerializedName = @"privateLinkServiceArmRegion",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkServiceArmRegion { get; set; }
        /// <summary>Gets or sets the redirect map id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the redirect map id.",
        SerializedName = @"redirectMapId",
        PossibleTypes = new [] { typeof(string) })]
        string RedirectMapId { get; set; }

    }
    /// Represents of a connection's group information.
    internal partial interface IGroupConnectivityInformationInternal

    {
        /// <summary>Gets or sets customer visible FQDNs.</summary>
        string[] CustomerVisibleFqdn { get; set; }
        /// <summary>Gets or sets group id.</summary>
        string GroupId { get; set; }
        /// <summary>Gets or sets Internal Fqdn.</summary>
        string InternalFqdn { get; set; }
        /// <summary>Gets or sets member name.</summary>
        string MemberName { get; set; }
        /// <summary>Gets or sets the private link service arm region.</summary>
        string PrivateLinkServiceArmRegion { get; set; }
        /// <summary>Gets or sets the redirect map id.</summary>
        string RedirectMapId { get; set; }

    }
}