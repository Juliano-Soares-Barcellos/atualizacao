using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models;

public class convet86
{
    public string convert77()
    {
        string clientId = "d1705049-6c2d-4318-bd98-ab39bc2d1143";
        string clientSecret = "973eab09-5cea-4d23-aff5-adeb7aa23186";
        string credentials = $"{clientId}:{clientSecret}";
        var encodedCredentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(credentials));
        return encodedCredentials;
    }

}
