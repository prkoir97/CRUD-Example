# CRUD Tests
This repository contains tests for CRUD operations on the Persons and Countries Service. The Persons and Countries Services allow users to manage information about individuals and countries respectively. The CRUD operations (Create, Read, Update, Delete) are thoroughly tested to ensure the services function correctly and reliably.

## Credits

These tests were written following the guidance of Web University by Harsha Vardhan, as part of an online course on Udemy.

## Test Cases

### PersonsServiceTest
- **AddPerson_NullPerson**: Test to verify that an ArgumentNullException is thrown when a null person is added.
- **AddPerson_PersonNameIsNull**: Test to verify that an ArgumentException is thrown when the person's name is null.
- **AddPerson_ProperPersonDetails**: Test to verify that a person is successfully added with proper details.
- **DeletePerson_InValidPersonID**: Test to verify that an ArgumentException is thrown when attempting to delete with an invalid person ID.
- **DeletePerson_ValidPersonID**: Test to verify that a person is successfully deleted with a valid person ID.
- **GetAllPersons_AddFewPersons**: Test to verify that the list of persons contains the expected persons after adding them.
- **GetAllPersons_EmptyList**: Test to verify that the list of persons is empty by default.
- **GetFilteredPersons_EmptySearchText**: Test to verify that an empty search text returns an empty list of persons.
- **GetFilteredPersons_SearchByPersonName**: Test to verify that searching by person name returns the expected persons.
- **GetPersonByPersonID_NullPersonID**: Test to verify that null is returned when a null person ID is provided.
- **GetPersonByPersonID_WithPersonID**: Test to verify that the correct person details are returned when a valid person ID is provided.
- **GetSortedPersons**: Test to verify that the list of persons is sorted correctly.
- **UpdatePerson_InvalidPersonID**: Test to verify that an ArgumentException is thrown when updating with an invalid person ID.
- **UpdatePerson_NullPerson**: Test to verify that an ArgumentNullException is thrown when updating with a null person.
- **UpdatePerson_PersonFullDetailsUpdation**: Test to verify that a person's details are updated correctly.
- **UpdatePerson_PersonNamelsNull**: Test to verify that an ArgumentException is thrown when the person's name is null.

### CountriesServiceTest
- **AddCountry_CountryNamelsNull**: Test to verify that an ArgumentException is thrown when the country name is null.
- **AddCountry_DuplicateCountryname**: Test to verify that an ArgumentException is thrown when attempting to add a duplicate country name.
- **AddCountry_NullCountry**: Test to verify that an ArgumentNullException is thrown when adding a null country.
- **AddCountry_ProperCountryDetails**: Test to verify that a country is successfully added with proper details.
- **GetAllCountries_AddFewCountries**: Test to verify that the list of countries contains the expected countries after adding them.
- **GetAllCountries_EmptyList**: Test to verify that the list of countries is empty by default.
- **GetCountryByCountryID_NullCountryID**: Test to verify that null is returned when a null country ID is provided.
- **GetCountryByCountryID_ValidCountryID**: Test to verify that the correct country details are returned when a valid country ID is provided.
