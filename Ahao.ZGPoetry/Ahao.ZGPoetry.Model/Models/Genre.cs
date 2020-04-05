using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;

namespace Ahao.ZGPoetry.Model
{
    /// <summary>
    /// 诗歌体裁表
    /// </summary>
    [SugarTable("T_Genre")]
    public class Genre
    {
        [SugarColumn(IsPrimaryKey = true)]
        public int ID { get; set; }
        public string GName { get; set; }

    }
}
