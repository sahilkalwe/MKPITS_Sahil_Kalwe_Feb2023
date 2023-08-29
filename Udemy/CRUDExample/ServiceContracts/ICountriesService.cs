using ServiceContracts.DTO;

namespace ServiceContracts
{
    /// <summary>
    /// Represents business logic for manipulationg Country entity
    /// </summary>
    public interface ICountriesService
    {
        /// <summary>
        /// Adds a country object to the list of countries
        /// </summary>
        /// <param name="countryAddRequest"></param>
        /// <returns> Returns the country object after adding it (including newly generated country id)</returns>
        CountryResponse AddCountry(CountryAddRequest? countryAddRequest);
       /// <summary>
       /// returns all countries from the list
       /// </summary>
       /// <returns>all countries from the list as list of countryResponse  </returns>
        List<CountryResponse> GetAllCountries();

        /// <summary>
        /// Returns a country object based on the given country id
        /// </summary>
        /// <param name="countryId"> CountryID(guid) to search</param>
        /// <returns> Matching country as COuntryResponse object</returns>

        CountryResponse? GetCountryByCountryID(Guid? countryId);
    }
}