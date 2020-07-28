/*
 * YoutubeSearchAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using YoutubeSearchAPI.Standard;
using YoutubeSearchAPI.Standard.Utilities;


namespace YoutubeSearchAPI.Standard.Models
{
    public class Errors : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string domain;
        private string reason;
        private string message;
        private string locationType;
        private string location;

        /// <summary>
        /// domain
        /// </summary>
        [JsonProperty("domain")]
        public string Domain 
        { 
            get 
            {
                return this.domain; 
            } 
            set 
            {
                this.domain = value;
                onPropertyChanged("Domain");
            }
        }

        /// <summary>
        /// reason
        /// </summary>
        [JsonProperty("reason")]
        public string Reason 
        { 
            get 
            {
                return this.reason; 
            } 
            set 
            {
                this.reason = value;
                onPropertyChanged("Reason");
            }
        }

        /// <summary>
        /// message
        /// </summary>
        [JsonProperty("message")]
        public string Message 
        { 
            get 
            {
                return this.message; 
            } 
            set 
            {
                this.message = value;
                onPropertyChanged("Message");
            }
        }

        /// <summary>
        /// locationType
        /// </summary>
        [JsonProperty("locationType")]
        public string LocationType 
        { 
            get 
            {
                return this.locationType; 
            } 
            set 
            {
                this.locationType = value;
                onPropertyChanged("LocationType");
            }
        }

        /// <summary>
        /// location
        /// </summary>
        [JsonProperty("location")]
        public string Location 
        { 
            get 
            {
                return this.location; 
            } 
            set 
            {
                this.location = value;
                onPropertyChanged("Location");
            }
        }
    }
} 