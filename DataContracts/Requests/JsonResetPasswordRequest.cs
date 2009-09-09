using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HiRePro.JSONServiceLayer.CommonManagement.DataContracts;
using System.Runtime.Serialization;
using HiRePro.Utility.Cache;
using HiRePro.JSONServiceLayer.Helper;
using ClientBusiness.Services.Services;

namespace HiRePro.JSONServiceLayer.UserManagement.DataContracts.Requests
{
    [DataContract]
    public class JsonResetPasswordRequest
    {
        #region Fields
        
        private string _targetPanel;
        private int _userId;
        private string _newPassword;
        private int _tenantId;
        private string _token;
        private bool _sendNotificationMail;
        private static ICacheService Cache;
        #endregion

        #region Properties

        [DataMember]
        public string TargetPanel
        {
            get { return _targetPanel; }
            set { _targetPanel = value; }
        }
        [DataMember]
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        [DataMember]
        public string NewPassword
        {
            get { return _newPassword; }
            set { _newPassword = value; }
        }

        [DataMember]
        public int TenantId
        {
            get { return _tenantId; }
            set { _tenantId = value; }
        }

        /// <summary>
        /// Gets or sets the token.
        /// </summary>
        /// <value>The token.</value>
        [DataMember]
        public bool SendNotificationMail
        {
            get { return _sendNotificationMail; }
            set { _sendNotificationMail = value; }
        }
        [DataMember]
        public string Token
        {
            get
            {
                if (TenantId != null && UserId != null)
                {
                    if (Cache == null)
                    {
                        Cache = new JsonEnterpriseLibraryCacheService();
                    }
                    int tenantID = int.Parse(HelperUtility.MD5Decrypt(TenantId.ToString()));
                    int userID = int.Parse(HelperUtility.MD5Decrypt(UserId.ToString()));
                    string tokenKey = "TokenKey" + tenantID + userID;
                    if (Cache.GetData(tokenKey) != null)
                    {
                        _token = (string)Cache.GetData(tokenKey);
                    }
                }
                return _token;
            }
            set { _token = value; }
        }
        #endregion
    }
}
