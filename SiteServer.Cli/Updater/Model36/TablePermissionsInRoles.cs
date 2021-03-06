﻿using System.Collections.Generic;
using Newtonsoft.Json;
using SiteServer.CMS.Core;
using SiteServer.Plugin;

namespace SiteServer.Cli.Updater.Model36
{
    public partial class TablePermissionsInRoles
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("roleName")]
        public string RoleName { get; set; }

        [JsonProperty("generalPermissions")]
        public string GeneralPermissions { get; set; }
    }

    public partial class TablePermissionsInRoles
    {
        public const string OldTableName = "PermissionsInRoles";

        public static readonly string NewTableName = DataProvider.PermissionsInRolesDao.TableName;

        public static readonly List<TableColumn> NewColumns = DataProvider.PermissionsInRolesDao.TableColumns;

        public static readonly Dictionary<string, string> ConvertKeyDict = null;

        public static readonly Dictionary<string, string> ConvertValueDict = null;
    }
}
