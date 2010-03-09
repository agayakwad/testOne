using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HiRePro.JSONServiceLayer.CommonManagement.DataContracts;
using System.Runtime.Serialization;
using ClientBusiness.Services.Services;

namespace HiRePro.JSONServiceLayer.UserManagement.DataContracts.Requests
{
    [DataContract]
    public class JsonForgetPasswordRequest : JsonTenantAdamInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the target panel.
        /// </summary>
        /// <value>The target panel.</value>
        [DataMember]
        public string TargetPanel { get; set; }

        /// <summary>
        /// Gets or sets the login id.
        /// </summary>
        /// <value>The login id.</value>
        [DataMember]
        public string LoginId { get; set; }

        /// <summary>
        /// Gets or sets the mail id.
        /// </summary>
        /// <value>The mail id.</value>
        [DataMember]
        public string MailId { get; set; } 

        /// <summary>
        /// Gets or sets the tenant adam info.
        /// </summary>
        /// <value>The tenant adam info.</value>
        [DataMember]
        public JsonTenantAdamInfo TenantAdamInfo { get; set; }

        #endregion
    }
}
