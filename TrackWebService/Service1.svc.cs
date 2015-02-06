using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TrackWebService
{
    /// <summary>
    /// Web service implementation
    /// </summary>
    public class Service1 : IService1
    {

        /// <summary>
        /// Return all linked fields in the database
        /// </summary>
        /// <returns>linked fields list</returns>
        public List<TChampLie> GetAllLinkedFields()
        {
            using(TRACK_DEVEntities1 context = new TRACK_DEVEntities1())
            {
                List<TChampLie> lstChampsLies = (from table in context.TChampLie where table.TCLie_Valeur != null select table).ToList();
                return lstChampsLies;
            }
            
        }

    }
}
