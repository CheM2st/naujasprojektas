using EgzasBaisu.KainynoModelis;
using EgzasBaisu.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


namespace EgzasBaisu.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PriceListController : Controller
	{
	

        [HttpPost]
		public IActionResult Create(PriceList priceList)
		{
			if (priceList.ActivityNumber == 0)
			{
				return ValidationProblem("Nenurodėte paslaugos numerio!");
			}

			if (priceList.Activity == "")
			{
				return ValidationProblem("Nenurodėte paslaugos pavadinimo!");
			}
			if (priceList.MakingActivity == "")
            {
				return ValidationProblem("Nenurodėte kada atliekama Paslauga");
			}
			if (priceList.Price == 0)
            {
				return ValidationProblem("Nenurodėte Paslaugos kainos!");
            }
			var service = new PriceListService();
			service.CreatePriceList(priceList);    
			return Ok();
		}

		[HttpGet("list")]
		public IActionResult List()
		{
			var service = new PriceListService();

			var priceLists = service.GetPriceLists();

			return new OkObjectResult(priceLists);
		}

		[HttpGet]
		public IActionResult Get(int activityNumber)
		{
			var service = new PriceListService();
			var priceList = service.GetPriceList(activityNumber);

			return new OkObjectResult(priceList);
		}

		[HttpGet("filter")]
		public IActionResult Filter(string text)
		{
			var service = new PriceListService();

			var priceLists = service.GetPriceLists();

			var filteredPriceLists = new List<PriceList>();
			foreach (var priceList in priceLists)
			{
				if (priceList.GetInformation().Contains(text))
				{
					filteredPriceLists.Add(priceList);
				}
			}

			return new OkObjectResult(filteredPriceLists);
		}
		
	}
}