namespace Mapbit.Abstractions.Queries
{
    public interface IQuery
    {
    }
    public interface IQuery<TResult> : IQuery
    {
    }
    public interface IQuery<T,TResult> : IQuery
    {
    }
}
