using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_GerenciadorDeConteudo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "sobre_danilo_parametro",
                "sobre/{id}/danilo",
                new {Controller = "home", Action = "about", id=0 } // Passando o {id}Parametro id e dando o valor padrãoo de 0 (id=0)
                
                );



            routes.MapRoute(
               "contato",
               "contato",
               new { Controller = "home", Action = "Contact" }

                );

            routes.MapRoute(
                "sobre",
                "sobre",
                new { Controller = "home", Action = "About" }

                );

             routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
