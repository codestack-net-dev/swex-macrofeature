﻿//**********************
//SwEx - development tools for SOLIDWORKS
//Copyright(C) 2018 www.codestack.net
//License: https://github.com/codestack-net-dev/swex-macrofeature/blob/master/LICENSE
//Product URL: https://www.codestack.net/labs/solidworks/swex-macrofeature
//**********************

using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeStack.SwEx.MacroFeature.Base
{
    public class MacroFeatureRebuildPatternResult : MacroFeatureRebuildResult
    {
        internal MacroFeatureRebuildPatternResult(IBody2[] bodiesPattern) : base(bodiesPattern)
        {
        }
    }
}
