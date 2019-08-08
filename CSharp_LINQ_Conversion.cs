using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace Conversion
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var conv = new ConversionClass();

			conv.GetConv();
		}
	}

	class ConversionClass
	{
		public void GetConv()
		{
			ArrayList mix = new ArrayList
			{
				"Taro", "Jiro", "Saburo", 123, "1", "abc", 2.22728
			};

			var WandH = new[]
			{
				new { Weight = 2, Height = 3 }, 
				new { Weight = 9, Height = 2 }, 
				new { Weight = 2, Height = 4 }, 
				new { Weight = 4, Height = 9 }, 
				new { Weight = 5, Height = 6 }, 
			};

			var collection = new[] 
			{
				"America", "Japan", "India", "China", 
			};

			// OfType()
			// 各要素を指定した型に変換。出来ないものは除外。
			IEnumerable<string> mixS = mix.OfType<string>();
			foreach (string n in mixS)
				Console.WriteLine(n);
			Console.WriteLine();

			// Cast()
			// 各要素を指定した型に変換。出来ない場合は例外をスロー。
			// IEnumerable<string> mixSS = mix.Cast<string>();
			// foreach (string n in mixSS)
			// 	Console.WriteLine(n);
			// Console.WriteLine();
			// 例外になり、処理が止まってしまうためコメントアウト

			// ToArray()
			// 配列を作成
			var wei = WandH.Select(e => e.Weight).ToArray();
			foreach (var n in wei)
				Console.Write("{0} ", n);
			Console.WriteLine();
			Console.WriteLine();

			// ToDictionary()
			// 連想配列（辞書型）を作成
			var dic = collection.ToDictionary(e => e.First());
			foreach (var n in dic)
				Console.WriteLine(n);
			Console.WriteLine();

			// ToList()
			// リストを作成
			var lis = collection.ToList();
			foreach (var v in lis)
				Console.Write("{0} ", v);
			Console.WriteLine();

		}		
	}
}

