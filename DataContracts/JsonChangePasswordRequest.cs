using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using HiRePro.JSONServiceLayer.CommonManagement.DataContracts;

namespace HiRePro.JSONServiceLayer.UserManagement.DataContracts
{
    [DataContract]
    public class JsonChangePasswordRequest
    {
        #region Fields
        private string _oldPassword;
        private string _newPassword;
        private JsonTenantAdamInfo tenantInfo;
        #endregion

        #region Properties


        /// <summary>
        /// Gets or sets the tenant info.
        /// </summary>
        /// <value>The tenant info.</value>
        [DataMember]
        public JsonTenantAdamInfo TenantInfo
        {
            get { return tenantInfo; }
            set { tenantInfo = value; }
        }

        /// <summary>
        /// Gets or sets the new password.
        /// </summary>
        /// <value>The new password.</value>
        [DataMember]
        public string NewPassword
        {
            get { return _newPassword; }
            set { _newPassword = value; }
        }

        /// <summary>
        /// Gets or sets the old password.
        /// </summary>
        /// <value>The old password.</value>
        [DataMember]
        public string OldPassword
        {
            get { return _oldPassword; }
            set { _oldPassword = value; }
        }

        
        #endregion

    }
}
