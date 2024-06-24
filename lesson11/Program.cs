using lesson11;
using System.Diagnostics.CodeAnalysis;

DateTime d = new DateTime(2000, 02, 15);
Seson s = Seson.winter;

Plant p = new Plant(15);
Plant p2 = new Plant(20, d, 50, true, s);
Console.WriteLine(p2.Printbase());

Wood w1 = new Wood(16);
Kind k = Kind.Idle;
TypeLeaves t = TypeLeaves.wide;
Wood w2 = new Wood(17, k, t);
Console.WriteLine(w2.Printbase());
Color C = Color.write;
Flower f1 = new Flower(20, C);
Flower f2 = new Flower(19, C);
Console.WriteLine(f1.Printbase());
Supervision Su = Supervision.week;
Greenhouseflower g = new Greenhouseflower(Su, 17,20, "hthr",17, C);
Greenhouseflower g1 = new Greenhouseflower(Su, 15, 15, "hthr", 20,C);
Console.WriteLine(g.Printbase()
    );
Console.WriteLine("****************");
Garden gg = new Garden();
gg.Add(p);
gg.Add(p2);
gg.Add(p);
//gg.Add(C);
gg.Print();
Console.WriteLine("***************");

gg.Remove(p);

gg.Print();

int x = gg.Cnt(typeof(Plant));
Console.WriteLine(x);
Console.WriteLine(w2.AgeOfPlant() + " " + w2.AgeWood(5));
f2.Chek(f1);
Console.WriteLine();
w2.DisplayMessage();
int totalSum;
w1.amountRequired = 600;
w2.amountRequired = 400;
Wood[] we = new Wood[] {w1,w2};

bool r= Garden.ChekMicsa(out totalSum, we);
Console.WriteLine(r);
    Console.WriteLine($"Total Sum: {totalSum}");

//למורה לא ממש הסתדרתי עם זה אבל זה הרעיון של 8
//    static public Garden(Plant p)
//{
//    int i;
//    for (i = 0; i < arrGrden.Length && arrGrden[i] != null; i++) ;
//    arrGrden[i] = p;
//    if (i == 1 && arrGrden[i].GetType() == typeof(Flower) || i == 1 && arrGrden[i].GetType() == typeof(Tree))
//        Console.WriteLine("מזל טוב");
//}
//כל השאר סבבה ברוך ה'