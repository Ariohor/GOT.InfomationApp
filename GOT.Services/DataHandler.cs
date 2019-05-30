using GOT.DataAccess;
using GOT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GOT.Services
{
    public class DataHandler
    {
        private RequestDataFromAPI _dataFromAPI;

        public DataHandler()
        {
           _dataFromAPI = new RequestDataFromAPI();
        }

        public IList<Character> GetCharacters()
        {
            return JsonConvert.DeserializeObject<List<Character>>(_dataFromAPI.RequestAllCharacters());
        }

        public IList<Character> SearchCaracters(IList<Character> Characters,string searchCharacters)
        {
            return Characters.Where(character => character.Name.Contains(searchCharacters)).ToList();
        }
    }
}
