using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationAlgorithmExample.Entities
{
	public class Association
	{
		public int TargetProductId { get; set; }
		public IEnumerable<int> RelatedProductIds { get; set; } = Enumerable.Empty<int>();
		public decimal NumberOf { get; set; }
		public decimal Support { get; set; }
		public decimal Confidence { get; set; }

		public override bool Equals(object? obj)
		{
			if (obj == null)
				return false;

			var other = obj as Association;

			if (other?.TargetProductId == default(int)||this?.TargetProductId == default(int))
				return false;

			if (other?.TargetProductId != this.TargetProductId)
				return false;

			if (!other.RelatedProductIds.Any() != !this.RelatedProductIds.Any())
				return true;

			var thisRelatedProducts = this.RelatedProductIds.OrderBy(x => x);	
			var otherRelatedProducts = other.RelatedProductIds.OrderBy(x => x);

			return thisRelatedProducts.SequenceEqual(otherRelatedProducts);
		}

		public override int GetHashCode()
		{
			var orderedProductIds = RelatedProductIds.OrderBy(x => x);
			int hash = 1430287;

			foreach (var id in orderedProductIds)
			{
				hash = hash * id ^ id.GetHashCode();
			}
			hash = hash *TargetProductId^TargetProductId.GetHashCode();

			return hash;
		}
	}
}
