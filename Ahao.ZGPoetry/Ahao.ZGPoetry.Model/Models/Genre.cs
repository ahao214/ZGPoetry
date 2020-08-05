using Ahao.ZGPoetry.Model.Models;
using SqlSugar;
using System;

namespace Ahao.ZGPoetry.Model
{
    /// <summary>
    /// 诗歌体裁表
    /// </summary>
    [SugarTable("T_Genre")]
    public class Genre: RootEntity
    {                
        public string GName { get; set; }
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
