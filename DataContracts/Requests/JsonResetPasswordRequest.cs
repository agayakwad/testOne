using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HiRePro.JSONServiceLayer.CommonManagement.DataContracts;
using System.Runtime.Serialization;
using HiRePro.JSONServiceLayer.Helper;
using ClientBusiness.Services.Services;

namespace HiRePro.JSONServiceLayer.UserManagement.DataContracts.Requests
{
    [DataContract]
    public class JsonResetPasswordRequest : JsonTenantAdamInfo
    {
        #region Fields
        
        private string _targetPanel; 
        private string _newPassword; 
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
        public string NewPassword
        {
            get { return _newPassword; }
            set { _newPassword = value; }
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
