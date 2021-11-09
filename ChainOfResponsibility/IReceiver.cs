namespace ChainOfResponsibility;

public interface IReceiver<in T> where T : class
{
    public bool Validate(T voucher);
}