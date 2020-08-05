using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ahao.ZGPoetry.IRepository.BASE
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<TEntity> QueryByID(object objId);
        Task<TEntity> QueryByID(object objId, bool blUseCache = false);
        Task<List<TEntity>> QueryByIDs(object[] lstIds);


        Task<int> Add(TEntity model);
        Task<bool> DeleteById(object id);
        Task<bool> Delete(TEntity model);
        Task<bool> DeleteByIds(object[] ids);




    }
}
