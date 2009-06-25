using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HiRePro.JSONServiceLayer.CommonManagement.DataContracts;
using System.Runtime.Serialization;

namespace HiRePro.JSONServiceLayer.UserManagement.DataContracts.Requests
{
    [DataContract]
    public class JsonGetUserByIdRequest : JsonTenantAdamInfo
    {
        #region Fields
        private int _userById;
        private string _currentuserById;
        #endregion

        #region Properties

        [DataMember]
        public int UserById
        {
            get { return _userById; }
            set { _userById = value; }
        }
        [DataMember]
        public string CurrentUserById
        {
            get { return _currentuserById; }
            set { _currentuserById = value; }
        }
        #endregion
    }
}
