using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop.Data.Models
{
	public class Order
	{
		[BindNever]
		public int id { get; set; }

		[Display(Name = "Input name")]
		[StringLength(20)]
		[Required(ErrorMessage = "No more 20 characters")]
		public string name { get; set; }

		[Display(Name = "Input surname")]
		[StringLength(30)]
		[Required(ErrorMessage = "No more 30 characters")]
		public string surname { get; set; }

		[Display(Name = "Input adress")]
		[StringLength(30)]
		[Required(ErrorMessage = "No more 30 characters")]
		public string adress { get; set; }

		[Display(Name = "Input phone")]
		[DataType(DataType.PhoneNumber)]
		[StringLength(12)]
		[Required(ErrorMessage = "No more 12 characters")]
		public string phone { get; set; }
		
		[Display(Name = "Input email")]
		[DataType(DataType.EmailAddress)]
		[StringLength(25)]
		[Required(ErrorMessage = "No more 25 characters")]
		public string email { get; set; }

		[BindNever]
		[ScaffoldColumn(false)]
		public DateTime orderTime { get; set; }

		public List<OrderDetail> orderDetails { get; set; }
	}
}