#define MYSIMBOL
using static System.Console;

foreach (string arg in args)
{
  WriteLine(arg);
}

try
{
    CursorSize = int.Parse(args[2]);
}
catch (PlatformNotSupportedException)
{
    WriteLine("The current platform does not support changing the size of cursor");
}

if (OperatingSystem.IsWindows())
{
    //윈도우에서만 실행되는 코드
}
else if (OperatingSystem.IsWindowsVersionAtLeast(major: 10))
{
    //윈도우 10에서만 실행 되는 코드
}
else if (OperatingSystem.IsIOSVersionAtLeast(major:14, minor:5))
{
    //IOS 14.5 이상에서 작동 되는 코드
}
else if (OperatingSystem.IsBrowser())
{
    //블레이저를 사용하는 브라우저에서만 코드 실행
}