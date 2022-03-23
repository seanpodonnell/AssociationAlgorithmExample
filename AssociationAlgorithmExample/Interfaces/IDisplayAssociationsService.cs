using AssociationAlgorithmExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationAlgorithmExample.Interfaces
{
	internal interface IDisplayAssociationsService
	{
		void DisplayAssociations(IEnumerable<Association> associations);
	}
}
