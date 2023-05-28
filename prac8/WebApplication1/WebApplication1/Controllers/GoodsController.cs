using System.Linq;
using System.Web.Mvc;
using Application.Models;

namespace Application.Controllers
{
    public class GoodsController : Controller
    {
        private GoodsModel _goodsModel;

        public GoodsController(GoodsModel goodsModel)
        {
            _goodsModel = goodsModel;
        }

        public ActionResult Goods()
        {
            ViewData.Model = _goodsModel.Goods.ToArray();
            return View();
        }
    }
}