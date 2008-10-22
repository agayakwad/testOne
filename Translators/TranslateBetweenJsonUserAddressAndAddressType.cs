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
using HiRePro.JSONServiceLayer.UserManagement.DataContracts;
using Common.ServiceProxies.UserManagement;

namespace HiRePro.JSONServiceLayer.UserManagement.Translators
{
    //public static class TranslateBetweenJsonUserAddressAndAddressType
    //{
    //    public static JsonUserAddress ServiceToBusiness(AddressType from)
    //    {
    //        JsonUserAddress to = new JsonUserAddress();
    //        to.Street = from.Street;
    //        to.City = from.City;
    //        to.State = from.State;
    //        to.Country = from.Country;
    //        to.Pincode = from.Pincode;
    //        to.StateId = from.StateId;
    //        to.CountryId = from.CountryId;
    //        to.CityId = from.CityId;

    //        return to;
    //    }

    //    public static AddressType BusinessToService(JsonUserAddress from)
    //    {
    //        AddressType to = new AddressType();
    //        to.Street = from.Street;
    //        to.City = from.City;
    //        to.State = from.State;
    //        to.Country = from.Country;
    //        to.Pincode = from.Pincode;
    //        to.StateId = from.StateId;
    //        to.CountryId = from.CountryId;
    //        to.CityId = from.CityId;

    //        return to;
    //    }
    //}
}
