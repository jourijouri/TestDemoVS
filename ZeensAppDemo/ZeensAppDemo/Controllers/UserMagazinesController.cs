using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ZeensAppDemo.Models;

namespace ZeensAppDemo.Controllers
{
    public class UserMagazinesController : ApiController
    {
        public int User;
        public List<Magazine> magazines;

        public UserMagazinesController(int user)
        {
            User = user;
            magazines = new List<Magazine>();

        }
        public String AddMagFav(Magazine m)
        {

            String message = "not-set";

            if (User == 0)
            {
                message = "Verifier votre connexion de compte";
                //  return message;
            }

            else if (User != 0)
            {
                //magazine is not added yet
                if (m.IsNotInFavoris())
                {
                    magazines.Add(m);
                    message = "Succesfully added";
                    //   return message;
                }
                else if (m.IsInFavoris())
                {

                    message = "Already added";
                    //  return message;
                }

            }









            return message;

        }
    }
}
