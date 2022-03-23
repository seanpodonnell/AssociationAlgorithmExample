using AssociationAlgorithmExample.Entities;
using AssociationAlgorithmExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationAlgorithmExample.Services
{
	internal class DisplayAssociationsService : IDisplayAssociationsService
	{
		public void DisplayAssociations(IEnumerable<Association> associations)
		{
			var results = associations.Select(association =>
			
			new { ProductId = association.TargetProductId,
				 RelatedProductIDs = String.Join(", ", association.RelatedProductIds),
				 Support = association.Support,
				 Confidence = association.Confidence,
				 NumberofOccurances = association.NumberOf
				}
			);
			Console.WriteLine(@"ProductId/RelatedProductIds/Support/Confidence/NumberOfOccurances");
			
			foreach(var result in results)
			{
				Console.WriteLine($"{result.ProductId} - {result.RelatedProductIDs} - {result.Support} - {result.Confidence} - {result.NumberofOccurances}");
			}
		}
	}
}
