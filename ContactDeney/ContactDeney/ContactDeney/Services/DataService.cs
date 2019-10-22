using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using ContactDeney.Models;

namespace ContactDeney.Services
{
    public class DataService : IDataService
    {
        private ObservableCollection<ContactItem> _contactItems;
        public  DataService(ObservableCollection<ContactItem> contactItems)
        {
            _contactItems = contactItems;
        }

        public List<ContactItem> GetSearchResults(string queryString)
        {
            var normalizedQuery = queryString?.ToLower() ?? "";
            return _contactItems.Where(p => p.FirstName.StartsWith(normalizedQuery)).ToList();
        }


    }
}
