using oop_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2
{
    internal class Cinema
    {

        private Ticket[] _tickets = new Ticket[20];


        public Ticket this[int index]
        {
            get
            {
                if (index >= 0 && index <20)
                {
                    return _tickets[index];
                }
                return null;
            }
            set
            {
                if (index >= 0 && index < 20)
                {
                    _tickets[index] = value;
                }
            }
        }


        public Ticket this[string name]
        {
            get
            {
                foreach (var movie in _tickets)
                {
                    if (movie.MovieName == name)
                    {
                        return movie;
                    }
                  
                }
                return null;
            }
        }


        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < _tickets.Length; i++)
            {
                if (_tickets[i] == null)
                {
                    _tickets[i] = t;
                   return true;
                }
            }
            return false;
        }


    }
}
