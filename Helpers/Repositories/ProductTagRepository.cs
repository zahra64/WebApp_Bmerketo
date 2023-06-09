using WebApp.Contexts;
using static WebApp.Models.Entities.TagEntity;

namespace WebApp.Helpers.Repositories
{
    public class ProductTagRepository : Repo<ProductTagEntity>
    {
        public ProductTagRepository(DataContext context) : base(context)
        {
        }
    }
}
