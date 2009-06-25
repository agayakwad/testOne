using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HiRePro.JSONServiceLayer.CommonManagement.DataContracts;
using System.Runtime.Serialization;

namespace HiRePro.JSONServiceLayer.UserManagement.DataContracts.Requests
{
    [DataContract]
    public class JsonDeleteUserRequest : JsonTenantAdamInfo
    {
        #region Fields
        private int[] _ids;
        #endregion

        #region Properties

        [DataMember]
        public int[] Ids
        {
            get { return _ids; }
            set { _ids = value; }
        }

        #endregion

    }
}
