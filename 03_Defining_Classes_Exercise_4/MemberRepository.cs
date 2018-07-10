using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_Exercise_4
{
    public class MemberRepository
    {
        private List<Member> _memberList = new List<Member>();
        
        public void AddMemberToList(Member member)
        {
            _memberList.Add(member);
        }

        public decimal CalculateTeamSales()
        {
            var teamSales = 0m;
            foreach (var member in _memberList)
            {
                teamSales += member.TotalSales;
            }

            return teamSales;
        }
    }
}
