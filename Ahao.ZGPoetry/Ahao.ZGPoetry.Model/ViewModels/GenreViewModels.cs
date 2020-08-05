using System;
using System.Collections.Generic;
using System.Text;

namespace Ahao.ZGPoetry.Model.ViewModels
{
    /// <summary>
    /// 诗歌体裁表
    /// </summary>
    public class GenreViewModels
    {
        public int ID { get; set;}
        public string GName { get; set; }
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
