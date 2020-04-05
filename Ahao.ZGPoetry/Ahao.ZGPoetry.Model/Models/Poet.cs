using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;

namespace Ahao.ZGPoetry.Model
{
    /// <summary>
    /// 诗人表
    /// </summary>
   [SugarTable("T_Poet")]
   public  class Poet
    {
        [SugarColumn(IsPrimaryKey =true)]
        public int ID { get; set; }

        public string Name { get; set; }

        public string  Zi { get; set; }
        public string Hao { get; set; }

        public string BrithDate { get; set; }
        public string Poem { get; set; }
        /// <summary>
        /// 持续时间
        /// </summary>
        public string Duration { get; set; }     
    }
}
