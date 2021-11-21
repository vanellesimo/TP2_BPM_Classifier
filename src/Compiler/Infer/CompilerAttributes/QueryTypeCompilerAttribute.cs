// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.ML.Probabilistic.Compiler;

namespace Microsoft.ML.Probabilistic.Compiler.Attributes
{
    internal class QueryTypeCompilerAttribute : ICompilerAttribute
    {
        public QueryTypeCompilerAttribute(QueryType queryType)
        {
            this.QueryType = queryType;
        }

        public QueryType QueryType { get; private set; }
    }
}
