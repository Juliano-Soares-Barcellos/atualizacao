using ConsoleApp2;
using ConsoleApp2.Models;
using ConsoleApp2.Rest;

Requisicoes R = new Requisicoes();
TokenModel T = new TokenModel();
GeraTokenModel G = new GeraTokenModel();
ArmazenaDadosModel A = new ArmazenaDadosModel();


T = R.autentificacao();
G = R.GeraToken(T.AccessToken);
A = R.ArmazenaDados(G.NumberToken);
