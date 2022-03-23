using AssociationAlgorithmExample.Entities;
using AssociationAlgorithmExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationAlgorithmExample.Services
{
	public class DeriveSupportService : IDeriveSupportService
	{
		public IEnumerable<Association> DeriveSupport(IEnumerable<Association> associations,int totalNumberOfTransactions )
		{
			foreach(var association in associations )
			{
				association.Support = association.NumberOf / totalNumberOfTransactions;
			}
			return associations;
		}
	}
}
