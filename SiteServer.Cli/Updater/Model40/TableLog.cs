﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using SiteServer.CMS.Core;
using SiteServer.CMS.Model;
using SiteServer.Plugin;

namespace SiteServer.Cli.Updater.Model40
{
    public partial class TableLog
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("ipAddress")]
        public string IpAddress { get; set; }

        [JsonProperty("addDate")]
        public DateTimeOffset AddDate { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }
    }

    public partial class TableLog
    {
        public const string OldTableName = "Log";

        public static readonly string NewTableName = DataProvider.LogDao.TableName;

        public static readonly List<TableColumn> NewColumns = DataProvider.LogDao.TableColumns;

        public static readonly Dictionary<string, string> ConvertKeyDict = null;

        public static readonly Dictionary<string, string> ConvertValueDict = null;
    }
}
