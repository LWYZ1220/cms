﻿using System.Collections.Generic;
using Newtonsoft.Json;
using SiteServer.CMS.Core;
using SiteServer.CMS.Model;
using SiteServer.Plugin;

namespace SiteServer.Cli.Updater.Model41
{
    public partial class TableRelatedFieldItem
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("relatedFieldID")]
        public long RelatedFieldId { get; set; }

        [JsonProperty("itemName")]
        public string ItemName { get; set; }

        [JsonProperty("itemValue")]
        public string ItemValue { get; set; }

        [JsonProperty("parentID")]
        public long ParentId { get; set; }

        [JsonProperty("taxis")]
        public long Taxis { get; set; }
    }

    public partial class TableRelatedFieldItem
    {
        public const string OldTableName = "RelatedFieldItem";

        public static readonly string NewTableName = DataProvider.RelatedFieldItemDao.TableName;

        public static readonly List<TableColumn> NewColumns = DataProvider.RelatedFieldItemDao.TableColumns;

        public static readonly Dictionary<string, string> ConvertKeyDict = null;

        public static readonly Dictionary<string, string> ConvertValueDict = null;
    }
}
