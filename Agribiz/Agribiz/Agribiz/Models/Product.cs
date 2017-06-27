using Newtonsoft.Json;
using System;

namespace Agribiz.Models
{
	public class Product
	{
		public int Id { get; set; }
		[JsonProperty("titre")]
		public string Title { get; set; }
		public string Description { get; set; }
		public string Image { get; set; }
		[JsonProperty("quantite")]
		public string Quantity { get; set; }
		public string Price { get; set; }
		[JsonProperty("categorie")]
		public string Category { get; set; }
		[JsonProperty("proprietaire")]
		public string Proprietor { get; set; }
		[JsonProperty("dateAjout")]
		public string Created { get; set; }
		[JsonProperty("modifierLe")]
		public string Modified { get; set; }
	}
}