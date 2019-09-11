using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarEvent.Models
{
    public class CalDataAccessLayer
    {
        Cal_DBContext _dbcontext = new Cal_DBContext();
        public IEnumerable<TblCalevent> GetAllEvent()
        {
            try
            {
                return _dbcontext.TblCalevent.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add New Event Record
        public int AddEvent(TblCalevent calevent)
        {
            try
            {
                _dbcontext.TblCalevent.Add(calevent);
                _dbcontext.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar employee 
        public int UpdateEvent(TblCalevent claevent)
        {
            try
            {
                _dbcontext.Entry(claevent).State = EntityState.Modified;
                _dbcontext.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular employee 
        public TblCalevent GetEventData(int id)
        {
            try
            {
                TblCalevent tbl = _dbcontext.TblCalevent.Find(id);
                return tbl;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular employee  
        public int DeleteEvent(int id)
        {
            try
            {
                TblCalevent tbl = _dbcontext.TblCalevent.Find(id);
                _dbcontext.TblCalevent.Remove(tbl);
                _dbcontext.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }
    }
}
