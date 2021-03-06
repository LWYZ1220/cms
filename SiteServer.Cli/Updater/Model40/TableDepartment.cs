﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using SiteServer.CMS.Core;
using SiteServer.CMS.Model;
using SiteServer.Plugin;

namespace SiteServer.Cli.Updater.Model40
{
    public partial class TableDepartment
    {
        [JsonProperty("departmentId")]
        public long DepartmentId { get; set; }

        [JsonProperty("departmentName")]
        public string DepartmentName { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("parentId")]
        public long ParentId { get; set; }

        [JsonProperty("parentsPath")]
        public string ParentsPath { get; set; }

        [JsonProperty("parentsCount")]
        public long ParentsCount { get; set; }

        [JsonProperty("childrenCount")]
        public long ChildrenCount { get; set; }

        [JsonProperty("isLastNode")]
        public string IsLastNode { get; set; }

        [JsonProperty("taxis")]
        public long Taxis { get; set; }

        [JsonProperty("addDate")]
        public DateTimeOffset AddDate { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("countOfAdmin")]
        public long CountOfAdmin { get; set; }
    }

    public partial class TableDepartment
    {
        public const string OldTableName = "Department";

        public static readonly string NewTableName = DataProvider.DepartmentDao.TableName;

        public static readonly List<TableColumn> NewColumns = DataProvider.DepartmentDao.TableColumns;

        public static readonly Dictionary<string, string> ConvertKeyDict =
            new Dictionary<string, string>
            {
                {nameof(DepartmentInfo.Id), nameof(DepartmentId)}
            };

        public static readonly Dictionary<string, string> ConvertValueDict = null;
    }
}
