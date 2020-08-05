using System;
using System.Collections.Generic;
using System.Text;

namespace Ahao.ZGPoetry.Model.ViewModels
{
    /// <summary>
    /// 朝代表
    /// </summary>
    public class DynastyViewModels
    {
        public int ID { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// 持续时间
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
