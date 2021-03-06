using AssociationAlgorithmExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationAlgorithmExample.Interfaces
{
	public interface IGetAssociationService
	{
		IEnumerable<Association> GetAssociations(IEnumerable<LineItem>lineItems);
	}
}
