/*
 * YoutubeSearchAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using YoutubeSearchAPI.Standard;
using YoutubeSearchAPI.Standard.Utilities;

namespace YoutubeSearchAPI.Standard.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum PartEnum
    {
        SNIPPET, //snippet
        ID, //id
        INVALID, //Invalid part parameter for forcing 400
    }

    /// <summary>
    /// Helper for the enum type PartEnum
    /// </summary>
    public static class PartEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "snippet", "id", "invalid" };

        /// <summary>
        /// Converts a PartEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The PartEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(PartEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case PartEnum.SNIPPET:
                case PartEnum.ID:
                case PartEnum.INVALID:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of PartEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of PartEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<PartEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into PartEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed PartEnum value</returns>
        public static PartEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type PartEnum", value));

            return (PartEnum) index;
        }
    }
} 