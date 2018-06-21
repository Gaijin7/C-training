using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressbookTests
{
    class UserData
    {
        private string firstname;
        private string lastname;
        private string nickname;
        private string address;
        private string home;
        private string address2;
        

        public UserData(string firstname)
        {
            this.firstname = firstname;
        }



        /* public UserData(string firstname,string lastname, string nickname, string address, string home, string address2)
         {
             this.firstname = firstname;
             this.lastname = lastname;
             this.nickname = nickname;
             this.address = address;
             this.home = home;
             this.address2 = address2;
         }*/
        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }
        public string Nickname
        {
            get
            {
                return nickname;
            }
            set
            {
                nickname = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public string Home
        {
            get
            {
                return home;
            }
            set
            {
                home = value;
            }
        }
        public string Address2
        {
            get
            {
                return address2;
            }
            set
            {
                address2 = value;
            }
        }
    }
}
