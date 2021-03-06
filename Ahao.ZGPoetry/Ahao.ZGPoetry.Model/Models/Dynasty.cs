﻿using System;
using Ahao.ZGPoetry.Model.Models;
using SqlSugar;


namespace Ahao.ZGPoetry.Model
{
    /// <summary>
    /// 朝代表
    /// </summary>
    [SugarTable("T_Dynasty")]
    public class Dynasty : RootEntity
    {
        public string Name { get; set; }
        /// <summary>
        /// 持续时间
        /// </summary>
        public string Duration { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [SugarColumn(Length = int.MaxValue, IsNullable = true, ColumnDataType = "nvarchar")]
        public string Remark { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Createdate { get; set; } = DateTime.Now;
    }
}
