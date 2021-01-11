using DNZ.Calculator.GrpcServer.Protos;
using Grpc.Core;
using System.Threading.Tasks;

namespace DNZ.Calculator.GrpcServer.GrpcServices
{
    public class CalculatorGrpcService : CalculatorService.CalculatorServiceBase
    {
        public override Task<SumResponse> Sum(SumRequest request, ServerCallContext context)
        {
            long sum = request.FirstNumber + request.SecondNumber;

            SumResponse sumResponse = new()
            {
                Result = sum
            };

            return Task.FromResult(sumResponse);
        }
    }
}
