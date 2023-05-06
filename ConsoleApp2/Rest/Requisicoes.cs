using ConsoleApp2.Models;
using RestSharp;
using System;
using RestSharp;
using Newtonsoft.Json;
using static System.Formats.Asn1.AsnWriter;
using System.Net;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.InteropServices;
using System.Text.Unicode;

namespace ConsoleApp2.Rest
{
    internal class Requisicoes
    {
        public TokenModel autentificacao()
        {
            string Status = "";
            TokenModel _tokenModel = new TokenModel();
            convet86 c = new convet86(); var cs = c.convert77();
            var client = new RestClient("https://api-sandbox.getnet.com.br");

            var request = new RestRequest("/auth/oauth/v2/token", Method.Post);
            request.AddParameter("scope", "oob");
            request.AddParameter("grant_type", "client_credentials");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Authorization", $"Basic {cs}");
            while (Status != "OK")
            {
                var response = client.Execute(request);
                Status = response.StatusCode.ToString();


                if (response.IsSuccessful && !string.IsNullOrEmpty(response.Content))
                {
                    _tokenModel = JsonConvert.DeserializeObject<TokenModel>(response.Content);
                    Console.WriteLine("solicitacao aceira: primeiro" + Status);
                }
                else
                {
                    Console.WriteLine($"Erro na solicitação primeiro: {Status}");
                }
            }
            return _tokenModel;
        }
        public GeraTokenModel GeraToken(string accestoken)
        {
            var Status = "";
            int retryCount = 20;
            GeraTokenModel _GeraTokenModel = new GeraTokenModel();
            var client = new RestClient("https://api-sandbox.getnet.com.br");
            var request = new RestRequest("/v1/tokens/card", Method.Post);
            //request.AddHeader("Content-Type", "application/json;charset=utf-8");
            request.AddHeader("Authorization", $"Bearer {accestoken}");
            request.AddHeader("seller_id", "65f01c44-4771-4e67-a104-bb8b107b85a4");

            request.AddParameter("card_number", "5155901222280001");
            request.AddParameter("customer_id", "customer_21081826");
            while (Status !="OK")
            {
                

                var response = client.Execute(request);

                Status = response.StatusCode.ToString();

                if (response.IsSuccessful && !string.IsNullOrEmpty(response.Content))
                {
                    _GeraTokenModel = JsonConvert.DeserializeObject<GeraTokenModel>(response.Content);
                    Console.WriteLine("solicitacao aceira: segundo" + Status);
                    break;
                }
                else
                {
                    Console.WriteLine($"Erro na solicitação segundo: {Status}");

                }
               
            }
            return _GeraTokenModel;

        }
        public ArmazenaDadosModel ArmazenaDados(string number_token)
        {
            ArmazenaDadosModel A =new  ArmazenaDadosModel();
            var Status = "";
            
            var client = new RestClient("https://api-sandbox.getnet.com.br");
            var request = new RestRequest("/v1/cards", Method.Post);


            request.AddHeader("Authorization", $"Bearer {number_token}");
        //    request.AddHeader("Content-Type", "application/json; charset=utf-8");
            request.AddHeader("seller_id", "65f01c44-4771-4e67-a104-bb8b107b85a4");
            request.AddParameter("brand", "Mastercard");
            request.AddParameter("verify_card", false);
            request.AddParameter("card_number", "5155901222280001");
            request.AddParameter("customer_id", "customer_21081826");
            request.AddParameter("cardholder_name", "JOAO DA SILVA");
            request.AddParameter("expiration_month", "12");
            request.AddParameter("expiration_year", "26");
            request.AddParameter("cardholder_identification", "12345678912");
            request.AddParameter("security_code", "123");
            while (Status != "OK"  )
            {

                var response = client.Execute(request);

                Status = response.StatusCode.ToString();

                if (response.IsSuccessful && !string.IsNullOrEmpty(response.Content))
                {
                    A = JsonConvert.DeserializeObject<ArmazenaDadosModel>(response.Content);
                    Console.WriteLine("solicitacao aceira:  terceiro" + Status);
                }
                else
                {
                    Console.WriteLine($"Erro na solicitação 3: {Status}");

                }
            }
            return A;

        


        }
    } 
}
