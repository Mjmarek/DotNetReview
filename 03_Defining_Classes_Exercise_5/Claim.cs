using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_Exercise_5
{
    public class Claim
    {
        public Guid ClaimId { get; set; }
        public ClaimType TypeOfClaim { get; set; }
        public DateTime IncidentDate { get; set; }
        public DateTime ClaimDate { get; set; }
        public decimal EstimatedDollarAmount { get; set; }

        public Claim(DateTime claimDate, DateTime incidentDate, decimal estimatedDollarAmount)
        {
            ClaimDate = claimDate;
            IncidentDate = incidentDate;
            EstimatedDollarAmount = estimatedDollarAmount;
        }

        public enum ClaimType
        {
            Vehicle, Home, Theft, Other
        }
    }
}
