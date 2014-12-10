namespace ProducerConsumer
{
    public interface IBuffer
    {
        int BufferSize { get; }
        bool IsFull();
        bool IsEmpty();
        void Add(int input);
        int Take();
    }
}