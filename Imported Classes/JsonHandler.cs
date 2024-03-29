﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

//Ver 0.0.1.
/*Class made by https://www.github.com/StargazingNeko/ as a quick and easy method to reading and writing json files with Newtonsoft.
Feel free to use in your own projects if you desire, though there's somethings I dislike such as the "bool isFile" that I do plan to change in the future,
and I do recommend getting the updated class whenever I get around to finding a way to tell if it's a file or not without setting the bool.*/
public class JsonHandler
{
    public JObject Read(string json, bool isFile)
    {
        if(!isFile)
        {
            var _json = JObject.Parse(json);
            return _json;
        }
        else
        {
            using (StreamReader jsonFile = new StreamReader(json))
            using (JsonReader reader = new JsonTextReader(jsonFile))
            {
                var _json = JObject.Parse(jsonFile.ReadToEnd());
                return _json;
            }
        }
    }

    public void Write(dynamic param1, dynamic param2, string path)
    {
        if(!File.Exists(path))
        {
            File.WriteAllText(path,"{}");
        }

        var json = JObject.Parse(File.ReadAllText(path));
        json[$"{param1}"] = param2;
        File.WriteAllText(path, JsonConvert.SerializeObject(json, Formatting.Indented));
    }
}
