using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Soferox
{
    class Client
    {
        protected readonly string FirstName, LastName, Age ,Email, Country, Password,PhonNumber;
        protected decimal Balance = 0.00000000M;

        public Client(string Email,string Password, string FirstName, string LastName, string Country,
                      string Age, string PhonNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Country = Country;
            this.Age = Age;
            this.Password = Password;
            this.PhonNumber = PhonNumber;
            Balance = 0.00000000M;
        }
        public Client(string Email,string Password,string FirstName, string LastName, string Country,
                      string Age, string PhonNumber,decimal Balance)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Country = Country;
            this.Age = Age;
            this.Password = Password;
            this.PhonNumber = PhonNumber;
            this.Balance = Balance;
        }
        public string FName
        {
            get { return FirstName; }
        }
        public string LName
        {
            get { return LastName; }
        }
        public string EM
        {
            get { return Email; }
        }
        public string Ctry
        {
            get { return Country; }
        }
        public string Ag
        {
            get { return Age; }
        }
        public string Pass
        {
            get { return Password; }
        }
        public string Phone
        {
            get { return PhonNumber; }
        }

        public decimal Bal
        {
            set { Balance = value; }
            get { return Balance; }
        }
    }
}
