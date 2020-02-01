using System;
namespace Sharadi.Model
{
    public class Team
    {
        public string Name { get; set; }

        public int Score { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Team ComparableTeam = obj as Team; 
            if (ComparableTeam as Team == null)
                return false;
            return ComparableTeam.Name == this.Name;
        }
    }
}
