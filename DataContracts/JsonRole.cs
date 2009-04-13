using System;
using System.Data;
using System.Configuration;
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
    public partial class JsonRole
    {
        #region Fields 
        private string _name;
        private string _description;
        private int _objectId;
      
        #endregion

        #region Properties 

        [DataMember]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DataMember]
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        [DataMember]
        public int ObjectId
        {
            get { return _objectId; }
            set { _objectId = value; }

        }
        #endregion
    }
}
