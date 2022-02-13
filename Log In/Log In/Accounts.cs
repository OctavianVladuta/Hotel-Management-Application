using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log_In
{
    class Accounts
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Adresa { get; set; }
        public string Oras { get; set; }
        public string Tara { get; set; }
        public string CodPostal { get; set; }
        public string Picture { get; set; }
        public int AccountBalance { get; set; }



        public override bool Equals(object obj)
        {
            if (!(obj is Accounts))
            {
                return false;
            }

            Accounts account = obj as Accounts;

            return account.Id == Id && account.Nume == Nume && account.Prenume == Prenume && account.Email == Email &&
                account.Telefon == Telefon && account.Adresa == Adresa && account.Oras == Oras && account.Tara == Tara && account.CodPostal == CodPostal
                && account.Picture == Picture && account.AccountBalance == AccountBalance;
        }


        public override string ToString()
        {
            return $"{Id},{Nume},{Prenume},{Email},{Telefon},{Adresa},{Oras},{Tara},{CodPostal},{Picture},{AccountBalance}";
        }
    }
}
