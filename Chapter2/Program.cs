using System.Reflection;

//추가
System.Data.DataSet ds;
HttpClient client;

// See https://aka.ms/new-console-template for more information
// #error version
Assembly? assembly = Assembly.GetExecutingAssembly();

if (assembly == null) return;
foreach (AssemblyName name in assembly.GetReferencedAssemblies())
{

    //세부정보 읽기 위해 어셈블리 로드
    Assembly a = Assembly.Load(name);

    int methodCount = 0; 
    foreach (TypeInfo t in a.DefinedTypes)
    {
        methodCount += t.GetMethods().Count();
    }

    Console.WriteLine(
        "{0:N0} types with {1:N0} methods in {2} assembly.",
        arg0: a.DefinedTypes.Count(),
        arg1: methodCount, arg2: name.Name);
}
