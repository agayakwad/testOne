﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using HiRePro.JSONServiceLayer.BaseResponse;

namespace HiRePro.JSONServiceLayer.UserManagement.DataContracts.Response
{
    [DataContract]
    public class JsonDeleteUserResponse: ResponseBase
    {
        [DataMember]
        public bool Deleted { get; set; }
    }
}
