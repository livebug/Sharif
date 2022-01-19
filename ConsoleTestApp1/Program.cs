// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");

string platform;

if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
{
    platform = OSPlatform.Windows.ToString();
}
else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
{
    platform = OSPlatform.Linux.ToString();
}
else
{
    platform = "OTHERS";
}


Console.WriteLine(platform);
Console.WriteLine(RuntimeInformation.FrameworkDescription);
Console.WriteLine(RuntimeInformation.OSDescription);
Console.WriteLine(RuntimeInformation.OSArchitecture.ToString());
Console.WriteLine(Environment.OSVersion.ToString());
// 环境变量获取
//Console.WriteLine(Environment.GetEnvironmentVariable("PATH"));
// 机器名称
Console.WriteLine(Environment.MachineName);
// 线程树
Console.WriteLine(Environment.ProcessorCount);
// 获取映射到进程上下文的物理内存量。
Console.WriteLine(Environment.WorkingSet/1024.0/1024.0);
// 获取系统启动后经过的毫秒数。
Console.WriteLine(Environment.TickCount64); 


