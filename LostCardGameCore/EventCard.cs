using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostCardGameCore
{
    public enum EventCardType
    {
        PIVOTAL, STANDARD
    }
    public class EventCard : Card
    {
        public EventCardType EventCardType;
        public int Season;
        public List<string> Characters;

        public override string ToString()
        {
            return Season + "  " + Name;
        }
    }
}
