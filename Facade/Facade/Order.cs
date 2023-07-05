public class Order
{
    
    //Facade Design Pattern - Facade class
    
    public void ProcessOrder(){
        Console.WriteLine("Place Order Started");

        Product product = new Product();
        product.GetProductDetails();
        Payment payment = new Payment();
        payment.MakePayment();
        Invoice invoice = new Invoice();
        invoice.Sendinvoice();
      

        Console.WriteLine("Order Placed Successfully");
    }
}