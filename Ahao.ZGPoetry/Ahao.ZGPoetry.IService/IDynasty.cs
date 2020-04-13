using System;
using System.Collections.Generic;
using Ahao.ZGPoetry.Model;

namespace Ahao.ZGPoetry.IService
{
    /// <summary>
    /// 朝代
    /// </summary>
    public interface IDynasty
    {
        bool Add(Dynasty model);
        bool Edit(Dynasty model);
        bool Delete(Dynasty model);
        List<Dynasty> GetList(Dynasty model);

    }
}
