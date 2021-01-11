using DNZ.Calculator.GrpcServer.Protos;
using Grpc.Net.Client;
using System;

namespace DNZ.Calculator.GrpcClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using var grpcChannel = GrpcChannel.ForAddress("https://localhost:5001/");

            var client = new CalculatorService.CalculatorServiceClient(grpcChannel);

            SumRequest sumRequest = new()
            {
                FirstNumber = 105600,
                SecondNumber = 89700
            };

            SumResponse sumResponse = client.Sum(sumRequest);

            Console.WriteLine(sumResponse.Result);
            Console.ReadKey();
        }
    }
}
