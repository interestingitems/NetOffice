﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.VBIDEApi
{
    /// <summary>
    /// CoClass LinkedWindows
    /// SupportByVersion VBIDE 12, 14, 5.3
    /// </summary>
    [SupportByVersion("VBIDE", 12, 14, 5.3)]
    [EntityType(EntityType.IsCoClass)]
	[TypeId("0002E187-0000-0000-C000-000000000046")]
    public interface LinkedWindows : _LinkedWindows
    {

    }
}
