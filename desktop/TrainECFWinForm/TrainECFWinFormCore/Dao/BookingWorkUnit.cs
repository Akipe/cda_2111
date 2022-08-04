using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainECFWinFormCore.Dao
{
    // Fait le lien entre l'interface graphique et la couche de de données
    public class BookingWorkUnit
    {
        public void AddBooking(AddBooking model)
        {
            USer user = new User()
            {
                UserName = model.UserName,
                Password = model.Password
            };
        }
    }
}
