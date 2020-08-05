using System;
using System.Collections.Generic;
using System.Text;

namespace Ahao.ZGPoetry.Model.ViewModels
{
    /// <summary>
    /// 诗歌表
    /// </summary>
    public class PoemViewModels
    {
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
        public string Context { get; set; }
        /// <summary>
        /// 讲解
        /// </summary>
        public string Explain { get; set; }
        /// <summary>
        /// 体裁
        /// </summary>
        public string Genre { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Createdate { get; set; }
    }
}
