﻿//HintName: Test.TestWithModel.g.cs
// <auto-generated/>
#nullable enable

using Fluidic;
using System.Diagnostics.CodeAnalysis;
using System;

namespace <global namespace>;

public static partial class Test
{
    public static partial void TestWithModel(this StringBuilder builder, SomeModel model)
    {
        builder.Append("This is a more complex example with a parameter ");
        builder.Append( model.Value );
        builder.Append(" and a second parameter ");
        builder.Append( model.Text );
    }
}
