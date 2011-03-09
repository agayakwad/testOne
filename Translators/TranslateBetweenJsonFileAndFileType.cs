using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HiRePro.JSONServiceLayer.CommonManagement.DataContracts;
using Common.ServiceProxies.UserManagement;

namespace HiRePro.JSONServiceLayer.UserManagement.Translators
{
    public class TranslateBetweenJsonFileAndFileType
    {
        public static JsonFile ServiceToBusiness(FileType value)
        {
            JsonFile jsonFile = new JsonFile();
            if (value != null)
            {
                jsonFile.FileFormatId = value.FileFormatId;
                jsonFile.FileSize = value.FileSize;
                jsonFile.FileTypeId = value.FileTypeId;
                jsonFile.FileTypeText = value.FileTypeText;
                jsonFile.IsCompressed = value.IsCompressed;
                jsonFile.IsEncrypted = value.IsEncrypted;
                jsonFile.OriginalFileName = value.OriginalFileName;
                jsonFile.TargetPath = value.TargetPath;
                if (value.Title != null)
                    jsonFile.Title = value.Title.Replace(" ", "").Replace("/", "").Replace(":", "");
                jsonFile.Content = value.Content;
                jsonFile.FileCreatedOn = value.FileCreatedOn;
                jsonFile.FileModifiedOn = value.FileModifiedOn;
                if (value.Id.HasValue)
                    jsonFile.AttachmentId = value.Id.Value;
                if (value.Content != null)
                {
                    jsonFile.BytesAsString = System.Text.ASCIIEncoding.ASCII.GetString(value.Content);
                }
            }
            return jsonFile;
        }
    }
}
