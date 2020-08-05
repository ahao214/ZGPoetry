using System;
using System.Collections.Generic;
using System.Text;

namespace Ahao.ZGPoetry.Model.ViewModels
{
    /// <summary>
    /// 诗人表
    /// </summary>
    public class PoetViewModels
    {
        public int ID { get; set; }
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
        public string Remark { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Createdate { get; set; }
    }
}
