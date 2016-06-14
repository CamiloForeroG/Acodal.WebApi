using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business
{
    public class CongressBusiness
    {
        CongresoAcodalRepository DB = new CongresoAcodalRepository();

        public object GetConferences(DateTime? dia)
        {
            var Conferences =
                (from c in DB.Conferencias
                 select new
                 {
                     c.Id,
                     c.Nombre,
                     salon = c.Salone.Salon,
                     c.HoraInicio,
                     c.HoraFin,
                     Expositores = c.Expositors.Select(p => new { p.Nombre, pais = p.Pai.Pais })
                 }
                );
            return Conferences;
        }

        public object GetConferencesByHour(DateTime dia)
        {
            var Conferences = (
                      from c in DB.Conferencias
                      where c.Fecha.Day == 22//dia.Day //&& (c.HoraInicio >= hora.Date && Convert.ToDateTime(c.HoraFin).Date <= hora.Date)
                      select new
                      {
                          c.Id,
                          c.Nombre,
                          salon = c.Salone.Salon,
                          c.HoraInicio,
                          c.HoraFin,
                          Expositores = c.Expositors.Select(p => new { p.Nombre, pais = p.Pai.Pais })
                      }
                );
            //if (Conferences == null)
                //return hora;
               return Conferences;
        }
    }
}
