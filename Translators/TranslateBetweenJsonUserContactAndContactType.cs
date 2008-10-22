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
using Common.ServiceProxies.UserManagement;
using HiRePro.JSONServiceLayer.UserManagement.DataContracts;

namespace HiRePro.JSONServiceLayer.UserManagement.Translators
{
    //public static class TranslateBetweenJsonUserContactAndContactType
    //{
    //    public static JsonUserContact ServiceToBusiness(ContactType from)
    //    {
    //        JsonUserContact to = new JsonUserContact();
    //        to.Email1 = from.Email1;
    //       // to.Email2 = from.Email2;
    //        to.FirstName = from.FirstName;
    //        to.MiddleName = from.MiddleName;
    //        to.LastName = from.LastName;
    //       // to.PhoneOffice = from.PhoneOffice;
    //       // to.PhoneOther = from.PhoneOther;
    //       // to.HomeAddress = TranslateBetweenJsonUserAddressAndAddressType.ServiceToBusiness(from.HomeAddress);
    //        return to;
    //    }

    //    public static ContactType BusinessToService(JsonUserContact from)
    //    {
    //        ContactType to = new ContactType();
    //        to.Email1 = from.Email1;
    //        //to.Email2 = from.Email2;
    //        to.FirstName = from.FirstName;
    //        to.MiddleName = from.MiddleName;
    //        to.LastName = from.LastName;
    //        //to.PhoneOffice = from.PhoneOffice;
    //       // to.PhoneOther = from.PhoneOther;
    //       // to.HomeAddress = TranslateBetweenJsonUserAddressAndAddressType.BusinessToService(from.HomeAddress);
    //        return to;
    //    }
    //}
}
