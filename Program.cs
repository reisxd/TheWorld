using System.Reflection;

Console.WriteLine("Welcome to The World! Please wait.");

Assembly assembly = Assembly.GetExecutingAssembly();

Stream stream = assembly.GetManifestResourceStream("TheWorld.Resources.TOOLWIZTIMEFREEZE.CONFIG");
stream.Seek(0, SeekOrigin.Begin);

MemoryStream mem = new MemoryStream();
stream.CopyTo(mem);

if (Directory.Exists("C:\\TOOLWIZTIMEFREEZE"))
{
    if (!File.Exists("C:\\TOOLWIZTIMEFREEZE\\TOOLWIZTIMEFREEZE-oldconf.CONFIG")) File.Copy("C:\\TOOLWIZTIMEFREEZE\\TOOLWIZTIMEFREEZE.CONFIG", "C:\\TOOLWIZTIMEFREEZE\\TOOLWIZTIMEFREEZE-oldconf.CONFIG");
    File.Delete("C:\\TOOLWIZTIMEFREEZE\\TOOLWIZTIMEFREEZE.CONFIG");
    File.WriteAllBytes("C:\\TOOLWIZTIMEFREEZE\\TOOLWIZTIMEFREEZE.CONFIG", mem.ToArray());
    Console.WriteLine("Done! The password to unlock is 1234.");
}
else
{
    Console.WriteLine("Could not find Toolwiz TimeFreeze! Are you sure it's installed?");
}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();