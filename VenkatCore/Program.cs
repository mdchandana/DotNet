using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace VenkatCore
{
    public class Program
    {
        public static void Main(string[] args)
        {                                                   //Asp.net core app Initially starts as a console application..This is the Entry point for web app..   
            CreateHostBuilder(args).Build().Run();          //This builds the webhost that hosts the asp.net core app ..
        }                                                   //and Run the web host and It starts listing for incomming http requests..    



        public static IHostBuilder CreateHostBuilder(string[] args) =>     //This method return a object IHostBuilder..       
            Host.CreateDefaultBuilder(args)                                //Here Host class static method Host.CreateDefaultBuilder(args) method creates the web host with certain preconfigured defaults ...
                .ConfigureWebHostDefaults(webBuilder =>                    //CreateDefaultBuilder() method create the WebHost with certain preconfigured defaults.....
                {
                    webBuilder.UseStartup<Startup>();                       //After setting up the webhost, we are also configuring startup class -
                });                                                         //using the UseStartup<Startup>() extension method ...





        //===============Some of the Tasks that CreateDefaultBuilder() method performs=============
        /* 
         * -Setting up the web server..
         * -Loading the host and application configuration from various configuration sources ..
         * - Configuring logging...
        */



        /*
           CreateDefaultBuilder() method calls UseIIS() method and host the app inside -
           of the IIS worker process(w3wp.exe or iisexpress.exe)         
         */
    }
}
