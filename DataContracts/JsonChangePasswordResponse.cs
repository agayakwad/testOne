using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using HiRePro.JSONServiceLayer.BaseResponse;

namespace HiRePro.JSONServiceLayer.UserManagement.DataContracts
{
    [DataContract]
    public class JsonChangePasswordResponse : ResponseBase
    {
        #region Fields
        private bool _isPasswordChanged;
        private string _errorMessage; 
        #endregion

        #region Properties


        /// <summary>
        /// Gets or sets the error message.
        /// </summary>
        /// <value>The error message.</value>
        [DataMember]
        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is password changed.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is password changed; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool IsPasswordChanged
        {
            get { return _isPasswordChanged; }
            set { _isPasswordChanged = value; }
        }


        #endregion
    }
}
