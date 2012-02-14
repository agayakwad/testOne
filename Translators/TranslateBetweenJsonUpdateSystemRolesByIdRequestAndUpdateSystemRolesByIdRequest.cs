using Common.ServiceProxies.UserManagement;
using HiRePro.JSONServiceLayer.CommonManagement.DataContracts;

namespace HiRePro.JSONServiceLayer.UserManagement.Translators {
    public static class TranslateBetweenJsonUpdateSystemRolesByIdRequestAndUpdateSystemRolesByIdRequest {
        public static UpdateSystemRolesByIdRequest BusinessToService(JsonUpdateSystemRolesByIdRequest jsonRequest) {
            UpdateSystemRolesByIdRequest request = new UpdateSystemRolesByIdRequest();
            if (jsonRequest != null) {
                if (jsonRequest.AddedRoleIds != null && jsonRequest.AddedRoleIds.Length > 0)
                    request.AddedRoleIds = jsonRequest.AddedRoleIds;
                if (jsonRequest.RemovedRoleIds != null && jsonRequest.RemovedRoleIds.Length > 0)
                    request.RemovedRoleIds = jsonRequest.RemovedRoleIds;
            }
            return request;
        }
    }
}
