﻿using SqlSugar;

namespace Ahao.ZGPoetry.Model.Models
{
    public class RootEntity
    {
        /// <summary>
        /// ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
    }
}
