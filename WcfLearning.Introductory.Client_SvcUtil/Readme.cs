
namespace WcfLearning.Introductory.Client_SvcUtil
{
    class Readme
    {
        /*
         * 1、 使用 SvcUtil.exe 生成 CalculatorServiceConfig.config 和 CalculatorServiceProxy.cs。 
         *     命令：svcutil.exe /language:cs /out:CalculatorServiceProxy.cs /config:CalculatorServiceConfig.config http://localhost:8000/Introductory/
         *     注意地址最后的斜杠不能少。
         * 2、 将 CalculatorServiceProxy.cs 文件添加到项目中。
         * 3、 将 CalculatorServiceConfig.config 中的 system.serviceModel 节，拷贝到 App.config 中。
         * 4、 将 CalculatorServiceProxy.cs 封装成 ServiceClient 以便在客户端调用。
         */
    }
}
