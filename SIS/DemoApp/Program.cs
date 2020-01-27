﻿using SIS.HTTP;
using SIS.HTTP.Response;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var routeTable = new List<Route>();
            routeTable.Add(new Route(HttpMethodType.Get, "/", Index));
            routeTable.Add(new Route(HttpMethodType.Get, "/users/login", Login));
            routeTable.Add(new Route(HttpMethodType.Post, "/users/login", DoLogin));
            routeTable.Add(new Route(HttpMethodType.Get, "/contact", Contact));
            routeTable.Add(new Route(HttpMethodType.Get, "/favicon.ico", FavIcon));
            // Actions:
            // / => response IndexPage(request)
            // GET /Contact => response ShowContactForm(request)
            // POST /Contact => response FillContactForm(request)

            var httpServer = new HttpServer(80, routeTable);
            await httpServer.StartAsync();
        }

        private static HttpResponse FavIcon(HttpRequest request)
        {
            var byteContent = File.ReadAllBytes("wwwroot/favicon.ico");
            return new FileResponse(byteContent, "image/x-icon");
        }

        public static HttpResponse Index(HttpRequest request)
        {
            var username = request.SessionData.ContainsKey("Username") ? request.SessionData["Username"] : "Anonymous";
            return new HtmlResponse($"<h1>Home page. Hello, {username}</h1>");
        }

        public static HttpResponse Login(HttpRequest request)
        {
            request.SessionData["Username"] = "Pesho";
            return new HtmlResponse("<h1>Login page</h1>");
        }

        public static HttpResponse DoLogin(HttpRequest request)
        {
            return new HtmlResponse("<h1>DoLogin page</h1>");
        }

        public static HttpResponse Contact(HttpRequest request)
        {
            return new HtmlResponse("<h1>Contact</h1>");
        }
    }
}
