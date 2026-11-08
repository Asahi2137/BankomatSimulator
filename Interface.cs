using System.Globalization;

class Interface {
  private uint Money;
  public Interface() {}
  private void ShowInterface() {
    Console.WriteLine("Podaj ile chcesz wypłacić");
    Console.WriteLine("możesz skorzystać z opcji poniżej" + '\n' +
                      "1. 100" + '\n' +
                      "2. 280zł" + '\n' +
                      "3. 750" + '\n' +
                      "4. 1250" + '\n' +
                      "5. 125" + '\n' +
                      "6. 0" + '\n' +
                      "kazda inna liczba to inna kwota (dozwolone są tylko liczby nieujemne ze względu na użycie typu unsigned)");
  }

  private void ProceedVariant() {
    uint[] m = {500, 200, 100, 50, 20, 10};
    Bankomat b = new Bankomat(m, 100);
    switch (Money) {
      case 1:
        (uint[], string?) spend = b.SpendMoney();
        Show(spend.Item1);
        if (spend.Item2 != null) {
          Console.WriteLine(spend.Item2);
        }
        break;
      case 2:
        b.SetMoneyToSpend(280);
        spend = b.SpendMoney();
        Show(spend.Item1);
        if (spend.Item2 != null) {
          Console.WriteLine(spend.Item2);
        }
        break;
      case 3:
        b.SetMoneyToSpend(750);
        spend = b.SpendMoney();
        Show(spend.Item1);
        if (spend.Item2 != null) {
          Console.WriteLine(spend.Item2);
        }
        break;
      case 4:
        b.SetMoneyToSpend(1250);
        spend = b.SpendMoney();
        Show(spend.Item1);
        if (spend.Item2 != null) {
          Console.WriteLine(spend.Item2);
        }
        break;
      case 5:
        b.SetMoneyToSpend(125);
        spend = b.SpendMoney();
        Show(spend.Item1);
        if (spend.Item2 != null) {
          Console.WriteLine(spend.Item2);
        }
        break;
      case 6:
        b.SetMoneyToSpend(0);
        spend = b.SpendMoney();   
        Show(spend.Item1);
        if (spend.Item2 != null) {
          Console.WriteLine(spend.Item2);
        }
        break;
      default:
        b.SetMoneyToSpend(Money);
        spend = b.SpendMoney();
        Show(spend.Item1);
        if (spend.Item2 != null) {
          Console.WriteLine(spend.Item2);
        }
        break;
    }
  }

  private static void Show(uint[] s) {
    Console.WriteLine("wydano banknoty: ");
    for (int i = 0; i < s.Length; ++i) {
      Console.WriteLine(s[i]);
    }
  }


  public void UserInput() {
    ShowInterface();
    var input = Console.ReadLine();
    while (true) {
      //input = Console.ReadLine();
      if (uint.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out uint temp)) {
        Money = temp;
        break;
      }
      else {
        Console.WriteLine("nie udalo sie pobrac liczby, sproboj ponownie");
      }
    }
    ProceedVariant();
  }
}
