﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELIXIRETD.DATA.DATA_ACCESS_LAYER.DTOs.SETUP_DTO.Asset
{
    public class SyncAssetDto
    {
        public int? AssetNo {  get; set; }
        public string Asset_Code { get; set; }
        public string Asset_Name { get; set; }
        public string Added_By { get; set; }
        public string ModifyBy { get; set; }

    }
}
