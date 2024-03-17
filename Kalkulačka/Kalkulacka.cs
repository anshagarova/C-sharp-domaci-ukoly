using System;
public class Kalkulacka
{
	private double aktualniVysledek;
	public Kalkulacka()
	{
		aktualniVysledek = 0;
	}

	public bool JePlatnyOperator(char operace)
	{
		return operace == '+' || operace == '-' || operace == '*' || operace == '/' || operace == '^';
	}

	public void Pricti(double cislo)
	{
		aktualniVysledek += cislo;
	}

	public void Odecti(double cislo)
	{
		aktualniVysledek -= cislo;
	}

	public void Vynasob(double cislo)
	{
		aktualniVysledek *= cislo;
	}

	public void Vydel(double cislo)
	{
		if (cislo != 0)
		{
			aktualniVysledek /= cislo;
		}
		else
		{
			Console.WriteLine("Nelze dělit nulou.");
		}
	}

	public void Mocni(double cislo)
	{
		double vysledek = 1;
		for (int i = 0; i < cislo; i++)
		{
			vysledek *= aktualniVysledek;
		}

		aktualniVysledek = vysledek;
	}

	public double VratAktualniVysledek()
	{
		return aktualniVysledek;
	}
}