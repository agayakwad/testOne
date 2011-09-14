using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using HiRePro.JSONServiceLayer.CommonManagement.DataContracts;

namespace HiRePro.JSONServiceLayer.UserManagement.DataContracts.Requests {
    [DataContract]
    public class JsonGetListOfUserNameRequest : JsonTenantAdamInfo {
        #region Properties

        /// <summary>
        /// Gets or sets the common name request.
        /// </summary>
        /// <value>The common name request.</value>
        [DataMember]
        public JsonUsersNameRequest CommonNameRequest { get; set; }


        #endregion
    }
}
