using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZeensAppDemo.Models
{
    public class Magazine
    {
        public int id { get; set; }
        public string name { get; set; }

       
        public bool IsInFavoris()
        {
            //verification 

            return false;

        }
        public bool IsNotInFavoris()
        {
            //verification 

            return true;
        }


    }

}
