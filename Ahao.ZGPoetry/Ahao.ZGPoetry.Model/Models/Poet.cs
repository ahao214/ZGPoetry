﻿using Ahao.ZGPoetry.Model.Models;
using SqlSugar;
using System;

namespace Ahao.ZGPoetry.Model
{
    /// <summary>
    /// 诗人表
    /// </summary>
    [SugarTable("T_Poet")]
    public class Poet : RootEntity
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 字
        /// </summary>
        public string Zi { get; set; }
        /// <summary>
        /// 号
        /// </summary>
        public string Hao { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public string BrithDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Poem { get; set; }
        /// <summary>
        /// 生卒时间
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
