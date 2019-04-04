﻿using NetModular.Lib.Data.Query;

namespace NetModular.Module.Admin.Application.ModuleInfoService.ViewModels
{
    public class ModuleInfoQueryModel : QueryModel
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        public string Code { get; set; }
    }
}
