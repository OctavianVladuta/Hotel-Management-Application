using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log_In
{
   public class ReservationHistory
    {
        public int Id { get; set; }
        public DateTime dataSosire { get; set; }
        public DateTime dataPlecare { get; set; }
        public string NoRoom { get; set; }
        public int TypeRoom { get; set; }
        public int totalPlata { get; set; }
        public int idBeneficiar { get; set; }

    }
}
