using System;

namespace KapOddevGunDort
{
	class Program
	{
		static void Main(string[] args)
		{
			MyDictionary<double, double> koordinatlar = new MyDictionary<double,double>();
			koordinatlar.Add(385375.348,4418756.456);
			koordinatlar.Add(379987.548,4418740.457);
			koordinatlar.Listed(koordinatlar);
		}
	}
}
