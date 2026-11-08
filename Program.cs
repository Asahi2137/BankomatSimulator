class Program {
  static void Main(string[] args) {
    uint[] money = {500, 200, 100, 50, 20, 10};

    // case 1
    Bankomat b = new Bankomat(money, 100);
    uint[] spend = b.SpendMoney();
    Show(spend);

    // case 2
    b.SetMoneyToSpend(280);
    spend = b.SpendMoney();
    Show(spend);

    b.SetMoneyToSpend(750);
    spend = b.SpendMoney();
    Show(spend);

    //case 3
    b.SetMoneyToSpend(1250);
    spend = b.SpendMoney();
    Show(spend);

    //case 4
    b.SetMoneyToSpend(125);
    spend = b.SpendMoney();
    Show(spend);

    //case 5
    b.SetMoneyToSpend(0);
    spend = b.SpendMoney();   
    Show(spend);

    // case 6
    //niemozliwe bo uint wiec brak bitu znaku, odrzuci przed kompilacja
  }

  private static void Show(uint[] s) {
    Console.WriteLine("wydano banknoty: ");
    for (int i = 0; i < s.Length; ++i) {
      Console.WriteLine(s[i]);
    }
  }
}
