class PolymorphismClass
{
    public virtual void DoTransaction()
    {
        Console.WriteLine("I'm polymorphic! I can be called in many forms as follows:");
    }
}
class FundTransfer : PolymorphismClass
{
    public override void DoTransaction()
    {//override superclass method
        Console.WriteLine("a. Send money from source A to source B.");
    }
}
class AirtimeTopUp : PolymorphismClass
{
    public override void DoTransaction()
    {//override superclass method
        Console.WriteLine("b. Credit airtime to self phone number.");
    }
}
static class main
{
    static void Main()
    {
        //You can add all objects inherited from Transaction to an transaction type list
        PolymorphismClass[] transactions = new PolymorphismClass[3];
        transactions[0] = new PolymorphismClass();
        transactions[1] = new FundTransfer();
        transactions[2] = new AirtimeTopUp();

        for(int i = 0; i < 3; i++)
        {
            transactions[i].DoTransaction();    
        }

    }
}
