using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Task_2.Models
{
	public class Order
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ID { get; set; }
		[Required]
		[StringLength(50, ErrorMessage = "Cannot be longer than 50 characters.")]
		public string FirstName { get; set; }
		[Required]
		[StringLength(50, ErrorMessage = "Cannot be longer than 50 characters.")]
		public string LastName { get; set; }
		[Required]
		[StringLength(50, ErrorMessage = "Cannot be longer than 50 characters.")]
		public string Address { get; set; }
		[Required]
		[StringLength(50, ErrorMessage = "Cannot be longer than 50 characters.")]
		public string City { get; set; }
		[Required]
		[StringLength(50, ErrorMessage = "Cannot be longer than 50 characters.")]
		public string State { get; set; }
		[Required]
		[StringLength(7, ErrorMessage = "Cannot be longer than 7 characters.")]
		public string Zip { get; set; }

		[Required]
		[RegularExpression("^[0-9]+$", ErrorMessage = "Only number allowed.")]
		[StringLength(8, ErrorMessage = "Cannot be longer than 8 characters.")]
		public string Phone { get; set; }

		[Required]
		[EmailAddress(ErrorMessage = "Invalid Email Address")]
		[StringLength(50, ErrorMessage = "Cannot be longer than 50 characters.")]
		public string Email { get; set; }
		[Required]
		[StringLength(14, ErrorMessage = "Cannot be longer than 14 characters.")]
		public string CardNumber { get; set; }
		[Required]
		public int CardExpirationMonth { get; set; }
		[Required]
		[RegularExpression(@"^(\d{4})$", ErrorMessage = "Enter a valid 4 digit Year")]
		public int CardExpirationYear { get; set; }
		[Required]
		public int CardSecurityCode { get; set; }
		[Required]
		public int ProductId { get; set; }
		[Required]
		public decimal Price { get; set; }

		public int status { get; set; }
	}
}
