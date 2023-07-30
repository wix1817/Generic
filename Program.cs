using Generic;

var q1 = new ComparablePair<int, string>(1, "YaMegatron");
var q2 = new ComparablePair<int, string>(3, "YaDesepticon");
var q3 = new ComparablePair<int, string>(1, "YaLyntik");

Console.WriteLine(q1.CompareTo(q2));
Console.WriteLine(q1.CompareTo(q3));
Console.WriteLine(q2.CompareTo(q3));

Console.WriteLine("{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}");

var s1 = new ComparablePair<string, bool>("Alala", true);
var s2 = new ComparablePair<string, bool>("Alala", false);
var s3 = new ComparablePair<string, bool>("Blablabla", true);

Console.WriteLine(s1.CompareTo(s2));
Console.WriteLine(s1.CompareTo(s3));
Console.WriteLine(s2.CompareTo(s3));