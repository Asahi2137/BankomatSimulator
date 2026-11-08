class Bankomat {
  private uint[] Banknotes; 
  private uint MoneyToSpend;

  public Bankomat(uint[] tab, uint val) {Banknotes = tab; MoneyToSpend = val;} // przekazalem pozortowaja malejaca

  private uint IntegerDiv(uint sum, uint banknot) {
    return sum / banknot;
  }

  private uint[] GiveMoney() {
    uint sum = MoneyToSpend;
    uint[] banknotesNumber = {0, 0, 0, 0, 0, 0};
    for (int i = 0; i < Banknotes.Length; ++i) {
      if (sum - Banknotes[i] >= 0) {
        banknotesNumber[i] = IntegerDiv(sum, Banknotes[i]);
        if (sum == 0) {
          break;
        }
        sum = sum - Banknotes[i] * banknotesNumber[i];
      }
    }
    return banknotesNumber;
  }

  public uint[] SpendMoney() {
    uint[] banknotesNumber = GiveMoney();
    // wymysl jak fajnie petle przeleciec by miec liczbe elementow (Capacity += banknotes[i)
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
    // bo lsp
    return result;
  }
  public void SetMoneyToSpend(uint v) { MoneyToSpend = v; }
}
