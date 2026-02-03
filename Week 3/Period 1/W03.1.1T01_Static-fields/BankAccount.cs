class BankAccount
{
    public static double InterestPercentage = 0.0;
    public double Balance = 0.0;
    public void Deposit(double value) => Balance += value;
    public void ApplyInterest() => Balance *= InterestPercentage / 100 + 1;
}
