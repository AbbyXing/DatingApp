using System;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace DatingApp.API.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }

        public static int CalculateAge(this DateTime theDateTime)
        {
            var age = DateTime.Today.Year - theDateTime.Year;

            if(theDateTime.AddYears(age) > DateTime.Today)
            {
                // user havn't had his/her birthday yet, so take off the year
                age--;
            }

            return age;
        }

        // pass pagination to headers
        public static void AddPagination(this HttpResponse response, int totalItems,
            int totalPages, int itemsPerPage, int currentPage)
        {
                var paginationHeader = new PaginationHeader(totalItems, totalPages, itemsPerPage, currentPage);
                // trans into camel case format
                var camelCaseFormatter = new JsonSerializerSettings();
                camelCaseFormatter.ContractResolver = new CamelCasePropertyNamesContractResolver();
                response.Headers.Add("Pagination", JsonConvert.SerializeObject(paginationHeader, camelCaseFormatter));
                // expose the header
                response.Headers.Add("Access-Control-Expose-Headers", "Pagination");
        }
    }
}