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
    public class Medium : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string url;
        private int width;
        private int height;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("url")]
        public string Url 
        { 
            get 
            {
                return this.url; 
            } 
            set 
            {
                this.url = value;
                onPropertyChanged("Url");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("width")]
        public int Width 
        { 
            get 
            {
                return this.width; 
            } 
            set 
            {
                this.width = value;
                onPropertyChanged("Width");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("height")]
        public int Height 
        { 
            get 
            {
                return this.height; 
            } 
            set 
            {
                this.height = value;
                onPropertyChanged("Height");
            }
        }
    }
} 