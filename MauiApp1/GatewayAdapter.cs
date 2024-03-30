using System;

public class GatewayAdapter : IPayable
{
    private IDeal IdealAdapter;

    public GatewayAdapter(IDeal idealAdapter)
    {
        IdealAdapter = idealAdapter;
    }

    public bool ProcessPayment()
    {
        return IdealAdapter.IsValidIban() && IdealAdapter.IsValidBank() && IdealAdapter.IsValidAccountName();
    }
}