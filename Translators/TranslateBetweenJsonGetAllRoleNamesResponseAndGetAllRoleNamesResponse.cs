using HiRePro.JSONServiceLayer.CommonManagement.DataContracts;
using Common.ServiceProxies.UserManagement;

namespace HiRePro.JSONServiceLayer.UserManagement.Translators {
    public class TranslateBetweenJsonGetAllRoleNamesResponseAndGetAllRoleNamesResponse {
        public static JsonGetAllRoleNamesResponse ServiceToBusiness(GetAllRoleNamesResponse roleNamesResponse) {
            JsonGetAllRoleNamesResponse response = new JsonGetAllRoleNamesResponse();
            if (roleNamesResponse != null) {
                if (roleNamesResponse.AllRoleNames != null && roleNamesResponse.AllRoleNames.Length > 0) {
                    response.AllRoleNames = new GetAllRoleNames[roleNamesResponse.AllRoleNames.Length];
                    for (int roleNamesIndex = 0; roleNamesIndex < roleNamesResponse.AllRoleNames.Length; roleNamesIndex++) {
                        response.AllRoleNames[roleNamesIndex] = TranslateBetweenGetAllRoleNamesAndGetAllRoleNamesType.ServiceToBusiness(roleNamesResponse.AllRoleNames[roleNamesIndex]);
                    }
                }
            }
            return response;
        }
    }
}
