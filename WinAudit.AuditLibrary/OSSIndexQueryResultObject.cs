﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace WinAudit.AuditLibrary
{
    public class OSSIndexQueryResultObject
    {
        [JsonProperty("name")]
        public string PackageName { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("package_manager")]
        public string PackageManager { get; set; }

        [JsonProperty("package")]
        public string Package { get; set; }

        [JsonProperty("package_id")]
        public string PackageId { get; set; }

        [JsonProperty("project")]
        public string Project { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("scm_id")]
        public string SCMId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty()]
        public string Dependencies { get; set; }

        public OSSIndexQueryResultObject() { }
    }
}
