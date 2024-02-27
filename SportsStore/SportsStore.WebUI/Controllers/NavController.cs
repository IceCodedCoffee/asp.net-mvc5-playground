using SportsStore.Domain.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

public class NavController : Controller
{
    private IProductRepository repository;

    public NavController(IProductRepository repo)
    {
        repository = repo;
    }

    public PartialViewResult Menu()
    {
        IEnumerable<string> categories = repository.Products
                                            .Select(x => x.Category)
                                            .Distinct()
                                            .OrderBy(x => x);

        return PartialView(categories);
    }
}