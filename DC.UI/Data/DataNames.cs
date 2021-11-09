
using DC.UI.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DC.UI.Data
{
    public class DataNames
    {

        public IEnumerable<User> GetAll()
        {
            var path = @"C:\Users\Demiurgos\source\repos\DC.UI\DC.UI\Data\name.json";
            var jsonResponse = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<IEnumerable<User>>(jsonResponse);

        }

        public void UpdateName(string newName)
        {
            //Update name
            var path = @"C:\Users\Demiurgos\source\repos\DC.UI\DC.UI\Data\name.json";
            var jsonResponse = File.ReadAllText(path);
            var users = JsonConvert.DeserializeObject<IEnumerable<User>>(jsonResponse).ToList();
            users[0].Name = newName;
            //foreach (var item in users)
            //{
            
            //    if (item.Name.Equals(oldName))
            //    {
            //        users[users.IndexOf(item)].Name = newName;
            //    }
            //}
            var serializedUsers = JsonConvert.SerializeObject(users);
            File.WriteAllText(path, serializedUsers);
        }
    }
}
