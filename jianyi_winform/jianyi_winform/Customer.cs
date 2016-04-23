using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Newtonsoft.Json;


namespace jianyi_winform
{
    [DataContract]
    class Customer
    {




        [JsonProperty("id")]
        public string id
        {
            get;
            set;
        }


        [JsonProperty("idcard")]
        public string idcard
        {
            get;
            set;
        }



        [JsonProperty("mobile")]
        public string mobile
        {
            get;
            set;
        }



     [JsonProperty("name")]
        public string name
        {
            get;
            set;
        }



      [JsonProperty("sex")]
        public string sex
        {
            get;
            set;
        }


        [JsonProperty("birthday")]
        public string birthday
        {
            get;
            set;
        }


        [JsonProperty("body_height")]
        public string body_height
        {
            get;
            set;
        }


        [JsonProperty("weight")]
        public string weight
        {
            get;
            set;
        }

        [JsonProperty("last_check_time")]
        public string last_check_time
        {
            get;
            set;
        }

        [JsonProperty("insert_time")]
        public string insert_time
        {
            get;
            set;
        }
        
    }
}
