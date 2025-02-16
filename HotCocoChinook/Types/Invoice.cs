namespace HotCocoChinook.Types;

public class Invoice
{
    public required int InvoiceId { get; set; }
    public required int CustomerId { get; set; }
    public required DateTime InvoiceDate { get; set; }
    public string? BillingAddress { get; set; }
    public string? BillingCity { get; set; }
    public string? BillingState { get; set; }
    public string? BillingCountry { get; set; }
    public string? BillingPostalCode { get; set; }
    public required long Total { get; set; }
}