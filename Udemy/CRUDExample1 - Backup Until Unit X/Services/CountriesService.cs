using ServiceContracts;
using ServiceContracts.DTO;
using Entities;
using Services;

namespace Services
{
    public class CountriesService : ICountriesService
    {
        //private field
        private readonly List<Country> _countries;
            //constructor
            public CountriesService() 
            { 
                _countries = new List<Country>();
              }
        public CountryResponse AddCountry(CountryAddRequest? countryAddRequest)
        {
            //validation:countryAddrequest parameter can't be null
            if(countryAddRequest==null)
            {
                throw new ArgumentNullException(nameof(countryAddRequest));
            }

            //validation:countryname cant be null
            if(countryAddRequest.CountryName==null)
            {
                throw new ArgumentException(nameof(countryAddRequest.CountryName));
            }

            //validation: countryname can't be duplicate
            if(_countries.Where(Country => Country.CountryName==countryAddRequest.CountryName).Count()>0)
            {
                throw new ArgumentException("Given country name already exists");
            }
            if(_countries.Where(temp => temp.CountryName ==countryAddRequest.CountryName).Count() >0)
            {
                throw new ArgumentException("Given country name already exists");
            }



            //Convert object from CountryAddRequest to Country type
            Country country = countryAddRequest.ToCountry();
          //generate CountryID
          country.CountryID=Guid.NewGuid();
           
            
            
            //add country object into _countries
            _countries.Add(country);
            return country.ToCountryResponse();
        }

        public List<CountryResponse> GetAllCountries()
        {
           return _countries.Select(country =>country.ToCountryResponse()).ToList();
        }

        public CountryResponse? GetCountryByCountryID(Guid? countryId)
        {
            
            if(countryId==null)
                return null;
            Country? country_response_from_list = _countries.FirstOrDefault(temp => temp.CountryID == countryId);

            if (country_response_from_list == null)
                return null;
            return country_response_from_list.ToCountryResponse();

        }
    }
} 