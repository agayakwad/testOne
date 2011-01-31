using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HiRePro.JSONServiceLayer.CommonManagement.DataContracts;
using System.Runtime.Serialization;

namespace HiRePro.JSONServiceLayer.UserManagement.DataContracts.Requests
{
    [DataContract]
    public class JsonLoginRequest : JsonTenantAdamInfo
    {
        #region Fields
        private JsonUser _jsonUser;
        #endregion

        #region Properties
        [DataMember]
        public JsonUser JsonUser
        {
            get { return _jsonUser; }
            set { _jsonUser = value; }
        }

        [DataMember]
        public string BrowserDetails { get; set; }

        [DataMember]
        public string OperatingSystemDetails { get; set; }

        #endregion


    }
}
