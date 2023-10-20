namespace Prototype;

public interface IDeepCopyable<out T>
{
    T DeepCopy();
}
