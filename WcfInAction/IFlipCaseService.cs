﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfInAction
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFlipCaseService" in both code and config file together.
    [ServiceContract]
    public interface IFlipCaseService
    {
        [OperationContract]
        StringData FlipCase(StringData sd);
    }
}
