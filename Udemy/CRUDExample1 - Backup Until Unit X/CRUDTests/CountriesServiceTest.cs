using System;
using System.Collections.Generic;
using Entities;
using ServiceContracts.DTO;
using ServiceContracts;
using Services;
using Xunit;
using System.Security.Cryptography.X509Certificates;

namespace CRUDTests
{
    public class CountriesServiceTest
    {
        private readonly ICountriesService
            _countriesService;
        //constructor
        public CountriesServiceTest()
        {
            _countriesService = new CountriesService();
        }

        #region AddCountry
        //when COuntryAddrequest is null, it should throw ArgumentNullException
        [Fact]
        public void AddCountry_NullCountry()
        {
            //arrange
            CountryAddRequest? request = null;

            //assert
            Assert.Throws<ArgumentNullException>(() =>
            {
                //act
                _countriesService.AddCountry(request);

            });
        }

        //when the CountryName is null, it should throw ArgumentException

        [Fact]
        public void AddCountry_CountryNameIsNull()
        {
            //arrange
            CountryAddRequest? request = new CountryAddRequest()
            { CountryName = null };

            //assert
            Assert.Throws<ArgumentException>(() =>
            {
                //act
                _countriesService.AddCountry(request);

            });
        }

        //when the countryName is duplicate, it should throw ArgumentException

        [Fact]
        public void AddCountry_DuplicateCountryName()
        {
            //arrange
            CountryAddRequest? request1 = new CountryAddRequest()
            { CountryName = "USA" };
            CountryAddRequest? request2 = new CountryAddRequest()
            { CountryName = "USA" };

            //assert
            Assert.Throws<ArgumentException>(() =>
            {
                //act
                _countriesService.AddCountry(request1);
                _countriesService.AddCountry(request2);
            });
        }

        //when you supply proper country name it should insert (add) the country to the existing list of countries


        [Fact]
        public void AddCountry_ProperCountryDetails()
        {
            //arrange
            CountryAddRequest? request = new CountryAddRequest()
            { CountryName = "Japan" };

            //act
            CountryResponse response = _countriesService.AddCountry(request);
            List<CountryResponse> countries_from_GetAllCountries =
                _countriesService.GetAllCountries();

            //assert
            Assert.True(response.CountryID != Guid.Empty);
            Assert.Contains(response, countries_from_GetAllCountries);
        }

        #endregion

        #region GetAllCountries
        [Fact]
        //the list of countrie sshould be empty by default(before adding any countries)
        public void GetAllCountries_EmptyList()
        {
            //acts
            List<CountryResponse> actual_country_response_list = _countriesService.GetAllCountries();


            //assert
            Assert.Empty(actual_country_response_list);
        }
        [Fact]

        public void GetAllCountries_AddFewCountries()
        {
            //Arange
            List<CountryAddRequest> country_request_list = new
                List<CountryAddRequest>() {
                new CountryAddRequest() { CountryName="USA" },
                new CountryAddRequest() { CountryName="UK" }
                };
            //Act
            List<CountryResponse> countries_list_from_add_country = new
                List<CountryResponse>();
            foreach (CountryAddRequest country_request in country_request_list)
            {
                countries_list_from_add_country.Add
                 (_countriesService.AddCountry(country_request));
            }
            List<CountryResponse> actualCountryResponseList =
                _countriesService.GetAllCountries();
            //read each element from countries_list_from_add_country
            foreach (CountryResponse expected_country in
                countries_list_from_add_country)
            {
                Assert.Contains(expected_country, actualCountryResponseList);
            }
        }
        #endregion

        #region GetCountryByCountryID

        [Fact]

        public void GetCountryByCountryID_NullCountryID()
        {
            //arrange
            Guid? countrID = null;

            //act
            CountryResponse? country_response_from_get_method = _countriesService.GetCountryByCountryID(countrID);

            //assert
            Assert.Null(country_response_from_get_method);


        }

        [Fact]

        //if we supply a valid country id, it should return the matching country details as CountryResponse object
        public void GetCountryByCountryID_validCountryID()
        {
            //arrange
            CountryAddRequest? country_add_request = new CountryAddRequest() { CountryName = "China" };
            CountryResponse country_response_from_add = _countriesService.AddCountry(country_add_request);

            //act
            CountryResponse? country_responce_from_get = _countriesService.GetCountryByCountryID(country_response_from_add.CountryID);

            //assert
            Assert.Equal(country_response_from_add, country_responce_from_get);

        }
        
        #endregion


    }
}
