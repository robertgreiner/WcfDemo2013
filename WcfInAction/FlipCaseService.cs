﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfInAction
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FlipCaseService" in both code and config file together.
    public class FlipCaseService : IFlipCaseService
    {
        public StringData FlipCase(StringData sd)
        {
            sd.FlippedCaseString = null;
            foreach (char c in sd.OriginalString)
            {
                sd.FlippedCaseString += char.IsLower(c) ?
                      c.ToString().ToUpper() : c.ToString().ToLower();
            }
            return sd;
        }
    }
}
