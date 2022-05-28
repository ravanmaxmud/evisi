// See https://aka.ms/new-console-template for more information
    int azn = 20000;
    float usd = 0.59f;
    float euro = 0.55f;
    float rubl = 38.68f;


    string name = "20min manat nece dollardir";
    Console.WriteLine(name);
    float vurma = azn * usd;
    Console.WriteLine(vurma);


     string name2 = "20min manat nece euro-dur";
     Console.WriteLine(name2);
     float vurma2 = azn * euro;
     Console.Write(vurma2);

Console.WriteLine("");

    string name3 = "20min manat nece rubl-dur";
    Console.WriteLine(name3);
    float vurma3 = azn * rubl;
    Console.WriteLine(vurma3);


Console.WriteLine();

string name4 = "Ölkə büdcəsi ";
Console.WriteLine(name4);
float budce = 30000000000f;
Console.WriteLine(budce);



string name5 = "MN";
Console.WriteLine(name5);
float mn = 20f;
float ortalama = budce * mn/100;
Console.WriteLine(ortalama);

string name6 = "YTN";
Console.WriteLine(name6);
float ytn = 10f;
float ortalama2 = budce * ytn/100;
Console.WriteLine(ortalama2);

string name7 = "yerde qalan";
Console.WriteLine(name7);
float yerdeqalan = budce - ortalama - ortalama2;
Console.WriteLine(yerdeqalan);

Console.WriteLine();

string basliq = "Kargo sifarişlərinin hesablanması üçün program";
Console.WriteLine(basliq);

string name8 = "Adidas";
Console.WriteLine(name8);
float marka1 = 200f;
float topCost = marka1 * 4;
Console.WriteLine(topCost);



string name9 = "Gucci";
Console.WriteLine(name9);
float marka2 = 1000f;
float topCost2 = marka2 * 2;
Console.WriteLine(topCost2);



string name10 = "Nike";
Console.WriteLine(name10);
float marka3 = 150f;
float topCost3 = marka3 * 1;
Console.WriteLine(topCost3);



string total = "Toplam Qiymet";
Console.WriteLine(total);
float cem=topCost+topCost2+ topCost3;
Console.WriteLine(cem);


























