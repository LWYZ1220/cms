﻿using System.Collections.Generic;
using Newtonsoft.Json;
using SiteServer.CMS.Core;
using SiteServer.CMS.Model;
using SiteServer.Plugin;

namespace SiteServer.Cli.Updater.Model50
{
    public partial class TableTableStyleItem
    {
        [JsonProperty("tableStyleItemID")]
        public long TableStyleItemId { get; set; }

        [JsonProperty("tableStyleID")]
        public long TableStyleId { get; set; }

        [JsonProperty("itemTitle")]
        public string ItemTitle { get; set; }

        [JsonProperty("itemValue")]
        public string ItemValue { get; set; }

        [JsonProperty("isSelected")]
        public string IsSelected { get; set; }
    }

    public partial class TableTableStyleItem
    {
        public const string OldTableName = "TableStyleItem";

        public static readonly string NewTableName = DataProvider.TableStyleItemDao.TableName;

        public static readonly List<TableColumn> NewColumns = DataProvider.TableStyleItemDao.TableColumns;

        public static readonly Dictionary<string, string> ConvertKeyDict =
            new Dictionary<string, string>
            {
                {nameof(TableStyleItemInfo.Id), nameof(TableStyleItemId)}
            };

        public static readonly Dictionary<string, string> ConvertValueDict = null;
    }
}
