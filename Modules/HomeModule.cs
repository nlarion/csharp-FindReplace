using Nancy;
using System.Collections.Generic;
using System;
using System.Web;
using System.Linq;

namespace FinderReplacer
{


  public class HomeModule : NancyModule
  {
    public HomeModule()
    {


      Get["/"] = _ => View ["index.cshtml"];
      Post["/"] = _ => {
        string returnString = FindReplace.FindAndReplace(Request.Form["sentence"], Request.Form["wordChoice"], Request.Form["replaceChoice"]);
        return View["index.cshtml", returnString];
      };

    }
  }
}
