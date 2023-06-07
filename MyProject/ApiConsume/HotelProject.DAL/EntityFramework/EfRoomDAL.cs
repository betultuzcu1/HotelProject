﻿using HotelProject.DAL.Abstract;
using HotelProject.DAL.Concrete;
using HotelProject.DAL.Repositories;
using HotelProject.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DAL.EntityFramework
{
    public class EfRoomDAL:GenericRepository<Room>,IRoomDAL
    {
        public EfRoomDAL(Context context): base(context) 
        {
            
        }
    }
}
