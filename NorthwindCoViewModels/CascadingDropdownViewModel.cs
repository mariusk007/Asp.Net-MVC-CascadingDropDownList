using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindCoModels;

namespace NorthwindCoViewModels
{
    public class CascadingDropdownViewModel
    {
        public List<Country> AllCountries { get; set; }
        public List<State> AllStates { get; set; }
        public List<Town> AllTowns { get; set; }

        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int TownId { get; set; }

        public CascadingDropdownViewModel LoadModel()
        {
            var model = new CascadingDropdownViewModel
            {
                AllCountries = new List<Country>(),
                AllStates = new List<State>(),
                AllTowns = new List<Town>()
            };

            var country = new Country { Id = 1, Description = "Australia" };
            model.AllCountries.Add(country);

            country = new Country { Id = 2, Description = "Brazil" };
            model.AllCountries.Add(country);

            country = new Country { Id = 3, Description = "Germany" };
            model.AllCountries.Add(country);

            country = new Country { Id = 4, Description = "Mexico" };
            model.AllCountries.Add(country);

            var state = new State { Id = 1, Description = "New South Wales", CountryId = 1 };
            model.AllStates.Add(state);

            state = new State { Id = 2, Description = "Queensland", CountryId = 1 };
            model.AllStates.Add(state);

            state = new State { Id = 3, Description = "Victoria", CountryId = 1 };
            model.AllStates.Add(state);

            state = new State { Id = 4, Description = "South Australia", CountryId = 1 };
            model.AllStates.Add(state);

            state = new State { Id = 5, Description = "Bahia", CountryId = 2 };
            model.AllStates.Add(state);

            state = new State { Id = 6, Description = "Pernambuco", CountryId = 2 };
            model.AllStates.Add(state);

           var town = new Town { Id = 1, Description = "Berrara", StateId = 1 };
            model.AllTowns.Add(town);

            town = new Town { Id = 2, Description = "Cawongla", StateId = 1 };
            model.AllTowns.Add(town);

            town = new Town { Id = 3, Description = "Gerogery", StateId = 1 };
            model.AllTowns.Add(town);

            town = new Town { Id = 4, Description = "Kikoira", StateId = 1 };
            model.AllTowns.Add(town);

            town = new Town { Id = 5, Description = "Lauro de Freitas", StateId = 5 };
            model.AllTowns.Add(town);

            town = new Town { Id = 6, Description = "Olinda", StateId = 6 };
            model.AllTowns.Add(town);

            return model;
        }
    }
}
