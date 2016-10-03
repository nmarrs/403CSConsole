using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Console_Assignment
{
    class SoccerTeam : Team
    {
        public int draw;
        public int goalsFor;
        public int goalsAgainst;
        public int differential;
        public int points;
        //Declaring child class attributes 

        public SoccerTeam(string teamName, int points)
        {
            this.teamName = teamName;
            this.points = points;
        }
        //SoccerTeam constructor inheriting teamName from parent class 
    }
}
