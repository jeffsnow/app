﻿using System.Web;
using app.web.core.stubs;

namespace app.web.core.aspnet
{
  public class BasicHandler : IHttpHandler
  {
    IProcessRequests front_controller;
    ICreateRequests request_factory;

    public BasicHandler(IProcessRequests front_controller, ICreateRequests request_factory)
    {
      this.front_controller = front_controller;
      this.request_factory = request_factory;
    }


    public void ProcessRequest(HttpContext context)
    {
      front_controller.handle(request_factory.create_from(context));
    }

    public bool IsReusable { get { return true; } }
  }
}