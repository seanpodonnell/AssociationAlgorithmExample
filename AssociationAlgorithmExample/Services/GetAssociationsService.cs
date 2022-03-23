using AssociationAlgorithmExample.Entities;
using AssociationAlgorithmExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationAlgorithmExample.Services
{
	internal class GetAssociationsService : IGetAssociationService
	{
		public IEnumerable<Association> GetAssociations(IEnumerable<LineItem>lineItems)
		{
			var distinctProductIds = lineItems.Select(x=>x.ProductId).Distinct().ToList();


			var orderProductIds = lineItems.GroupBy(x => x.OrderId)
										   .Select(x => x.ToList()
										   .Select(x=>x.ProductId))
										   .OrderBy(x=>x.Count())
									       .ToList();
			
			var maxItemCount = orderProductIds.Last().Count();
			var allAssociations = new List<Association>();

			foreach(var productId in distinctProductIds)
			{
				for(var i = 2; i < orderProductIds.Count; i++)
				{
					var ordersContaingProductId = orderProductIds.Where(x => x.Count() == i && x.Contains(productId));
					
					if(ordersContaingProductId.Any())
					{
						foreach(var orderContaingProductId in ordersContaingProductId)
						{
							
								allAssociations.Add(new Association
								{

									TargetProductId = productId,
									RelatedProductIds =  orderContaingProductId,
								});
							}
						}
					}
				}
			return allAssociations;
			}
	
	}
}
