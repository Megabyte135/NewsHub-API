using Domain.Entities;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ArticleController : ControllerBase
    {
        private readonly NewsDbContext _dbContext;
        public ArticleController(NewsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ActionResult<IEnumerable<Article>> GetAll()
        {
            return new List<Article>();
        }

        public ActionResult<Article> Get(int id)
        {
            return new Article();
        }

        public ActionResult Post()
        {
            
        }

        public ActionResult Delete()
        {

        }
    }
}
