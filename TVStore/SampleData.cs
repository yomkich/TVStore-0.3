using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Linq;
using TVStore.Models;

namespace TVStore
{
    public static class SampleData
    {
        public static void Initialize(TVContext context)
        {
            if (!context.TVs.Any())
            {
                context.TVs.AddRange(
                    new TV
                    {
                    //    ImgSource = "Tuvio",
                        Name = "Tuvio ULTRA HD DLED",
                        Company = "Tuvio",
                        Price = 21800
                    },
                    new TV
                    {
					//	ImgSource = "TCL",
						Name = "TCL 43P637 2022",
                        Company = "TCL",
                        Price = 21500
                    },
                    new TV
                    {
					//	ImgSource = "Hyundai",
						Name = "Hyundai H-LED",
                        Company = "Hyundai",
                        Price = 14000
                    }
                );
                context.SaveChanges();
            }
        }
    }
}