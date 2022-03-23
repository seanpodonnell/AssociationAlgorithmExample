using AssociationAlgorithmExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationAlgorithmExample.Interfaces
{
	public interface IDeriveSupportService
	{
		IEnumerable<Association> DeriveSupport(IEnumerable<Association>associations, int totalNumberOfTransactions);
	}
}
