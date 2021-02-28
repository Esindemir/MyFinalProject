
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Category:IEntity 
    {
        //Çıplak Classs Kalmasın 
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
