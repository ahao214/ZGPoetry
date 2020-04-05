using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;

namespace Ahao.ZGPoetry.Model
{

    /// <summary>
    /// 诗歌表
    /// </summary>
    [SugarTable("T_Poem")]
    public class Poem
    {
        [SugarColumn(IsPrimaryKey =true)]
        public int ID { get; set; }
        /// <summary>
        /// 题目
        /// </summary>
        public string PName { get; set; }
        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string  Context { get; set; }
        /// <summary>
        /// 讲解
        /// </summary>
        public string Explain { get; set; }
        /// <summary>
        /// 体裁
        /// </summary>
        public string  Type { get; set; }

    }
}
