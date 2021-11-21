// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.ML.Probabilistic.Factors.Attributes;
using Microsoft.ML.Probabilistic.Compiler;

namespace Microsoft.ML.Probabilistic.Compiler.Attributes
{
    internal class QualityBandCompilerAttribute : ICompilerAttribute
    {
        public QualityBandCompilerAttribute(QualityBand qualityBand)
        {
            this.QualityBand = qualityBand;
        }

        public QualityBand QualityBand { get; private set; }
    }
}
