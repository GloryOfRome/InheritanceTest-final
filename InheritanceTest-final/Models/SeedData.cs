using InheritanceTest_final.Data;
using Microsoft.EntityFrameworkCore;

namespace InheritanceTest_final
{
    public class SeedData//种子数据
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = new InheritanceTest_finalContext(serviceProvider.GetRequiredService<DbContextOptions<InheritanceTest_finalContext>>());
            //GetRequiredService如果没有serviceType类型的服务，则抛出一个InvalidOperationException异常
            //InheritanceTest_finalContext这两个地方填代码在数据库中的文件名
        }
    }
}
