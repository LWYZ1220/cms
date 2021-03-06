﻿using System.Collections.Generic;
using Newtonsoft.Json;
using SiteServer.Plugin;

namespace SiteServer.Cli.Updater.Plugins.GovInteract
{
    public partial class TableGovInteractPermissions
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("nodeID")]
        public long NodeId { get; set; }

        [JsonProperty("permissions")]
        public string Permissions { get; set; }
    }

    public partial class TableGovInteractPermissions
    {
        public const string OldTableName = "GovInteractPermissions";

        public static readonly string NewTableName = "ss_govinteract_permissions";

        public static readonly List<TableColumn> NewColumns = new List<TableColumn>
        {
            new TableColumn
            {
                AttributeName = "Id",
                DataType = DataType.Integer,
                IsPrimaryKey = true,
                IsIdentity = true
            },
            new TableColumn
            {
                AttributeName = "UserName",
                DataType = DataType.VarChar,
                DataLength = 50
            },
            new TableColumn
            {
                AttributeName = "ChannelId",
                DataType = DataType.Integer
            },
            new TableColumn
            {
                AttributeName = "Permissions",
                DataType = DataType.Text
            }
        };

        public static readonly Dictionary<string, string> ConvertKeyDict =
            new Dictionary<string, string>
            {
                {"ChannelId", nameof(NodeId)}
            };

        public static readonly Dictionary<string, string> ConvertValueDict = null;
    }
}
