namespace tetofo.DesignPattern;

public interface IFactory<S,T>
{
    T Create(S s);
}