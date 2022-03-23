using AssociationAlgorithmExample.Entities;
using AssociationAlgorithmExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationAlgorithmExample.Services
{
	public class DeriveConfidenceService:IDeriveConfidenceService
	{
	

		public IEnumerable<Association> DeriveConfidence(IEnumerable<Association> associations)
		{
			foreach(var association in associations)
			{
				var numberOfMatchingRelatedItems = RelatedProductIdsMatch(association, associations);
				association.Confidence = association.NumberOf / numberOfMatchingRelatedItems;	
			}
			return associations;
		}


		private static decimal RelatedProductIdsMatch(Association association, IEnumerable<Association>associations )
		{
			decimal numberOfMatchingRelations = 0;
			var thisProducts = association.RelatedProductIds.OrderBy(x => x);

			foreach(var relation in associations.Select(x=>x.RelatedProductIds))
			{
				if(thisProducts.SequenceEqual(relation.OrderBy(x => x)))
					numberOfMatchingRelations++;
			}

			return numberOfMatchingRelations;

		}
	}
}
