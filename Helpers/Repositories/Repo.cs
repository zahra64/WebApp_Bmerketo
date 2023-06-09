using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebApp.Contexts;
using System.Diagnostics;

namespace WebApp.Helpers.Repositories;

public class Repo<TEntity> where TEntity : class
{

    private readonly DataContext _context;

    protected Repo(DataContext context)
    {
        _context = context;
    }


    public virtual async Task<TEntity> AddAsync(TEntity entity)
    {
        try
        {
            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }


    //
    public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression)
    {
        try
        {
            var entity = await _context.Set<TEntity>().FirstOrDefaultAsync(expression);
            if (entity != null)
                return entity;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }

    //
    public virtual async Task<IEnumerable<TEntity>> GetAsync()
    {
        try
        {   
            var entities = await _context.Set<TEntity>().ToListAsync();
            if(entities !=null)
            return entities;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }

    //public virtual async Task<TEntity> UpdateAsync(TEntity entity)
    //{
    //    try
    //    {
    //        _context.Set<TEntity>().Update(entity);
    //        await _context.SaveChangesAsync();
    //        return entity;
    //    }
    //    catch (Exception ex) { Debug.WriteLine(ex.Message); }
    //    return null!;
    //}

}

