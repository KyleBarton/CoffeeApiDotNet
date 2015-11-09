using System;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace CoffeeApi
{
    public class Global : HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);
        }

        private void RegisterRoutes(RouteCollection routes)
        {
            //Map Http Routes For DrinksController
            routes.MapHttpRoute(name: "GetAllDrinks", routeTemplate: "Drinks",
                defaults: new {controller = "Drinks", action = "GetAllDrinks"},
                constraints: new {httpMethod = new HttpMethodConstraint("GET")});

            routes.MapHttpRoute(name: "GetDrink", routeTemplate: "Drinks/{drinkId}",
                defaults: new {controller = "Drinks", action = "GetDrink"},
                constraints: new {httpMethod = new HttpMethodConstraint("GET")});

            routes.MapHttpRoute(name: "AddDrink", routeTemplate: "Drinks",
                defaults: new {controller = "Drinks", action = "AddDrink"},
                constraints: new {httpMethod = new HttpMethodConstraint("POST")});

            routes.MapHttpRoute(name: "ChangeDrink", routeTemplate: "Drinks/{drinkId}",
                defaults: new {controller = "Drinks", action = "ChangeDrink"},
                constraints: new {httpMethod = new HttpMethodConstraint("PUT")});
            routes.MapHttpRoute(name: "DeleteDrink", routeTemplate: "Drinks/{drinkId}",
                defaults: new {controller = "Drinks", action = "DeleteDrink"},
                constraints: new {httpMethod = new HttpMethodConstraint("DELETE")});

            //Map Http Routes For ExtrasController
            routes.MapHttpRoute(name: "GetAllExtras", routeTemplate: "Extras",
                defaults: new {controller = "Extras", action = "GetAllExtras"},
                constraints: new {httpMethod = new HttpMethodConstraint("GET")});

            routes.MapHttpRoute(name: "GetExtra", routeTemplate: "Extras/{extraId}",
                defaults: new { controller = "Extras", action = "GetExtra" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET") });

            routes.MapHttpRoute(name: "AddExtra", routeTemplate: "Extras",
                defaults: new { controller = "Extras", action = "AddExtra" },
                constraints: new { httpMethod = new HttpMethodConstraint("POST") });

            routes.MapHttpRoute(name: "ChangeExtra", routeTemplate: "Extras/{extraId}",
                defaults: new { controller = "Extras", action = "ChangeExtra" },
                constraints: new { httpMethod = new HttpMethodConstraint("PUT") });

            routes.MapHttpRoute(name: "DeleteExtra", routeTemplate: "Extras/{extraId}",
                defaults: new { controller = "Extras", action = "DeleteExtra" },
                constraints: new { httpMethod = new HttpMethodConstraint("DELETE") });
            
            //Map Http Routes For OrdersController
            routes.MapHttpRoute(name: "GetAllOrders", routeTemplate: "Orders",
                defaults: new {controller = "Orders", action = "GetAllOrders"},
                constraints: new {httpMethod = new HttpMethodConstraint("GET")});
            
            routes.MapHttpRoute(name: "GetOrder", routeTemplate: "Orders/{orderId}",
                defaults: new { controller = "Orders", action = "GetOrder" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET") });

            routes.MapHttpRoute(name: "SubmitOrder", routeTemplate: "Orders",
                defaults: new {controller = "Orders", action = "Submit"},
                constraints: new {httpMethod = new HttpMethodConstraint("POST")});

            routes.MapHttpRoute(name: "ChangeOrder", routeTemplate: "Orders/{orderId}",
                defaults: new {controller = "Orders", action = "ChangeOrder"},
                constraints: new {httpMethod = new HttpMethodConstraint("PUT")});

            routes.MapHttpRoute(name: "DeleteOrder", routeTemplate: "Orders/{orderId}",
                defaults: new {controller = "Orders", action = "DeleteOrder"},
                constraints: new {httpMethod = new HttpMethodConstraint("DELETE")});
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}