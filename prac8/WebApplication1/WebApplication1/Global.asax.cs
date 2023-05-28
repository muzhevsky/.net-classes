using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Application.Controllers;

namespace Application
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RegisterCustomControllerFactory();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void RegisterCustomControllerFactory()
        {
            IControllerFactory factory = new MyInjectionFactory();
            ControllerBuilder.Current.SetControllerFactory(factory);
        }
    }
}
