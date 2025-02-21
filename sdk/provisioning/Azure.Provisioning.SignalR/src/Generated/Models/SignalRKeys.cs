// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Expressions;
using Azure.Provisioning.Primitives;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.SignalR;

/// <summary>
/// A class represents the access keys of the resource.
/// </summary>
public partial class SignalRKeys : ProvisionableConstruct
{
    /// <summary>
    /// The primary access key.
    /// </summary>
    public BicepValue<string> PrimaryKey 
    {
        get { Initialize(); return _primaryKey!; }
    }
    private BicepValue<string>? _primaryKey;

    /// <summary>
    /// The secondary access key.
    /// </summary>
    public BicepValue<string> SecondaryKey 
    {
        get { Initialize(); return _secondaryKey!; }
    }
    private BicepValue<string>? _secondaryKey;

    /// <summary>
    /// Connection string constructed via the primaryKey.
    /// </summary>
    public BicepValue<string> PrimaryConnectionString 
    {
        get { Initialize(); return _primaryConnectionString!; }
    }
    private BicepValue<string>? _primaryConnectionString;

    /// <summary>
    /// Connection string constructed via the secondaryKey.
    /// </summary>
    public BicepValue<string> SecondaryConnectionString 
    {
        get { Initialize(); return _secondaryConnectionString!; }
    }
    private BicepValue<string>? _secondaryConnectionString;

    /// <summary>
    /// Creates a new SignalRKeys.
    /// </summary>
    public SignalRKeys()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of SignalRKeys.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _primaryKey = DefineProperty<string>("PrimaryKey", ["primaryKey"], isOutput: true, isSecure: true);
        _secondaryKey = DefineProperty<string>("SecondaryKey", ["secondaryKey"], isOutput: true, isSecure: true);
        _primaryConnectionString = DefineProperty<string>("PrimaryConnectionString", ["primaryConnectionString"], isOutput: true, isSecure: true);
        _secondaryConnectionString = DefineProperty<string>("SecondaryConnectionString", ["secondaryConnectionString"], isOutput: true, isSecure: true);
    }
}
