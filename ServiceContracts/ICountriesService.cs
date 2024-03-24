﻿using ServiceContracts.DTO;

namespace ServiceContracts
{
    /// <summary>
	/// Represents business logic for manipulating Country entitity
	/// </summary>

	public interface ICountriesService
	{
		/// <summary>
		/// Adds a country object to the list of countries
		/// </summary>
		/// <param name="countryAddRequest"></param>
		/// <returns> Returns the country object after adding it (including newly generated country id) </returns>

		CountryResponse AddCountry(CountryAddRequest?
		countryAddRequest);

		/// <summary>
		/// Returns all countries from the list
		/// </summary>
		/// <returns>All countries from the list as List<CountryResponse></CountryResponse></returns>
		List<CountryResponse> GetAllCountries();

		/// <summary>
		/// Returns a country object based on the given countryID
		/// </summary>
		/// <param name="countryID">CountryID (guid) to search</param>
		/// <returns>Matching country as CountryResponse object</returns>
		CountryResponse? GetCountryByCountryID(Guid? countryID);
    }
}
