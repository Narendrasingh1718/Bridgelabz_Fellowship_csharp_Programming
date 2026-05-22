using Review;
using System;
class Main
{
    public static void main(String[] args)
    {
        IBankService service = new BankService();
        service.AddAcount();
        service.DisplayInfo();
    }
}