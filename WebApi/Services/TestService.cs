using Service;

namespace WebApi.Services
{
    public class TestService : ITestService
    {
        public object Get()
        {
            return new { Code = 200, Msg = "成功" };
        }
    }
}
