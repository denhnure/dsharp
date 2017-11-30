﻿// IContainer.cs
// Script#/Libraries/CoreLib
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
    /// <summary>
    /// This attribute marks a field, property, event or method as
    /// "browsable", i.e. present in the type descriptor associated with
    /// the type.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Event | AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    [ScriptIgnore]
    public sealed class BrowsableAttribute : Attribute
    {
    }
}