﻿namespace ShopRelationsMirrorDB.Models
{
    public class PersonShop
    {   //EGN
        public string PersonId { get; set; }
        public virtual Person Person { get; set; } // 

        public int ShopId { get; set; }
        public virtual Shop Shop { get; set; }

    }


}
