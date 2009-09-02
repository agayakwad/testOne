using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HiRePro.JSONServiceLayer.CommonManagement.DataContracts;
using System.Runtime.Serialization;

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
        private bool _sendNotificationMail;
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
        [DataMember]
        public bool SendNotificationMail
        {
            get { return _sendNotificationMail; }
            set { _sendNotificationMail = value; }
        }
        #endregion
    }
}
