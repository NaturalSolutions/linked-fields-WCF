using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TrackWebService
{

    [DataContract]
    public class linkedFieldsInformation
    {
        [DataMember]
        public List<TChampLieSerialized> linkedFieldsList { get; set; }

        [DataMember]
        public List<string> tablesList { get; set; }

        [DataMember]
        public List<string> identifyingColumns { get; set; }

        public linkedFieldsInformation(List<TChampLieSerialized> linkedFieldsList, List<string> tablesList, List<string> identifyingColumns)
        {
            this.identifyingColumns = identifyingColumns;
            this.tablesList = tablesList;
            this.linkedFieldsList = linkedFieldsList;
        }       
    }

    public class TChampLieSerialized
    {
        public int id { get; set; }

        public string labelFr { get; set; }

        public string labelEn { get; set; }

        public string value { get; set; }

        public int order { get; set; }

        public string key { get; set; }
    }

}