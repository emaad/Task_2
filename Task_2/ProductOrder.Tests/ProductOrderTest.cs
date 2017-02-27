using System;
using Task_2.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;

namespace ProductOrder.Tests
{
	[TestClass]
	public class ProductOrderTest
	{
		[TestMethod]
		public void MissingFields()
		{
			var order = new Order()
			{
				FirstName = "test",
				LastName = "test",
				Address = "address test",
				City = null,
				State = null,
				Zip = "32423",
				Phone = "3214211",
				Email = "test@test.com",
				CardNumber = "324523423",
				CardExpirationMonth = 12,
				CardExpirationYear = 2018,
				CardSecurityCode = 123,
				ProductId = 12,
				Price = 23,
			};
			Task_2.Controllers.ValuesController controller = new Task_2.Controllers.ValuesController();
			var response =  controller.TestProductOrder(order);
			controller.ModelState.AddModelError("Missing Data", response.Content.ToString());

			Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);
		}

		[TestMethod]
		public void InvalidFields()
		{
			var order = new Order()
			{
				FirstName = "test",
				LastName = "test",
				Address = "address test",
				City = "city test",
				State = "state test",
				Zip = "32423",
				Phone = "321421132432423423",
				Email = "test@",
				CardNumber = "324523423",
				CardExpirationMonth = 12,
				CardExpirationYear = 2018,
				CardSecurityCode = 123,
				ProductId = 12,
				Price = 23,
			};
			Task_2.Controllers.ValuesController controller = new Task_2.Controllers.ValuesController();
			var response = controller.TestProductOrder(order);
			controller.ModelState.AddModelError("Invalid Data", response.Content.ToString());

			Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);
		}

		[TestMethod]
		public void StatusOne()
		{
			var order = new Order()
			{
				FirstName = "test",
				LastName = "test",
				Address = "address test",
				City = "city test",
				State = "state test",
				Zip = "32423",
				Phone = "3214211",
				Email = "test@test.com",
				CardNumber = "324523423",
				CardExpirationMonth = 12,
				CardExpirationYear = 2018,
				CardSecurityCode = 123,
				ProductId = 12,
				Price = 23,
			};
			Task_2.Controllers.ValuesController controller = new Task_2.Controllers.ValuesController();
			var response = controller.TestProductOrder(order);

			Assert.AreEqual(HttpStatusCode.Accepted, response.StatusCode);
		}

		[TestMethod]
		public void StatusTwo()
		{
			var order = new Order()
			{
				FirstName = "test",
				LastName = "test",
				Address = "address test",
				City = "city test",
				State = "state test",
				Zip = "32423",
				Phone = "3214211",
				Email = "test@test.com",
				CardNumber = "324523423",
				CardExpirationMonth = 12,
				CardExpirationYear = 2018,
				CardSecurityCode = 123,
				ProductId = 12,
				Price = 23,
			};
			Task_2.Controllers.ValuesController controller = new Task_2.Controllers.ValuesController();
			var response = controller.TestProductOrder(order);

			Assert.AreEqual(HttpStatusCode.Accepted, response.StatusCode);
		}
	}
}
