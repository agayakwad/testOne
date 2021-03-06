﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HiRePro.JSONServiceLayer.BaseResponse;
using System.Runtime.Serialization;

namespace HiRePro.JSONServiceLayer.UserManagement.DataContracts.Response
{
    [DataContract]
    public class JsonGetAllBrowserAnalysisResponse :ResponseBase
    {

        [DataMember]
        public IList<JsonNumberOfUserAgainstBrowserType> JsonNumberOfUserAgainstBrowserTypeCollection
        {
            get;
            set;
        }
       
    }
}
