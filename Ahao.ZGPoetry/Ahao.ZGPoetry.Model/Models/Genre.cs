using Ahao.ZGPoetry.Model.Models;
using SqlSugar;

namespace Ahao.ZGPoetry.Model
{
    /// <summary>
    /// 诗歌体裁表
    /// </summary>
    [SugarTable("T_Genre")]
    public class Genre: RootEntity
    {                
        public string GName { get; set; }

    }
}
