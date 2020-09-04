using UnitTesting.NetCore.Interfaces;

namespace UnitTesting.NetCore.Tests.MockServices
{
    public class MockService : IService
    {
        public string GenerateMessage(string input)
        {
            return "hello world";
        }
    }
}
