using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace dyc_quilting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}



//namespace QuiltLogic
//{
//    public class Quilt
//    {
//        public string QuiltId { get; set; }
//        public string QuiltName { get; set; }
//        public string QuiltDate { get; set; }
//        public string QuiltDimensions { get; set; }
//    }

//    public class QuiltCollection
//    {
//        //public static void Main(string[] args)
//        //{
//        //    CreateHostBuilder(args).Build().Run();
//        //}

//        public static List<Quilt> Quilts = new List<Quilt>
//        {
//            new Quilt
//            {
//                QuiltId = "1",
//                QuiltName = "Test Quilt One",
//                QuiltDate = "2020-01-01",
//                QuiltDimensions = "1x1"
//            },
//            new Quilt
//            {
//                QuiltId = "2",
//                QuiltName = "Test Quilt Two",
//                QuiltDate = "2020-01-02",
//                QuiltDimensions = "2x2"
//            },
//            new Quilt
//            {
//                QuiltId = "3",
//                QuiltName = "Test Quilt Three",
//                QuiltDate = "2020-01-03",
//                QuiltDimensions = "3x3"
//            }
//        };

//        public static Quilt GetByQuiltId(string id)
//        {
//            var whatever = Quilts.Single(c => c.QuiltId == id);
//            return whatever.QuiltName
//        }

//        public static IHostBuilder CreateHostBuilder(string[] args) =>
//            Host.CreateDefaultBuilder(args)
//                .ConfigureWebHostDefaults(webBuilder =>
//                {
//                    webBuilder.UseStartup<Startup>();
//                });
//    }
//}