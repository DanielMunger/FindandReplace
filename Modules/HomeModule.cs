using Nancy;
using System.Collections.Generic;
using System;
using FindReplaces.Objects;

namespace FindReplaces
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["TEMPLATE.cshtml"];
      };

    }
  }
}
