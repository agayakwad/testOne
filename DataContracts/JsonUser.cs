﻿using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Runtime.Serialization;
using HirePro.Framework.UI.Windows.Business;
using HirePro.Framework.UI.Windows.Business.Base.Utility;
using HiRePro.JSONServiceLayer.CommonManagement.DataContracts;
using System.Collections.Generic;

namespace HiRePro.JSONServiceLayer.UserManagement.DataContracts
{


    [DataContract]
    public partial class JsonUser
    {
        #region Fields

        private string _loginName;
        private int _id;
        private string _passwordQuestion;
        private string _passwordAnswer;
        private string _password;
        private string _newPassword;
        private string _signature;
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private string _email1;
        private string _email2;
        private string _phoneOffice;
        private string _phoneOther;
        private string _street;
        private string _city;
        private string _state;
        private string _country;
        private string _pincode;
        private Int32 _stateId;
        private Int32 _cityId;
        private Int32 _countryId;
        private int _departmentId;
        private bool _isWebRequest;
        private TypeOfUser _typeOfUser;
        private DateTime _lastLoginTime;
        private string userTypeValue;
        private bool _isPop3Listener;
        private string _emailPassword;
        private bool _isEmailExtractionRequired;
        private bool _isAdmin;
        #endregion

        #region Properties
        [DataMember]
        public string UserTypeValue
        {
            get { return userTypeValue; }
            set { userTypeValue = value; }
        }
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>The id.</value>
        [DataMember]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Gets or sets the DepartmentId.
        /// </summary>
        /// <value>The DepartmentId</value>
        [DataMember]
        public int DepartmentId
        {
            get { return _departmentId; }
            set { _departmentId = value; }
        }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>The first name.</value>
        [DataMember]
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        /// <summary>
        /// Gets or sets the name of the middle.
        /// </summary>
        /// <value>The name of the middle.</value>
        [DataMember]
        public string MiddleName
        {
            get { return _middleName; }
            set { _middleName = value; }
        }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        [DataMember]
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        /// <summary>
        /// Gets or sets the email1.
        /// </summary>
        /// <value>The email1.</value>
        [DataMember]
        public string Email1
        {
            get { return _email1; }
            set { _email1 = value; }
        }

        /// <summary>
        /// Gets or sets the name of the login.
        /// </summary>
        /// <value>The name of the login.</value>
        [DataMember]
        public string LoginName
        {
            get { return _loginName; }
            set { _loginName = value; }
        }

        /// <summary>
        /// Gets or sets the password question.
        /// </summary>
        /// <value>The password question.</value>
        [DataMember]
        public string PasswordQuestion
        {
            get { return _passwordQuestion; }
            set { _passwordQuestion = value; }
        }

        /// <summary>
        /// Gets or sets the password answer.
        /// </summary>
        /// <value>The password answer.</value>
        [DataMember]
        public string PasswordAnswer
        {
            get { return _passwordAnswer; }
            set { _passwordAnswer = value; }
        }


        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>The password.</value>
        [DataMember]
        public string Password
        {
            get { return _password; }
            set { _password = value; }
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
        /// Gets or sets the signature.
        /// </summary>
        /// <value>The signature.</value>
        [DataMember]
        public string Signature
        {
            get { return _signature; }
            set { _signature = value; }
        }

        [DataMember]
        public string Email2
        {
            get { return _email2; }
            set { _email2 = value; }
        }

        [DataMember]
        public string PhoneOffice
        {
            get { return _phoneOffice; }
            set { _phoneOffice = value; }
        }

        /// <summary>
        /// Gets or sets the phone other.
        /// </summary>
        /// <value>The phone other.</value>
        [DataMember]
        public string PhoneOther
        {
            get { return _phoneOther; }
            set { _phoneOther = value; }
        }

        [DataMember]
        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>The city.</value>
        [DataMember]
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        [DataMember]
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>The country.</value>
        [DataMember]
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        /// <summary>
        /// Gets or sets the pincode.
        /// </summary>
        /// <value>The pincode.</value>
        [DataMember]
        public string Pincode
        {
            get { return _pincode; }
            set { _pincode = value; }
        }


        [DataMember]
        public DateTime LastLoginTime
        {
            get { return _lastLoginTime; }
            set { _lastLoginTime = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is web request.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is web request; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool IsWebRequest
        {
            get { return _isWebRequest; }
            set { _isWebRequest = value; }
        }

        /// <summary>
        /// Gets or sets the type of user.
        /// </summary>
        /// <value>The type of user.</value>
        [DataMember]
        public TypeOfUser TypeOfUser
        {
            get { return _typeOfUser; }
            set { _typeOfUser = value; }
        }

        [DataMember]
        public bool IsPop3Listener
        {
            get { return _isPop3Listener; }
            set { _isPop3Listener = value; }
        }

        [DataMember]
        public bool IsEmailExtractionRequired
        {
            get { return _isEmailExtractionRequired; }
            set { _isEmailExtractionRequired = value; }
        }

        [DataMember]
        public string EmailPassword
        {
            get { return _emailPassword; }
            set { _emailPassword = value; }
        }

        [DataMember]
        public bool IsAdmin
        {
            get { return _isAdmin; }
            set { _isAdmin = value; }
        }
        #endregion
    }




    [DataContract]
    public  class JsonActionModule
    {
        [DataMember]
        public int ModuleId
        {
            get;
            set;
        }
        [DataMember]
        public List<JsonAction> ActionCollection
        {
            get;
            set;
        }
          
    }
    [DataContract]
    public class JsonAction
    {
        [DataMember]
        public int ActionId
        {
            get;
            set;
        }
        [DataMember] 
        public string ActionName
        {
            get;
            set;
        }
    }

}
