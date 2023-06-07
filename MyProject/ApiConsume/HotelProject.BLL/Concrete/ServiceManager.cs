using HotelProject.BLL.Absctract;
using HotelProject.DAL.Abstract;
using HotelProject.DAL.EntityFramework;
using HotelProject.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BLL.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDAL _serviceDAL;

        public ServiceManager(IServiceDAL serviceDAL)
        {
            _serviceDAL = serviceDAL;
        }

        public void TDelete(Service t)
        {
            _serviceDAL.Delete(t);
        }

        public Service TGetByID(int id)
        {
            return _serviceDAL.GetByID(id);
        }

        public List<Service> TGetList()
        {
            return _serviceDAL.GetList();
        }

        public void TInsert(Service t)
        {
            _serviceDAL.Insert(t);
        }

        public void TUpdate(Service t)
        {
            _serviceDAL.Update(t);
        }
    }
}
