using System;
using System.Collections.Generic;
using System.Text;

namespace KapOddevGunDort
{
	class MyDictionary<TKey,TValue>
	{
		TKey []  x_Koordinat;
		TValue [] y_Koordinat;

		public MyDictionary() // constructor metodu yazdık
		{
			x_Koordinat = new TKey[0];
			y_Koordinat = new TValue[0];
		}

		public void Add(TKey tkey, TValue tvalue)
		{
			TKey[] tempTKey = x_Koordinat;
			TValue[] tempTValues = y_Koordinat;

			x_Koordinat = new TKey[x_Koordinat.Length + 1];
			y_Koordinat = new TValue[y_Koordinat.Length + 1];

			for (int i = 0; i < tempTKey.Length; i++)
			{
				x_Koordinat[i] = tempTKey[i];
				y_Koordinat[i] = tempTValues[i];
			}

			x_Koordinat[x_Koordinat.Length - 1] = tkey;
			y_Koordinat[y_Koordinat.Length - 1] = tvalue;
		}

		public void Listed(MyDictionary<TKey,TValue> myDictionary)
		{
			for (int i = 0; i < x_Koordinat.Length; i++)
			{
				Console.WriteLine(" X koordinatları : {0}     Y koordinatları : {1}" , x_Koordinat[i], y_Koordinat[i]);
			}
		}
	}
}
