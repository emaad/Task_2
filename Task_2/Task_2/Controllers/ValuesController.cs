using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Task_2.Models;

namespace Task_2.Controllers
{
	public class ValuesController : ApiController
	{
		public HttpResponseMessage TestProductOrder(Order order)
		{
			if (ModelState.IsValid)
			{
				var errorMessage = "";
				if (order.CardExpirationMonth > 12)
				{
					errorMessage = "Invalid month";
				}
				if (!string.IsNullOrEmpty(errorMessage))
				{
					return Request.CreateErrorResponse(HttpStatusCode.BadRequest, errorMessage);
				}

				int status = 1;

				if (order.CardExpirationMonth < DateTime.Now.Month && order.CardExpirationYear < DateTime.Now.Year)
				{
					status = 2;
				}

				return new HttpResponseMessage(HttpStatusCode.OK);
			}
			else
			{
				return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
			}
		}


		[HttpPost]
		public HttpResponseMessage ProductOrder(Order order)
		{
			if (ModelState.IsValid)
			{
				var errorMessage = "";
				if (order.CardExpirationMonth > 12)
				{
					errorMessage = "Invalid month";
				}
				else if (order.CardExpirationYear.ToString().Length < 2 || order.CardExpirationYear.ToString().Length > 4)
				{
					errorMessage = errorMessage + "\n Year format must be xxxx";
				}
				if (!string.IsNullOrEmpty(errorMessage))
				{
					return Request.CreateErrorResponse(HttpStatusCode.BadRequest, errorMessage);
				}

				InsertRecord(order);

				return new HttpResponseMessage(HttpStatusCode.OK);
			}
			else
			{
				return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
			}
		}

		private void InsertRecord(Order order)
		{
			int status = 1;

			if (order.CardExpirationMonth < DateTime.Now.Month && order.CardExpirationYear < DateTime.Now.Year)
			{
				status = 2;
			}

			using (var context = new MyDbContext())
			{
				order.status = status;
				context.Order.Add(order);
				context.SaveChanges();
			}
		}
	}
}