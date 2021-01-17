using System;
using System.Net.Http;
using System.Text.Json.Serialization;

namespace PostClientSide
{
    class Program
    {
        static void Main(string[] args) => 
            Console.WriteLine(
                new HttpClient()
                    .GetAsync("https://localhost:44332/gallery")    //proszę dopasować do aktualnie otwartego portu przy testowaniu
                    .Result
                    .Content
                    .ReadAsStringAsync()
                    .Result);
    }
}
