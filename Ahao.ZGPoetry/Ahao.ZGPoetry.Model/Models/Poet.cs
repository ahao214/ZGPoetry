using Ahao.ZGPoetry.Model.Models;
using SqlSugar;

namespace Ahao.ZGPoetry.Model
{
    /// <summary>
    /// 诗人表
    /// </summary>
    [SugarTable("T_Poet")]
   public  class Poet: RootEntity
    {      
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
