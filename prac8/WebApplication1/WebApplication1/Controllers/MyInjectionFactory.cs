using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using Application.Models;
using Application.Utils;

namespace Application.Controllers
{
    public class MyInjectionFactory : IControllerFactory
    {
        ServiceCollection _services;
        ServiceProvider _provider;
        string _controllersPath = "Application.Controllers.";
        public MyInjectionFactory()
        {
            _services = new ServiceCollection();
            _services.AddSingleton<DatabaseConnectionData, DatabaseConnectionData>();

            _services.AddSingleton<GoodsModel, GoodsModel>();
            _services.AddSingleton<CustomerModel, CustomerModel>();
            _services.AddSingleton<OrdersModel, OrdersModel>();
            _services.AddSingleton<OrdersAndGoodsModel, OrdersAndGoodsModel>();

            _services.AddSingleton<FormAuthenticationManager, FormAuthenticationManager>();
            _provider = _services.BuildServiceProvider();
        }

        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            var type = Type.GetType(_controllersPath + controllerName + "Controller");
            if (type.GetInterface(nameof(IController)) == null) return null;
            var constructors = type.GetConstructors();
            ConstructorInfo constructor = constructors[0];
            int max = constructor.GetParameters().Length;
            foreach (var item in constructors)
            {
                if (item.GetParameters().Length > max)
                {
                    max = item.GetParameters().Length;
                    constructor = item;
                }
            }

            object[] parameters = new object[constructor.GetParameters().Length];
            for (var i = 0; i < max; i++)
                parameters[i] = _provider.GetRequiredService(constructor.GetParameters()[i].ParameterType);

            var obj = (IController)constructor.Invoke(parameters);

            return obj;
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            IDisposable disposable = controller as IDisposable;
            if (disposable != null)
                disposable.Dispose();
        }
    }
}