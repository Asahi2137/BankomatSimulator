class Bankomat {
  private uint[] Tab; 
  private uint Val;

  public Bankomat(uint[] tab, uint val) {Tab = tab; Val = val; GiveMoney();} // przekazalem pozortowaja malejaca

  private uint IntegerDiv(uint sum, uint banknot) {
    return sum / banknot;
  }

  private uint[] GiveMoney() {
    uint sum = Val;
    uint[] banknotes = {0, 0, 0, 0, 0, 0};
    for (uint i = 0; i < Tab.Length; ++i) {
      if (sum - Tab[i] >= 0) {
        banknotes[i] = IntegerDiv(sum, Tab[i]);
        if (sum == 0) {
          break;
        }
        sum = sum - Tab[i] * banknotes[i];
      }
      else {banknotes[i] = 0;}
    }
    return banknotes;
  }

  public uint[] SpendMoney() {
    uint[] banknotes = GiveMoney();
    // wymysl jak fajnie petle przeleciec by miec liczbe elementow (Capacity += banknotes[i)
    

    // bo lsp
    uint[] k = {1,2};
    return k;
  }
}
