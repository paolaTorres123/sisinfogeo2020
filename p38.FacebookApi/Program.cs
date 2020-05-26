using System;
using Newtonsoft.Json;

namespace p38.FacebookApi
{
    class Program
    {
        static void Main(string[] args)
        {
            string fbtoken = "EAAIg6bpujGMBANCPBaiss9lxS7e5RmvSVph5vVQso9wJuNzqvuqkdhgFk3ecZBSHD3bLQn4FnXbCQEZCCjUiVbTwNZArs0TDfnxSWvSwshyaDvfP47atGWn638SSUkYGKVq5PqaHB7ZBbehwpZBrGiOHb6z6MEyyGQ0JntpeuT8lVPvVmsLAZAgRZCLVQBO80kZD";
            string fbfields = "id_first_name, last_name,middle_name,name,name_format,picture,short_name,email";

            FacebookApi fb = new FacebookApi(fbtoken);

            string resultado = fb.ObtenerInfo(fbfields).Result;

            var res = JsonConvert.DeserializeObject(resultado);

            Console.WriteLine(res);

        }
    }
}
