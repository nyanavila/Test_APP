using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace WebTest
{
  public class StartUp
  {
    public void Configure(IApplicationBuilder App)
    {
      App.Run(context => {
        return context.Response.WriteAsync("Hello WOrld");
      });

    }
 

  }

}