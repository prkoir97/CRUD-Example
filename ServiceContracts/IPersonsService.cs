﻿using System;
using ServiceContracts.DTO;
using ServiceContracts.Enums;

namespace ServiceContracts
{
	/// <summary>
	/// Represents business logis for manipulating Person entity
	/// </summary>
	public interface IPersonsService
	{
		/// <summary>
		/// Adds a new person into the list of person
		/// </summary>
		/// <param name="personAddRequest"></param>
		/// <returns> Returns the same person details, along with newly generated PersonID </returns>
		PersonResponse AddPerson(PersonAddRequest? personAddRequest);

		/// <summary>
		/// Returns all persons
		/// </summary>
		/// <returns> Returns a list of objects of PersonResponse type </returns>
		List<PersonResponse>? GetAllPersons();

		/// <summary>
		/// Returns the person object based on the given person ID 
		/// </summary>
		/// <param name="personID"> Person ID to search</param>
		/// <returns> Returns matching person object</returns>
		PersonResponse GetPersonByPersonID(Guid? personID);

		/// <summary>
		/// Returns all objects that matches with the given search fields and search string
		/// </summary>
		/// <param name="searchBy">Search field to search</param>
		/// <param name="searchString">Returns all matching persons based on the given search field and search string</param>
		/// <returns></returns>
		List<PersonResponse> GetFilteredPersons(string searchBy, string? searchString);

		/// <summary>
		/// Returns sorted list of persons
		/// </summary>
		/// <param name="allPersons"> Represents list of persons to sort</param>
		/// <param name="sortBy"> Name of property (key), based on which the persons should be sorted</param>
		/// <param name="sortOrder">ASCENDING or DESCENDING</param>
		/// <returns>Returns sorted persons as PersonResponse list</returns>
		List<PersonResponse> GetSortedPersons(List<PersonResponse> allPersons, string sortBy, SortOrderOptions sortOrder);

		/// <summary>
		/// Updates the specified person details based on the given person ID
		/// </summary>
		/// <param name="personUpdateRequest">Person details to update, including person ID</param>
		/// <returns>Returns the person response object</returns>
		PersonResponse UpdatePerson(PersonUpdateRequest? personUpdateRequest);

		/// <summary>
		/// Deletes a person based on the given Person ID
		/// </summary>
		/// <param name="PersonID">PersonID to delete</param>
		/// <returns>Returns true, if the deletion is successful; otherwise false</returns>
		bool DeletePerson(Guid? personID);
	}
}

