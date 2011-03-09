﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HiRePro.JSONServiceLayer.BaseResponse;
using System.Runtime.Serialization;

namespace HiRePro.JSONServiceLayer.UserManagement.DataContracts
{   
    [DataContract]
    public class JsonGetAllUserRolesByTenantResponse:ResponseBase
    {
        #region GetAllUserRolesByTenantCSVPath

        [DataMember]
        public string CSVPath { get; set; }

        #endregion GetAllUserRolesByTenantCSVPath
    }
}
