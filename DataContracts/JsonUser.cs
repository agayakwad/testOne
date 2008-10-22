using System;
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

namespace HiRePro.JSONServiceLayer.UserManagement.DataContracts
{

    //[DataContract]
    //public partial class JsonUserRole : Entity<JsonUserRole>
    //{
    //    #region Data Members

    //    private string _roleName;
    //    private string _userName;

    //    #endregion

    //    #region Properties

    //    /// <summary>
    //    /// Gets or sets the name of the role.
    //    /// </summary>
    //    /// <value>The name of the role.</value>
    //    [DataMember]
    //    public string RoleName
    //    {
    //        get { return _roleName; }
    //        set { _roleName = value; }
    //    }

    //    /// <summary>
    //    /// Gets or sets the name of the user.
    //    /// </summary>
    //    /// <value>The name of the user.</value>
    //    [DataMember]
    //    public string UserName
    //    {
    //        get { return _userName; }
    //        set { _userName = value; }
    //    }

    //    #endregion
    //}

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
       // private bool _IsAdmin;
        private DateTime _lastLoginTime;

        #endregion

        //private JsonUserContact _jsonUserContact = new Null<JsonUserContact>();
        //private JsonUserProfile _jsonUserProfile = new Null<JsonUserProfile>();
        //private JsonGroupCollection _jsonGroupCollection = new JsonGroupCollection();
        //private JsonRoleCollection _jsonRoleCollection = new JsonRoleCollection();
        //private JsonUserActionCollection _jsonUserActionCollection = new JsonUserActionCollection();

        #region Properties

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
        /// Gets or sets the contact.
        /// </summary>
        /// <value>The contact.</value>
        //[DataMember]
        //public JsonUserContact JsonUserContact
        //{
        //    get { return _jsonUserContact; }
        //    set { _jsonUserContact = value; }
        //}

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

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>The first name.</value>
        //[DataMember]
        //public string FirstName
        //{
        //    get
        //    {
        //        return JsonUserContact.FirstName;
        //    }
        //    set
        //    {
        //        JsonUserContact.FirstName = value;
        //    }
        //}

        ///// <summary>
        ///// Gets or sets the name of the middle.
        ///// </summary>
        ///// <value>The name of the middle.</value>
        //[DataMember]
        //public string MiddleName
        //{
        //    get { return JsonUserContact.MiddleName; }
        //    set { JsonUserContact.MiddleName = value; }
        //}

        ///// <summary>
        ///// Gets or sets the last name.
        ///// </summary>
        ///// <value>The last name.</value>
        //[DataMember]
        //public string LastName
        //{
        //    get { return JsonUserContact.LastName; }
        //    set { JsonUserContact.LastName = value; }
        //}

        ///// <summary>
        ///// Gets or sets the email1.
        ///// </summary>
        ///// <value>The email1.</value>
        //[DataMember]
        //public string Email1
        //{
        //    get { return JsonUserContact.Email1; }
        //    set { JsonUserContact.Email1 = value; }
        //}

        ///// <summary>
        ///// Gets or sets the email2.
        ///// </summary>
        ///// <value>The email2.</value>
        //[DataMember]
        //public string Email2
        //{
        //    get { return JsonUserContact.Email2; }
        //    set { JsonUserContact.Email2 = value; }
        //}

        ///// <summary>
        ///// Gets or sets the phone office.
        ///// </summary>
        ///// <value>The phone office.</value>
        //[DataMember]
        //public string PhoneOffice
        //{
        //    get { return JsonUserContact.PhoneOffice; }
        //    set { JsonUserContact.PhoneOffice = value; }
        //}

        ///// <summary>
        ///// Gets or sets the phone other.
        ///// </summary>
        ///// <value>The phone other.</value>
        //[DataMember]
        //public string PhoneOther
        //{
        //    get { return JsonUserContact.PhoneOther; }
        //    set { JsonUserContact.PhoneOther = value; }
        //}

        ///// <summary>
        ///// Gets or sets the home street.
        ///// </summary>
        ///// <value>The home street.</value>
        //[DataMember]
        //public string HomeStreet
        //{
        //    get { return JsonUserContact.HomeAddress.Street; }
        //    set { JsonUserContact.HomeAddress.Street = value; }
        //}

        ///// <summary>
        ///// Gets or sets the home city.
        ///// </summary>
        ///// <value>The home city.</value>
        //[DataMember]
        //public string HomeCity
        //{
        //    get { return JsonUserContact.HomeAddress.City; }
        //    set { JsonUserContact.HomeAddress.City = value; }
        //}

        ///// <summary>
        ///// Gets or sets the home country.
        ///// </summary>
        ///// <value>The home country.</value>
        //[DataMember]
        //public string HomeCountry
        //{
        //    get { return JsonUserContact.HomeAddress.Country; }
        //    set { JsonUserContact.HomeAddress.Country = value; }
        //}

        ///// <summary>
        ///// Gets or sets the state of the home.
        ///// </summary>
        ///// <value>The state of the home.</value>
        //[DataMember]
        //public string HomeState
        //{
        //    get { return JsonUserContact.HomeAddress.State; }
        //    set { JsonUserContact.HomeAddress.State = value; }
        //}

        ///// <summary>
        ///// Gets or sets the home pin code.
        ///// </summary>
        ///// <value>The home pin code.</value>
        //[DataMember]
        //public string HomePinCode
        //{
        //    get { return JsonUserContact.HomeAddress.Pincode; }
        //    set { JsonUserContact.HomeAddress.Pincode = value; }
        //}

        ///// <summary>
        ///// Gets or sets a value indicating whether this instance is admin.
        ///// </summary>
        ///// <value><c>true</c> if this instance is admin; otherwise, <c>false</c>.</value>
        //[DataMember]
        //public bool IsAdmin
        //{
        //    get { return _IsAdmin; }
        //    set { _IsAdmin = value; }
        //}

        [DataMember]
        public DateTime LastLoginTime
        {
            get { return _lastLoginTime; }
            set { _lastLoginTime = value; }
        }

        ///// <summary>
        ///// Gets or sets the user profile.
        ///// </summary>
        ///// <value>The user profile.</value>
        //[DataMember]
        //public JsonUserProfile JsonUserProfile
        //{
        //    get { return _jsonUserProfile; }
        //    set { _jsonUserProfile = value; }
        //}

        ///// <summary>
        ///// Gets the group collection.
        ///// </summary>
        ///// <value>The group collection.</value>
        //[DataMember]
        //public JsonGroupCollection JsonGroupCollection
        //{
        //    get
        //    {
        //        return _jsonGroupCollection;
        //    }
        //}

        /// <summary>
        /// Gets the role collection.
        /// </summary>
        /// <value>The role collection.</value>
        //[DataMember]
        //public JsonRoleCollection JsonRoleCollection
        //{
        //    get
        //    {
        //        return _jsonRoleCollection;
        //    }
        //}

        //public JsonUserActionCollection JsonUserActionCollection
        //{
        //    get
        //    {
        //        return _jsonUserActionCollection;
        //    }
        //}
        
        //public override void MarkOld()
        //{
        //    base.MarkOld();
        //    ObjectStateHelper.MarkOld(JsonUserContact);
        //    ObjectStateHelper.MarkOld(JsonUserProfile);
        //    ObjectStateHelper.MarkOld(JsonGroupCollection);
        //    ObjectStateHelper.MarkOld(JsonRoleCollection);
        //    ObjectStateHelper.MarkOld(JsonUserActionCollection);
        //}

        //public override void BeginLoad()
        //{
        //    base.BeginLoad();

        //    if (JsonUserContact != null)
        //        JsonUserContact.MarkOld();

        //    if (JsonUserProfile != null)
        //        JsonUserProfile.MarkOld();

        //    JsonGroupCollection.MarkOld();

        //    JsonRoleCollection.MarkOld();

        //}

        #endregion
    }

        //[DataContract]
    //public partial class JsonUserContact : Entity<JsonUserContact>
    //{
    //    #region Fields

    //    private string _firstName;
    //    private string _middleName;
    //    private string _lastName;
    //    private string _email1;
    //    private string _email2;
    //    private string _phoneOffice;
    //    private string _phoneOther;
       // private JsonUserAddress _homeAddress = new Null<JsonUserAddress>();

        //#endregion

        //#region Properties

        ///// <summary>
        ///// Gets or sets the first name.
        ///// </summary>
        ///// <value>The first name.</value>
        //[DataMember]
        //public string FirstName
        //{
        //    get { return _firstName; }
        //    set { _firstName = value; }
        //}

        /// <summary>
        /// Gets or sets the name of the middle.
        /// </summary>
        /// 
        ///// <value>The name of the middle.</value>
        //[DataMember]
        //public string MiddleName
        //{
        //    get { return _middleName; }
        //    set { _middleName = value; }
        //}

        ///// <summary>
        ///// Gets or sets the last name.
        ///// </summary>
        ///// <value>The last name.</value>
        //[DataMember]
        //public string LastName
        //{
        //    get { return _lastName; }
        //    set { _lastName = value; }
        //}

        /// <summary>
        /// Gets or sets the email1.
        /// </summary>
        /// <value>The email1.</value>
        
        //[DataMember]
        //public string Email1
        //{
        //    get { return _email1; }
        //    set { _email1 = value; }
        //}

    //    /// <summary>
    //    /// Gets or sets the email2.
    //    /// </summary>
    //    /// <value>The email2.</value>
    //    [DataMember]
    //    public string Email2
    //    {
    //        get { return _email2; }
    //        set { _email2 = value; }
    //    }

    //    /// <summary>
    //    /// Gets or sets the phone office.
    //    /// </summary>
    //    /// <value>The phone office.</value>
    //    [DataMember]
    //    public string PhoneOffice
    //    {
    //        get { return _phoneOffice; }
    //        set { _phoneOffice = value; }
    //    }

    //    /// <summary>
    //    /// Gets or sets the phone other.
    //    /// </summary>
    //    /// <value>The phone other.</value>
    //    [DataMember]
    //    public string PhoneOther
    //    {
    //        get { return _phoneOther; }
    //        set { _phoneOther = value; }
    //    }

    //    /// <summary>
    //    /// Gets or sets the home address.
    //    /// </summary>
    //    /// <value>The home address.</value>
    //    [DataMember]
    //    public JsonUserAddress HomeAddress
    //    {
    //        get { return _homeAddress; }
    //        set { _homeAddress = value; }
    //    }

    //    #endregion
    //}

    //[DataContract]
    //public partial class JsonUserAddress : Entity<JsonUserAddress>
    //{
    //    #region Fields

    //    private string _street;
    //    private string _city;
    //    private string _state;
    //    private string _country;
    //    private string _pincode;
    //    private Int32 _stateId;
    //    private Int32 _cityId;
    //    private Int32 _countryId;
        
    //    #endregion

    //    #region Properties

    //    /// <summary>
    //    /// Gets or sets the street.
    //    /// </summary>
    //    /// <value>The street.</value>
    //    [DataMember]
    //    public string Street
    //    {
    //        get { return _street; }
    //        set { _street = value; }
    //    }

    //    /// <summary>
    //    /// Gets or sets the city.
    //    /// </summary>
    //    /// <value>The city.</value>
    //    [DataMember]
    //    public string City
    //    {
    //        get { return _city; }
    //        set { _city = value; }
    //    }

    //    /// <summary>
    //    /// Gets or sets the state.
    //    /// </summary>
    //    /// <value>The state.</value>
    //    [DataMember]
    //    public string State
    //    {
    //        get { return _state; }
    //        set { _state = value; }
    //    }

    //    /// <summary>
    //    /// Gets or sets the country.
    //    /// </summary>
    //    /// <value>The country.</value>
    //    [DataMember]
    //    public string Country
    //    {
    //        get { return _country; }
    //        set { _country = value; }
    //    }

    //    /// <summary>
    //    /// Gets or sets the pincode.
    //    /// </summary>
    //    /// <value>The pincode.</value>
    //    [DataMember]
    //    public string Pincode
    //    {
    //        get { return _pincode; }
    //        set { _pincode = value; }
    //    }

    //    /// <summary>
    //    /// Gets or sets the state id.
    //    /// </summary>
    //    /// <value>The state id.</value>
    //    [DataMember]
    //    public Int32 StateId
    //    {
    //        get { return _stateId; }
    //        set { _stateId = value; }
    //    }

    //    /// <summary>
    //    /// Gets or sets the city id.
    //    /// </summary>
    //    /// <value>The city id.</value>
    //    [DataMember]
    //    public Int32 CityId
    //    {
    //        get { return _cityId; }
    //        set { _cityId = value; }
    //    }

    //    /// <summary>
    //    /// Gets or sets the country id.
    //    /// </summary>
    //    /// <value>The country id.</value>
    //    [DataMember]
    //    public Int32 CountryId
    //    {
    //        get { return _countryId; }
    //        set { _countryId = value; }
    //    }

    //    #endregion
    //}

    //[DataContract]
    //public partial class JsonUserProfile : Entity<JsonUserProfile>
    //{
    //    #region Fields

    //    private string _propertyNames;
    //    private string _propertyValues;

    //    #endregion

    //    #region Properties

    //    /// <summary>
    //    /// Gets or sets the property names.
    //    /// </summary>
    //    /// <value>The property names.</value>
    //    [DataMember]
    //    public string PropertyNames
    //    {
    //        get { return _propertyNames; }
    //        set { _propertyNames = value; }
    //    }

    //    /// <summary>
    //    /// Gets or sets the property values.
    //    /// </summary>
    //    /// <value>The property values.</value>
    //    [DataMember]
    //    public string PropertyValues
    //    {
    //        get { return _propertyValues; }
    //        set { _propertyValues = value; }
    //    }

        

    //    #endregion
    //}

    //[DataContract]
    //public class JsonActionCollection : BusinessListBase<JsonActionCollection, JsonAction>
    //{
    //    [DataMember]
    //    public JsonActionCollection()
    //    {
    //        MarkAsChild();
    //    }
    //}
    //[DataContract]
    //public partial class JsonRole : Entity<JsonRole>
    //{
    //    #region Fields

    //    private string _name;
    //    private string _description;
    //    private bool _new;
    //    private bool _deleted;
    //    private JsonActionCollection _jsonActionCollection = new JsonActionCollection();

    //    #endregion

    //    #region Properties

    //    [DataMember]
    //    public string Name
    //    {
    //        get
    //        {
    //            return _name;
    //        }
    //        set
    //        {
    //             _name = value;
    //        }
    //    }

    //    [DataMember]
    //    public String Description
    //    {
    //        get
    //        {
    //            return _description;
    //        }
    //        set
    //        {
    //             _description = value;
    //        }
    //    }

    //    [DataMember]
    //    public bool New
    //    {
    //        get
    //        {
    //            return _new;
    //        }
    //        set
    //        {
    //             _new = value;
    //        }
    //    }

    //    [DataMember]
    //    public bool Deleted
    //    {
    //        get
    //        {
    //            return _deleted;
    //        }
    //        set
    //        {
    //              _deleted = value;
    //        }
    //    }

    //    [DataMember]
    //    public JsonActionCollection JsonActionCollection
    //    {
    //        get
    //        {
    //            return _jsonActionCollection;
    //        }
    //    }

    //    [DataMember]
    //    public override bool IsValid
    //    {
    //        get
    //        {
    //            return base.IsValid || ObjectStateHelper.IsValid(_jsonActionCollection);
    //        }
    //    }

    //    [DataMember]
    //    public override bool IsDirty
    //    {
    //        get
    //        {
    //            return base.IsDirty || ObjectStateHelper.IsDirty(_jsonActionCollection);
    //        }
    //    }
    //    #endregion

    //    [DataMember]
    //    public override void MarkOld()
    //    {
    //        base.MarkOld();
    //        ObjectStateHelper.MarkOld(JsonActionCollection);
    //    }

    //    [DataMember]
    //    public override void BeginLoad()
    //    {
    //        base.BeginLoad();

    //        JsonActionCollection.MarkOld();
    //    }


    //}

    //[DataContract]
    //public partial class JsonAction : Entity<JsonAction>
    //{
    //    #region Fields

    //    private string _name;
    //    private string _description;
    //    private bool _deleted;
    //    private bool _new;

    //    #endregion

    //    #region Properties

    //    /// <summary>
    //    /// Gets or sets the name.
    //    /// </summary>
    //    /// <value>The name.</value>
    //    [DataMember]
    //    public string Name
    //    {
    //        get
    //        {
    //            return _name;
    //        }
    //        set
    //        {
    //                _name = value;
        
    //        }
    //    }

    //    /// <summary>
    //    /// Gets or sets the description.
    //    /// </summary>
    //    /// <value>The description.</value>
    //    [DataMember]
    //    public string Description
    //    {
    //        get
    //        {
    //            return _description;
    //        }
    //        set
    //        {
    //             _description = value;
    //        }
    //    }

    //    /// <summary>
    //    /// Gets or sets a value indicating whether this <see cref="JsonAction"/> is deleted.
    //    /// </summary>
    //    /// <value><c>true</c> if deleted; otherwise, <c>false</c>.</value>
    //    [DataMember]
    //    public bool Deleted
    //    {
    //        get
    //        {
    //            return _deleted;
    //        }
    //        set
    //        {  
    //            _deleted = value;
    //        }
    //    }

    //    /// <summary>
    //    /// Gets or sets a value indicating whether this <see cref="JsonAction"/> is new.
    //    /// </summary>
    //    /// <value><c>true</c> if new; otherwise, <c>false</c>.</value>
    //    [DataMember]
    //    public bool New
    //    {
    //        get
    //        {
    //            return _new;
    //        }
    //        set
    //        {
    //                _new = value;
              
    //        }
    //    }

    //    #endregion

    //}

    //[DataContract]
    //public class JsonGroupCollection : BusinessListBase<JsonGroupCollection, JsonGroup>
    //{
    //    [DataMember]
    //    public JsonGroupCollection()
    //    {
    //        MarkAsChild();
    //    }
    //}

    //[DataContract]
    //public partial class JsonGroup : Entity<JsonGroup>
    //{
    //    #region Fields

    //    private string _name;
    //    private string _description;

    //    #endregion

    //    #region Properties

    //    /// <summary>
    //    /// Gets or sets the name.
    //    /// </summary>
    //    /// <value>The name.</value>
    //    [DataMember]
    //    public string Name
    //    {
    //        get
    //        {
    //            return _name;
    //        }
    //        set
    //        {
    //            _name = value;
               
    //        }
    //    }

    //    /// <summary>
    //    /// Gets or sets the description.
    //    /// </summary>
    //    /// <value>The description.</value>
    //    [DataMember]
    //    public string Description
    //    {
    //        get
    //        {
    //            return _description;
    //        }
    //        set
    //        {
    //              _description = value;
    //        }
    //    }

    //    #endregion

    //}

    //public class JsonRoleCollection : BusinessListBase<JsonRoleCollection, JsonRole>
    //{
    //    [DataMember]
    //    public JsonRoleCollection()
    //    {
    //        MarkAsChild();
    //    }

    //    private int _recordCount;

    //    [DataMember]
    //    public int RecordCount
    //    {
    //        get
    //        {
    //            return _recordCount;
    //        }
    //        set
    //        {
    //            _recordCount = value;
    //        }

    //    }
    //}

    //[DataContract]
    //public partial class JsonAction : Entity<JsonAction>
    //{
    //    #region Fields

    //    private string _name;
    //    private string _description;
    //    private bool _deleted;
    //    private bool _new;

    //    #endregion

    //    #region Properties

    //    /// <summary>
    //    /// Gets or sets the name.
    //    /// </summary>
    //    /// <value>The name.</value>
    //    [DataMember]
    //    public string Name
    //    {
    //        get
    //        {
    //            return _name;
    //        }
    //        set
    //        {
    //             _name = value;
    //        }
    //    }

    //    /// <summary>
    //    /// Gets or sets the description.
    //    /// </summary>
    //    /// <value>The description.</value>
    //    [DataMember]
    //    public String Description
    //    {
    //        get
    //        {
    //            return _description;
    //        }
    //        set
    //        {
    //              _description = value;
    //        }
    //    }

    //    /// <summary>
    //    /// Gets or sets a value indicating whether this <see cref="JsonAction"/> is deleted.
    //    /// </summary>
    //    /// <value><c>true</c> if deleted; otherwise, <c>false</c>.</value>
    //    [DataMember]
    //    public bool Deleted
    //    {
    //        get
    //        {
    //            return _deleted;
    //        }
    //        set
    //        {
              
    //             _deleted = value;
    //        }
    //    }

    //    /// <summary>
    //    /// Gets or sets a value indicating whether this <see cref="JsonAction"/> is new.
    //    /// </summary>
    //    /// <value><c>true</c> if new; otherwise, <c>false</c>.</value>
    //    [DataMember]
    //    public bool New
    //    {
    //        get
    //        {
               
    //            return _new;
    //        }
    //        set
    //        { 
    //             _new = value;
              
    //        }
    //    }

    //    #endregion

    //}

   // public class JsonUserActionCollection : BusinessListBase<JsonUserActionCollection, JsonUserAction>
   // {
   //     [DataMember]
   //     public JsonUserActionCollection()
   //     {
   //         MarkAsChild();
   //     }
   // }

   //[DataContract]
   //public partial class JsonUserAction : Entity<JsonUserAction>
   //{

   //    #region Fields

   //    private	Int32	_actionId ;
   //    private	Boolean	_enable;

   //    #endregion

   //    #region Properties

   //    /// <summary>
   //    /// Gets or sets the action id.
   //    /// </summary>
   //    /// <value>The action id.</value>
   //    [DataMember]
   //    public  Int32 ActionId
   //     {
   //         get
   //         {
   //             return _actionId;
   //         }
   //         set
   //         {
   //             _actionId = value;
				
   //         }
   //     }

   //    /// <summary>
   //    /// Gets or sets a value indicating whether this <see cref="JsonUserAction"/> is enable.
   //    /// </summary>
   //    /// <value><c>true</c> if enable; otherwise, <c>false</c>.</value>
   //    [DataMember]
   //     public  Boolean Enable
   //     {
   //         get
   //         {
   //             return _enable;
   //         }
   //         set
   //         {
   //             _enable = value;
				
   //         }
   //     }

   //    #endregion

   //}
}
