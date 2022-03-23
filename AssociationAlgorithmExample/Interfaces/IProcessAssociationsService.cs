using AssociationAlgorithmExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationAlgorithmExample.Interfaces
{
	public  interface IProcessAssociationsService
	{
		public IEnumerable<Association> ProcessAssociations(IEnumerable<Association> associations);
	}
}
