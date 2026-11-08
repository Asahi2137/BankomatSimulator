class Bankomat {
  private uint[] Banknotes; 
  private uint MoneyToSpend;

  public Bankomat(uint[] tab, uint val) {Banknotes = tab; MoneyToSpend = val;} // przekazalem pozortowaja malejaca

  private uint IntegerDiv(uint banknot) {
    return MoneyToSpend / banknot;
  }

  private uint[] GiveMoney() {
    uint[] banknotesNumber = {0, 0, 0, 0, 0, 0};
    for (int i = 0; i < Banknotes.Length; ++i) {
      if (MoneyToSpend - Banknotes[i] >= 0) {
        banknotesNumber[i] = IntegerDiv(Banknotes[i]);
        if (MoneyToSpend == 0) {
          break;
        }
        MoneyToSpend = MoneyToSpend - Banknotes[i] * banknotesNumber[i];
      }
    }
    return banknotesNumber;
  }

  public (uint[], string?) SpendMoney() {
    uint[] banknotesNumber = GiveMoney();
    uint capacity = 0;
    for (int u = 0; u < Banknotes.Length; ++u) {
      capacity += banknotesNumber[u];
    }
    
    uint[] result = new uint[capacity];
    
    int i = 0, j = 0;
    while (i < Banknotes.Length && j < capacity) {
      if (banknotesNumber[i] > 0) {
        for (int k = 0; k < banknotesNumber[i] && j < capacity; ++k) {
          result[j] = Banknotes[i];
          j++;
        }
      }
      i++;
    }
    if (MoneyToSpend == 0) {
      return (result, "");
    }
    return (result, "nie mozna wyplacic pełnej kwoty, lub wyplata jest calkowicie niemozliwa");
  }
  public void SetMoneyToSpend(uint v) { MoneyToSpend = v; }
}
