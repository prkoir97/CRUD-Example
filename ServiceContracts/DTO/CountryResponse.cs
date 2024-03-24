using System;
using Entities;

namespace ServiceContracts.DTO
{
    // <summary>
    // DTO class for adding a new country
    // </summary>

    public class CountryResponse
    {
        public Guid CountryID { get; set; }
        public string? CountryName { get; set; }

        // It compares the current object to another object of CountryResponse
        // type and returns true, if both values are same; otherwise returns false
        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj.GetType() != typeof(CountryResponse))
            {
                return false;
            }

            CountryResponse country_to_compare = (CountryResponse)obj;

            // if both match - returns true
            return CountryID == country_to_compare.CountryID && CountryName == country_to_compare.CountryName;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public static class CountryExtensions
    {
        //Converts from country object to CountryResponse object
        public static CountryResponse ToCountryResponse(this Country country)
        {
            return new CountryResponse()
            {
                CountryID =
                country.CountryID,
                CountryName =
                country.CountryName
            };
        }
    }
}

