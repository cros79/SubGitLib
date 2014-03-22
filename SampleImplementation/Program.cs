namespace Cros.SubRepoLib.SampleImplementation {
    using System;
    using Cros.SubRepoLib.Utilities;

    public class Program {
        private static void Main(string[] args) {
            Console.WriteLine(
                General.SerializeJson(
                    new {
                        Foo = "Bar"
                    }));

            Console.ReadLine();
        }
    }
}