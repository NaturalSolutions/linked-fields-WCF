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
        public linkedFieldsInformation GetAllLinkedFields()
        {
            // First we need the table list
            List<string> tablesList = new List<string>() { "TIndividus" };

            // And a list of identifying column
            List<string> identifyingColumns = new List<string>() { "TInd_BagueID", "TInd_BagueJuvenile", "TInd_OeufID" };

            using(TRACK_DEVEntities1 context = new TRACK_DEVEntities1())
            {
                List<TChampLieSerialized> lstChampsLies = (
                    from
                        table in context.TChampLie
                    where
                        table.TCLie_Valeur != null
                    select
                        new TChampLieSerialized
                        {
                            id      = table.TCLie_PK_ID,
                            value   = table.TCLie_Valeur,
                            labelFr = table.TClie_LabelFr,
                            labelEn = table.TClie_LabelEn,
                            order   = table.TCLie_Ordre,
                            key     = table.TCLie_ChampTInd
                        }
                ).OrderBy(r => r.id).ToList();

                linkedFieldsInformation information = new linkedFieldsInformation(lstChampsLies, tablesList, identifyingColumns);

                return information;
            }
            
        }

    }
}
