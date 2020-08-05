using System;
using Ahao.ZGPoetry.Model.Models;
using SqlSugar;


namespace Ahao.ZGPoetry.Model
{
    /// <summary>
    /// 朝代表
    /// </summary>
    [SugarTable("T_Dynasty")]
    public class Dynasty : RootEntity
    {
        public string Name { get; set; }
        /// <summary>
        /// 持续时间
        /// </summary>
        public string Duration { get; set; }
    }
}
