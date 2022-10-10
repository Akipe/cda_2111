using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    public class Authentification
    {
        private static Authentification? _iteration = null;

        public static Authentification GetIteration()
        {
            if (_iteration is null)
            {
                Authentification._iteration = new Authentification();
            }

            return _iteration;
        }

        public Boolean IsConnected { get; private set; }
        public event EventHandler? OnConnected;
        public event EventHandler? OnLogout;

        private Authentification()
        {
            IsConnected = false;
            OnConnected = null;
            OnLogout = null;
        }

        public void Connect()
        {
            IsConnected = true;
            EventConnect();
        }

        public void Logout()
        {
            IsConnected = false;
            EventLogout();
        }

        private void EventConnect()
        {
            if (OnConnected is not null)
            {
                OnConnected(this, new EventArgs());
            }
        }

        private void EventLogout()
        {
            if (OnLogout is not null)
            {
                OnLogout(this, new EventArgs());
            }
        }
    }
}
