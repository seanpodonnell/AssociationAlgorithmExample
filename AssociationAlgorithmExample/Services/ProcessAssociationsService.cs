using AssociationAlgorithmExample.Entities;
using AssociationAlgorithmExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AssociationAlgorithmExample.Services
{
	public class ProcessAssociationsService : IProcessAssociationsService
	{



		public IEnumerable<Association> ProcessAssociations(IEnumerable<Association> associations)
		{
			var distinctAssociations = new List<Association>();
			foreach (var association in associations)
			{
				var existingAssociation = distinctAssociations.FirstOrDefault(x => x.Equals(association));
				if (existingAssociation != null)
					existingAssociation.NumberOf++;
				else
				{
					association.NumberOf++;
					distinctAssociations.Add(association);
				}
			}
			return distinctAssociations;
		}
	}
}
